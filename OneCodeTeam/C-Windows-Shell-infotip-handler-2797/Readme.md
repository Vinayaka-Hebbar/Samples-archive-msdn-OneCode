# C++ Windows Shell infotip handler (CppShellExtInfotipHandler)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Shell
## Topics
* Windows Shell
* handler
* infotip
## IsPublished
* True
## ModifiedDate
* 2012-08-20 01:32:58
## Description

<h1><span style="font-family:新宋体">C&#43;&#43; Windows Shell infotip handler </span>(<span class="SpellE"><span style="font-family:新宋体">CppShellExtInfotipHandler</span></span>)</h1>
<h2>Introduction</h2>
<p class="MsoNormal"><span style=""><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>The code sample demonstrates creating a Shell <span class="SpellE">infotip</span> handler with C&#43;&#43;. An
<span class="SpellE">infotip</span> handler is a shell extension handler that provides pop-up text when the user
<span class="GramE">hovers</span> the mouse pointer over the object. It is the most flexible way to customize
<span class="SpellE">infotips</span>. The alternative way is to specify either a fixed string or a list of certain file properties to be displayed (See the
<span class="SpellE">Infotip</span> Customization section in <a href="http://msdn.microsoft.com/en-us/library/cc144067.aspx">
http://msdn.microsoft.com/en-us/library/cc144067.aspx</a>). </span></p>
<p class="MsoNormal"><span style="">The example <span class="SpellE">infotip</span> handler has the class ID (CLSID):<span style="">&nbsp;
</span>{A67511FE-371A-498D-9372-A27FDA58BE60}. </span></p>
<p class="MsoNormal"><span style="">It customizes the <span class="SpellE">infotips</span> of .<span class="SpellE">cpp</span> file objects. When you
<span class="GramE">hover</span> your mouse pointer over a .<span class="SpellE">cpp</span> file object in the Windows Explorer, you will see an
<span class="SpellE">infotip</span> with the text: </span></p>
<p class="MsoNormal"><span style="font-size:9.0pt; line-height:115%"><span style="">&nbsp;&nbsp;&nbsp;
</span>File: &lt;File path, e.g. D:\Test.cpp&gt; </span></p>
<p class="MsoNormal"><span style="font-size:9.0pt; line-height:115%"><span style="">&nbsp;&nbsp;&nbsp;
</span>Lines: &lt;Line number, e.g. 123 or N/A&gt; </span></p>
<p class="MsoNormal"><span style="font-size:9.0pt; line-height:115%"><span style="">&nbsp;&nbsp;&nbsp;
</span>- <span class="SpellE">Infotip</span> displayed by <span class="SpellE">
CppShellExtInfotipHandle</span>. </span></p>
<h2>Running the Sample</h2>
<p class="MsoNormal"><span style="">The following steps walk through a demonstration of the
<span class="SpellE">infotip</span> handler code sample. </span></p>
<p class="MsoNormal"><b style=""><span style="font-size:16.0pt; line-height:115%">Step1.</span></b><span style=""> If you are going to use the Shell extension in
<span class="GramE">a</span> x64 Windows system, please configure the Visual C&#43;&#43; project to target 64-bit platforms using project configurations (http://msdn.microsoft.com/en-us/library/9yb4317s.aspx). Only 64-bit extension DLLs can be loaded in the 64-bit
 Windows Shell. </span></p>
<p class="MsoNormal"><span style="">If the extension is to be loaded in a 32-bit Windows system, please use the default Win32 project configuration.
</span></p>
<p class="MsoNormal"><b style=""><span style="font-size:16.0pt; line-height:115%">Step2.</span></b><span style=""> After you successfully build the sample project in Visual Studio 2010, you will get a DLL: CppShellExtInfotipHandler.dll. Start a command prompt
 as administrator, navigate to the folder that contains the file and enter the command: Regsvr32.exe CppShellExtInfotipHandler.dll. The operation needs the Administrator permission.
</span></p>
<p class="MsoNormal"><span style="">The <span class="SpellE">infotip</span> handler is registered successfully if you see a message box saying: &quot;<span class="SpellE">DllRegisterServer</span> in CppShellExtInfotipHandler.dll succeeded.&quot;
</span></p>
<p class="MsoNormal"><b style=""><span style="font-size:16.0pt; line-height:115%">Step3.</span></b><span style=""> Find a .<span class="SpellE">cpp</span> file in the Windows Explorer (e.g. FileInfotipExt.cpp in the sample folder), and hover the mouse pointer
 over it. <span class="GramE">you</span> will see an <span class="SpellE">infotip</span> with the text:
</span></p>
<p class="MsoNormal"><span style=""><span style="">&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.0pt; line-height:115%">File: &lt;File path, e.g. D:\CppShellExtInfotipHandler\FileInfotipExt.cpp&gt;
</span></p>
<p class="MsoNormal"><span style="font-size:9.0pt; line-height:115%"><span style="">&nbsp;&nbsp;&nbsp;
</span>Lines: &lt;Line number, e.g. 123 or N/A&gt; </span></p>
<p class="MsoNormal"><span style="font-size:9.0pt; line-height:115%"><span style="">&nbsp;&nbsp;&nbsp;
</span>- <span class="SpellE">Infotip</span> displayed by <span class="SpellE">
CppShellExtInfotipHandler</span>. </span></p>
<p class="MsoNormal"><span style=""></span></p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/65010/1/image.png" alt="" width="576" height="375" align="middle">
</span></p>
<p class="MsoNormal"><b style=""><span style="font-size:16.0pt; line-height:115%">Step4.</span></b><span style=""> In the same command prompt, run the
<span class="GramE">command<span style="">&nbsp; </span>&quot;</span> Regsvr32.exe /u CppShellExtInfotipHandler.dll&quot; to unregister the Shell
<span class="SpellE">infotip</span> handler. The operation needs the Administrator permission.
</span></p>
<h2>Implementation</h2>
<p class="MsoListParagraph" style="text-indent:-.25in"><b style=""><span style="font-size:12.0pt; line-height:115%"><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span></b>Creating and configuring the project.</p>
<p class="MsoNormal"><span style="">In Visual Studio 2010, create a Visual C&#43;&#43; / Win32 / Win32 Project named &quot;<span class="SpellE">CppShellExtInfotipHandler</span>&quot;. In the &quot;Application Settings&quot; page of Win32 Application Wizard, select
 the application type as &quot;DLL&quot; and check the &quot;Empty project&quot; option. After you click the Finish button, an empty Win32 DLL project is created.
</span></p>
<p class="MsoListParagraph" style="text-indent:-.25in"><b style=""><span style="font-size:12.0pt; line-height:115%"><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span></b>Implementing a basic Component Object Model (COM) DLL.</p>
<p class="MsoNormal"><span style="">Shell extension handlers are all in-process COM objects implemented as DLLs. Making a basic COM includes implementing
<span class="SpellE">DllGetClassObject</span>, <span class="SpellE">DllCanUnloadNow</span>,
</span></p>
<p class="MsoNormal"><span class="SpellE"><span class="GramE"><span style="">DllRegisterServer</span></span></span><span class="GramE"><span style="">, and
<span class="SpellE">DllUnregisterServer</span> in (and exporting them from) the DLL, adding a COM class with the basic implementation of the
<span class="SpellE">IUnknown</span> interface, preparing the class factory for your COM class.</span></span><span style=""> The relevant files in this code sample are:
</span></p>
<p class="MsoNormal"><span style=""><span style="">&nbsp; </span></span><span style="font-size:10.0pt; line-height:115%">dllmain.cpp - implements
<span class="SpellE">DllMain</span> and the <span class="SpellE">DllGetClassObject</span>,
<span class="SpellE">DllCanUnloadNow</span><span class="GramE">,<span style="">&nbsp;
</span><span class="SpellE">DllRegisterServer</span></span>, <span class="SpellE">
DllUnregisterServer</span> functions that are necessary for a COM DLL. </span></p>
<p class="MsoNormal"><span style="font-size:10.0pt; line-height:115%"><span style="">&nbsp;
</span>GlobalExportFunctions.def - exports the <span class="SpellE">DllGetClassObject</span>,
<span class="SpellE">DllCanUnloadNow</span>,<span style="">&nbsp;&nbsp; </span>
<span class="SpellE">DllRegisterServer</span>, <span class="SpellE">DllUnregisterServer</span> functions from the DLL through
<span class="GramE">the<span style="">&nbsp; </span>module</span>-definition file. You need to pass the .<span class="SpellE">def</span> file to the linker
<span class="GramE">by<span style="">&nbsp; </span>configuring</span> the Module Definition File property in the project's Property Pages / Linker / Input property page.
</span></p>
<p class="MsoNormal"><span style="font-size:10.0pt; line-height:115%"><span style="">&nbsp;</span><span class="SpellE">Reg.h</span>/<span class="SpellE">cpp</span> - defines the reusable helper functions to register or unregister in-process COM components
 in the registry:<span style="">&nbsp; </span><span class="SpellE">RegisterInprocServer</span>,
<span class="SpellE">UnregisterInprocServer</span>. </span></p>
<p class="MsoNormal"><span style="font-size:10.0pt; line-height:115%"><span style="">&nbsp;
</span><span class="SpellE">FileInfotipExt.h</span>/<span class="SpellE">cpp</span> - defines the COM class. You can find the basic implementation of the
<span class="SpellE">IUnknown</span> interface in the files. </span></p>
<p class="MsoNormal"><span style="font-size:10.0pt; line-height:115%"><span style="">&nbsp;
</span><span class="SpellE">ClassFactory.h</span>/<span class="SpellE">cpp</span> - defines the class factory for the COM class.
</span></p>
<p class="MsoListParagraph" style="text-indent:-.25in"><b style=""><span style="font-size:12.0pt; line-height:115%"><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span></b>Implementing the <span class="SpellE">infotip</span> handler and registering it for a certain file class.</p>
<p class="MsoNormal"><span class="GramE">Implementing the <span class="SpellE">
infotip</span> handler: The <span class="SpellE">FileInfotipExt.h</span>/<span class="SpellE">cpp</span> files define an
<span class="SpellE">infotip</span> handler.</span> <span class="SpellE">Infotip</span> handlers must implement the
<span class="SpellE">IQueryInfo</span> interface to create text for the tooltip, and implement the
<span class="SpellE">IPersistFile</span> interface for initialization.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">


class FileInfotipExt
: public IPersistFile,
public IQueryInfo


{


public:


   
// IPersistFile


   
IFACEMETHODIMP GetClassID(CLSID *pClassID);


   
IFACEMETHODIMP IsDirty(void);


   
IFACEMETHODIMP Load(LPCOLESTR pszFileName, DWORD dwMode);


   
IFACEMETHODIMP Save(LPCOLESTR pszFileName, BOOL fRemember);


   
IFACEMETHODIMP SaveCompleted(LPCOLESTR pszFileName);


       IFACEMETHODIMP
GetCurFile(LPOLESTR
*ppszFileName);






   
// IQueryInfo


   
IFACEMETHODIMP GetInfoTip(DWORD dwFlags, LPWSTR *ppwszTip);


   
IFACEMETHODIMP GetInfoFlags(DWORD *pdwFlags);      


};



</pre>
<pre id="codePreview" class="cplusplus">


class FileInfotipExt
: public IPersistFile,
public IQueryInfo


{


public:


   
// IPersistFile


   
IFACEMETHODIMP GetClassID(CLSID *pClassID);


   
IFACEMETHODIMP IsDirty(void);


   
IFACEMETHODIMP Load(LPCOLESTR pszFileName, DWORD dwMode);


   
IFACEMETHODIMP Save(LPCOLESTR pszFileName, BOOL fRemember);


   
IFACEMETHODIMP SaveCompleted(LPCOLESTR pszFileName);


       IFACEMETHODIMP
GetCurFile(LPOLESTR
*ppszFileName);






   
// IQueryInfo


   
IFACEMETHODIMP GetInfoTip(DWORD dwFlags, LPWSTR *ppwszTip);


   
IFACEMETHODIMP GetInfoFlags(DWORD *pdwFlags);      


};



</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span class="GramE"><span style="font-size:10.0pt; font-family:Consolas; color:blue">class</span></span><span style="font-size:10.0pt; font-family:Consolas">
<span class="SpellE">FileInfotipExt</span> : <span style="color:blue">public</span>
<span class="SpellE">IPersistFile</span>, <span style="color:blue">public</span>
<span class="SpellE">IQueryInfo</span> </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas">{ </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span class="GramE"><span style="font-size:10.0pt; font-family:Consolas; color:blue">public</span></span><span style="font-size:10.0pt; font-family:Consolas">:
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span style="color:green">// <span class="SpellE">IPersistFile</span></span>
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>IFACEMETHODIMP <span class="SpellE"><span class="GramE">GetClassID</span></span><span class="GramE">(</span>CLSID *<span class="SpellE">pClassID</span>);
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>IFACEMETHODIMP <span class="SpellE"><span class="GramE">IsDirty</span></span><span class="GramE">(</span><span style="color:blue">void</span>);
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>IFACEMETHODIMP <span class="GramE">Load(</span>LPCOLESTR <span class="SpellE">
pszFileName</span>, DWORD <span class="SpellE">dwMode</span>); </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>IFACEMETHODIMP <span class="GramE">Save(</span>LPCOLESTR <span class="SpellE">
pszFileName</span>, BOOL <span class="SpellE">fRemember</span>); </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>IFACEMETHODIMP <span class="SpellE"><span class="GramE">SaveCompleted</span></span><span class="GramE">(</span>LPCOLESTR
<span class="SpellE">pszFileName</span>); </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>IFACEMETHODIMP <span class="SpellE"><span class="GramE">GetCurFile</span></span><span class="GramE">(</span>LPOLESTR *<span class="SpellE">ppszFileName</span>);
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span style="color:green">// <span class="SpellE">IQueryInfo</span></span>
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>IFACEMETHODIMP <span class="SpellE"><span class="GramE">GetInfoTip</span></span><span class="GramE">(</span>DWORD
<span class="SpellE">dwFlags</span>, LPWSTR *<span class="SpellE">ppwszTip</span>);
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>IFACEMETHODIMP <span class="SpellE"><span class="GramE">GetInfoFlags</span></span><span class="GramE">(</span>DWORD *<span class="SpellE">pdwFlags</span>);<span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas">}; </span></p>
<p class="MsoNormal"><span class="GramE"><b style="">3.1</b><span style="">&nbsp;
</span>Implementing</span> <span class="SpellE">IPersistFile</span>.</p>
<p class="MsoNormal">The Shell queries the extension for <span class="SpellE">
IPersistFile</span> and calls its Load <span class="GramE">method<span style="">&nbsp;
</span>passing</span> the file name of the item over which mouse is placed. <span class="SpellE">
IPersistFile</span>::Load opens the specified file and initializes the wanted data.<span style="">&nbsp;&nbsp;
</span>In this code sample, we save the absolute path of the file.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">


IFACEMETHODIMP FileInfotipExt::Load(LPCOLESTR pszFileName, DWORD dwMode)


{


   
// pszFileName
contains the absolute path of the file to be opened.


   
return StringCchCopy(


        m_szSelectedFile, 


        ARRAYSIZE(m_szSelectedFile), 


        pszFileName);


}






<pre id="codePreview" class="cplusplus">


IFACEMETHODIMP FileInfotipExt::Load(LPCOLESTR pszFileName, DWORD dwMode)


{


   
// pszFileName
contains the absolute path of the file to be opened.


   
return StringCchCopy(


        m_szSelectedFile, 


        ARRAYSIZE(m_szSelectedFile), 


        pszFileName);


}






</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas">IFACEMETHODIMP <span class="SpellE">
FileInfotipExt</span>::<span class="GramE">Load(</span>LPCOLESTR <span class="SpellE">
pszFileName</span>, DWORD <span class="SpellE">dwMode</span>) </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas">{ </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span style="color:green">// <span class="SpellE">pszFileName</span> contains the absolute path of the file to be opened.</span>
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span class="GramE"><span style="color:blue">return</span></span> <span class="SpellE">
StringCchCopy</span>( </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE">m_szSelectedFile</span>, </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="GramE">ARRAYSIZE(</span><span class="SpellE">m_szSelectedFile</span>),
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE"><span class="GramE">pszFileName</span></span>); </span>
</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas">} </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:&quot;Courier New&quot;"></span></p>
<p class="MsoNormal"><span class="GramE"><b style="">3.2</b><span style="">&nbsp;
</span>Implementing</span> <span class="SpellE">IQueryInfo</span>.</p>
<p class="MsoNormal">After <span class="SpellE">IPersistFile</span> is queried, the Shell queries the
<span class="SpellE">IQueryInfo</span> <span class="GramE">interface<span style="">&nbsp;
</span>and</span> the <span class="SpellE">GetInfoTip</span> method is called. <span class="SpellE">
GetInfoTip</span> has an out parameter <span class="SpellE">ppwszTip</span> of the type LPWSTR * which
<span class="SpellE">recieves</span> the address of the tool <span class="GramE">
tip<span style="">&nbsp; </span>buffer</span>. Please note that the memory pointed by *<span class="SpellE">ppwszTip</span> must be
<span class="GramE">allocated<span style="">&nbsp; </span>by</span> calling <span class="SpellE">
CoTaskMemAlloc</span>. Shell knows to call <span class="SpellE">CoTaskMemFree</span> to free the memory when the info tip is no longer needed.</p>
<p class="MsoNormal">In this code sample, the example <span class="SpellE">infotip</span> is composed of the file path and the count of text lines.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">


    const int cch = MAX_PATH &#43;
512;


   
*ppwszTip = static_cast&lt;LPWSTR&gt;(CoTaskMemAlloc(cch * sizeof(wchar_t)));


   
if (*ppwszTip == NULL)


   
{


        return E_OUTOFMEMORY;


   
}






   
// Prepare the text
of the infotip. The example infotip
is composed of 


   
// the file path and the count of code lines.


   
wchar_t
szLineNum[50] = L&quot;N/A&quot;;


   
{


        wifstream infile(m_szSelectedFile);


        if (infile.good())


        {


           
__int64 lineNum
= 0;


           
wstring line;


           
while (getline(infile, line))


           
{


               
lineNum&#43;&#43;;


           
}


           
// Ignore the return
value because this call will not fail.


           
StringCchPrintf(szLineNum, ARRAYSIZE(szLineNum), L&quot;%I64i&quot;,
lineNum);


        }


   
}






   
HRESULT hr = StringCchPrintf(*ppwszTip, cch, 


        L&quot;File: %s\nLines: %s\n- Infotip displayed by CppShellExtInfotipHandler&quot;,



        m_szSelectedFile, szLineNum);


   
if (FAILED(hr))


   
{


        CoTaskMemFree(*ppwszTip);


   
}






<pre id="codePreview" class="cplusplus">


    const int cch = MAX_PATH &#43;
512;


   
*ppwszTip = static_cast&lt;LPWSTR&gt;(CoTaskMemAlloc(cch * sizeof(wchar_t)));


   
if (*ppwszTip == NULL)


   
{


        return E_OUTOFMEMORY;


   
}






   
// Prepare the text
of the infotip. The example infotip
is composed of 


   
// the file path and the count of code lines.


   
wchar_t
szLineNum[50] = L&quot;N/A&quot;;


   
{


        wifstream infile(m_szSelectedFile);


        if (infile.good())


        {


           
__int64 lineNum
= 0;


           
wstring line;


           
while (getline(infile, line))


           
{


               
lineNum&#43;&#43;;


           
}


           
// Ignore the return
value because this call will not fail.


           
StringCchPrintf(szLineNum, ARRAYSIZE(szLineNum), L&quot;%I64i&quot;,
lineNum);


        }


   
}






   
HRESULT hr = StringCchPrintf(*ppwszTip, cch, 


        L&quot;File: %s\nLines: %s\n- Infotip displayed by CppShellExtInfotipHandler&quot;,



        m_szSelectedFile, szLineNum);


   
if (FAILED(hr))


   
{


        CoTaskMemFree(*ppwszTip);


   
}






</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas; color:green"><span style="">&nbsp;&nbsp;&nbsp;
</span></span><span class="SpellE"><span class="GramE"><span style="font-size:10.0pt; font-family:Consolas; color:blue">const</span></span></span><span style="font-size:10.0pt; font-family:Consolas">
<span class="SpellE"><span style="color:blue">int</span></span> <span class="SpellE">
cch</span> = MAX_PATH &#43; 512; </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>*<span class="SpellE">ppwszTip</span> = <span class="SpellE"><span style="color:blue">static_cast</span></span>&lt;LPWSTR<span class="GramE">&gt;(</span><span class="SpellE">CoTaskMemAlloc</span>(<span class="SpellE">cch</span> *
<span class="SpellE"><span style="color:blue">sizeof</span></span>(<span class="SpellE"><span style="color:blue">wchar_t</span></span>)));
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span class="GramE"><span style="color:blue">if</span></span> (*<span class="SpellE">ppwszTip</span> == NULL)
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>{ </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="GramE"><span style="color:blue">return</span></span> E_OUTOFMEMORY;
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>} </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span style="color:green">// <span class="GramE">Prepare</span> the text of the
<span class="SpellE">infotip</span>. The example <span class="SpellE">infotip</span> is composed of
</span></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span style="color:green">// the file path and the count of code lines.</span>
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span class="SpellE"><span class="GramE"><span style="color:blue">wchar_t</span></span></span>
<span class="SpellE">szLineNum</span>[50] = L<span style="color:#A31515">&quot;N/A&quot;</span>;
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>{ </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE"><span class="GramE">wifstream</span></span> <span class="SpellE">
infile</span>(<span class="SpellE">m_szSelectedFile</span>); </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="GramE"><span style="color:blue">if</span></span> (<span class="SpellE">infile.good</span>())
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>{ </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="color:blue">__int64</span> <span class="SpellE">lineNum</span> = 0;
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE"><span class="GramE">wstring</span></span> line; </span>
</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="GramE"><span style="color:blue">while</span></span> (<span class="SpellE">getline</span>(<span class="SpellE">infile</span>, line))
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>{ </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE"><span class="GramE">lineNum</span></span>&#43;&#43;; </span>
</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>} </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="color:green">// <span class="GramE">Ignore</span> the return value because this call will not fail.</span>
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE"><span class="GramE">StringCchPrintf</span></span><span class="GramE">(</span><span class="SpellE">szLineNum</span>, ARRAYSIZE(<span class="SpellE">szLineNum</span>), L<span style="color:#A31515">&quot;%I64i&quot;</span>,
<span class="SpellE">lineNum</span>); </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>} </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>} </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>HRESULT <span class="SpellE">hr</span> = <span class="SpellE"><span class="GramE">StringCchPrintf</span></span><span class="GramE">(</span>*<span class="SpellE">ppwszTip</span>,
<span class="SpellE">cch</span>, </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE">L<span style="color:#A31515">&quot;File</span></span><span style="color:#A31515">: %s\<span class="SpellE">nLines</span>: %s\n-
<span class="SpellE">Infotip</span> displayed by <span class="SpellE">CppShellExtInfotipHandler</span>&quot;</span>,
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE">m_szSelectedFile</span>, <span class="SpellE">szLineNum</span>);
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span><span class="GramE"><span style="color:blue">if</span></span> (FAILED(<span class="SpellE">hr</span>))
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>{ </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE"><span class="GramE">CoTaskMemFree</span></span><span class="GramE">(</span>*<span class="SpellE">ppwszTip</span>);
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;
</span>} </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:&quot;Courier New&quot;"></span></p>
<p class="MsoNormal">The <span class="SpellE">IQueryInfo</span>::<span class="SpellE">GetInfoFlags</span> method is not currently used. We simply return E_NOTIMPL from the method.</p>
<p class="MsoListParagraph" style="text-indent:-.25in"><b style=""><span style="font-size:12.0pt; line-height:115%"><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span></b>Registration and <span class="SpellE">Unregistration</span>.</p>
<p class="MsoNormal"><span class="GramE">Registering the handler for a certain file class: The CLSID of the handler is declared at the beginning of dllmain.cpp.</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C&#43;&#43;</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">cplusplus</span>
<pre class="hidden">


          
// {A67511FE-371A-498D-9372-A27FDA58BE60}


         
const CLSID CLSID_FileInfotipExt
= 


         
{ 0xA67511FE, 0x371A, 0x498D, { 0x93, 0x72, 0xA2, 0x7F, 0xDA, 0x58,
0xBE, 0x60 } };


 


<pre id="codePreview" class="cplusplus">


          
// {A67511FE-371A-498D-9372-A27FDA58BE60}


         
const CLSID CLSID_FileInfotipExt
= 


         
{ 0xA67511FE, 0x371A, 0x498D, { 0x93, 0x72, 0xA2, 0x7F, 0xDA, 0x58,
0xBE, 0x60 } };


 


</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Consolas; color:green"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>// {A67511FE-371A-498D-9372-A27FDA58BE60}</span><span style="font-size:9.5pt; font-family:Consolas">
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Consolas; color:blue"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span class="SpellE"><span class="GramE">const</span></span></span><span style="font-size:9.5pt; font-family:Consolas"> CLSID
<span class="SpellE">CLSID_FileInfotipExt</span> = </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Consolas"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>{ 0xA67511FE, 0x371A, 0x498D, { 0x93, 0x72, 0xA2, 0x7F, 0xDA, 0x58, 0xBE, 0x60 } };
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:9.5pt; font-family:Consolas; color:green"><span style="">&nbsp;</span>
</span></p>
<p class="MsoNormal">When you write your own handler, you must create a new CLSID by using the &quot;Create GUID&quot; tool in the Tools menu, and specify the CLSID value here.</p>
<p class="MsoNormal"><span class="SpellE">Infotip</span> handlers can be associated with a file class. The handlers are registered under the following
<span class="SpellE">subkey</span>:</p>
<p class="MsoNormal" style="text-indent:9.0pt">HKEY_CLASSES_ROOT\&lt;File Type&gt;\<span class="SpellE">shellex</span><span class="GramE">\{</span>00021500-0000-0000-C000-000000000046}.</p>
<p class="MsoNormal">The registration of the <span class="SpellE">infotip</span> handler is implemented in the
<span class="SpellE">DllRegisterServer</span> function of dllmain.cpp. <span class="SpellE">
DllRegisterServer</span> first calls the <span class="SpellE">RegisterInprocServer</span> function in
<span class="SpellE">Reg.h</span>/<span class="SpellE">cpp</span> to register the COM component. Next, it calls
<span class="SpellE">RegisterShellExtInfotipHandler</span> to associate the handler with a certain file type. If the file type starts with '.', it tries to read the default value of the HKCR\&lt;File Type&gt; key which may contain the Program ID to which
 the file type is linked. If the default value is not empty, use the Program ID as the file type to
<span class="GramE">proceed</span> the registration.</p>
<p class="MsoNormal">For example, this code sample associates the handler with '.<span class="SpellE">cpp</span>' files. HKCR\.<span class="SpellE">cpp</span> has the default value 'VisualStudio.cpp.9.0' by default when Visual Studio 2008 is installed,
 so we proceed to register the handler under HKCR\VisualStudio.cpp.9.0\ instead of under HKCR\.<span class="SpellE">cpp</span>. The following keys and values are added in the registration process of the sample handler.</p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="font-size:10.0pt; font-family:&quot;Courier New&quot;"></span></p>
<p class="MsoNormal">The <span class="SpellE">unregistration</span> is implemented in the
<span class="SpellE">DllUnregisterServer</span> function of dllmain.cpp. It removes the HKCR\CLSID<span class="GramE">\{</span>&lt;CLSID&gt;} key and the HKCR\&lt;File Type&gt;\<span class="SpellE">shellex</span>\{00021500-0000-0000-C000-000000000046}
 key.</p>
<h2>More Information<span style="font-family:新宋体"> </span></h2>
<p class="MsoNormal"><span style="">MSDN: Initializing Shell Extensions </span>
</p>
<p class="MsoNormal"><span class="MsoHyperlink">http://msdn.microsoft.com/en-us/library/cc144105.aspx</span><u><span style="color:blue">
</span></u></p>
<p class="MsoNormal"><span style="">MSDN: IQueryInfo Interface </span></p>
<p class="MsoNormal"><span class="MsoHyperlink">http://msdn.microsoft.com/en-us/library/bb761359.aspx</span><u><span style="color:blue">
</span></u></p>
<p class="MsoNormal"><span style="">The Complete Idiot's Guide to Writing Shell Extensions - Part III
</span></p>
<p class="MsoNormal"><span class="MsoHyperlink">http://www.codeproject.com/KB/shell/ShellExtGuide3.aspx</span><u><span style="color:blue">
</span></u></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>