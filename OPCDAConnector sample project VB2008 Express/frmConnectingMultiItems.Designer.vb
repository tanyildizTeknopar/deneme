<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectingMultiItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnectingMultiItems))
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GOPCDAConnector1 = New GelecekOPCDAConnector.gOPCDAConnector
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSetUpdateRate5000 = New System.Windows.Forms.Button
        Me.btnSetUpdateRate1000 = New System.Windows.Forms.Button
        Me.txtFunctionResult = New System.Windows.Forms.TextBox
        Me.btnClearValuesAndResuldIDs = New System.Windows.Forms.Button
        Me.btnRemove2Items = New System.Windows.Forms.Button
        Me.btnRemove1Item = New System.Windows.Forms.Button
        Me.txtItem3 = New System.Windows.Forms.TextBox
        Me.txtValue3 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtResultID3 = New System.Windows.Forms.TextBox
        Me.txtItem2 = New System.Windows.Forms.TextBox
        Me.txtValue2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtResultID2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnGetGroupInfo = New System.Windows.Forms.Button
        Me.btnGetActiveState = New System.Windows.Forms.Button
        Me.btnKill = New System.Windows.Forms.Button
        Me.btnResume = New System.Windows.Forms.Button
        Me.btnPause = New System.Windows.Forms.Button
        Me.txtItem1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtValue1 = New System.Windows.Forms.TextBox
        Me.btnConnectItems = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtResultID1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CONNECTING"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 33)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(451, 170)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
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
        Me.GOPCDAConnector1.Location = New System.Drawing.Point(9, 8)
        Me.GOPCDAConnector1.MaximumSize = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.MinimumSize = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.Name = "GOPCDAConnector1"
        Me.GOPCDAConnector1.Size = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.btnSetUpdateRate5000)
        Me.GroupBox1.Controls.Add(Me.btnSetUpdateRate1000)
        Me.GroupBox1.Controls.Add(Me.txtFunctionResult)
        Me.GroupBox1.Controls.Add(Me.btnClearValuesAndResuldIDs)
        Me.GroupBox1.Controls.Add(Me.btnRemove2Items)
        Me.GroupBox1.Controls.Add(Me.btnRemove1Item)
        Me.GroupBox1.Controls.Add(Me.txtItem3)
        Me.GroupBox1.Controls.Add(Me.txtValue3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtResultID3)
        Me.GroupBox1.Controls.Add(Me.txtItem2)
        Me.GroupBox1.Controls.Add(Me.txtValue2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtResultID2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnGetGroupInfo)
        Me.GroupBox1.Controls.Add(Me.btnGetActiveState)
        Me.GroupBox1.Controls.Add(Me.btnKill)
        Me.GroupBox1.Controls.Add(Me.btnResume)
        Me.GroupBox1.Controls.Add(Me.btnPause)
        Me.GroupBox1.Controls.Add(Me.txtItem1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtValue1)
        Me.GroupBox1.Controls.Add(Me.btnConnectItems)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtResultID1)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 306)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connect multi items"
        '
        'btnSetUpdateRate5000
        '
        Me.btnSetUpdateRate5000.Location = New System.Drawing.Point(302, 106)
        Me.btnSetUpdateRate5000.Name = "btnSetUpdateRate5000"
        Me.btnSetUpdateRate5000.Size = New System.Drawing.Size(152, 23)
        Me.btnSetUpdateRate5000.TabIndex = 41
        Me.btnSetUpdateRate5000.Text = "btnSetUpdateRate5000"
        Me.btnSetUpdateRate5000.UseVisualStyleBackColor = True
        '
        'btnSetUpdateRate1000
        '
        Me.btnSetUpdateRate1000.Location = New System.Drawing.Point(302, 77)
        Me.btnSetUpdateRate1000.Name = "btnSetUpdateRate1000"
        Me.btnSetUpdateRate1000.Size = New System.Drawing.Size(152, 23)
        Me.btnSetUpdateRate1000.TabIndex = 40
        Me.btnSetUpdateRate1000.Text = "btnSetUpdateRate1000"
        Me.btnSetUpdateRate1000.UseVisualStyleBackColor = True
        '
        'txtFunctionResult
        '
        Me.txtFunctionResult.Location = New System.Drawing.Point(99, 64)
        Me.txtFunctionResult.Name = "txtFunctionResult"
        Me.txtFunctionResult.Size = New System.Drawing.Size(153, 20)
        Me.txtFunctionResult.TabIndex = 8
        '
        'btnClearValuesAndResuldIDs
        '
        Me.btnClearValuesAndResuldIDs.Location = New System.Drawing.Point(269, 234)
        Me.btnClearValuesAndResuldIDs.Name = "btnClearValuesAndResuldIDs"
        Me.btnClearValuesAndResuldIDs.Size = New System.Drawing.Size(145, 40)
        Me.btnClearValuesAndResuldIDs.TabIndex = 39
        Me.btnClearValuesAndResuldIDs.Text = "btnClearValues And ResuldIDs"
        Me.btnClearValuesAndResuldIDs.UseVisualStyleBackColor = True
        '
        'btnRemove2Items
        '
        Me.btnRemove2Items.Location = New System.Drawing.Point(420, 183)
        Me.btnRemove2Items.Name = "btnRemove2Items"
        Me.btnRemove2Items.Size = New System.Drawing.Size(106, 45)
        Me.btnRemove2Items.TabIndex = 38
        Me.btnRemove2Items.Text = "btnRemove2Items"
        Me.btnRemove2Items.UseVisualStyleBackColor = True
        '
        'btnRemove1Item
        '
        Me.btnRemove1Item.Location = New System.Drawing.Point(420, 154)
        Me.btnRemove1Item.Name = "btnRemove1Item"
        Me.btnRemove1Item.Size = New System.Drawing.Size(106, 23)
        Me.btnRemove1Item.TabIndex = 37
        Me.btnRemove1Item.Text = "btnRemove1Item"
        Me.btnRemove1Item.UseVisualStyleBackColor = True
        '
        'txtItem3
        '
        Me.txtItem3.Location = New System.Drawing.Point(73, 209)
        Me.txtItem3.Name = "txtItem3"
        Me.txtItem3.Size = New System.Drawing.Size(189, 20)
        Me.txtItem3.TabIndex = 35
        Me.txtItem3.Text = "Dynamic/Enumerated Types/Gems"
        '
        'txtValue3
        '
        Me.txtValue3.Location = New System.Drawing.Point(269, 208)
        Me.txtValue3.Name = "txtValue3"
        Me.txtValue3.Size = New System.Drawing.Size(68, 20)
        Me.txtValue3.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Item 3"
        '
        'txtResultID3
        '
        Me.txtResultID3.Location = New System.Drawing.Point(343, 208)
        Me.txtResultID3.Name = "txtResultID3"
        Me.txtResultID3.Size = New System.Drawing.Size(71, 20)
        Me.txtResultID3.TabIndex = 36
        '
        'txtItem2
        '
        Me.txtItem2.Location = New System.Drawing.Point(73, 183)
        Me.txtItem2.Name = "txtItem2"
        Me.txtItem2.Size = New System.Drawing.Size(189, 20)
        Me.txtItem2.TabIndex = 31
        Me.txtItem2.Text = "Dynamic/Analog Types/Double"
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(269, 182)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(68, 20)
        Me.txtValue2.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Item 2 "
        '
        'txtResultID2
        '
        Me.txtResultID2.Location = New System.Drawing.Point(343, 182)
        Me.txtResultID2.Name = "txtResultID2"
        Me.txtResultID2.Size = New System.Drawing.Size(71, 20)
        Me.txtResultID2.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(347, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "RESULT ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(282, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "VALUES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ITEM IDs"
        '
        'btnGetGroupInfo
        '
        Me.btnGetGroupInfo.Location = New System.Drawing.Point(420, 48)
        Me.btnGetGroupInfo.Name = "btnGetGroupInfo"
        Me.btnGetGroupInfo.Size = New System.Drawing.Size(112, 23)
        Me.btnGetGroupInfo.TabIndex = 25
        Me.btnGetGroupInfo.Text = "btnGetGroupInfo"
        Me.btnGetGroupInfo.UseVisualStyleBackColor = True
        '
        'btnGetActiveState
        '
        Me.btnGetActiveState.Location = New System.Drawing.Point(302, 48)
        Me.btnGetActiveState.Name = "btnGetActiveState"
        Me.btnGetActiveState.Size = New System.Drawing.Size(112, 23)
        Me.btnGetActiveState.TabIndex = 24
        Me.btnGetActiveState.Text = "btnGetActiveState"
        Me.btnGetActiveState.UseVisualStyleBackColor = True
        '
        'btnKill
        '
        Me.btnKill.Location = New System.Drawing.Point(464, 19)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(75, 23)
        Me.btnKill.TabIndex = 23
        Me.btnKill.Text = "btnKill"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'btnResume
        '
        Me.btnResume.Location = New System.Drawing.Point(383, 19)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(75, 23)
        Me.btnResume.TabIndex = 22
        Me.btnResume.Text = "btnResume"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(302, 19)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 21
        Me.btnPause.Text = "btnPause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'txtItem1
        '
        Me.txtItem1.Location = New System.Drawing.Point(73, 157)
        Me.txtItem1.Name = "txtItem1"
        Me.txtItem1.Size = New System.Drawing.Size(189, 20)
        Me.txtItem1.TabIndex = 4
        Me.txtItem1.Text = "Dynamic/Analog Types/Int"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Function result:"
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(269, 156)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(68, 20)
        Me.txtValue1.TabIndex = 1
        '
        'btnConnectItems
        '
        Me.btnConnectItems.Location = New System.Drawing.Point(21, 19)
        Me.btnConnectItems.Name = "btnConnectItems"
        Me.btnConnectItems.Size = New System.Drawing.Size(231, 43)
        Me.btnConnectItems.TabIndex = 2
        Me.btnConnectItems.Text = "btnConnectItems"
        Me.btnConnectItems.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item 1"
        '
        'txtResultID1
        '
        Me.txtResultID1.Location = New System.Drawing.Point(343, 156)
        Me.txtResultID1.Name = "txtResultID1"
        Me.txtResultID1.Size = New System.Drawing.Size(71, 20)
        Me.txtResultID1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 60)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "click on this icon to open and close Large Interface in runtime"
        '
        'frmConnectingMultiItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 639)
        Me.Controls.Add(Me.GOPCDAConnector1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmConnectingMultiItems"
        Me.Text = "frmConnectingMultiItems"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GOPCDAConnector1 As GelecekOPCDAConnector.gOPCDAConnector
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetUpdateRate5000 As System.Windows.Forms.Button
    Friend WithEvents btnSetUpdateRate1000 As System.Windows.Forms.Button
    Friend WithEvents txtFunctionResult As System.Windows.Forms.TextBox
    Friend WithEvents btnClearValuesAndResuldIDs As System.Windows.Forms.Button
    Friend WithEvents btnRemove2Items As System.Windows.Forms.Button
    Friend WithEvents btnRemove1Item As System.Windows.Forms.Button
    Friend WithEvents txtItem3 As System.Windows.Forms.TextBox
    Friend WithEvents txtValue3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtResultID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem2 As System.Windows.Forms.TextBox
    Friend WithEvents txtValue2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtResultID2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnGetGroupInfo As System.Windows.Forms.Button
    Friend WithEvents btnGetActiveState As System.Windows.Forms.Button
    Friend WithEvents btnKill As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents txtItem1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtValue1 As System.Windows.Forms.TextBox
    Friend WithEvents btnConnectItems As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResultID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
