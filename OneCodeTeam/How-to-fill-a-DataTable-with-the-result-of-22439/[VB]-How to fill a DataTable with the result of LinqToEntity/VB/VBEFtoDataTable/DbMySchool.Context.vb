﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class MySchoolEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=MySchoolEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
	    Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property Courses() As DbSet(Of Course)
    Public Property Departments() As DbSet(Of Department)

End Class
