<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectDataGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnectDataGrid))
        Me.GOPCDAConnector1 = New GelecekOPCDAConnector.gOPCDAConnector
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtFunctionResult = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnConnectItems = New System.Windows.Forms.Button
        Me.colItemIDs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colValues = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GOPCDAConnector1.Location = New System.Drawing.Point(8, 8)
        Me.GOPCDAConnector1.MaximumSize = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.MinimumSize = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.Name = "GOPCDAConnector1"
        Me.GOPCDAConnector1.Size = New System.Drawing.Size(32, 32)
        Me.GOPCDAConnector1.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CONNECTING DATAGRIDVIEW CELLS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 38)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(451, 170)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemIDs, Me.colValues})
        Me.DataGridView1.Location = New System.Drawing.Point(121, 330)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(415, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'txtFunctionResult
        '
        Me.txtFunctionResult.Location = New System.Drawing.Point(199, 284)
        Me.txtFunctionResult.Name = "txtFunctionResult"
        Me.txtFunctionResult.Size = New System.Drawing.Size(153, 20)
        Me.txtFunctionResult.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Function result:"
        '
        'btnConnectItems
        '
        Me.btnConnectItems.Location = New System.Drawing.Point(121, 239)
        Me.btnConnectItems.Name = "btnConnectItems"
        Me.btnConnectItems.Size = New System.Drawing.Size(231, 43)
        Me.btnConnectItems.TabIndex = 22
        Me.btnConnectItems.Text = "btnConnectItems"
        Me.btnConnectItems.UseVisualStyleBackColor = True
        '
        'colItemIDs
        '
        Me.colItemIDs.HeaderText = "Item IDs"
        Me.colItemIDs.Name = "colItemIDs"
        Me.colItemIDs.Width = 220
        '
        'colValues
        '
        Me.colValues.HeaderText = "Values"
        Me.colValues.Name = "colValues"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(5, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 60)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "click on this icon to open and close Large Interface in runtime"
        '
        'frmConnectDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 559)
        Me.Controls.Add(Me.GOPCDAConnector1)
        Me.Controls.Add(Me.txtFunctionResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnConnectItems)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConnectDataGrid"
        Me.Text = "frmConnectDataGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GOPCDAConnector1 As GelecekOPCDAConnector.gOPCDAConnector
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFunctionResult As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnConnectItems As System.Windows.Forms.Button
    Friend WithEvents colItemIDs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValues As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
