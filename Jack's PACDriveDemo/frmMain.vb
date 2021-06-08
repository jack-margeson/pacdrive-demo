Imports System.ComponentModel

Public Class frmMain
    Dim pacDrive As PacDrive = New PacDrive(Me)

    Dim devices() As PacDrive = {pacDrive}
    Public toggleButtons() As Button
    Public togglePictures() As PictureBox

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each device As PacDrive In devices
            device.Initialize()
        Next
        If checkConnections() Then
            picConnected.Image = My.Resources.ResourceManager.GetObject("green")
            setDeviceLabels()
        End If

        toggleButtons = {btn1, btn2, btn3, btn4, btn5, btn6}
        togglePictures = {pic1, pic2, pic3, pic4, pic5, pic6}
        For i As Integer = 0 To 5
            RemoveHandler toggleButtons(i).Click, AddressOf toggleLED
            AddHandler toggleButtons(i).Click, AddressOf toggleLED
        Next
    End Sub

    Private Sub toggleLED(ByVal sender As Object, ByVal e As EventArgs)
        Dim LED As Integer = Array.IndexOf(toggleButtons, sender)
        If pacDrive.LEDState(0)(LED) Then
            ' Turn the LED off.
            pacDrive.SetSingleLEDState(0, LED, 0)
            togglePictures(LED).Image = My.Resources.ResourceManager.GetObject("grey")
        Else
            ' Turn the LED on.
            pacDrive.SetSingleLEDState(0, LED, 1)
            togglePictures(LED).Image = My.Resources.ResourceManager.GetObject("green")
        End If
    End Sub

    Function checkConnections()
        Dim result As Boolean = True
        For i As Integer = 0 To devices.Length() - 1
            If Not devices(i).IsPacDrive(i) Then
                result = False
            End If
        Next
        Return result
    End Function

    Private Sub setDeviceLabels()
        lblDeviceType.Text = lblDeviceType.Text + CStr(devices(0).GetDeviceType(0))
        lblVendorID.Text = lblVendorID.Text + CStr(devices(0).GetVendorId(0))
        lblProductID.Text = lblProductID.Text + CStr(devices(0).GetProductId(0))
        lblVersion.Text = lblVersion.Text + CStr(devices(0).GetVersionNumber(0))
        lblVendorName.Text = lblVendorName.Text + devices(0).GetVendorName(0)
        lblProductName.Text = lblProductName.Text + devices(0).GetProductName(0)
        lblSerial.Text = lblSerial.Text + devices(0).GetSerialNumber(0)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pacDrive.SetLEDStateAll(0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        pacDrive.SetLEDStateAll(0)
        Application.Exit()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        pacDrive.SetLEDStateAll(0)
    End Sub
End Class
