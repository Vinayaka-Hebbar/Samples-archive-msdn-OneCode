# Customize VS Toolbar in VSPackage (VBVSPackageToolbars)
## Requires
* Visual Studio 2008
## License
* MS-LPL
## Technologies
* VSX
## Topics
* Toolbar
## IsPublished
* True
## ModifiedDate
* 2012-03-01 11:47:30
## Description

<h1>Customize VS Toolbar in VSPackage (<span class="SpellE"><span style="">VB</span>VSPackageToo<wbr>lbars</span>)<span style="">
</span></h1>
<h2>Introduction<span style=""> </span></h2>
<p class="MsoNormal">VSPackages are software modules that make up and extend the Visual Studio integrated development environment (IDE) by providing UI elements, services, projects, editors, and designers. VSPackages are the principal architectural unit of
 Visual Studio, and are the unit of deployment, licensing, and security also. Visual Studio itself is written mostly as a collection of VSPackages. This sample demonstrates how to use the Visual Studio Integration Package Wizard to create a simple VSPackage
 with a toolbar.<b> </b></p>
<h2>Building the Sample</h2>
<p class="MsoNormal">VS 20<span style="">08</span> SP1 SDK must be installed on the machine. You can download it from:
</p>
<p class="MsoNormal"><span lang="EN" style=""><a href="http://www.microsoft.com/download/en/details.aspx?id=21827">Visual Studio 2008 SDK 1.1</a></span><span lang="EN" style="">
</span></p>
<p class="MsoNormal">Set the Start Action and Start Options of Debug.</p>
<p class="MsoNormal">Start Action: <u>C:\Program Files\Microsoft Visual Studio </u>
<u><span style="">9</span>.0\Common7\IDE\devenv.exe</u> (32bit OS) or <u>C:\Program Files (x86)\Microsoft Visual Studio
</u><u><span style="">9</span>.0\Common7\IDE\devenv.exe</u> (64bit OS)<u> </u></p>
<p class="MsoNormal">Start Option: <u>/ranu /rootsuffix Exp</u></p>
<p class="MsoNormal"><span style=""><img src="/site/view/file/53269/1/image.png" alt="" width="576" height="404" align="middle">
</span></p>
<h2>Running the Sample</h2>
<p class="MsoListParagraphCxSpFirst" style=""><a name="OLE_LINK2"></a><a name="OLE_LINK1"><span style=""><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Press <b style="">F5</b> to debug this project.</span></a></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style=""><b style=""><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span></b>In the new instance of Visual Studio, right click the non-populated portion of the toolbar docking window and selecting the &quot;My Toolbar&quot; toolbar. Or select the Tools=&gt;Customize menu item, and from the Customize dialog,
 then can select the &quot;My Toolbar&quot; entry to display the toolbar<b style="">.</b></span></span><span style=""><span style=""><b style=""><span style="">
</span></b></span></span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><span style=""><b style=""><span style=""><img src="/site/view/file/53270/1/image.png" alt="" width="575" height="80" align="middle">
</span></b></span></span><span style=""><span style=""><b style=""><span style=""></span></b></span></span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><span style=""><span style=""></span></span></span></p>
<p class="MsoListParagraphCxSpMiddle" style=""><span style=""><span style=""><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>This toolbar supports Dropdown, you can click the buttons in the toolbar, and it will show the related messages.
</span></span></p>
<p class="MsoListParagraphCxSpMiddle"><span style=""><span style=""><span style=""><img src="/site/view/file/53271/1/image.png" alt="" width="667" height="181" align="middle">
</span></span></span><span style=""><span style=""><span style=""></span></span></span></p>
<p class="MsoListParagraphCxSpLast"><span style=""><span style=""><span style=""></span></span></span></p>
<h2>Using the Code</h2>
<p class="MsoNormal"><b style=""><span style="">A: How to Create a VSPackage </span>
</b></p>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Create a new project using Visual Studio Integration Package as template(New Project dialog box -&gt; Other Project Types -&gt; Extensibility).
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Location box, type the file path for your VSPackage.
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Name box, type the name for the solution and then click OK to startthe wizard.
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">On the Select a Programming Language page, select V</span><span style="">B</span><span style=""> and have the wizard generate a key.snk file to sign the assembly, then click Next.
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">5.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Basic VSPackage Information page, specify details about your VSPackage(Brand the VSPackage) and click Next.
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">6.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Select the Menu Command option to create a new command for the VSPackage. Then click Next.
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">7.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Type the name(All-In-One) and ID(cmdidMyCommand) for the new menu command in the text boxes, then click Next. The command ID is the name of a constant that represents this menu command in the generated code.
</span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">8.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Uncheck the Intergration Test Project and Unit Test Project, then click Finish.
</span></p>
<p class="MsoNormal" style="margin-bottom:0cm; margin-bottom:.0001pt; text-indent:36.0pt; line-height:normal; text-autospace:none">
<span style="font-size:9.0pt; font-family:&quot;Courier New&quot;"></span></p>
<p class="MsoNormal"><b style=""><span style="">B: Add a Toolbar to VS IDE </span>
</b></p>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In Solution Explorer, open </span><span style="">VB</span><span style="">VSToolbars.vsct.
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style="">VSCT file stands for Visual Studio Command Table. This is an XML based file that<span style="">&nbsp;
</span>describes the layout and appearance of command items for a VSPackage. Command<span style="">&nbsp;
</span>items include buttons, combo boxes, menus, toolbars, and groups of command items.<span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the &lt;Symbols&gt; section, find the &lt;GuidSymbol&gt; node whose name attribute is guid</span><span style="">VB</span><span style="">VSToolbarsCmdSet. Add the following two &lt;IDSymbol&gt; elements to the list of &lt;IDSymbol&gt;
 elements in this node to define a toolbar and a toolbar group. </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;IDSymbol name=&quot;ToolbarID&quot; value=&quot;0x1000&quot; /&gt;
&lt;IDSymbol name=&quot;ToolbarGroupID&quot; value=&quot;0x1001&quot; /&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;IDSymbol name=&quot;ToolbarID&quot; value=&quot;0x1000&quot; /&gt;
&lt;IDSymbol name=&quot;ToolbarGroupID&quot; value=&quot;0x1001&quot; /&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"><span style=""></span></p>
<p class="MsoListParagraph" style="margin-left:54.0pt"><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Just above the &lt;Groups&gt; section, create an empty &lt;Menus&gt; section, and create the following &lt;Menu&gt; element to define the toolbar that you declared in step 2.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Menus&gt;
 &lt;Menu guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarID&quot;
       priority=&quot;0x0000&quot; type=&quot;Toolbar&quot;&gt;
   &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarID&quot; /&gt;
   &lt;Strings&gt;
     &lt;ButtonText&gt;My Toolbar&lt;/ButtonText&gt;
     &lt;CommandName&gt;My Toolbar&lt;/CommandName&gt;
   &lt;/Strings&gt;
 &lt;/Menu&gt;
&lt;/Menus&gt; 

</pre>
<pre id="codePreview" class="xml">
&lt;Menus&gt;
 &lt;Menu guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarID&quot;
       priority=&quot;0x0000&quot; type=&quot;Toolbar&quot;&gt;
   &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarID&quot; /&gt;
   &lt;Strings&gt;
     &lt;ButtonText&gt;My Toolbar&lt;/ButtonText&gt;
     &lt;CommandName&gt;My Toolbar&lt;/CommandName&gt;
   &lt;/Strings&gt;
 &lt;/Menu&gt;
&lt;/Menus&gt; 

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Add a new &lt;Group&gt; element to the &lt;Groups&gt; section to define the group that you declared in the &lt;Symbols&gt; section.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Group guid=&quot;guidVbVSToolbarsCmdSet&quot; id=&quot;ToolbarGroupID&quot;
       priority=&quot;0x0000&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarID&quot;/&gt;
&lt;/Group&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;Group guid=&quot;guidVbVSToolbarsCmdSet&quot; id=&quot;ToolbarGroupID&quot;
       priority=&quot;0x0000&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarID&quot;/&gt;
&lt;/Group&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">5.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Buttons Element, change the parent of the existing Button Elementto the toolbar group so that the toolbar will be displayed.<span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarGroupID&quot; /&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarGroupID&quot; /&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">6.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Save </span><span style="">VB</span><span style="">VSToolbars.vsct.
</span></p>
<p class="MsoNormal"><b style=""><span style="">C: Add a icon to the command: </span>
</b></p>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Create a bitmap with a color depth of 32-bits. An icon is always 16 x 16 so this bitmap must be 16 pixels high and a multiple of 16 pixels wide.In this sample, it is camera.png, which is a 32bits png image.<span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Add the bitmap to the resource of this project
</span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:54.0pt"><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Open the .vsct file in the editor. </span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Symbols Element, find the GuidSymbol Element that contains your existing<span style="">&nbsp;
</span>bitmap entries. By default, it is named guidImages. And add new Symbols Element next to the existing one.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;GuidSymbol name=&quot;guidMyImages&quot; value=&quot;{4056cc26-4a2f-432c-a816-e6694e673abb}&quot;&gt;
  &lt;IDSymbol name=&quot;bmpMyPic&quot; value=&quot;1&quot; /&gt;
&lt;/GuidSymbol&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;GuidSymbol name=&quot;guidMyImages&quot; value=&quot;{4056cc26-4a2f-432c-a816-e6694e673abb}&quot;&gt;
  &lt;IDSymbol name=&quot;bmpMyPic&quot; value=&quot;1&quot; /&gt;
&lt;/GuidSymbol&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">5.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Add an IDSymbol Element for each icon in your bitmap. The name attribute is the icon's ID, and the value indicates its position on the strip.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;IDSymbol name=&quot;bmpMyPic&quot; value=&quot;1&quot; /&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;IDSymbol name=&quot;bmpMyPic&quot; value=&quot;1&quot; /&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">6.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Create a Bitmap Element in the &lt;Bitmaps&gt; section of the .vsct file to represent the bitmap containing the icons.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Bitmap guid=&quot;guidMyImages&quot; href=&quot;Resources\camera.png&quot;/&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;Bitmap guid=&quot;guidMyImages&quot; href=&quot;Resources\camera.png&quot;/&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">7.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Change the Toolbar button to use the new icon
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Icon guid=&quot;guidMyImages&quot; id=&quot;bmpMyPic&quot; /&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;Icon guid=&quot;guidMyImages&quot; id=&quot;bmpMyPic&quot; /&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">8.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Save all the files. </span></p>
<p class="MsoNormal"><b style=""><span style="">D: Add a menu controller </span>
</b></p>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Open the .vsct file in the editor. </span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Symbols Element, in the GuidSymbol Element named &quot;guid</span><span style="">VB</span><span style="">VSToolbarsCmdSet&quot;,<span style="">&nbsp;
</span>declare your menu controller, menu controller group, and three menu items.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;IDSymbol name=&quot;TestMenuController&quot; value=&quot;0x1300&quot;/&gt;
&lt;IDSymbol name=&quot;TestMenuControllerGroup&quot; value=&quot;0x1060&quot;/&gt;
&lt;IDSymbol name=&quot;cmdidMCItem1&quot; value=&quot;0x0130&quot;/&gt;
&lt;IDSymbol name=&quot;cmdidMCItem2&quot; value=&quot;0x0131&quot;/&gt;
&lt;IDSymbol name=&quot;cmdidMCItem3&quot; value=&quot;0x0132&quot;/&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;IDSymbol name=&quot;TestMenuController&quot; value=&quot;0x1300&quot;/&gt;
&lt;IDSymbol name=&quot;TestMenuControllerGroup&quot; value=&quot;0x1060&quot;/&gt;
&lt;IDSymbol name=&quot;cmdidMCItem1&quot; value=&quot;0x0130&quot;/&gt;
&lt;IDSymbol name=&quot;cmdidMCItem2&quot; value=&quot;0x0131&quot;/&gt;
&lt;IDSymbol name=&quot;cmdidMCItem3&quot; value=&quot;0x0132&quot;/&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In Menus Element,after the last menu entry, define the menu controller as a menu.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Menu guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuController&quot;
    priority=&quot;0x0100&quot; type=&quot;MenuController&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarGroupID&quot;/&gt;
  &lt;CommandFlag&gt;IconAndText&lt;/CommandFlag&gt;
  &lt;CommandFlag&gt;TextChanges&lt;/CommandFlag&gt;
  &lt;CommandFlag&gt;TextIsAnchorCommand&lt;/CommandFlag&gt;
  &lt;Strings&gt;
    &lt;ButtonText&gt;Test Menu Controller&lt;/ButtonText&gt;
    &lt;CommandName&gt;Test Menu Controller&lt;/CommandName&gt;
  &lt;/Strings&gt;
&lt;/Menu&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;Menu guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuController&quot;
    priority=&quot;0x0100&quot; type=&quot;MenuController&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;ToolbarGroupID&quot;/&gt;
  &lt;CommandFlag&gt;IconAndText&lt;/CommandFlag&gt;
  &lt;CommandFlag&gt;TextChanges&lt;/CommandFlag&gt;
  &lt;CommandFlag&gt;TextIsAnchorCommand&lt;/CommandFlag&gt;
  &lt;Strings&gt;
    &lt;ButtonText&gt;Test Menu Controller&lt;/ButtonText&gt;
    &lt;CommandName&gt;Test Menu Controller&lt;/CommandName&gt;
  &lt;/Strings&gt;
&lt;/Menu&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Groups Element, after the last group entry, add the menu controller group
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Group guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuControllerGroup&quot;
 priority=&quot;0x000&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuController&quot;/&gt;
&lt;/Group&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;Group guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuControllerGroup&quot;
 priority=&quot;0x000&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuController&quot;/&gt;
&lt;/Group&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="">&nbsp;</span> </span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">5.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Buttons Element, after the last button entry, add a Button Element for each of<span style="">&nbsp;
</span>your menu items. </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;Button guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;cmdidMCItem1&quot;
priority=&quot;0x0000&quot; type=&quot;Button&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuControllerGroup&quot;/&gt;
  &lt;Icon guid=&quot;guidImages&quot; id=&quot;bmpPic1&quot;/&gt;
  &lt;CommandFlag&gt;IconAndText&lt;/CommandFlag&gt;
  &lt;Strings&gt;
    &lt;ButtonText&gt;MC Item 1&lt;/ButtonText&gt;
    &lt;CommandName&gt;MC Item 1&lt;/CommandName&gt;
  &lt;/Strings&gt;
&lt;/Button&gt;
&lt;Button guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;cmdidMCItem2&quot;
      priority=&quot;0x0100&quot; type=&quot;Button&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuControllerGroup&quot;/&gt;
  &lt;Icon guid=&quot;guidImages&quot; id=&quot;bmpPic2&quot;/&gt;
  &lt;CommandFlag&gt;IconAndText&lt;/CommandFlag&gt;
  &lt;Strings&gt;
    &lt;ButtonText&gt;MC Item 2&lt;/ButtonText&gt;
    &lt;CommandName&gt;MC Item 2&lt;/CommandName&gt;
  &lt;/Strings&gt;
&lt;/Button&gt;
&lt;Button guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;cmdidMCItem3&quot;
      priority=&quot;0x0200&quot; type=&quot;Button&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuControllerGroup&quot;/&gt;
  &lt;Icon guid=&quot;guidImages&quot; id=&quot;bmpPicSearch&quot;/&gt;
  &lt;CommandFlag&gt;IconAndText&lt;/CommandFlag&gt;
  &lt;Strings&gt;
    &lt;ButtonText&gt;MC Item 3&lt;/ButtonText&gt;
    &lt;CommandName&gt;MC Item 3&lt;/CommandName&gt;
  &lt;/Strings&gt;
&lt;/Button&gt;   

</pre>
<pre id="codePreview" class="xml">
&lt;Button guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;cmdidMCItem1&quot;
priority=&quot;0x0000&quot; type=&quot;Button&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuControllerGroup&quot;/&gt;
  &lt;Icon guid=&quot;guidImages&quot; id=&quot;bmpPic1&quot;/&gt;
  &lt;CommandFlag&gt;IconAndText&lt;/CommandFlag&gt;
  &lt;Strings&gt;
    &lt;ButtonText&gt;MC Item 1&lt;/ButtonText&gt;
    &lt;CommandName&gt;MC Item 1&lt;/CommandName&gt;
  &lt;/Strings&gt;
&lt;/Button&gt;
&lt;Button guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;cmdidMCItem2&quot;
      priority=&quot;0x0100&quot; type=&quot;Button&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuControllerGroup&quot;/&gt;
  &lt;Icon guid=&quot;guidImages&quot; id=&quot;bmpPic2&quot;/&gt;
  &lt;CommandFlag&gt;IconAndText&lt;/CommandFlag&gt;
  &lt;Strings&gt;
    &lt;ButtonText&gt;MC Item 2&lt;/ButtonText&gt;
    &lt;CommandName&gt;MC Item 2&lt;/CommandName&gt;
  &lt;/Strings&gt;
&lt;/Button&gt;
&lt;Button guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;cmdidMCItem3&quot;
      priority=&quot;0x0200&quot; type=&quot;Button&quot;&gt;
  &lt;Parent guid=&quot;guidVBVSToolbarsCmdSet&quot; id=&quot;TestMenuControllerGroup&quot;/&gt;
  &lt;Icon guid=&quot;guidImages&quot; id=&quot;bmpPicSearch&quot;/&gt;
  &lt;CommandFlag&gt;IconAndText&lt;/CommandFlag&gt;
  &lt;Strings&gt;
    &lt;ButtonText&gt;MC Item 3&lt;/ButtonText&gt;
    &lt;CommandName&gt;MC Item 3&lt;/CommandName&gt;
  &lt;/Strings&gt;
&lt;/Button&gt;   

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:54.0pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:54.0pt"><span style=""><span style="">6.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Save the .vsct file.<span style="">&nbsp;&nbsp;
</span></span></p>
<p class="MsoNormal"><b style=""><span style=""><span style="">&nbsp;</span>E: Implement the menu controller
</span></b></p>
<p class="MsoListParagraph" style="margin-left:58.5pt"><span style=""><span style="">1.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Open PkgCmdID.</span><span style="">vb</span><span style=""> and add the following lines
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Public Const cmdidMCItem1 As UInteger = &H130
Public Const cmdidMCItem2 As UInteger = &H131
Public Const cmdidMCItem3 As UInteger = &H132

</pre>
<pre id="codePreview" class="vb">
Public Const cmdidMCItem1 As UInteger = &H130
Public Const cmdidMCItem2 As UInteger = &H131
Public Const cmdidMCItem3 As UInteger = &H132

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:58.5pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:58.5pt"><span style=""><span style="">2.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">At the top of the </span><span style="">VB</span><span style="">VSToolbarsPackage class, add the following:
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
' The currently selected menu controller command
Private currentMCCommand As Integer

</pre>
<pre id="codePreview" class="vb">
' The currently selected menu controller command
Private currentMCCommand As Integer

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:58.5pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:58.5pt"><span style=""><span style="">3.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">In the Initialize method, immediately after the last call to the AddCommand method, add code to route the events for each command through the same handlers.
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
For i As Integer = PkgCmdIDList.cmdidMCItem1 To PkgCmdIDList.cmdidMCItem3
    Dim cmdID As New CommandID(GuidList.guidVBVSPackageToolbarsCmdSet, i)
    Dim mc As New OleMenuCommand(New EventHandler(AddressOf OnMCItemClicked), cmdID)
    AddHandler mc.BeforeQueryStatus, AddressOf OnMCItemQueryStatus
    mcs.AddCommand(mc)
    ' The first item is, by default, checked.
    If PkgCmdIDList.cmdidMCItem1 = i Then
        mc.Checked = True
        Me.currentMCCommand = i
    End If
Next i

</pre>
<pre id="codePreview" class="vb">
For i As Integer = PkgCmdIDList.cmdidMCItem1 To PkgCmdIDList.cmdidMCItem3
    Dim cmdID As New CommandID(GuidList.guidVBVSPackageToolbarsCmdSet, i)
    Dim mc As New OleMenuCommand(New EventHandler(AddressOf OnMCItemClicked), cmdID)
    AddHandler mc.BeforeQueryStatus, AddressOf OnMCItemQueryStatus
    mcs.AddCommand(mc)
    ' The first item is, by default, checked.
    If PkgCmdIDList.cmdidMCItem1 = i Then
        mc.Checked = True
        Me.currentMCCommand = i
    End If
Next i

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:58.5pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpLast" style="margin-left:58.5pt"><span style=""><span style="">4.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Add the following two event handler defined above
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
Private Sub OnMCItemClicked(ByVal sender As Object, ByVal e As EventArgs)
    Dim mc As OleMenuCommand = TryCast(sender, OleMenuCommand)
    If Nothing IsNot mc Then
        Dim selection As String
        Select Case mc.CommandID.ID
            Case PkgCmdIDList.cmdidMCItem1
                selection = &quot;Menu controller Item 1&quot;


            Case PkgCmdIDList.cmdidMCItem2
                selection = &quot;Menu controller Item 2&quot;


            Case PkgCmdIDList.cmdidMCItem3
                selection = &quot;Menu controller Item 3&quot;


            Case Else
                selection = &quot;Unknown command&quot;
        End Select
        Me.currentMCCommand = mc.CommandID.ID


        Dim uiShell As IVsUIShell = CType(GetService(GetType(SVsUIShell)), IVsUIShell)
        Dim clsid As Guid = Guid.Empty
        Dim result As Integer
        uiShell.ShowMessageBox(0, clsid, &quot;Test Tool Window Toolbar Package&quot;, String.Format(CultureInfo.CurrentCulture, &quot;You selected {0}&quot;, selection), String.Empty, 0, OLEMSGBUTTON.OLEMSGBUTTON_OK, OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST, OLEMSGICON.OLEMSGICON_INFO, 0, result)
    End If
End Sub

</pre>
<pre id="codePreview" class="vb">
Private Sub OnMCItemClicked(ByVal sender As Object, ByVal e As EventArgs)
    Dim mc As OleMenuCommand = TryCast(sender, OleMenuCommand)
    If Nothing IsNot mc Then
        Dim selection As String
        Select Case mc.CommandID.ID
            Case PkgCmdIDList.cmdidMCItem1
                selection = &quot;Menu controller Item 1&quot;


            Case PkgCmdIDList.cmdidMCItem2
                selection = &quot;Menu controller Item 2&quot;


            Case PkgCmdIDList.cmdidMCItem3
                selection = &quot;Menu controller Item 3&quot;


            Case Else
                selection = &quot;Unknown command&quot;
        End Select
        Me.currentMCCommand = mc.CommandID.ID


        Dim uiShell As IVsUIShell = CType(GetService(GetType(SVsUIShell)), IVsUIShell)
        Dim clsid As Guid = Guid.Empty
        Dim result As Integer
        uiShell.ShowMessageBox(0, clsid, &quot;Test Tool Window Toolbar Package&quot;, String.Format(CultureInfo.CurrentCulture, &quot;You selected {0}&quot;, selection), String.Empty, 0, OLEMSGBUTTON.OLEMSGBUTTON_OK, OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST, OLEMSGICON.OLEMSGICON_INFO, 0, result)
    End If
End Sub

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoListParagraphCxSpFirst" style="margin-left:58.5pt"><span style=""></span></p>
<p class="MsoListParagraphCxSpMiddle" style="margin-left:58.5pt"><span style=""><span style="">5.<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="">Save the all files. </span></p>
<p class="MsoListParagraphCxSpLast"><b style=""></b></p>
<h2>More Information</h2>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb164725.aspx">How to: Create VSPackages (C# and Visual Basic)</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb166544.aspx">How to: Register a VSPackage (C#)</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/cc138589.aspx">VSPackage Tutorial 1: How to Create a VSPackage</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb166366.aspx">Designing XML Command Table (.Vsct) Files</a></span><span class="MsoHyperlink"><span style="color:windowtext; text-decoration:none">
</span></span></p>
<p class="MsoNormal"><span class="MsoHyperlink"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb165399.aspx">Commands Element</a></span></span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb165085.aspx">KeyBindings Element</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb164715.aspx">Walkthrough: Adding a Toolbar to the IDE</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb165158.aspx">How to: Add Icons to Commands on Toolbars</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb166443.aspx">How to: Add Menu Controllers to Toolbars</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://msdn.microsoft.com/en-us/library/bb165748.aspx">Walkthrough: Adding a Menu Controller to a Toolbar</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://dotneteers.net/blogs/divedeeper/archive/2008/01/06/LearnVSXNowPart3.aspx">Creating a package with a simple command</a>
</span></p>
<p class="MsoNormal"><span style=""><a href="http://dotneteers.net/blogs/divedeeper/archive/2008/02/22/LearnVSXNowPart13.aspx">Menus and comands in VS IDE</a>
</span></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>