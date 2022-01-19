Imports System.Collections.Generic

Imports BandwidthSMSAPIConnectorLibrary40.BandWidth.Net.API

Imports BandwidthSMSAPIConnectorLibrary40

Public Class InBox
    Inherits List(Of Message)

    Public ReadOnly Property HasMessages() As Boolean
        Get
            Return Me.Any()
        End Get
    End Property

    Public ReadOnly Property IsEmpty() As Boolean
        Get
            Return Not Me.Any()
        End Get
    End Property

    Public Overloads ReadOnly Property Count() As Short
        Get
            Return MyBase.Count()
        End Get
    End Property

#Region "Methods"

    Public Function Message(ByVal Index As Short) As Message

        Dim msg As Message = Nothing

        If Index < Me.Count() Then
            msg = Me(Index)
        End If

        Return msg
    End Function

    Public Function Clear() As Boolean

        MyBase.Clear()

        Return True
    End Function

    Public Sub Refresh(ByVal fromNumber As String)

        Dim fromDateTimeUTC As DateTime? = Nothing
        Dim lastMessage As Message = Me.LastOrDefault()

        Dim lstMessages As New List(Of Bandwidth.Net.Api.Message)

        If Not IsNothing(lastMessage) Then

            fromDateTimeUTC = lastMessage.TimeStampUTC ' the last utc time stamp.

            Dim getAllMessagesInTask = APIHelper.GetAllMessagesByToNumberDirectionNToDtm(
                fromNumber, MessageDirection.In, fromDateTimeUTC, Nothing).ConfigureAwait(False).GetAwaiter()
            'Dim getAllMessagesOutTask = APIHelper.GetAllMessagesByFromNumberDirectionNToDtm(
            '    fromNumber, MessageDirection.Out, lastDtmUTC).ConfigureAwait(False).GetAwaiter()

            Dim getAllMessagesInResults = getAllMessagesInTask.GetResult()
            If Not IsNothing(getAllMessagesInResults) Then
                lstMessages.AddRange(getAllMessagesInResults)
            End If

            'Dim getAllMessagesOutResults = getAllMessagesOutTask.GetResult()
            'If Not IsNothing(getAllMessagesOutResults) Then
            '    lstMessages.AddRange(getAllMessagesOutResults)
            'End If
        Else

            fromDateTimeUTC = DateTime.UtcNow.AddDays(-1) '' 24 hrs ago

            Dim getAllMessagesInTask = APIHelper.GetAllMessagesByToNumberDirectionNToDtm(
                fromNumber, MessageDirection.In, fromDateTimeUTC, Nothing).ConfigureAwait(False).GetAwaiter()
            'Dim getAllMessagesOutTask = APIHelper.GetAllMessagesByFromNumberDirectionNToDtm(
            '    fromNumber, MessageDirection.Out, Nothing).ConfigureAwait(False).GetAwaiter()

            Dim getAllMessagesInResults = getAllMessagesInTask.GetResult()
            If Not IsNothing(getAllMessagesInResults) Then
                lstMessages.AddRange(getAllMessagesInResults)
            End If

            'Dim getAllMessagesOutResults = getAllMessagesOutTask.GetResult()
            'If Not IsNothing(getAllMessagesOutResults) Then
            '    lstMessages.AddRange(getAllMessagesOutResults)
            'End If

            'Dim getAllMessagesTask = APIHelper.GetAllMessagesByFromNumber(
            '    fromNumber).ConfigureAwait(False).GetAwaiter()

            'lstMessages.AddRange(getAllMessagesTask.GetResult())
        End If

            If lstMessages.Any() Then

            Dim messageIndex = Me.Count - 1

            If (messageIndex = 0) Then messageIndex = -1

            Dim maxIndex00 = lstMessages.Count - 1
            For index00 = 0 To maxIndex00

                Dim objBandWidthMessage = lstMessages(index00)

                messageIndex += 1

                Dim objInboxMessage As New Message() With
                    {
                    .MessageId = objBandWidthMessage.Id,
                    .Sender = objBandWidthMessage.From,
                    .Phone = objBandWidthMessage.To,
                    .Message = objBandWidthMessage.Text,
                    .Text = objBandWidthMessage.Text,
                    .Status = objBandWidthMessage.State.ToString(),
                    .TimeStamp = objBandWidthMessage.Time,
                    .TimeStampUTC = objBandWidthMessage.Time,
                    .Index = messageIndex
                    }

                If IsNothing(Me.FirstOrDefault(Function(o) o.MessageId = objInboxMessage.MessageId)) Then
                    Me.Add(objInboxMessage)
                End If
            Next
        End If
    End Sub

#End Region

End Class
