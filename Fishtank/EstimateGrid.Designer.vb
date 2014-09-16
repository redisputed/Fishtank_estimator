<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstimateGrid
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstimateGrid))
        Me.dgLengthEstimate = New System.Windows.Forms.DataGridView()
        Me.Length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TankSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostFish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFilters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostFilters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnOutputText = New System.Windows.Forms.Button()
        CType(Me.dgLengthEstimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLengthEstimate
        '
        Me.dgLengthEstimate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLengthEstimate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Length, Me.Width, Me.Height, Me.TankSize, Me.Capacity, Me.NumFish, Me.CostFish, Me.NumFilters, Me.CostFilters, Me.TotalCost})
        Me.dgLengthEstimate.Location = New System.Drawing.Point(41, 12)
        Me.dgLengthEstimate.Name = "dgLengthEstimate"
        Me.dgLengthEstimate.RowHeadersWidth = 80
        Me.dgLengthEstimate.Size = New System.Drawing.Size(1091, 400)
        Me.dgLengthEstimate.TabIndex = 0
        '
        'Length
        '
        Me.Length.HeaderText = "Length"
        Me.Length.Name = "Length"
        '
        'Width
        '
        Me.Width.HeaderText = "Width"
        Me.Width.Name = "Width"
        '
        'Height
        '
        Me.Height.HeaderText = "Height"
        Me.Height.Name = "Height"
        '
        'TankSize
        '
        Me.TankSize.HeaderText = "Tank Size"
        Me.TankSize.Name = "TankSize"
        '
        'Capacity
        '
        Me.Capacity.HeaderText = "Amount of Water"
        Me.Capacity.Name = "Capacity"
        '
        'NumFish
        '
        Me.NumFish.HeaderText = "Number of Fish"
        Me.NumFish.Name = "NumFish"
        '
        'CostFish
        '
        Me.CostFish.HeaderText = "Cost of Fish"
        Me.CostFish.Name = "CostFish"
        '
        'NumFilters
        '
        Me.NumFilters.HeaderText = "Number of Filters"
        Me.NumFilters.Name = "NumFilters"
        '
        'CostFilters
        '
        Me.CostFilters.HeaderText = "Cost of Filters"
        Me.CostFilters.Name = "CostFilters"
        '
        'TotalCost
        '
        Me.TotalCost.HeaderText = "Total Cost"
        Me.TotalCost.Name = "TotalCost"
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(Fishtank.My.MyApplication)
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(219, 426)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnOutputText
        '
        Me.btnOutputText.Location = New System.Drawing.Point(330, 426)
        Me.btnOutputText.Name = "btnOutputText"
        Me.btnOutputText.Size = New System.Drawing.Size(149, 23)
        Me.btnOutputText.TabIndex = 2
        Me.btnOutputText.Text = "&Output to TextFile"
        Me.btnOutputText.UseVisualStyleBackColor = True
        '
        'EstimateGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1184, 461)
        Me.Controls.Add(Me.btnOutputText)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.dgLengthEstimate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EstimateGrid"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Length Estimate Grid"
        CType(Me.dgLengthEstimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLengthEstimate As System.Windows.Forms.DataGridView
    Friend WithEvents Length As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Width As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Height As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TankSize As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Capacity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumFish As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostFish As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumFilters As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostFilters As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MyApplicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnOutputText As System.Windows.Forms.Button
End Class
