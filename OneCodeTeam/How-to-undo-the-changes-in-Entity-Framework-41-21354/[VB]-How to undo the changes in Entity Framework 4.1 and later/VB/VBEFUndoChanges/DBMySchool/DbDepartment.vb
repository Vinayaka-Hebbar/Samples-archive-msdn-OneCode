'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class DbDepartment
    Public Property DepartmentID As Integer
    Public Property Name As String
    Public Property Budget As Decimal
    Public Property StartDate As Date
    Public Property Administrator As Nullable(Of Integer)

    Public Overridable Property Courses As ICollection(Of DbCourse) = New HashSet(Of DbCourse)

End Class
