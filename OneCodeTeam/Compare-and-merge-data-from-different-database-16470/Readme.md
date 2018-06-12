# Compare and merge data from different database (CompareAndMergeData)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* ASP.NET
## Topics
* Merge Data
## IsPublished
* True
## ModifiedDate
* 2012-04-20 01:06:22
## Description

<h1><span style="">How to compare and merge data from different <span class="SpellE">
datasources</span> </span>(<span class="SpellE"><span style="">VBASPNETCompareAndMergeData</span></span>)</h1>
<h2>Introduction</h2>
<p class="MsoNormal">The project illustrates how to compare and merge data which from different
<span class="SpellE">datasources</span>. In this sample, we store some data in xml file and SQL Server database respectively. We need to compare the data from different
<span class="SpellE">datasources</span> and display the columns with one <span class="SpellE">
GridView</span> Control. If the records ID are equal we need to set the status column as ��ok��. Otherwise the status column should be set as ��null��. When we display the columns from different
<span class="SpellE">datasources</span> we may need to merge the datasets in order to bind to
<span class="SpellE">GridView</span> Control.<b><br>
</b><span class="Heading2Char"><span style="font-size:13.0pt; line-height:115%">Running the Sample</span></span></p>
<p class="MsoNormal"><span style="">Please follow these demonstration steps below.
</span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="">Step 1: Open the VBASPNETCompareAndMergeData.sln. </span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style=""></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="">Step 2: Right click Default.aspx and choose &quot;View in Browser&quot;.<span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style=""><br>
<span style=""><img src="/site/view/file/56375/1/image.png" alt="" width="650" height="306" align="middle">
</span></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style=""></span></p>
<p class="MsoNormal" style="margin-bottom:0in; margin-bottom:.0001pt; line-height:normal; text-autospace:none">
<span style="">Step 3: Validation finished. </span></p>
<h2>Using the Code</h2>
<p class="MsoNormal" style=""><span style="">Code Logical: <span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></p>
<p class="MsoNormal" style=""><span style="">Step 1. Create a VB ASP.NET Web Application in Visual Studio 2010 and name it as ��VBASPNETCompareAndMergeData��.
</span></p>
<p class="MsoNormal" style=""><span style="">Step 2. Create a test database and the xml file.
</span></p>
<p class="MsoNormal" style=""><span style="">The database name is ��books�� and the definition of the table ��<span class="SpellE">bookdata</span>�� as shown below:</span><span style="color:black">
<br>
ISBN(<span class="SpellE">nvarchar</span>(50)),<span style="">&nbsp; </span><span class="SpellE">BookName</span>(<span class="SpellE">nvarchar</span>(50)), Price(<span class="SpellE">nvarchar</span>(50)),
<span class="SpellE">AuthorName</span>(<span class="SpellE">nvarchar</span>(50)), Publisher(nvarchar(50))<span style="">&nbsp;
</span><span style="">&nbsp;</span></span><span style=""> </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">xml</span>
<pre class="hidden">
&lt;?xml version=&quot;1.0&quot; standalone=&quot;yes&quot;?&gt;
&lt;BookWorld&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;F2LGFGCEUC&lt;/ISBN&gt;
    &lt;BookName&gt;Mysteries of World&lt;/BookName&gt;
    &lt;Price&gt;20$&lt;/Price&gt;
    &lt;AuthorName&gt;Alfred Newton&lt;/AuthorName&gt;
    &lt;Publisher&gt;McGraw Bills&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;R2MGFGASDF&lt;/ISBN&gt;
    &lt;BookName&gt;Bank of modern world&lt;/BookName&gt;
    &lt;Price&gt;20$&lt;/Price&gt;
    &lt;AuthorName&gt;Rajib Banerjee&lt;/AuthorName&gt;
    &lt;Publisher&gt;Kaplana Inc&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;H2LGFGBNFG&lt;/ISBN&gt;
    &lt;BookName&gt;Gulf and Gas&lt;/BookName&gt;
    &lt;Price&gt;40$&lt;/Price&gt;
    &lt;AuthorName&gt;Rahul Banerjee&lt;/AuthorName&gt;
    &lt;Publisher&gt;Oxford Newland&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;K2LGFGUIFR&lt;/ISBN&gt;
    &lt;BookName&gt;I am just tired. not retired&lt;/BookName&gt;
    &lt;Price&gt;35$&lt;/Price&gt;
    &lt;AuthorName&gt;Rajib Banerjee&lt;/AuthorName&gt;
    &lt;Publisher&gt;New Press&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;O2LGFGOPTR&lt;/ISBN&gt;
    &lt;BookName&gt;Bomb of Future&lt;/BookName&gt;
    &lt;Price&gt;39$&lt;/Price&gt;
    &lt;AuthorName&gt;James Kirk&lt;/AuthorName&gt;
    &lt;Publisher&gt;Alter Nation&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;A2LGFGWERT&lt;/ISBN&gt;
    &lt;BookName&gt;Climb the Tomb&lt;/BookName&gt;
    &lt;Price&gt;45$&lt;/Price&gt;
    &lt;AuthorName&gt;Abardeen&lt;/AuthorName&gt;
    &lt;Publisher&gt;New Castle&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;K2LGFGNJYI&lt;/ISBN&gt;
    &lt;BookName&gt;If you can Dare&lt;/BookName&gt;
    &lt;Price&gt;40$&lt;/Price&gt;
    &lt;AuthorName&gt;Sydmond Rock&lt;/AuthorName&gt;
    &lt;Publisher&gt;Daily Needs&lt;/Publisher&gt;
  &lt;/BookData&gt;
&lt;/BookWorld&gt;

</pre>
<pre id="codePreview" class="xml">
&lt;?xml version=&quot;1.0&quot; standalone=&quot;yes&quot;?&gt;
&lt;BookWorld&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;F2LGFGCEUC&lt;/ISBN&gt;
    &lt;BookName&gt;Mysteries of World&lt;/BookName&gt;
    &lt;Price&gt;20$&lt;/Price&gt;
    &lt;AuthorName&gt;Alfred Newton&lt;/AuthorName&gt;
    &lt;Publisher&gt;McGraw Bills&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;R2MGFGASDF&lt;/ISBN&gt;
    &lt;BookName&gt;Bank of modern world&lt;/BookName&gt;
    &lt;Price&gt;20$&lt;/Price&gt;
    &lt;AuthorName&gt;Rajib Banerjee&lt;/AuthorName&gt;
    &lt;Publisher&gt;Kaplana Inc&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;H2LGFGBNFG&lt;/ISBN&gt;
    &lt;BookName&gt;Gulf and Gas&lt;/BookName&gt;
    &lt;Price&gt;40$&lt;/Price&gt;
    &lt;AuthorName&gt;Rahul Banerjee&lt;/AuthorName&gt;
    &lt;Publisher&gt;Oxford Newland&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;K2LGFGUIFR&lt;/ISBN&gt;
    &lt;BookName&gt;I am just tired. not retired&lt;/BookName&gt;
    &lt;Price&gt;35$&lt;/Price&gt;
    &lt;AuthorName&gt;Rajib Banerjee&lt;/AuthorName&gt;
    &lt;Publisher&gt;New Press&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;O2LGFGOPTR&lt;/ISBN&gt;
    &lt;BookName&gt;Bomb of Future&lt;/BookName&gt;
    &lt;Price&gt;39$&lt;/Price&gt;
    &lt;AuthorName&gt;James Kirk&lt;/AuthorName&gt;
    &lt;Publisher&gt;Alter Nation&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;A2LGFGWERT&lt;/ISBN&gt;
    &lt;BookName&gt;Climb the Tomb&lt;/BookName&gt;
    &lt;Price&gt;45$&lt;/Price&gt;
    &lt;AuthorName&gt;Abardeen&lt;/AuthorName&gt;
    &lt;Publisher&gt;New Castle&lt;/Publisher&gt;
  &lt;/BookData&gt;
  &lt;BookData&gt;
    &lt;ISBN&gt;K2LGFGNJYI&lt;/ISBN&gt;
    &lt;BookName&gt;If you can Dare&lt;/BookName&gt;
    &lt;Price&gt;40$&lt;/Price&gt;
    &lt;AuthorName&gt;Sydmond Rock&lt;/AuthorName&gt;
    &lt;Publisher&gt;Daily Needs&lt;/Publisher&gt;
  &lt;/BookData&gt;
&lt;/BookWorld&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style=""><span style=""><br>
Step 3. Add a GridView Control to the Default page. </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
&lt;asp:GridView ID=&quot;gdvData&quot; runat=&quot;server&quot; &gt;
        &lt;/asp:GridView&gt;

</pre>
<pre id="codePreview" class="vb">
&lt;asp:GridView ID=&quot;gdvData&quot; runat=&quot;server&quot; &gt;
        &lt;/asp:GridView&gt;

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style=""><span style=""><br>
Step 4. <span style="">Get data from database and then fill it in dataset</span>.</span>
<span style="">The code as shown below: </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
' Sql DataSource
Dim connection As New SqlConnection(connString)
Dim queryString As String = &quot;select * from bookData&quot;
Dim adapter As New SqlDataAdapter()
adapter.SelectCommand = New SqlCommand(queryString, connection)


' Open connection
connection.Open()


' Fill Sql data in DataSet.
Dim sqlData As New DataSet()
adapter.FillSchema(sqlData, SchemaType.Source, &quot;BookData&quot;)
adapter.Fill(sqlData, &quot;BookData&quot;)


' Close connection
connection.Close()

</pre>
<pre id="codePreview" class="vb">
' Sql DataSource
Dim connection As New SqlConnection(connString)
Dim queryString As String = &quot;select * from bookData&quot;
Dim adapter As New SqlDataAdapter()
adapter.SelectCommand = New SqlCommand(queryString, connection)


' Open connection
connection.Open()


' Fill Sql data in DataSet.
Dim sqlData As New DataSet()
adapter.FillSchema(sqlData, SchemaType.Source, &quot;BookData&quot;)
adapter.Fill(sqlData, &quot;BookData&quot;)


' Close connection
connection.Close()

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style=""><span style=""><br>
<span class="GramE">Step 5.</span> <span style="">Get data from xml file and then fill it in
<span class="GramE">dataset<span style=""> .</span></span></span> </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
' Fill xml data in DataSet.
Dim xmlData As New DataSet()
xmlData.ReadXml(filePath)
xmlData.AcceptChanges()

</pre>
<pre id="codePreview" class="vb">
' Fill xml data in DataSet.
Dim xmlData As New DataSet()
xmlData.ReadXml(filePath)
xmlData.AcceptChanges()

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style=""><span style=""><br>
<span class="GramE">Step 6.</span> Declare <span class="SpellE">DataTable</span>, and add the desired status column.</span>
<span style="">The code as shown below: </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
' A column is used to store compare state.
xmlData.Tables(0).Columns.Add(&quot;CompareState&quot;)


' Declare a table to hold Xml data.
Dim dtXml As DataTable = xmlData.Tables(0)


' Declare a table to hold Sql data.
Dim dtSql As DataTable = sqlData.Tables(0)


' The table is used to store Merged data.
Dim dtXmlTemp As DataTable = dtXml.Clone()


' Copy dtXml data to dtXmlTemp.
For Each row As DataRow In dtXml.Rows
    dtXmlTemp.ImportRow(row)
Next

</pre>
<pre id="codePreview" class="vb">
' A column is used to store compare state.
xmlData.Tables(0).Columns.Add(&quot;CompareState&quot;)


' Declare a table to hold Xml data.
Dim dtXml As DataTable = xmlData.Tables(0)


' Declare a table to hold Sql data.
Dim dtSql As DataTable = sqlData.Tables(0)


' The table is used to store Merged data.
Dim dtXmlTemp As DataTable = dtXml.Clone()


' Copy dtXml data to dtXmlTemp.
For Each row As DataRow In dtXml.Rows
    dtXmlTemp.ImportRow(row)
Next

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style=""><span style=""></span></p>
<p class="MsoNormal" style=""><span class="GramE"><span style="">Step 7.</span></span><span style="font-size:10.0pt; line-height:115%; font-family:&quot;Courier New&quot;">
</span><span style="">Compare and merge operations.</span> <span style="">The code as shown below:
</span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
' Loop all rows of the sql table and xml table.
' If the ISBN in the dtXml is equal to the ISBN in dtSql we can merge the two records and 
' set CompareState as &quot;OK&quot;, Otherwise we can add the null value to the records in dtXml. 
For Each dr1 As DataRow In dtXml.Rows
    For Each dr2 As DataRow In dtSql.Rows
        If dr1(0).ToString().Equals(dr2(0).ToString()) Then
            ' Compare the ISBN
            ' Get the index of current row, then update the CompareState in the copy of dtXml(dtXmlTemp).
            Dim intIndex As Integer = dtXml.Rows.IndexOf(dr1)
            ' Set CompareState value
            dtXmlTemp.Rows(intIndex)(5) = &quot;OK&quot;
        Else
            ' Add record to dtXmlTemp and add a &quot;null&quot; flag.
            Dim drNew As DataRow = dtXmlTemp.NewRow()
            drNew(&quot;ISBN&quot;) = dr2(&quot;ISBN&quot;)
            drNew(&quot;CompareState&quot;) = &quot;null&quot;


            ' Add a new row if the table does not has duplicate rows.
            If IsNotExist(drNew, dtXmlTemp) Then
                dtXmlTemp.Rows.Add(drNew)
            End If
        End If
    Next
Next

</pre>
<pre id="codePreview" class="vb">
' Loop all rows of the sql table and xml table.
' If the ISBN in the dtXml is equal to the ISBN in dtSql we can merge the two records and 
' set CompareState as &quot;OK&quot;, Otherwise we can add the null value to the records in dtXml. 
For Each dr1 As DataRow In dtXml.Rows
    For Each dr2 As DataRow In dtSql.Rows
        If dr1(0).ToString().Equals(dr2(0).ToString()) Then
            ' Compare the ISBN
            ' Get the index of current row, then update the CompareState in the copy of dtXml(dtXmlTemp).
            Dim intIndex As Integer = dtXml.Rows.IndexOf(dr1)
            ' Set CompareState value
            dtXmlTemp.Rows(intIndex)(5) = &quot;OK&quot;
        Else
            ' Add record to dtXmlTemp and add a &quot;null&quot; flag.
            Dim drNew As DataRow = dtXmlTemp.NewRow()
            drNew(&quot;ISBN&quot;) = dr2(&quot;ISBN&quot;)
            drNew(&quot;CompareState&quot;) = &quot;null&quot;


            ' Add a new row if the table does not has duplicate rows.
            If IsNotExist(drNew, dtXmlTemp) Then
                dtXmlTemp.Rows.Add(drNew)
            End If
        End If
    Next
Next

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style=""><span style=""></span></p>
<p class="MsoNormal" style=""><span style="">Step 8. Bind data to GridView.</span>
<span style="">The code as shown below: </span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>VB</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">vb</span>
<pre class="hidden">
'Bind datatable to GridView
       gdvData.DataSource = dtXmlTemp
       gdvData.DataBind()

</pre>
<pre id="codePreview" class="vb">
'Bind datatable to GridView
       gdvData.DataSource = dtXmlTemp
       gdvData.DataBind()

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal" style=""><span style=""><br>
Step 9: You can run and debug it.</span></p>
<p class="MsoNormal" style=""><span style=""><a href="http://msdn.microsoft.com/en-us/library/system.data.datatable.importrow.aspx"><span class="SpellE">DataTable.ImportRow</span> Method
</a><span class="MsoHyperlink"></span></span></p>
<p class="MsoNormal" style=""><span style=""><a href="http://msdn.microsoft.com/en-us/library/system.data.datatable.clone.aspx"><span class="SpellE"><span class="GramE">DataTable.Clone</span></span><span class="GramE"><span style="">&nbsp;
</span>Method</span> </a><span style="">&nbsp;</span></span></p>
<p class="MsoNormal" style=""><span style=""><a href="http://msdn.microsoft.com/en-us/library/system.data.dataset.readxml.aspx"><span class="SpellE">DataSet.ReadXml</span> Method
</a><u><span style="color:blue"></span></u></span></p>
<p class="MsoNormal" style=""></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>