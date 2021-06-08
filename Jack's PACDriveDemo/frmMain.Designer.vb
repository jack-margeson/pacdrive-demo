<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picConnected = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDeviceType = New System.Windows.Forms.Label()
        Me.lblVendorID = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblVendorName = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblSerial = New System.Windows.Forms.Label()
        CType(Me.picConnected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picConnected
        '
        Me.picConnected.BackColor = System.Drawing.SystemColors.Control
        Me.picConnected.BackgroundImage = CType(resources.GetObject("picConnected.BackgroundImage"), System.Drawing.Image)
        Me.picConnected.Location = New System.Drawing.Point(21, 29)
        Me.picConnected.Name = "picConnected"
        Me.picConnected.Size = New System.Drawing.Size(50, 50)
        Me.picConnected.TabIndex = 0
        Me.picConnected.TabStop = False
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.SystemColors.Control
        Me.pic1.BackgroundImage = CType(resources.GetObject("pic1.BackgroundImage"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(21, 166)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(50, 50)
        Me.pic1.TabIndex = 1
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.BackColor = System.Drawing.SystemColors.Control
        Me.pic2.BackgroundImage = CType(resources.GetObject("pic2.BackgroundImage"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(103, 166)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(50, 50)
        Me.pic2.TabIndex = 2
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.BackColor = System.Drawing.SystemColors.Control
        Me.pic3.BackgroundImage = CType(resources.GetObject("pic3.BackgroundImage"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(184, 166)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(50, 50)
        Me.pic3.TabIndex = 3
        Me.pic3.TabStop = False
        '
        'pic4
        '
        Me.pic4.BackColor = System.Drawing.SystemColors.Control
        Me.pic4.BackgroundImage = CType(resources.GetObject("pic4.BackgroundImage"), System.Drawing.Image)
        Me.pic4.Location = New System.Drawing.Point(264, 166)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(50, 50)
        Me.pic4.TabIndex = 4
        Me.pic4.TabStop = False
        '
        'pic5
        '
        Me.pic5.BackColor = System.Drawing.SystemColors.Control
        Me.pic5.BackgroundImage = CType(resources.GetObject("pic5.BackgroundImage"), System.Drawing.Image)
        Me.pic5.Location = New System.Drawing.Point(342, 166)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(50, 50)
        Me.pic5.TabIndex = 5
        Me.pic5.TabStop = False
        '
        'pic6
        '
        Me.pic6.BackColor = System.Drawing.SystemColors.Control
        Me.pic6.BackgroundImage = CType(resources.GetObject("pic6.BackgroundImage"), System.Drawing.Image)
        Me.pic6.Location = New System.Drawing.Point(426, 166)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(50, 50)
        Me.pic6.TabIndex = 6
        Me.pic6.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(10, 11)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(156, 15)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "PACDrive Connection Status"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(10, 137)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 8
        Me.btn1.Text = "Toggle #1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(91, 137)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 9
        Me.btn2.Text = "Toggle #2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(172, 137)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 10
        Me.btn3.Text = "Toggle #3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(253, 137)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 23)
        Me.btn4.TabIndex = 11
        Me.btn4.Text = "Toggle #4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(333, 137)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 23)
        Me.btn5.TabIndex = 12
        Me.btn5.Text = "Toggle #5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(414, 137)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 23)
        Me.btn6.TabIndex = 13
        Me.btn6.Text = "Toggle #6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(333, 9)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(414, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDeviceType
        '
        Me.lblDeviceType.AutoSize = True
        Me.lblDeviceType.Location = New System.Drawing.Point(181, 52)
        Me.lblDeviceType.Name = "lblDeviceType"
        Me.lblDeviceType.Size = New System.Drawing.Size(75, 15)
        Me.lblDeviceType.TabIndex = 16
        Me.lblDeviceType.Text = "Device Type: "
        '
        'lblVendorID
        '
        Me.lblVendorID.AutoSize = True
        Me.lblVendorID.Location = New System.Drawing.Point(181, 76)
        Me.lblVendorID.Name = "lblVendorID"
        Me.lblVendorID.Size = New System.Drawing.Size(61, 15)
        Me.lblVendorID.TabIndex = 17
        Me.lblVendorID.Text = "Vendor ID:"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(181, 100)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(66, 15)
        Me.lblProductID.TabIndex = 18
        Me.lblProductID.Text = "Product ID:"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(318, 52)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(51, 15)
        Me.lblVersion.TabIndex = 19
        Me.lblVersion.Text = "Version: "
        '
        'lblVendorName
        '
        Me.lblVendorName.AutoSize = True
        Me.lblVendorName.Location = New System.Drawing.Point(318, 76)
        Me.lblVendorName.Name = "lblVendorName"
        Me.lblVendorName.Size = New System.Drawing.Size(82, 15)
        Me.lblVendorName.TabIndex = 20
        Me.lblVendorName.Text = "Vendor Name:"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(318, 100)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(90, 15)
        Me.lblProductName.TabIndex = 21
        Me.lblProductName.Text = "Product Name: "
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.Location = New System.Drawing.Point(10, 86)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(41, 15)
        Me.lblSerial.TabIndex = 22
        Me.lblSerial.Text = "Serial: "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 225)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblVendorName)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.lblVendorID)
        Me.Controls.Add(Me.lblDeviceType)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pic6)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.picConnected)
        Me.Name = "frmMain"
        Me.Text = "Jack's PACDrive Demo (VB.NET)"
        CType(Me.picConnected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picConnected As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDeviceType As Label
    Friend WithEvents lblVendorID As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblVendorName As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblSerial As Label
End Class
