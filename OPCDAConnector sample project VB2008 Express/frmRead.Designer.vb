<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRead
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
        Me.GOPCDAConnector1 = New GelecekOPCDAConnector.gOPCDAConnector
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnReadSimplestWay = New System.Windows.Forms.Button
        Me.txtQuality = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtResultID = New System.Windows.Forms.TextBox
        Me.btnReadWithErrorCheck = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFunctionResult = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtItemToBeRead = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtQuality3 = New System.Windows.Forms.TextBox
        Me.txtQuality2 = New System.Windows.Forms.TextBox
        Me.txtQuality1 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtResultID3 = New System.Windows.Forms.TextBox
        Me.txtResultID2 = New System.Windows.Forms.TextBox
        Me.txtResultID1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtValue3 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtValue2 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtValue1 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMultiReadFunctionResult = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnReadMultiWithErrorCheck = New System.Windows.Forms.Button
        Me.btnReadMultiSimplestWay = New System.Windows.Forms.Button
        Me.txtItem3ToBeRead = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtItem2ToBeRead = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtItem1ToBeRead = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GOPCDAConnector1
        '
        Me.GOPCDAConnector1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GOPCDAConnector1.BackColor = System.Drawing.Color.Gainsboro
        Me.GOPCDAConnector1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GOPCDAConnector1.gAutoConnect = True
        Me.GOPCDAConnector1.gLargeView = False
        Me.GOPCDAConnector1.gRemoteComputer = ""
        Me.GOPCDAConnector1.gServerName = "OPCSample.OpcDaServer"
        Me.GOPCDAConnector1.gShowMessages = True
        Me.GOPCDAConnector1.gStepItemCount = 0
        Me.GOPCDAConnector1.gSubscriptionsActive = True
        Me.GOPCDAConnector1.gVisible = True
        Me.GOPCDAConnector1.Location = New System.Drawing.Point(12, 12)
        Me.GOPCDAConnector1.MaximumSize = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.MinimumSize = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.Name = "GOPCDAConnector1"
        Me.GOPCDAConnector1.Size = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.btnReadSimplestWay)
        Me.GroupBox1.Controls.Add(Me.txtQuality)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtResultID)
        Me.GroupBox1.Controls.Add(Me.btnReadWithErrorCheck)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFunctionResult)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtValue)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtItemToBeRead)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 222)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Read One Item"
        '
        'btnReadSimplestWay
        '
        Me.btnReadSimplestWay.Location = New System.Drawing.Point(43, 58)
        Me.btnReadSimplestWay.Name = "btnReadSimplestWay"
        Me.btnReadSimplestWay.Size = New System.Drawing.Size(149, 23)
        Me.btnReadSimplestWay.TabIndex = 12
        Me.btnReadSimplestWay.Text = "btnReadSimplestWay"
        Me.btnReadSimplestWay.UseVisualStyleBackColor = True
        '
        'txtQuality
        '
        Me.txtQuality.Location = New System.Drawing.Point(124, 165)
        Me.txtQuality.Name = "txtQuality"
        Me.txtQuality.Size = New System.Drawing.Size(219, 20)
        Me.txtQuality.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quality:"
        '
        'txtResultID
        '
        Me.txtResultID.Location = New System.Drawing.Point(124, 139)
        Me.txtResultID.Name = "txtResultID"
        Me.txtResultID.Size = New System.Drawing.Size(219, 20)
        Me.txtResultID.TabIndex = 9
        '
        'btnReadWithErrorCheck
        '
        Me.btnReadWithErrorCheck.Location = New System.Drawing.Point(194, 58)
        Me.btnReadWithErrorCheck.Name = "btnReadWithErrorCheck"
        Me.btnReadWithErrorCheck.Size = New System.Drawing.Size(149, 23)
        Me.btnReadWithErrorCheck.TabIndex = 1
        Me.btnReadWithErrorCheck.Text = "btnReadWithErrorCheck"
        Me.btnReadWithErrorCheck.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Result ID:"
        '
        'txtFunctionResult
        '
        Me.txtFunctionResult.Location = New System.Drawing.Point(124, 113)
        Me.txtFunctionResult.Name = "txtFunctionResult"
        Me.txtFunctionResult.Size = New System.Drawing.Size(219, 20)
        Me.txtFunctionResult.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Function result:"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(124, 191)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(219, 20)
        Me.txtValue.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Value:"
        '
        'txtItemToBeRead
        '
        Me.txtItemToBeRead.Location = New System.Drawing.Point(124, 87)
        Me.txtItemToBeRead.Name = "txtItemToBeRead"
        Me.txtItemToBeRead.Size = New System.Drawing.Size(219, 20)
        Me.txtItemToBeRead.TabIndex = 3
        Me.txtItemToBeRead.Text = "Dynamic/Analog Types/Int"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item to be read:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reading a single items value from Sample OPC Server"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtQuality3)
        Me.GroupBox2.Controls.Add(Me.txtQuality2)
        Me.GroupBox2.Controls.Add(Me.txtQuality1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtResultID3)
        Me.GroupBox2.Controls.Add(Me.txtResultID2)
        Me.GroupBox2.Controls.Add(Me.txtResultID1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtValue3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtValue2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtValue1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtMultiReadFunctionResult)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btnReadMultiWithErrorCheck)
        Me.GroupBox2.Controls.Add(Me.btnReadMultiSimplestWay)
        Me.GroupBox2.Controls.Add(Me.txtItem3ToBeRead)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtItem2ToBeRead)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtItem1ToBeRead)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 240)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Read Multi Items"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(372, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "QUALITY"
        '
        'txtQuality3
        '
        Me.txtQuality3.Location = New System.Drawing.Point(366, 201)
        Me.txtQuality3.Name = "txtQuality3"
        Me.txtQuality3.Size = New System.Drawing.Size(127, 20)
        Me.txtQuality3.TabIndex = 30
        '
        'txtQuality2
        '
        Me.txtQuality2.Location = New System.Drawing.Point(366, 181)
        Me.txtQuality2.Name = "txtQuality2"
        Me.txtQuality2.Size = New System.Drawing.Size(127, 20)
        Me.txtQuality2.TabIndex = 29
        '
        'txtQuality1
        '
        Me.txtQuality1.Location = New System.Drawing.Point(366, 164)
        Me.txtQuality1.Name = "txtQuality1"
        Me.txtQuality1.Size = New System.Drawing.Size(127, 20)
        Me.txtQuality1.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(239, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "RESULT ID"
        '
        'txtResultID3
        '
        Me.txtResultID3.Location = New System.Drawing.Point(233, 201)
        Me.txtResultID3.Name = "txtResultID3"
        Me.txtResultID3.Size = New System.Drawing.Size(127, 20)
        Me.txtResultID3.TabIndex = 26
        '
        'txtResultID2
        '
        Me.txtResultID2.Location = New System.Drawing.Point(233, 181)
        Me.txtResultID2.Name = "txtResultID2"
        Me.txtResultID2.Size = New System.Drawing.Size(127, 20)
        Me.txtResultID2.TabIndex = 25
        '
        'txtResultID1
        '
        Me.txtResultID1.Location = New System.Drawing.Point(233, 164)
        Me.txtResultID1.Name = "txtResultID1"
        Me.txtResultID1.Size = New System.Drawing.Size(127, 20)
        Me.txtResultID1.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(108, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "VALUE"
        '
        'txtValue3
        '
        Me.txtValue3.Location = New System.Drawing.Point(102, 201)
        Me.txtValue3.Name = "txtValue3"
        Me.txtValue3.Size = New System.Drawing.Size(127, 20)
        Me.txtValue3.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Item3:"
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(102, 181)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(127, 20)
        Me.txtValue2.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Item2:"
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(102, 164)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(127, 20)
        Me.txtValue1.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 167)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Item1:"
        '
        'txtMultiReadFunctionResult
        '
        Me.txtMultiReadFunctionResult.Location = New System.Drawing.Point(102, 111)
        Me.txtMultiReadFunctionResult.Name = "txtMultiReadFunctionResult"
        Me.txtMultiReadFunctionResult.Size = New System.Drawing.Size(219, 20)
        Me.txtMultiReadFunctionResult.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Function result:"
        '
        'btnReadMultiWithErrorCheck
        '
        Me.btnReadMultiWithErrorCheck.Location = New System.Drawing.Point(181, 82)
        Me.btnReadMultiWithErrorCheck.Name = "btnReadMultiWithErrorCheck"
        Me.btnReadMultiWithErrorCheck.Size = New System.Drawing.Size(162, 23)
        Me.btnReadMultiWithErrorCheck.TabIndex = 14
        Me.btnReadMultiWithErrorCheck.Text = "btnReadMultiWithErrorCheck"
        Me.btnReadMultiWithErrorCheck.UseVisualStyleBackColor = True
        '
        'btnReadMultiSimplestWay
        '
        Me.btnReadMultiSimplestWay.Location = New System.Drawing.Point(16, 82)
        Me.btnReadMultiSimplestWay.Name = "btnReadMultiSimplestWay"
        Me.btnReadMultiSimplestWay.Size = New System.Drawing.Size(160, 23)
        Me.btnReadMultiSimplestWay.TabIndex = 13
        Me.btnReadMultiSimplestWay.Text = "btnReadMultiSimplestWay"
        Me.btnReadMultiSimplestWay.UseVisualStyleBackColor = True
        '
        'txtItem3ToBeRead
        '
        Me.txtItem3ToBeRead.Location = New System.Drawing.Point(102, 56)
        Me.txtItem3ToBeRead.Name = "txtItem3ToBeRead"
        Me.txtItem3ToBeRead.Size = New System.Drawing.Size(181, 20)
        Me.txtItem3ToBeRead.TabIndex = 9
        Me.txtItem3ToBeRead.Text = "Static/Analog Types/Int"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Item3 to be read:"
        '
        'txtItem2ToBeRead
        '
        Me.txtItem2ToBeRead.Location = New System.Drawing.Point(102, 36)
        Me.txtItem2ToBeRead.Name = "txtItem2ToBeRead"
        Me.txtItem2ToBeRead.Size = New System.Drawing.Size(181, 20)
        Me.txtItem2ToBeRead.TabIndex = 7
        Me.txtItem2ToBeRead.Text = "Dynamic/Analog Types/Double"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Item2 to be read:"
        '
        'txtItem1ToBeRead
        '
        Me.txtItem1ToBeRead.Location = New System.Drawing.Point(102, 19)
        Me.txtItem1ToBeRead.Name = "txtItem1ToBeRead"
        Me.txtItem1ToBeRead.Size = New System.Drawing.Size(181, 20)
        Me.txtItem1ToBeRead.TabIndex = 5
        Me.txtItem1ToBeRead.Text = "Dynamic/Analog Types/Int"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Item1 to be read:"
        '
        'Label17
        '
        Me.Label17.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label17.Location = New System.Drawing.Point(52, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 60)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "click on this icon to open and close Large Interface in runtime"
        '
        'frmRead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 579)
        Me.Controls.Add(Me.GOPCDAConnector1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Name = "frmRead"
        Me.Text = "frmRead"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GOPCDAConnector1 As GelecekOPCDAConnector.gOPCDAConnector
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemToBeRead As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReadWithErrorCheck As System.Windows.Forms.Button
    Friend WithEvents txtFunctionResult As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQuality As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtResultID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnReadSimplestWay As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtItem3ToBeRead As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtItem2ToBeRead As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItem1ToBeRead As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMultiReadFunctionResult As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnReadMultiWithErrorCheck As System.Windows.Forms.Button
    Friend WithEvents btnReadMultiSimplestWay As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtResultID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResultID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResultID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtValue3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtValue2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtValue1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtQuality3 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuality2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuality1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
