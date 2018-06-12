﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18010
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace ServiceReference1
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Leave", [Namespace]:="http://schemas.datacontract.org/2004/07/DBOperate"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Leave
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CommentField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private LeaveDayField As System.Nullable(Of Integer)
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private LeaveIDField As System.Guid
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private LeaveNameField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private StatusField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Comment() As String
            Get
                Return Me.CommentField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CommentField, value) <> true) Then
                    Me.CommentField = value
                    Me.RaisePropertyChanged("Comment")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property LeaveDay() As System.Nullable(Of Integer)
            Get
                Return Me.LeaveDayField
            End Get
            Set
                If (Me.LeaveDayField.Equals(value) <> true) Then
                    Me.LeaveDayField = value
                    Me.RaisePropertyChanged("LeaveDay")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property LeaveID() As System.Guid
            Get
                Return Me.LeaveIDField
            End Get
            Set
                If (Me.LeaveIDField.Equals(value) <> true) Then
                    Me.LeaveIDField = value
                    Me.RaisePropertyChanged("LeaveID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property LeaveName() As String
            Get
                Return Me.LeaveNameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.LeaveNameField, value) <> true) Then
                    Me.LeaveNameField = value
                    Me.RaisePropertyChanged("LeaveName")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Status() As String
            Get
                Return Me.StatusField
            End Get
            Set
                If (Object.ReferenceEquals(Me.StatusField, value) <> true) Then
                    Me.StatusField = value
                    Me.RaisePropertyChanged("Status")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.ILeaveService")>  _
    Public Interface ILeaveService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILeaveService/GetLeaveList", ReplyAction:="http://tempuri.org/ILeaveService/GetLeaveListResponse")>  _
        Function GetLeaveList() As ServiceReference1.Leave()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILeaveService/CreateLeave", ReplyAction:="http://tempuri.org/ILeaveService/CreateLeaveResponse")>  _
        Sub CreateLeave(ByVal name As String, ByVal day As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ILeaveService/AuditingLeave", ReplyAction:="http://tempuri.org/ILeaveService/AuditingLeaveResponse")>  _
        Sub AuditingLeave(ByVal id As String, ByVal comment As String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ILeaveServiceChannel
        Inherits ServiceReference1.ILeaveService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class LeaveServiceClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.ILeaveService)
        Implements ServiceReference1.ILeaveService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GetLeaveList() As ServiceReference1.Leave() Implements ServiceReference1.ILeaveService.GetLeaveList
            Return MyBase.Channel.GetLeaveList
        End Function
        
        Public Sub CreateLeave(ByVal name As String, ByVal day As String) Implements ServiceReference1.ILeaveService.CreateLeave
            MyBase.Channel.CreateLeave(name, day)
        End Sub
        
        Public Sub AuditingLeave(ByVal id As String, ByVal comment As String) Implements ServiceReference1.ILeaveService.AuditingLeave
            MyBase.Channel.AuditingLeave(id, comment)
        End Sub
    End Class
End Namespace
