# Upload/edit image in ASP.NET (VBASPNETImageEditUpload)
## Requires
* Visual Studio 2010
## License
* Apache License, Version 2.0
## Technologies
* ASP.NET
## Topics
* HTTP Handler
* Image
## IsPublished
* True
## ModifiedDate
* 2011-04-05 04:44:32
## Description

<h2>ASP.NET APPLICATION : VBASPNETImageEditUpload Project Overview</h2>
<h3>Summary:</h3>
<p><br>
<span style="font-family:courier new,courier; font-size:small">The project demonstrates how to insert,edit and update a database with an
</span><br>
<span style="font-family:courier new,courier; font-size:small">Image type field.</span></p>
<h3>Implementation:</h3>
<p><span style="font-family:courier new,courier; font-size:small">Step1. Create a VB ASP.NET Web Application in Visual Studio 2010 /</span><br>
<span style="font-family:courier new,courier; font-size:small">Visual Web Developer 2010 and name it as VBASPNETImageEditUpload.</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">[ NOTE: You can download the free Web Developer from:</span><br>
<span style="font-family:courier new,courier; font-size:small"><a href="http://www.microsoft.com/express/Web/" target="_blank">http://www.microsoft.com/express/Web/</a> ]</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">[ NOTE2: You can also download the free Sql2008 from:</span><br>
<span style="font-family:courier new,courier; font-size:small"><a href="http://www.microsoft.com/express/Database/" target="_blank">http://www.microsoft.com/express/Database/</a> ]</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">Step2. Delete the following default folders and files created automatically
</span><br>
<span style="font-family:courier new,courier; font-size:small">by Visual Studio.</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Account folder</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Script folder</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Style folder</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;About.aspx file</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Default.aspx file</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Global.asax file</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Site.Master file</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">Step3. Create a folder called &quot;DefaultImage&quot;, where you can put an image</span><br>
<span style="font-family:courier new,courier; font-size:small">as a default photo when no picture for a new comer's registration or update.</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">Step4. Create another folder called &quot;ImageHandler&quot;, this will read out byte</span><br>
<span style="font-family:courier new,courier; font-size:small">collection to show a picture stored in the specific datatable &quot;db_Persons&quot;.</span><br>
<span style="font-family:courier new,courier; font-size:small">Your codes should be something like this:</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">Public Class ImageHandler</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Implements System.Web.IHttpHandler</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;Using cmd As New SqlCommand()</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;cmd.Connection = New SqlConnection(</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;ConfigurationManager.ConnectionStrings(&quot;db_PersonsConnectionString&quot;).ConnectionString)</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;cmd.Connection.Open()</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;cmd.CommandText = &quot;select PersonImage,PersonImageType from tb_personInfo where id=&quot; &#43;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;context.Request.QueryString(&quot;id&quot;)</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Dim reader As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection _</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
 &nbsp; &nbsp;Or CommandBehavior.SingleRow)</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;If (reader.Read) Then</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Dim imgbytes() As Byte = Nothing</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Dim imgtype As String = Nothing</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;If (reader.GetValue(0) IsNot DBNull.Value) Then</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;imgbytes = CType(reader.GetValue(0), Byte())</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;imgtype = reader.GetString(1)</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Else</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;imgbytes = File.ReadAllBytes(</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;context.Server.MapPath(&quot;~/DefaultImage/DefaultImage.JPG&quot;))</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;imgtype = &quot;image/pjpeg&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;End If</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;context.Response.ContentType = imgtype</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;context.Response.BinaryWrite(imgbytes)</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;End If</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;reader.Close()</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;context.Response.End()</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;End Using</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;End Sub</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;Get</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Return False</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;End Get</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;End Property</span><br>
<span style="font-family:courier new,courier; font-size:small">End Class</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">Step5: Drag and drop a GridView control inside the Default.aspx page, and bind</span><br>
<span style="font-family:courier new,courier; font-size:small">it with SqlDataSource. Your codes finally look like this:</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;&lt;asp:SqlDataSource ID=&quot;SqlDSPersonOverView&quot; runat=&quot;server&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;ConnectionString=&quot;&lt;%$ ConnectionStrings:db_PersonsConnectionString %&gt;&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;SelectCommand=&quot;SELECT [Id], [PersonName] FROM [tb_personInfo]&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;&lt;/asp:SqlDataSource&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;&lt;asp:GridView ID=&quot;gvPersonOverView&quot; runat=&quot;server&quot; CellPadding=&quot;4&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;EnableModelValidation=&quot;True&quot; ForeColor=&quot;#333333&quot; GridLines=&quot;None&quot; Width=&quot;70%&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;AutoGenerateColumns=&quot;False&quot; DataKeyNames=&quot;Id&quot; DataSourceID=&quot;SqlDSPersonOverView&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;onselectedindexchanged=&quot;gvPersonOverView_SelectedIndexChanged&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;AlternatingRowStyle BackColor=&quot;White&quot; ForeColor=&quot;#284775&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;Columns&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:BoundField DataField=&quot;Id&quot; HeaderText=&quot;Id&quot; InsertVisible=&quot;False&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;ReadOnly=&quot;True&quot; SortExpression=&quot;Id&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:BoundField DataField=&quot;PersonName&quot; HeaderText=&quot;PersonName&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;SortExpression=&quot;PersonName&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:CommandField ShowSelectButton=&quot;True&quot; HeaderText=&quot;Click to see Details&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;SelectText=&quot;Details...&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/Columns&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;EditRowStyle BackColor=&quot;#999999&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;EmptyDataTemplate&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;No Data Available, Please Insert data with the help of the FormView...&lt;br /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/EmptyDataTemplate&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;FooterStyle BackColor=&quot;#5D7B9D&quot; Font-Bold=&quot;True&quot; ForeColor=&quot;White&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;HeaderStyle BackColor=&quot;#5D7B9D&quot; Font-Bold=&quot;True&quot; ForeColor=&quot;White&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;PagerStyle BackColor=&quot;#284775&quot; ForeColor=&quot;White&quot; HorizontalAlign=&quot;Center&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;RowStyle BackColor=&quot;#F7F6F3&quot; ForeColor=&quot;#333333&quot; HorizontalAlign=&quot;Center&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;VerticalAlign=&quot;Middle&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;SelectedRowStyle BackColor=&quot;#E2DED6&quot; Font-Bold=&quot;True&quot; ForeColor=&quot;#333333&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;&lt;/asp:GridView&gt;</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">[NOTE] You can:</span><br>
<span style="font-family:courier new,courier; font-size:small">1) Drag and drop a SqlDataSource from &quot;Data&quot; panel, or just click the right</span><br>
<span style="font-family:courier new,courier; font-size:small">arrow of the GridView,choose SqlDataSource as datasource for GridView.</span><br>
<span style="font-family:courier new,courier; font-size:small">2) Then according to the Wizard, bind the database &quot;db_Persons&quot; to the SqlDataSource.</span><br>
<span style="font-family:courier new,courier; font-size:small">3) At last bind the SqlDataSource to the GridView.</span><br>
<span style="font-family:courier new,courier; font-size:small">4) Modify your Sql connection string in the web.config, &quot;connectionStrings&quot; node</span><br>
<span style="font-family:courier new,courier; font-size:small">if necessary (If you do not know how to write the string, please switch to the SqlDataSource</span><br>
<span style="font-family:courier new,courier; font-size:small">and see the property panel, copy the ConnectionString there).</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">Step6: Drag and drop FormView onto the Default.aspx page, bind it with another SqlDataSource</span><br>
<span style="font-family:courier new,courier; font-size:small">with the same table as mentioned below, modify it as this:</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;&lt;asp:FormView ID=&quot;fvPersonDetails&quot; runat=&quot;server&quot; Width=&quot;50%&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;DataSourceID=&quot;SqlDSPersonDetails&quot; EnableModelValidation=&quot;True&quot; DataKeyNames=&quot;Id&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;DataMember=&quot;DefaultView&quot; OnItemInserting=&quot;fvPersonDetails_ItemInserting&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;onitemupdating=&quot;fvPersonDetails_ItemUpdating&quot; BackColor=&quot;#DEBA84&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;BorderColor=&quot;#DEBA84&quot; BorderStyle=&quot;None&quot; BorderWidth=&quot;1px&quot; CellPadding=&quot;3&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;CellSpacing=&quot;2&quot; GridLines=&quot;Both&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;onitemupdated=&quot;fvPersonDetails_ItemUpdated&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;onitemdeleted=&quot;fvPersonDetails_ItemDeleted&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;onitemdeleting=&quot;fvPersonDetails_ItemDeleting&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;oniteminserted=&quot;fvPersonDetails_ItemInserted&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;onmodechanging=&quot;fvPersonDetails_ModeChanging&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;ItemTemplate&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;table width=&quot;100%&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Person Name:</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td colspan=&quot;2&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;%#Eval(&quot;PersonName&quot;) %&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Person Image:</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td colspan=&quot;2&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;img src='ImageHandler/ImageHandler.ashx?id=&lt;%#Eval(&quot;Id&quot;) %&gt;' width=&quot;200&quot; alt=&quot;&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;height=&quot;200&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td align=&quot;center&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:LinkButton ID=&quot;lnkEdit&quot; runat=&quot;server&quot; CommandName=&quot;Edit&quot; Text=&quot;Edit&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td align=&quot;center&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:LinkButton ID=&quot;lnkDelete&quot; runat=&quot;server&quot; CommandName=&quot;Delete&quot; Text=&quot;Delete&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;OnClientClick=&quot;return confirm('Are you sure to delete it completely?');&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td align=&quot;center&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:LinkButton ID=&quot;lnkNew&quot; runat=&quot;server&quot; CommandName=&quot;New&quot; Text=&quot;New&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/table&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/ItemTemplate&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;EditItemTemplate&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;table width=&quot;100%&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Person Name:</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:TextBox ID=&quot;txtName&quot; runat=&quot;server&quot; Text=' &lt;%#Bind(&quot;PersonName&quot;) %&gt;'
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;MaxLength=&quot;20&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:RequiredFieldValidator ID=&quot;reqName&quot; runat=&quot;server&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;ControlToValidate=&quot;txtName&quot; ErrorMessage=&quot;Name is required!&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;*</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/asp:RequiredFieldValidator&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Person Image:</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:FileUpload ID=&quot;fupEditImage&quot; runat=&quot;server&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:CustomValidator ID=&quot;cmvImageType&quot; runat=&quot;server&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;ControlToValidate=&quot;fupEditImage&quot; ErrorMessage=&quot;File is invalid!&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;OnServerValidate=&quot;CustomValidator1_ServerValidate&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/asp:CustomValidator&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td align=&quot;center&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:LinkButton ID=&quot;lnkUpdate&quot; runat=&quot;server&quot; CommandName=&quot;Update&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Text=&quot;Update&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td align=&quot;center&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:LinkButton ID=&quot;lnkCancel&quot; runat=&quot;server&quot; CommandName=&quot;Cancel&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Text=&quot;Cancel&quot; CausesValidation=&quot;False&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/table&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/EditItemTemplate&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;EditRowStyle BackColor=&quot;#738A9C&quot; Font-Bold=&quot;True&quot; ForeColor=&quot;White&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;FooterStyle BackColor=&quot;#F7DFB5&quot; ForeColor=&quot;#8C4510&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;HeaderStyle BackColor=&quot;#A55129&quot; Font-Bold=&quot;True&quot; ForeColor=&quot;White&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;InsertItemTemplate&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;table width=&quot;100%&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Person Name:</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:TextBox ID=&quot;txtName&quot; runat=&quot;server&quot; MaxLength=&quot;20&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Text='&lt;%#Bind(&quot;PersonName&quot;) %&gt;'&gt;&lt;/asp:TextBox&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:RequiredFieldValidator ID=&quot;RequiredFieldValidator1&quot; runat=&quot;server&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;ControlToValidate=&quot;txtName&quot; ErrorMessage=&quot;Name is required!&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;*</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/asp:RequiredFieldValidator&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Person Image:</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/th&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:FileUpload ID=&quot;fupInsertImage&quot; runat=&quot;server&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:CustomValidator ID=&quot;cmvImageType&quot; runat=&quot;server&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;ControlToValidate=&quot;fupInsertImage&quot; ErrorMessage=&quot;File is invalid!&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;OnServerValidate=&quot;CustomValidator1_ServerValidate&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/asp:CustomValidator&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td align=&quot;center&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:LinkButton ID=&quot;lnkInsert&quot; runat=&quot;server&quot; CommandName=&quot;Insert&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Text=&quot;Insert&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;td align=&quot;center&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:LinkButton ID=&quot;lnkInsertCancel&quot; runat=&quot;server&quot; CommandName=&quot;Cancel&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Text=&quot;Cancel&quot; CausesValidation=&quot;False&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/td&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/tr&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/table&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/InsertItemTemplate&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;PagerStyle HorizontalAlign=&quot;Center&quot; ForeColor=&quot;#8C4510&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;RowStyle BackColor=&quot;#FFF7E7&quot; ForeColor=&quot;#8C4510&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;&lt;/asp:FormView&gt;</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;&lt;asp:SqlDataSource ID=&quot;SqlDSPersonDetails&quot; runat=&quot;server&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;ConnectionString=&quot;&lt;%$ ConnectionStrings:db_PersonsConnectionString %&gt;&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;DeleteCommand=&quot;DELETE FROM tb_personInfo WHERE (Id = @Id)&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;InsertCommand=&quot;INSERT INTO tb_personInfo(PersonName, PersonImage, PersonImageType)
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;VALUES (@PersonName, @PersonImage, @PersonImageType)&quot;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;SelectCommand=&quot;SELECT [Id], [PersonName] FROM [tb_personInfo] where id=@id&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;UpdateCommand=&quot;UPDATE tb_personInfo SET PersonName = @PersonName,</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; PersonImage = @PersonImage, PersonImageType = @PersonImageType WHERE (Id = @Id)&quot;&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;DeleteParameters&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:Parameter Name=&quot;Id&quot; Type=&quot;Int32&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/DeleteParameters&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;InsertParameters&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:Parameter Name=&quot;PersonName&quot; Type=&quot;String&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:Parameter Name=&quot;PersonImage&quot; DbType=&quot;Binary&quot; ConvertEmptyStringToNull=&quot;true&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:Parameter Name=&quot;PersonImageType&quot; Type=&quot;String&quot; ConvertEmptyStringToNull=&quot;true&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/InsertParameters&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;UpdateParameters&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:Parameter Name=&quot;PersonName&quot; Type=&quot;String&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:Parameter Name=&quot;PersonImage&quot; DbType=&quot;Binary&quot; ConvertEmptyStringToNull=&quot;true&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:Parameter Name=&quot;PersonImageType&quot; Type=&quot;String&quot; ConvertEmptyStringToNull=&quot;true&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:Parameter Name=&quot;Id&quot; Type=&quot;Int32&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/UpdateParameters&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;SelectParameters&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;asp:ControlParameter Name=&quot;id&quot; Type=&quot;Int32&quot; ControlID=&quot;gvPersonOverView&quot;
</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;PropertyName=&quot;SelectedValue&quot; DefaultValue=&quot;0&quot; /&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;&lt;/SelectParameters&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;&lt;/asp:SqlDataSource&gt;</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">Step7: Switch to design mode, double click the blank place, in the Page_Load event</span><br>
<span style="font-family:courier new,courier; font-size:small">please write this following:</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Partial Public Class _Default</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;Inherits System.Web.UI.Page</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;''' &lt;summary&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;''' Static types of common images for checking.</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;''' &lt;/summary&gt;</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;Private Shared imgytpes As New List(Of String)() From { _</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &quot;.BMP&quot;, _</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &quot;.GIF&quot;, _</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &quot;.JPG&quot;, _</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &quot;.PNG&quot; _</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;}</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;If Not IsPostBack Then</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;gvPersonOverView.DataBind()</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;If gvPersonOverView.Rows.Count &gt; 0 Then</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;gvPersonOverView.SelectedIndex = 0</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;fvPersonDetails.ChangeMode(FormViewMode.[ReadOnly])</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;fvPersonDetails.DefaultMode = FormViewMode.[ReadOnly]</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Else</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;fvPersonDetails.ChangeMode(FormViewMode.Insert)</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;fvPersonDetails.DefaultMode = FormViewMode.Insert</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;End If</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;End If</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;End Sub</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;End Class</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp;</span><br>
<span style="font-family:courier new,courier; font-size:small">Step8: Now you can turn to gridview, switch to the event panel and double click
</span><br>
<span style="font-family:courier new,courier; font-size:small">the event name &quot;SelectIndexChanged&quot;, and say like this:</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;Protected Sub gvPersonOverView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;fvPersonDetails.ChangeMode(FormViewMode.[ReadOnly])</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp; &nbsp; &nbsp;fvPersonDetails.DefaultMode = FormViewMode.[ReadOnly]</span><br>
<span style="font-family:courier new,courier; font-size:small">&nbsp; &nbsp;End Sub</span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">[Note] Your other controls' events can be added like Step9, for detailed codes
</span><br>
<span style="font-family:courier new,courier; font-size:small">and information, please see the Default.aspx.cs (Open by clicking the symbol
</span><br>
<span style="font-family:courier new,courier; font-size:small">&quot;&#43;&quot; to expand the Default.aspx page).</span></p>
<h3>References:</h3>
<p><br>
<span style="font-family:courier new,courier; font-size:small">ASP.NET QuickStart Torturial:</span><br>
<span style="font-family:courier new,courier; font-size:small"><a href="http://quickstarts.asp.net/QuickStartv20/aspnet/doc/ctrlref/data/gridview.aspx" target="_blank">http://quickstarts.asp.net/QuickStartv20/aspnet/doc/ctrlref/data/gridview.aspx</a></span><br>
<br>
<span style="font-family:courier new,courier; font-size:small">MSDN: Serving Dynamic Content with HTTP Handlers</span><br>
<span style="font-family:courier new,courier; font-size:small"><a href="http://msdn.microsoft.com/en-us/library/ms972953.aspx" target="_blank">http://msdn.microsoft.com/en-us/library/ms972953.aspx</a></span><br>
<br>
<br>
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="/site/view/file/887/0/image.png" alt="">
</a></div>