﻿'************************** Module Header ******************************'
' Module Name:  MSNdis_EnumerateAdapterEx.vb
' Project:      VBMACAddress
' Copyright (c) Microsoft Corporation.
' 
' This class represents the MSNdis_EnumerateAdapterEx WMI class. It represents
' an adapter in the computer, and the EnumerateAdapter property contains the 
' more information of the adapter. 
' 
' 
' You can download WMI Administrative Tools to get the detailed information of 
' this class.
' http://www.microsoft.com/download/en/details.aspx?id=24045
' 
' 
' The NDIS WMI classes are available in Windows Vista / Windows Server 2008 
' or later version. You can run following PowerShell script to discover
' other interesting WMI classes.
' 
' Get-WmiObject -Namespace root\wmi -List  | Where-Object {$_.name -Match "MSNdis" } | Sort-Object
' 
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
' All other rights reserved.
' 
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'*************************************************************************'

Imports VBMACAddress.WMIHelper

Namespace NDIS
    <WMIClass(ClassName:="MSNdis_EnumerateAdapterEx")>
    Public Class MSNdis_EnumerateAdapterEx

        Private privateActive? As Boolean
        <WMIProperty(PropertyName:="Active", PropertyType:=WMIPropertyType.Bool)>
        Public Property Active() As Boolean?
            Get
                Return privateActive
            End Get
            Private Set(ByVal value? As Boolean)
                privateActive = value
            End Set
        End Property

        Private privateEnumerateAdapter As MSNdis_WmiEnumAdapter
        <WMIProperty(PropertyName:="EnumerateAdapter", PropertyType:=WMIPropertyType.WMIObject, AssociatedWMIClass:=GetType(MSNdis_WmiEnumAdapter))>
        Public Property EnumerateAdapter() As MSNdis_WmiEnumAdapter
            Get
                Return privateEnumerateAdapter
            End Get
            Private Set(ByVal value As MSNdis_WmiEnumAdapter)
                privateEnumerateAdapter = value
            End Set
        End Property

        Private privateInstanceName As String
        <WMIProperty(PropertyName:="InstanceName", PropertyType:=WMIPropertyType.StringValue)>
        Public Property InstanceName() As String
            Get
                Return privateInstanceName
            End Get
            Private Set(ByVal value As String)
                privateInstanceName = value
            End Set
        End Property
    End Class
End Namespace