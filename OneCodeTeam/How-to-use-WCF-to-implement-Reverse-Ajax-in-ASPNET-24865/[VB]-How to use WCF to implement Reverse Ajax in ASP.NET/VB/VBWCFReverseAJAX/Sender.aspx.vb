﻿'***************************** Module Header ******************************\
'* Module Name:    Sender.aspx.vb
'* Project:        VBWCFReverseAJAX
'* Copyright (c) Microsoft Corporation
'*
'* The user will use this page to send a message to a particular recipient.
'* 
'* This source is subject to the Microsoft Public License.
'* See http://www.microsoft.com/en-us/openness/licenses.aspx#MPL.
'* All other rights reserved.
'* 
'* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
'* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
'* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'\****************************************************************************

Partial Public Class Sender
    Inherits System.Web.UI.Page
    Protected Sub btnSend_Click(sender As Object, e As EventArgs)
        ' Create a message entity to contain all necessary data.
        Dim message As New Message()
        message.RecipientName = tbRecipientName.Text.Trim()
        message.MessageContent = tbMessageContent.Text.Trim()

        If Not String.IsNullOrWhiteSpace(message.RecipientName) AndAlso Not String.IsNullOrEmpty(message.MessageContent) Then
            ' Call the client adapter to send the message to the particular recipient instantly.
            ClientAdapter.Instance.SendMessage(message)

            ' Display a timestamp.
            lbNotification.Text += DateTime.Now.ToLongTimeString() & ": Message sent!<br/>"
        End If
    End Sub
End Class

