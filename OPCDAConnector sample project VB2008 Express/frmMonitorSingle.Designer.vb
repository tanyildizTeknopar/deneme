<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitorSingle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitorSingle))
        Me.GOPCDAConnector1 = New GelecekOPCDAConnector.gOPCDAConnector
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.btnMonitorOneItem = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMonitoredItem = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtResultID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFunctionResult = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnGetGroupInfo = New System.Windows.Forms.Button
        Me.btnGetActiveState = New System.Windows.Forms.Button
        Me.btnKill = New System.Windows.Forms.Button
        Me.btnResume = New System.Windows.Forms.Button
        Me.btnPause = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
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
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(144, 98)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(153, 20)
        Me.txtValue.TabIndex = 1
        '
        'btnMonitorOneItem
        '
        Me.btnMonitorOneItem.Location = New System.Drawing.Point(21, 39)
        Me.btnMonitorOneItem.Name = "btnMonitorOneItem"
        Me.btnMonitorOneItem.Size = New System.Drawing.Size(120, 23)
        Me.btnMonitorOneItem.TabIndex = 2
        Me.btnMonitorOneItem.Text = "btnMonitorOneItem"
        Me.btnMonitorOneItem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item to be monitored:"
        '
        'txtMonitoredItem
        '
        Me.txtMonitoredItem.Location = New System.Drawing.Point(144, 72)
        Me.txtMonitoredItem.Name = "txtMonitoredItem"
        Me.txtMonitoredItem.Size = New System.Drawing.Size(153, 20)
        Me.txtMonitoredItem.TabIndex = 4
        Me.txtMonitoredItem.Text = "Dynamic/Analog Types/Int"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Value of monitored item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Result ID:"
        '
        'txtResultID
        '
        Me.txtResultID.Location = New System.Drawing.Point(144, 148)
        Me.txtResultID.Name = "txtResultID"
        Me.txtResultID.Size = New System.Drawing.Size(153, 20)
        Me.txtResultID.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Function result:"
        '
        'txtFunctionResult
        '
        Me.txtFunctionResult.Location = New System.Drawing.Point(144, 123)
        Me.txtFunctionResult.Name = "txtFunctionResult"
        Me.txtFunctionResult.Size = New System.Drawing.Size(153, 20)
        Me.txtFunctionResult.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.btnGetGroupInfo)
        Me.GroupBox1.Controls.Add(Me.btnGetActiveState)
        Me.GroupBox1.Controls.Add(Me.btnKill)
        Me.GroupBox1.Controls.Add(Me.btnResume)
        Me.GroupBox1.Controls.Add(Me.btnPause)
        Me.GroupBox1.Controls.Add(Me.txtMonitoredItem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtValue)
        Me.GroupBox1.Controls.Add(Me.txtFunctionResult)
        Me.GroupBox1.Controls.Add(Me.btnMonitorOneItem)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtResultID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 246)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monitor one item"
        '
        'btnGetGroupInfo
        '
        Me.btnGetGroupInfo.Location = New System.Drawing.Point(329, 187)
        Me.btnGetGroupInfo.Name = "btnGetGroupInfo"
        Me.btnGetGroupInfo.Size = New System.Drawing.Size(112, 23)
        Me.btnGetGroupInfo.TabIndex = 25
        Me.btnGetGroupInfo.Text = "btnGetGroupInfo"
        Me.btnGetGroupInfo.UseVisualStyleBackColor = True
        '
        'btnGetActiveState
        '
        Me.btnGetActiveState.Location = New System.Drawing.Point(329, 158)
        Me.btnGetActiveState.Name = "btnGetActiveState"
        Me.btnGetActiveState.Size = New System.Drawing.Size(112, 23)
        Me.btnGetActiveState.TabIndex = 24
        Me.btnGetActiveState.Text = "btnGetActiveState"
        Me.btnGetActiveState.UseVisualStyleBackColor = True
        '
        'btnKill
        '
        Me.btnKill.Location = New System.Drawing.Point(329, 129)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(75, 23)
        Me.btnKill.TabIndex = 23
        Me.btnKill.Text = "btnKill"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'btnResume
        '
        Me.btnResume.Location = New System.Drawing.Point(329, 100)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(75, 23)
        Me.btnResume.TabIndex = 22
        Me.btnResume.Text = "btnResume"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(329, 72)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 21
        Me.btnPause.Text = "btnPause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(451, 170)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "MONITORING"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(12, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 60)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "click on this icon to open and close Large Interface in runtime"
        '
        'frmMonitorSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 559)
        Me.Controls.Add(Me.GOPCDAConnector1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmMonitorSingle"
        Me.Text = "frmMonitorSingle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GOPCDAConnector1 As GelecekOPCDAConnector.gOPCDAConnector
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents btnMonitorOneItem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMonitoredItem As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtResultID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFunctionResult As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKill As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnGetGroupInfo As System.Windows.Forms.Button
    Friend WithEvents btnGetActiveState As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
