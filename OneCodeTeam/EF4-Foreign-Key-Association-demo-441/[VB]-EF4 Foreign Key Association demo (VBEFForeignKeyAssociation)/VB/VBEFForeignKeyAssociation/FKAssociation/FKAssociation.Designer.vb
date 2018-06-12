﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

Imports VBEFForeignKeyAssociation.VBEFForeignKeyAssociation.FKAssociation

<Assembly: EdmSchemaAttribute("cd5b97b9-c2fc-4622-9b31-e9d7c464fc46")> 

#Region "EDM Relationship Metadata"
<Assembly: EdmRelationshipAttribute("FKAssociationModel", "FK_Course_Department", "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(Department), "Course", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(Course), True)> 

#End Region
Namespace VBEFForeignKeyAssociation.FKAssociation
#Region "Contexts"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Partial Public Class FKAssociationEntities
        Inherits ObjectContext

#Region "Constructors"

        ''' <summary>
        ''' Initializes a new FKAssociationEntities object using the connection string found in the 'FKAssociationEntities' section of the application configuration file.
        ''' </summary>
        Public Sub New()
            MyBase.New("name=FKAssociationEntities", "FKAssociationEntities")
            MyBase.ContextOptions.LazyLoadingEnabled = True
            OnContextCreated()
        End Sub

        ''' <summary>
        ''' Initialize a new FKAssociationEntities object.
        ''' </summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "FKAssociationEntities")
            MyBase.ContextOptions.LazyLoadingEnabled = True
            OnContextCreated()
        End Sub

        ''' <summary>
        ''' Initialize a new FKAssociationEntities object.
        ''' </summary>
        Public Sub New(ByVal connection As EntityConnection)
            MyBase.New(connection, "FKAssociationEntities")
            MyBase.ContextOptions.LazyLoadingEnabled = True
            OnContextCreated()
        End Sub

#End Region

#Region "Partial Methods"

        Partial Private Sub OnContextCreated()
        End Sub

#End Region

#Region "ObjectSet Properties"

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property Courses() As ObjectSet(Of Course)
            Get
                If (_Courses Is Nothing) Then
                    _Courses = MyBase.CreateObjectSet(Of Course)("Courses")
                End If
                Return _Courses
            End Get
        End Property

        Private _Courses As ObjectSet(Of Course)

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property Departments() As ObjectSet(Of Department)
            Get
                If (_Departments Is Nothing) Then
                    _Departments = MyBase.CreateObjectSet(Of Department)("Departments")
                End If
                Return _Departments
            End Get
        End Property

        Private _Departments As ObjectSet(Of Department)

#End Region
#Region "AddTo Methods"

        ''' <summary>
        ''' Deprecated Method for adding a new object to the Courses EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToCourses(ByVal course As Course)
            MyBase.AddObject("Courses", course)
        End Sub

        ''' <summary>
        ''' Deprecated Method for adding a new object to the Departments EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToDepartments(ByVal department As Department)
            MyBase.AddObject("Departments", department)
        End Sub

#End Region
    End Class

#End Region
#Region "Entities"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="FKAssociationModel", Name:="Course")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Partial Public Class Course
        Inherits EntityObject
#Region "Factory Method"

        ''' <summary>
        ''' Create a new Course object.
        ''' </summary>
        ''' <param name="courseID">Initial value of the CourseID property.</param>
        Public Shared Function CreateCourse(ByVal courseID As Global.System.Int32) As Course
            Dim course As Course = New Course
            course.CourseID = courseID
            Return course
        End Function

#End Region
#Region "Primitive Properties"

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False)>
        <DataMemberAttribute()>
        Public Property CourseID() As Global.System.Int32
            Get
                Return _CourseID
            End Get
            Set(ByVal value As Global.System.Int32)
                If (_CourseID <> value) Then
                    OnCourseIDChanging(value)
                    ReportPropertyChanging("CourseID")
                    _CourseID = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("CourseID")
                    OnCourseIDChanged()
                End If
            End Set
        End Property

        Private _CourseID As Global.System.Int32
        Partial Private Sub OnCourseIDChanging(ByVal value As Global.System.Int32)
        End Sub

        Partial Private Sub OnCourseIDChanged()
        End Sub

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True)>
        <DataMemberAttribute()>
        Public Property Title() As Global.System.String
            Get
                Return _Title
            End Get
            Set(ByVal value As Global.System.String)
                OnTitleChanging(value)
                ReportPropertyChanging("Title")
                _Title = StructuralObject.SetValidValue(value, True)
                ReportPropertyChanged("Title")
                OnTitleChanged()
            End Set
        End Property

        Private _Title As Global.System.String
        Partial Private Sub OnTitleChanging(ByVal value As Global.System.String)
        End Sub

        Partial Private Sub OnTitleChanged()
        End Sub

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True)>
        <DataMemberAttribute()>
        Public Property Credits() As Nullable(Of Global.System.Int32)
            Get
                Return _Credits
            End Get
            Set(ByVal value As Nullable(Of Global.System.Int32))
                OnCreditsChanging(value)
                ReportPropertyChanging("Credits")
                _Credits = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("Credits")
                OnCreditsChanged()
            End Set
        End Property

        Private _Credits As Nullable(Of Global.System.Int32)
        Partial Private Sub OnCreditsChanging(ByVal value As Nullable(Of Global.System.Int32))
        End Sub

        Partial Private Sub OnCreditsChanged()
        End Sub

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True)>
        <DataMemberAttribute()>
        Public Property DepartmentID() As Nullable(Of Global.System.Int32)
            Get
                Return _DepartmentID
            End Get
            Set(ByVal value As Nullable(Of Global.System.Int32))
                OnDepartmentIDChanging(value)
                ReportPropertyChanging("DepartmentID")
                _DepartmentID = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("DepartmentID")
                OnDepartmentIDChanged()
            End Set
        End Property

        Private _DepartmentID As Nullable(Of Global.System.Int32)
        Partial Private Sub OnDepartmentIDChanging(ByVal value As Nullable(Of Global.System.Int32))
        End Sub

        Partial Private Sub OnDepartmentIDChanged()
        End Sub

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True)>
        <DataMemberAttribute()>
        Public Property StatusID() As Nullable(Of Global.System.Boolean)
            Get
                Return _StatusID
            End Get
            Set(ByVal value As Nullable(Of Global.System.Boolean))
                OnStatusIDChanging(value)
                ReportPropertyChanging("StatusID")
                _StatusID = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("StatusID")
                OnStatusIDChanged()
            End Set
        End Property

        Private _StatusID As Nullable(Of Global.System.Boolean)
        Partial Private Sub OnStatusIDChanging(ByVal value As Nullable(Of Global.System.Boolean))
        End Sub

        Partial Private Sub OnStatusIDChanged()
        End Sub

#End Region
#Region "Navigation Properties"

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <XmlIgnoreAttribute()>
        <SoapIgnoreAttribute()>
        <DataMemberAttribute()>
        <EdmRelationshipNavigationPropertyAttribute("FKAssociationModel", "FK_Course_Department", "Department")>
        Public Property Department() As Department
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Department)("FKAssociationModel.FK_Course_Department", "Department").Value
            End Get
            Set(ByVal value As Department)
                CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Department)("FKAssociationModel.FK_Course_Department", "Department").Value = value
            End Set
        End Property
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <BrowsableAttribute(False)>
        <DataMemberAttribute()>
        Public Property DepartmentReference() As EntityReference(Of Department)
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Department)("FKAssociationModel.FK_Course_Department", "Department")
            End Get
            Set(ByVal value As EntityReference(Of Department))
                If (Not value Is Nothing) Then
                    CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Department)("FKAssociationModel.FK_Course_Department", "Department", value)
                End If
            End Set
        End Property

#End Region
    End Class

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="FKAssociationModel", Name:="Department")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Partial Public Class Department
        Inherits EntityObject
#Region "Factory Method"

        ''' <summary>
        ''' Create a new Department object.
        ''' </summary>
        ''' <param name="departmentID">Initial value of the DepartmentID property.</param>
        Public Shared Function CreateDepartment(ByVal departmentID As Global.System.Int32) As Department
            Dim department As Department = New Department
            department.DepartmentID = departmentID
            Return department
        End Function

#End Region
#Region "Primitive Properties"

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False)>
        <DataMemberAttribute()>
        Public Property DepartmentID() As Global.System.Int32
            Get
                Return _DepartmentID
            End Get
            Set(ByVal value As Global.System.Int32)
                If (_DepartmentID <> value) Then
                    OnDepartmentIDChanging(value)
                    ReportPropertyChanging("DepartmentID")
                    _DepartmentID = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("DepartmentID")
                    OnDepartmentIDChanged()
                End If
            End Set
        End Property

        Private _DepartmentID As Global.System.Int32
        Partial Private Sub OnDepartmentIDChanging(ByVal value As Global.System.Int32)
        End Sub

        Partial Private Sub OnDepartmentIDChanged()
        End Sub

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True)>
        <DataMemberAttribute()>
        Public Property Name() As Global.System.String
            Get
                Return _Name
            End Get
            Set(ByVal value As Global.System.String)
                OnNameChanging(value)
                ReportPropertyChanging("Name")
                _Name = StructuralObject.SetValidValue(value, True)
                ReportPropertyChanged("Name")
                OnNameChanged()
            End Set
        End Property

        Private _Name As Global.System.String
        Partial Private Sub OnNameChanging(ByVal value As Global.System.String)
        End Sub

        Partial Private Sub OnNameChanged()
        End Sub

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True)>
        <DataMemberAttribute()>
        Public Property Budget() As Nullable(Of Global.System.Decimal)
            Get
                Return _Budget
            End Get
            Set(ByVal value As Nullable(Of Global.System.Decimal))
                OnBudgetChanging(value)
                ReportPropertyChanging("Budget")
                _Budget = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("Budget")
                OnBudgetChanged()
            End Set
        End Property

        Private _Budget As Nullable(Of Global.System.Decimal)
        Partial Private Sub OnBudgetChanging(ByVal value As Nullable(Of Global.System.Decimal))
        End Sub

        Partial Private Sub OnBudgetChanged()
        End Sub

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True)>
        <DataMemberAttribute()>
        Public Property StartDate() As Nullable(Of Global.System.DateTime)
            Get
                Return _StartDate
            End Get
            Set(ByVal value As Nullable(Of Global.System.DateTime))
                OnStartDateChanging(value)
                ReportPropertyChanging("StartDate")
                _StartDate = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("StartDate")
                OnStartDateChanged()
            End Set
        End Property

        Private _StartDate As Nullable(Of Global.System.DateTime)
        Partial Private Sub OnStartDateChanging(ByVal value As Nullable(Of Global.System.DateTime))
        End Sub

        Partial Private Sub OnStartDateChanged()
        End Sub

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True)>
        <DataMemberAttribute()>
        Public Property Administrator() As Nullable(Of Global.System.Int32)
            Get
                Return _Administrator
            End Get
            Set(ByVal value As Nullable(Of Global.System.Int32))
                OnAdministratorChanging(value)
                ReportPropertyChanging("Administrator")
                _Administrator = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("Administrator")
                OnAdministratorChanged()
            End Set
        End Property

        Private _Administrator As Nullable(Of Global.System.Int32)
        Partial Private Sub OnAdministratorChanging(ByVal value As Nullable(Of Global.System.Int32))
        End Sub

        Partial Private Sub OnAdministratorChanged()
        End Sub

#End Region
#Region "Navigation Properties"

        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <XmlIgnoreAttribute()>
        <SoapIgnoreAttribute()>
        <DataMemberAttribute()>
        <EdmRelationshipNavigationPropertyAttribute("FKAssociationModel", "FK_Course_Department", "Course")>
        Public Property Courses() As EntityCollection(Of Course)
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of Course)("FKAssociationModel.FK_Course_Department", "Course")
            End Get
            Set(ByVal value As EntityCollection(Of Course))
                If (Not value Is Nothing) Then
                    CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Course)("FKAssociationModel.FK_Course_Department", "Course", value)
                End If
            End Set
        End Property

#End Region
    End Class

#End Region
End Namespace

