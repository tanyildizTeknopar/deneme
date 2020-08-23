<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsynchronousWrite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsynchronousWrite))
        Me.GOPCDAConnector1 = New GelecekOPCDAConnector.gOPCDAConnector
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnWriteSimplestWay = New System.Windows.Forms.Button
        Me.txtResultID = New System.Windows.Forms.TextBox
        Me.btnWriteWithErrorCheck = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFunctionResult = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtItemToBeWritten = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCancelResult = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnCancelAsyncWrite = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtResultID3 = New System.Windows.Forms.TextBox
        Me.txtResultID2 = New System.Windows.Forms.TextBox
        Me.txtResultID1 = New System.Windows.Forms.TextBox
        Me.txtValue3 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtValue2 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtValue1 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMultiWriteFunctionResult = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnWriteMultiWithErrorCheck = New System.Windows.Forms.Button
        Me.btnWriteMultiSimplestWay = New System.Windows.Forms.Button
        Me.txtItem3ToBeRead = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtItem2ToBeRead = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtItem1ToBeRead = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
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
        Me.GOPCDAConnector1.Location = New System.Drawing.Point(7, 6)
        Me.GOPCDAConnector1.MaximumSize = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.MinimumSize = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.Name = "GOPCDAConnector1"
        Me.GOPCDAConnector1.Size = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "ASYNCHRONOUS WRITE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(580, 122)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(4, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 60)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "click on this icon to open and close Large Interface in runtime"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.btnWriteSimplestWay)
        Me.GroupBox1.Controls.Add(Me.txtResultID)
        Me.GroupBox1.Controls.Add(Me.btnWriteWithErrorCheck)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFunctionResult)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtValue)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtItemToBeWritten)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 250)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Write One Item"
        '
        'btnWriteSimplestWay
        '
        Me.btnWriteSimplestWay.Location = New System.Drawing.Point(43, 58)
        Me.btnWriteSimplestWay.Name = "btnWriteSimplestWay"
        Me.btnWriteSimplestWay.Size = New System.Drawing.Size(149, 23)
        Me.btnWriteSimplestWay.TabIndex = 12
        Me.btnWriteSimplestWay.Text = "btnWriteSimplestWay"
        Me.btnWriteSimplestWay.UseVisualStyleBackColor = True
        '
        'txtResultID
        '
        Me.txtResultID.Location = New System.Drawing.Point(137, 139)
        Me.txtResultID.Name = "txtResultID"
        Me.txtResultID.Size = New System.Drawing.Size(206, 20)
        Me.txtResultID.TabIndex = 9
        '
        'btnWriteWithErrorCheck
        '
        Me.btnWriteWithErrorCheck.Location = New System.Drawing.Point(194, 58)
        Me.btnWriteWithErrorCheck.Name = "btnWriteWithErrorCheck"
        Me.btnWriteWithErrorCheck.Size = New System.Drawing.Size(149, 23)
        Me.btnWriteWithErrorCheck.TabIndex = 1
        Me.btnWriteWithErrorCheck.Text = "btnWriteWithErrorCheck"
        Me.btnWriteWithErrorCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Result ID:"
        '
        'txtFunctionResult
        '
        Me.txtFunctionResult.Location = New System.Drawing.Point(137, 113)
        Me.txtFunctionResult.Name = "txtFunctionResult"
        Me.txtFunctionResult.Size = New System.Drawing.Size(206, 20)
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
        Me.txtValue.Location = New System.Drawing.Point(137, 191)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(206, 20)
        Me.txtValue.TabIndex = 5
        Me.txtValue.Text = "12"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Value to write:"
        '
        'txtItemToBeWritten
        '
        Me.txtItemToBeWritten.Location = New System.Drawing.Point(137, 87)
        Me.txtItemToBeWritten.Name = "txtItemToBeWritten"
        Me.txtItemToBeWritten.Size = New System.Drawing.Size(206, 20)
        Me.txtItemToBeWritten.TabIndex = 3
        Me.txtItemToBeWritten.Text = "Static/Analog Types/Double"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Item to be written:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Writing a value to a single item"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox2.Controls.Add(Me.txtCancelResult)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.btnCancelAsyncWrite)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtResultID3)
        Me.GroupBox2.Controls.Add(Me.txtResultID2)
        Me.GroupBox2.Controls.Add(Me.txtResultID1)
        Me.GroupBox2.Controls.Add(Me.txtValue3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtValue2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtValue1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtMultiWriteFunctionResult)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btnWriteMultiWithErrorCheck)
        Me.GroupBox2.Controls.Add(Me.btnWriteMultiSimplestWay)
        Me.GroupBox2.Controls.Add(Me.txtItem3ToBeRead)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtItem2ToBeRead)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtItem1ToBeRead)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(386, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 250)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Write Multi Items"
        '
        'txtCancelResult
        '
        Me.txtCancelResult.Location = New System.Drawing.Point(349, 111)
        Me.txtCancelResult.Name = "txtCancelResult"
        Me.txtCancelResult.Size = New System.Drawing.Size(134, 20)
        Me.txtCancelResult.TabIndex = 39
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(276, 116)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Cancel result:"
        '
        'btnCancelAsyncWrite
        '
        Me.btnCancelAsyncWrite.Location = New System.Drawing.Point(349, 82)
        Me.btnCancelAsyncWrite.Name = "btnCancelAsyncWrite"
        Me.btnCancelAsyncWrite.Size = New System.Drawing.Size(134, 23)
        Me.btnCancelAsyncWrite.TabIndex = 37
        Me.btnCancelAsyncWrite.Text = "btnCancelAsyncWrite"
        Me.btnCancelAsyncWrite.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(270, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Value3"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(270, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Value2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(270, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Value1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(71, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "RESULT ID"
        '
        'txtResultID3
        '
        Me.txtResultID3.Location = New System.Drawing.Point(65, 217)
        Me.txtResultID3.Name = "txtResultID3"
        Me.txtResultID3.Size = New System.Drawing.Size(127, 20)
        Me.txtResultID3.TabIndex = 26
        '
        'txtResultID2
        '
        Me.txtResultID2.Location = New System.Drawing.Point(65, 197)
        Me.txtResultID2.Name = "txtResultID2"
        Me.txtResultID2.Size = New System.Drawing.Size(127, 20)
        Me.txtResultID2.TabIndex = 25
        '
        'txtResultID1
        '
        Me.txtResultID1.Location = New System.Drawing.Point(65, 180)
        Me.txtResultID1.Name = "txtResultID1"
        Me.txtResultID1.Size = New System.Drawing.Size(127, 20)
        Me.txtResultID1.TabIndex = 24
        '
        'txtValue3
        '
        Me.txtValue3.Location = New System.Drawing.Point(316, 56)
        Me.txtValue3.Name = "txtValue3"
        Me.txtValue3.Size = New System.Drawing.Size(68, 20)
        Me.txtValue3.TabIndex = 22
        Me.txtValue3.Text = "78"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Item3:"
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(316, 36)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(68, 20)
        Me.txtValue2.TabIndex = 20
        Me.txtValue2.Text = "34,45"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Item2:"
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(316, 19)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(68, 20)
        Me.txtValue1.TabIndex = 18
        Me.txtValue1.Text = "12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Item1:"
        '
        'txtMultiWriteFunctionResult
        '
        Me.txtMultiWriteFunctionResult.Location = New System.Drawing.Point(102, 111)
        Me.txtMultiWriteFunctionResult.Name = "txtMultiWriteFunctionResult"
        Me.txtMultiWriteFunctionResult.Size = New System.Drawing.Size(151, 20)
        Me.txtMultiWriteFunctionResult.TabIndex = 16
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
        'btnWriteMultiWithErrorCheck
        '
        Me.btnWriteMultiWithErrorCheck.Location = New System.Drawing.Point(181, 82)
        Me.btnWriteMultiWithErrorCheck.Name = "btnWriteMultiWithErrorCheck"
        Me.btnWriteMultiWithErrorCheck.Size = New System.Drawing.Size(162, 23)
        Me.btnWriteMultiWithErrorCheck.TabIndex = 14
        Me.btnWriteMultiWithErrorCheck.Text = "btnWriteMultiWithErrorCheck"
        Me.btnWriteMultiWithErrorCheck.UseVisualStyleBackColor = True
        '
        'btnWriteMultiSimplestWay
        '
        Me.btnWriteMultiSimplestWay.Location = New System.Drawing.Point(16, 82)
        Me.btnWriteMultiSimplestWay.Name = "btnWriteMultiSimplestWay"
        Me.btnWriteMultiSimplestWay.Size = New System.Drawing.Size(160, 23)
        Me.btnWriteMultiSimplestWay.TabIndex = 13
        Me.btnWriteMultiSimplestWay.Text = "btnWriteMultiSimplestWay"
        Me.btnWriteMultiSimplestWay.UseVisualStyleBackColor = True
        '
        'txtItem3ToBeRead
        '
        Me.txtItem3ToBeRead.Location = New System.Drawing.Point(63, 56)
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
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Item3"
        '
        'txtItem2ToBeRead
        '
        Me.txtItem2ToBeRead.Location = New System.Drawing.Point(63, 36)
        Me.txtItem2ToBeRead.Name = "txtItem2ToBeRead"
        Me.txtItem2ToBeRead.Size = New System.Drawing.Size(181, 20)
        Me.txtItem2ToBeRead.TabIndex = 7
        Me.txtItem2ToBeRead.Text = "Static/Analog Types/Double"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Item2"
        '
        'txtItem1ToBeRead
        '
        Me.txtItem1ToBeRead.Location = New System.Drawing.Point(63, 19)
        Me.txtItem1ToBeRead.Name = "txtItem1ToBeRead"
        Me.txtItem1ToBeRead.Size = New System.Drawing.Size(181, 20)
        Me.txtItem1ToBeRead.TabIndex = 5
        Me.txtItem1ToBeRead.Text = "Dynamic/Analog Types/Int"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Item1"
        '
        'frmAsynchronousWrite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 477)
        Me.Controls.Add(Me.GOPCDAConnector1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmAsynchronousWrite"
        Me.Text = "frmAsynchronousWrite"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GOPCDAConnector1 As GelecekOPCDAConnector.gOPCDAConnector
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnWriteSimplestWay As System.Windows.Forms.Button
    Friend WithEvents txtResultID As System.Windows.Forms.TextBox
    Friend WithEvents btnWriteWithErrorCheck As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFunctionResult As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemToBeWritten As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtResultID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResultID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResultID1 As System.Windows.Forms.TextBox
    Friend WithEvents txtValue3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtValue2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtValue1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMultiWriteFunctionResult As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnWriteMultiWithErrorCheck As System.Windows.Forms.Button
    Friend WithEvents btnWriteMultiSimplestWay As System.Windows.Forms.Button
    Friend WithEvents txtItem3ToBeRead As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtItem2ToBeRead As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtItem1ToBeRead As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCancelResult As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnCancelAsyncWrite As System.Windows.Forms.Button
End Class
