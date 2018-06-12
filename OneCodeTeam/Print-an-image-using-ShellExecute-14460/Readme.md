# Print an image using ShellExecute (CSShellPrintImageWithShellExecute)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Shell
* Windows SDK
* Windows General
## Topics
* Printing
* ShellExecute
## IsPublished
* True
## ModifiedDate
* 2011-12-12 07:32:05
## Description

<h1 class="WordSection1">Print an image using ShellExecute (CSShellPrintImageWithShellExecute)</h1>
<h2 class="WordSection1">Introduction</h2>
<div class="WordSection1">The sample demonstrates how to print an image using ShellExecute to invoke ImageView_PrintTo, equivalent to right clicking on an image and printing. Using the printto verb with ShellExecute may have unpredictable effects since this
 may be configured differently on different operating systems.&nbsp; The approach demonstrated here invokes ImageView directly with the correct parameters to directly print an image to the default printer.</div>
<h2 class="WordSection1">Running the Sample</h2>
<div class="WordSection1">To run the sample, simply open in Visual Studio 2010 and run it. It simply prompts the user to select any image file, using the
<span class="SpellE">OpenFileDialog</span>, and then uses <span class="SpellE">
ShellExecute</span> to launch <span class="SpellE">ImageView_PrintTo</span>, exposed in shimgvw.dll, with rundll32.exe, and providing the necessary parameters to this function.<span>&nbsp;
</span>This is more reliable than trying to use the Shell <span class="SpellE">
printto</span> verb, which may or may not be configured for a particular file type, and so may not work for images.</div>
<p class="MsoNormal">NOTE: If you run this sample on Windows Server 2008, you may encounter an error 'Picture printing not available from desktop printing experience'.</p>
<p class="MsoNormal">Cause:</p>
<p class="MsoNormal">The Windows feature required to print from the default image viewer on Windows is disabled by default on Windows 2008.</p>
<p class="MsoNormal">Solution:</p>
<p class="MsoNormal">To resolve this problem, install the Desktop Experience feature of Windows Server 2008. To do this, follow these steps:</p>
<ol>
<li>
<div class="WordSection1">Click Start, click Administrative Tools, and then double-click Server Manager.</div>
</li><li>
<div class="WordSection1">In Server Manager, click Add Features under Features Summary.</div>
</li><li>
<div class="WordSection1">In the Add Features Wizard dialog box, make sure that the Desktop Experience option is selected.</div>
</li><li>
<div class="WordSection1">Click <span class="GramE">Next</span>, and then click Install.</div>
</li><li>
<div class="WordSection1">After the installation process is complete, click Close, and then close Server Manager.</div>
</li></ol>
<div class="WordSection1">After you install Desktop Experience, you have to restart the computer.</div>
<h2 class="WordSection1">Using the Code</h2>
<div class="WordSection1"><span><span>1.<span style="font:7.0pt">&nbsp;&nbsp;</span></span></span>Class Win32 is a wrapper class.</div>
<div class="WordSection1">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">// These are the functions, structures and enumerations required to get printer information, using PInvoke to Win32
class Win32
{
    private const int ERROR_FILE_NOT_FOUND = 2;
    private const int ERROR_INSUFFICIENT_BUFFER = 122;
 
    [DllImport(&quot;shell32.dll&quot;&quot;, CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, ShowCommands nShowCmd);
 
    [DllImport(&quot;winspool.drv&quot;, CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool GetDefaultPrinter(StringBuilder pszBuffer, ref int pcchBuffer);
 
    [DllImport(&quot;winspool.drv&quot;, CharSet = CharSet.Auto, SetLastError = true)]
    static extern bool OpenPrinter(string pPrinterName, out IntPtr phPrinter, ref PrinterDefaults pDefault);
 
    [DllImport(&quot;winspool.drv&quot;, SetLastError = true, CharSet = CharSet.Auto)]
    public static extern bool GetPrinter(IntPtr printerHandle, int level, IntPtr printerData, int bufferSize, ref int printerDataSize);
 
    [DllImport(&quot;winspool.drv&quot;, SetLastError = true, CharSet = CharSet.Auto)]
    public static extern bool ClosePrinter(IntPtr printerHandle);
 
    [StructLayout(LayoutKind.Sequential)]
    public struct PrinterDefaults
    {
        public IntPtr pDatatype;
        public IntPtr pDevMode;
        public int DesiredAccess;
    }
 
    public struct PrinterInfo2
    {
        [MarshalAs(UnmanagedType.LPTStr)]
        public string ServerName;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string PrinterName;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string ShareName;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string PortName;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string DriverName;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string Comment;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string Location;
        public IntPtr DevMode;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string SepFile;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string PrintProcessor;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string Datatype;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string Parameters;
        public IntPtr SecurityDescriptor;
        public uint Attributes;
        public uint Priority;
        public uint DefaultPriority;
        public uint StartTime;
        public uint UntilTime;
        public uint Status;
        public uint Jobs;
        public uint AveragePpm;
    }
 
    public enum ShowCommands : int
    {
        SW_HIDE = 0,
        SW_SHOWNORMAL = 1,
        SW_NORMAL = 1,
        SW_SHOWMINIMIZED = 2,
        SW_SHOWMAXIMIZED = 3,
        SW_MAXIMIZE = 3,
        SW_SHOWNOACTIVATE = 4,
        SW_SHOW = 5,
        SW_MINIMIZE = 6,
        SW_SHOWMINNOACTIVE = 7,
        SW_SHOWNA = 8,
        SW_RESTORE = 9,
        SW_SHOWDEFAULT = 10,
        SW_FORCEMINIMIZE = 11,
        SW_MAX = 11
    }
 
    public enum PrinterProperty
    {
        ServerName,
        PrinterName,
        ShareName,
        PortName,
        DriverName,
        Comment,
        Location,
        PrintProcessor,
        Datatype,
        Parameters,
        Attributes,
        Priority,
        DefaultPriority,
        StartTime,
        UntilTime,
        Status,
        Jobs,
        AveragePpm
    };
 
    public static string GetDefaultPrinter()
    {
        int pcchBuffer = 0;
        if (GetDefaultPrinter(null, ref pcchBuffer))
        {
            return null;
        }
        int lastWin32Error = Marshal.GetLastWin32Error();
        if (lastWin32Error == ERROR_INSUFFICIENT_BUFFER)
        {
            StringBuilder pszBuffer = new StringBuilder(pcchBuffer);
            if (GetDefaultPrinter(pszBuffer, ref pcchBuffer))
            {
                return pszBuffer.ToString();
            }
            lastWin32Error = Marshal.GetLastWin32Error();
        }
        if (lastWin32Error == ERROR_FILE_NOT_FOUND)
        {
            return null;
        }
        throw new Win32Exception(Marshal.GetLastWin32Error());
    }
 
    public static PrinterInfo2 GetPrinterProperty(string printerUncName)
    {
        var printerInfo2 = new PrinterInfo2();
 
        var pHandle = new IntPtr();
        var defaults = new PrinterDefaults();
        try
        {
            // Open a handle to the printer
            bool ok = OpenPrinter(printerUncName, out pHandle, ref defaults);
 
            if (!ok)
            {
                // OpenPrinter failed, get the last known error and thrown it
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
 
            // Here we determine the size of the data we to be returned
            // Passing in 0 for the size will force the function to return the size of the data requested
            int actualDataSize = 0;
            GetPrinter(pHandle, 2, IntPtr.Zero, 0, ref actualDataSize);
 
            int err = Marshal.GetLastWin32Error();
 
            if (err == 122)
            {
                if (actualDataSize &gt; 0)
                {
                    // Allocate memory to the size of the data requested
                    IntPtr printerData = Marshal.AllocHGlobal(actualDataSize);
                   
                    // Retrieve the actual information this time
                    GetPrinter(pHandle, 2, printerData, actualDataSize, ref actualDataSize);
 
                    // Marshal to our structure
                    printerInfo2 = (PrinterInfo2)Marshal.PtrToStructure(printerData, typeof(PrinterInfo2));
                   
                    // We've made the conversion, now free up that memory
                    Marshal.FreeHGlobal(printerData);
                }
            }
            else
            {
                throw new Win32Exception(err);
            }
 
            return printerInfo2;
        }
        finally
        {
            // Always close the handle to the printer
            ClosePrinter(pHandle);
        }
    }
}
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__com">//&nbsp;These&nbsp;are&nbsp;the&nbsp;functions,&nbsp;structures&nbsp;and&nbsp;enumerations&nbsp;required&nbsp;to&nbsp;get&nbsp;printer&nbsp;information,&nbsp;using&nbsp;PInvoke&nbsp;to&nbsp;Win32</span>&nbsp;
<span class="cs__keyword">class</span>&nbsp;Win32&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">const</span>&nbsp;<span class="cs__keyword">int</span>&nbsp;ERROR_FILE_NOT_FOUND&nbsp;=&nbsp;<span class="cs__number">2</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">const</span>&nbsp;<span class="cs__keyword">int</span>&nbsp;ERROR_INSUFFICIENT_BUFFER&nbsp;=&nbsp;<span class="cs__number">122</span>;&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;[DllImport(<span class="cs__string">&quot;shell32.dll&quot;</span>&quot;,&nbsp;CharSet&nbsp;=&nbsp;CharSet.Auto,&nbsp;SetLastError&nbsp;=&nbsp;<span class="cs__keyword">true</span>)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;<span class="cs__keyword">extern</span>&nbsp;<span class="cs__keyword">int</span>&nbsp;ShellExecute(IntPtr&nbsp;hwnd,&nbsp;<span class="cs__keyword">string</span>&nbsp;lpOperation,&nbsp;<span class="cs__keyword">string</span>&nbsp;lpFile,&nbsp;<span class="cs__keyword">string</span>&nbsp;lpParameters,&nbsp;<span class="cs__keyword">string</span>&nbsp;lpDirectory,&nbsp;ShowCommands&nbsp;nShowCmd);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;[DllImport(<span class="cs__string">&quot;winspool.drv&quot;</span>,&nbsp;CharSet&nbsp;=&nbsp;CharSet.Auto,&nbsp;SetLastError&nbsp;=&nbsp;<span class="cs__keyword">true</span>)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;<span class="cs__keyword">extern</span>&nbsp;<span class="cs__keyword">bool</span>&nbsp;GetDefaultPrinter(StringBuilder&nbsp;pszBuffer,&nbsp;<span class="cs__keyword">ref</span>&nbsp;<span class="cs__keyword">int</span>&nbsp;pcchBuffer);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;[DllImport(<span class="cs__string">&quot;winspool.drv&quot;</span>,&nbsp;CharSet&nbsp;=&nbsp;CharSet.Auto,&nbsp;SetLastError&nbsp;=&nbsp;<span class="cs__keyword">true</span>)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">static</span>&nbsp;<span class="cs__keyword">extern</span>&nbsp;<span class="cs__keyword">bool</span>&nbsp;OpenPrinter(<span class="cs__keyword">string</span>&nbsp;pPrinterName,&nbsp;<span class="cs__keyword">out</span>&nbsp;IntPtr&nbsp;phPrinter,&nbsp;<span class="cs__keyword">ref</span>&nbsp;PrinterDefaults&nbsp;pDefault);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;[DllImport(<span class="cs__string">&quot;winspool.drv&quot;</span>,&nbsp;SetLastError&nbsp;=&nbsp;<span class="cs__keyword">true</span>,&nbsp;CharSet&nbsp;=&nbsp;CharSet.Auto)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;<span class="cs__keyword">extern</span>&nbsp;<span class="cs__keyword">bool</span>&nbsp;GetPrinter(IntPtr&nbsp;printerHandle,&nbsp;<span class="cs__keyword">int</span>&nbsp;level,&nbsp;IntPtr&nbsp;printerData,&nbsp;<span class="cs__keyword">int</span>&nbsp;bufferSize,&nbsp;<span class="cs__keyword">ref</span>&nbsp;<span class="cs__keyword">int</span>&nbsp;printerDataSize);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;[DllImport(<span class="cs__string">&quot;winspool.drv&quot;</span>,&nbsp;SetLastError&nbsp;=&nbsp;<span class="cs__keyword">true</span>,&nbsp;CharSet&nbsp;=&nbsp;CharSet.Auto)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;<span class="cs__keyword">extern</span>&nbsp;<span class="cs__keyword">bool</span>&nbsp;ClosePrinter(IntPtr&nbsp;printerHandle);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;[StructLayout(LayoutKind.Sequential)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">struct</span>&nbsp;PrinterDefaults&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;IntPtr&nbsp;pDatatype;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;IntPtr&nbsp;pDevMode;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">int</span>&nbsp;DesiredAccess;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">struct</span>&nbsp;PrinterInfo2&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;ServerName;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;PrinterName;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;ShareName;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;PortName;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;DriverName;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;Comment;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;Location;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;IntPtr&nbsp;DevMode;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;SepFile;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;PrintProcessor;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;Datatype;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[MarshalAs(UnmanagedType.LPTStr)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;Parameters;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;IntPtr&nbsp;SecurityDescriptor;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">uint</span>&nbsp;Attributes;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">uint</span>&nbsp;Priority;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">uint</span>&nbsp;DefaultPriority;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">uint</span>&nbsp;StartTime;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">uint</span>&nbsp;UntilTime;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">uint</span>&nbsp;Status;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">uint</span>&nbsp;Jobs;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">uint</span>&nbsp;AveragePpm;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">enum</span>&nbsp;ShowCommands&nbsp;:&nbsp;<span class="cs__keyword">int</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_HIDE&nbsp;=&nbsp;<span class="cs__number">0</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_SHOWNORMAL&nbsp;=&nbsp;<span class="cs__number">1</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_NORMAL&nbsp;=&nbsp;<span class="cs__number">1</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_SHOWMINIMIZED&nbsp;=&nbsp;<span class="cs__number">2</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_SHOWMAXIMIZED&nbsp;=&nbsp;<span class="cs__number">3</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_MAXIMIZE&nbsp;=&nbsp;<span class="cs__number">3</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_SHOWNOACTIVATE&nbsp;=&nbsp;<span class="cs__number">4</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_SHOW&nbsp;=&nbsp;<span class="cs__number">5</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_MINIMIZE&nbsp;=&nbsp;<span class="cs__number">6</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_SHOWMINNOACTIVE&nbsp;=&nbsp;<span class="cs__number">7</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_SHOWNA&nbsp;=&nbsp;<span class="cs__number">8</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_RESTORE&nbsp;=&nbsp;<span class="cs__number">9</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_SHOWDEFAULT&nbsp;=&nbsp;<span class="cs__number">10</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_FORCEMINIMIZE&nbsp;=&nbsp;<span class="cs__number">11</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SW_MAX&nbsp;=&nbsp;<span class="cs__number">11</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">enum</span>&nbsp;PrinterProperty&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ServerName,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PrinterName,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ShareName,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PortName,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;DriverName,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Comment,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Location,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PrintProcessor,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Datatype,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Parameters,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Attributes,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Priority,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;DefaultPriority,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;StartTime,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UntilTime,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Status,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Jobs,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;AveragePpm&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;};&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;GetDefaultPrinter()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">int</span>&nbsp;pcchBuffer&nbsp;=&nbsp;<span class="cs__number">0</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(GetDefaultPrinter(<span class="cs__keyword">null</span>,&nbsp;<span class="cs__keyword">ref</span>&nbsp;pcchBuffer))&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;<span class="cs__keyword">null</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">int</span>&nbsp;lastWin32Error&nbsp;=&nbsp;Marshal.GetLastWin32Error();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(lastWin32Error&nbsp;==&nbsp;ERROR_INSUFFICIENT_BUFFER)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;StringBuilder&nbsp;pszBuffer&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;StringBuilder(pcchBuffer);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(GetDefaultPrinter(pszBuffer,&nbsp;<span class="cs__keyword">ref</span>&nbsp;pcchBuffer))&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;pszBuffer.ToString();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;lastWin32Error&nbsp;=&nbsp;Marshal.GetLastWin32Error();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(lastWin32Error&nbsp;==&nbsp;ERROR_FILE_NOT_FOUND)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;<span class="cs__keyword">null</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">throw</span>&nbsp;<span class="cs__keyword">new</span>&nbsp;Win32Exception(Marshal.GetLastWin32Error());&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;PrinterInfo2&nbsp;GetPrinterProperty(<span class="cs__keyword">string</span>&nbsp;printerUncName)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;printerInfo2&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;PrinterInfo2();&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;pHandle&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;IntPtr();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;defaults&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;PrinterDefaults();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">try</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Open&nbsp;a&nbsp;handle&nbsp;to&nbsp;the&nbsp;printer</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">bool</span>&nbsp;ok&nbsp;=&nbsp;OpenPrinter(printerUncName,&nbsp;<span class="cs__keyword">out</span>&nbsp;pHandle,&nbsp;<span class="cs__keyword">ref</span>&nbsp;defaults);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(!ok)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;OpenPrinter&nbsp;failed,&nbsp;get&nbsp;the&nbsp;last&nbsp;known&nbsp;error&nbsp;and&nbsp;thrown&nbsp;it</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">throw</span>&nbsp;<span class="cs__keyword">new</span>&nbsp;Win32Exception(Marshal.GetLastWin32Error());&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Here&nbsp;we&nbsp;determine&nbsp;the&nbsp;size&nbsp;of&nbsp;the&nbsp;data&nbsp;we&nbsp;to&nbsp;be&nbsp;returned</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Passing&nbsp;in&nbsp;0&nbsp;for&nbsp;the&nbsp;size&nbsp;will&nbsp;force&nbsp;the&nbsp;function&nbsp;to&nbsp;return&nbsp;the&nbsp;size&nbsp;of&nbsp;the&nbsp;data&nbsp;requested</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">int</span>&nbsp;actualDataSize&nbsp;=&nbsp;<span class="cs__number">0</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GetPrinter(pHandle,&nbsp;<span class="cs__number">2</span>,&nbsp;IntPtr.Zero,&nbsp;<span class="cs__number">0</span>,&nbsp;<span class="cs__keyword">ref</span>&nbsp;actualDataSize);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">int</span>&nbsp;err&nbsp;=&nbsp;Marshal.GetLastWin32Error();&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(err&nbsp;==&nbsp;<span class="cs__number">122</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">if</span>&nbsp;(actualDataSize&nbsp;&gt;&nbsp;<span class="cs__number">0</span>)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Allocate&nbsp;memory&nbsp;to&nbsp;the&nbsp;size&nbsp;of&nbsp;the&nbsp;data&nbsp;requested</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;IntPtr&nbsp;printerData&nbsp;=&nbsp;Marshal.AllocHGlobal(actualDataSize);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Retrieve&nbsp;the&nbsp;actual&nbsp;information&nbsp;this&nbsp;time</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GetPrinter(pHandle,&nbsp;<span class="cs__number">2</span>,&nbsp;printerData,&nbsp;actualDataSize,&nbsp;<span class="cs__keyword">ref</span>&nbsp;actualDataSize);&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Marshal&nbsp;to&nbsp;our&nbsp;structure</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;printerInfo2&nbsp;=&nbsp;(PrinterInfo2)Marshal.PtrToStructure(printerData,&nbsp;<span class="cs__keyword">typeof</span>(PrinterInfo2));&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;We've&nbsp;made&nbsp;the&nbsp;conversion,&nbsp;now&nbsp;free&nbsp;up&nbsp;that&nbsp;memory</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Marshal.FreeHGlobal(printerData);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">else</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">throw</span>&nbsp;<span class="cs__keyword">new</span>&nbsp;Win32Exception(err);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;printerInfo2;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">finally</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Always&nbsp;close&nbsp;the&nbsp;handle&nbsp;to&nbsp;the&nbsp;printer</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ClosePrinter(pHandle);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
</div>
<div class="WordSection1">2<span><span>.<span style="font:7.0pt">&nbsp; </span>
</span></span>The following code shows how <span class="SpellE">ShellExecute</span> does the work.</div>
<div class="WordSection1">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>
<pre class="hidden">// GetPrinterProperty() and GetDefaultPrinter() are used to retrieve information for 
// the parameters passed to ImageView_PrintTo
Win32.PrinterInfo2 prn = Win32.GetPrinterProperty(Win32.GetDefaultPrinter());
 
// ShellExecute does the work
int retVal = Win32.ShellExecute(
    IntPtr.Zero, // This parameter can be null.
    String.Empty, // There is no verb being invoked in this case.
 
    // The next parameter actually supplies the command line used for ShellExecute.
    // We invoke ImageView_PrintTo through rundll32.exe, with the shimgvw.dll, hosting this feature.
    System.Environment.SystemDirectory &#43; &quot;\\rundll32.exe&quot;,  // The command line itself.
 
    // Command line parameters, specifying dll and ImageView_PrintTo function within it
    System.Environment.SystemDirectory &#43; &quot;\\shimgvw.dll,ImageView_PrintTo /pt &quot; &#43; 
 
    // Parameters passed to ImageView_PrintTo
        &quot;\&quot;&quot; &#43; ofd.FileName &#43; &quot;\&quot; &quot; &#43; // File to print
        &quot;\&quot;&quot; &#43; prn.PrinterName &#43;&quot;\&quot; &quot; &#43;  // Printer name
        &quot;\&quot;&quot; &#43; prn.DriverName &#43; &quot;\&quot; &quot; &#43;  // Driver name
        &quot;\&quot;&quot; &#43; prn.PortName &#43; &quot;\&quot;&quot;,   // Port name
    String.Empty, // Default directory for ShellExecute process, can be null.
    Win32.ShowCommands.SW_HIDE  // Window state for ShellExecute process, will be hidden
    );
</pre>
<div class="preview">
<pre class="csharp"><span class="cs__com">//&nbsp;GetPrinterProperty()&nbsp;and&nbsp;GetDefaultPrinter()&nbsp;are&nbsp;used&nbsp;to&nbsp;retrieve&nbsp;information&nbsp;for&nbsp;</span>&nbsp;
<span class="cs__com">//&nbsp;the&nbsp;parameters&nbsp;passed&nbsp;to&nbsp;ImageView_PrintTo</span>&nbsp;
Win32.PrinterInfo2&nbsp;prn&nbsp;=&nbsp;Win32.GetPrinterProperty(Win32.GetDefaultPrinter());&nbsp;
&nbsp;&nbsp;
<span class="cs__com">//&nbsp;ShellExecute&nbsp;does&nbsp;the&nbsp;work</span>&nbsp;
<span class="cs__keyword">int</span>&nbsp;retVal&nbsp;=&nbsp;Win32.ShellExecute(&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;IntPtr.Zero,&nbsp;<span class="cs__com">//&nbsp;This&nbsp;parameter&nbsp;can&nbsp;be&nbsp;null.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;String.Empty,&nbsp;<span class="cs__com">//&nbsp;There&nbsp;is&nbsp;no&nbsp;verb&nbsp;being&nbsp;invoked&nbsp;in&nbsp;this&nbsp;case.</span>&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;The&nbsp;next&nbsp;parameter&nbsp;actually&nbsp;supplies&nbsp;the&nbsp;command&nbsp;line&nbsp;used&nbsp;for&nbsp;ShellExecute.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;We&nbsp;invoke&nbsp;ImageView_PrintTo&nbsp;through&nbsp;rundll32.exe,&nbsp;with&nbsp;the&nbsp;shimgvw.dll,&nbsp;hosting&nbsp;this&nbsp;feature.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;System.Environment.SystemDirectory&nbsp;&#43;&nbsp;<span class="cs__string">&quot;\\rundll32.exe&quot;</span>,&nbsp;&nbsp;<span class="cs__com">//&nbsp;The&nbsp;command&nbsp;line&nbsp;itself.</span>&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Command&nbsp;line&nbsp;parameters,&nbsp;specifying&nbsp;dll&nbsp;and&nbsp;ImageView_PrintTo&nbsp;function&nbsp;within&nbsp;it</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;System.Environment.SystemDirectory&nbsp;&#43;&nbsp;<span class="cs__string">&quot;\\shimgvw.dll,ImageView_PrintTo&nbsp;/pt&nbsp;&quot;</span>&nbsp;&#43;&nbsp;&nbsp;
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Parameters&nbsp;passed&nbsp;to&nbsp;ImageView_PrintTo</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__string">&quot;\&quot;&quot;</span>&nbsp;&#43;&nbsp;ofd.FileName&nbsp;&#43;&nbsp;<span class="cs__string">&quot;\&quot;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;<span class="cs__com">//&nbsp;File&nbsp;to&nbsp;print</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__string">&quot;\&quot;&quot;</span>&nbsp;&#43;&nbsp;prn.PrinterName&nbsp;&#43;<span class="cs__string">&quot;\&quot;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Printer&nbsp;name</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__string">&quot;\&quot;&quot;</span>&nbsp;&#43;&nbsp;prn.DriverName&nbsp;&#43;&nbsp;<span class="cs__string">&quot;\&quot;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Driver&nbsp;name</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__string">&quot;\&quot;&quot;</span>&nbsp;&#43;&nbsp;prn.PortName&nbsp;&#43;&nbsp;<span class="cs__string">&quot;\&quot;&quot;</span>,&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;Port&nbsp;name</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;String.Empty,&nbsp;<span class="cs__com">//&nbsp;Default&nbsp;directory&nbsp;for&nbsp;ShellExecute&nbsp;process,&nbsp;can&nbsp;be&nbsp;null.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;Win32.ShowCommands.SW_HIDE&nbsp;&nbsp;<span class="cs__com">//&nbsp;Window&nbsp;state&nbsp;for&nbsp;ShellExecute&nbsp;process,&nbsp;will&nbsp;be&nbsp;hidden</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;);&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode"></div>
</div>
<h2 class="WordSection1">More Information</h2>
<p class="MsoListParagraphCxSpLast" style="text-indent:-18.0pt"><span style="font-family:Symbol"><span>&middot;<span style="font:7.0pt">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb762153(v=vs.85).aspx"><span class="SpellE">ShellExecute</span> function</a></span></p>
<div class="WordSection1"><br>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo" alt=""></a></div>
</div>