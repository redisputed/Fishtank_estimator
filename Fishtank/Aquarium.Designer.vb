<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aquarium
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aquarium))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInputHeight = New System.Windows.Forms.TextBox()
        Me.txtInputLength = New System.Windows.Forms.TextBox()
        Me.txtInputWidth = New System.Windows.Forms.TextBox()
        Me.lblInputWidth = New System.Windows.Forms.Label()
        Me.lblInputLength = New System.Windows.Forms.Label()
        Me.lblInputHeight = New System.Windows.Forms.Label()
        Me.btnCalcVolume = New System.Windows.Forms.Button()
        Me.btnClearInput = New System.Windows.Forms.Button()
        Me.picFishTankWireFrame = New System.Windows.Forms.PictureBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radLongLifeFilter = New System.Windows.Forms.RadioButton()
        Me.radSuperQtFilter = New System.Windows.Forms.RadioButton()
        Me.radBasicFilter = New System.Windows.Forms.RadioButton()
        Me.lstFishSelect = New System.Windows.Forms.ListBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtFilterSubtotal = New System.Windows.Forms.TextBox()
        Me.txtFishSubtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFilterSubTotal = New System.Windows.Forms.Label()
        Me.lblFishSubTotal = New System.Windows.Forms.Label()
        Me.lblFishCapacity = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.LengthEst = New System.Windows.Forms.GroupBox()
        Me.btnEstimate = New System.Windows.Forms.Button()
        Me.txtInputMaxLength = New System.Windows.Forms.TextBox()
        Me.lblInputMaxLength = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picFishTankWireFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LengthEst.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInputHeight)
        Me.GroupBox1.Controls.Add(Me.txtInputLength)
        Me.GroupBox1.Controls.Add(Me.txtInputWidth)
        Me.GroupBox1.Controls.Add(Me.lblInputWidth)
        Me.GroupBox1.Controls.Add(Me.lblInputLength)
        Me.GroupBox1.Controls.Add(Me.lblInputHeight)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aquarium"
        '
        'txtInputHeight
        '
        Me.txtInputHeight.Location = New System.Drawing.Point(131, 12)
        Me.txtInputHeight.Name = "txtInputHeight"
        Me.txtInputHeight.Size = New System.Drawing.Size(53, 20)
        Me.txtInputHeight.TabIndex = 1
        '
        'txtInputLength
        '
        Me.txtInputLength.Location = New System.Drawing.Point(131, 41)
        Me.txtInputLength.Name = "txtInputLength"
        Me.txtInputLength.Size = New System.Drawing.Size(53, 20)
        Me.txtInputLength.TabIndex = 2
        '
        'txtInputWidth
        '
        Me.txtInputWidth.Location = New System.Drawing.Point(131, 68)
        Me.txtInputWidth.Name = "txtInputWidth"
        Me.txtInputWidth.Size = New System.Drawing.Size(53, 20)
        Me.txtInputWidth.TabIndex = 3
        '
        'lblInputWidth
        '
        Me.lblInputWidth.AutoSize = True
        Me.lblInputWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputWidth.Location = New System.Drawing.Point(18, 72)
        Me.lblInputWidth.Name = "lblInputWidth"
        Me.lblInputWidth.Size = New System.Drawing.Size(110, 16)
        Me.lblInputWidth.TabIndex = 2
        Me.lblInputWidth.Text = "Width (inches):"
        '
        'lblInputLength
        '
        Me.lblInputLength.AutoSize = True
        Me.lblInputLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputLength.Location = New System.Drawing.Point(11, 45)
        Me.lblInputLength.Name = "lblInputLength"
        Me.lblInputLength.Size = New System.Drawing.Size(117, 16)
        Me.lblInputLength.TabIndex = 1
        Me.lblInputLength.Text = "Length (inches):"
        '
        'lblInputHeight
        '
        Me.lblInputHeight.AutoSize = True
        Me.lblInputHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputHeight.Location = New System.Drawing.Point(12, 16)
        Me.lblInputHeight.Name = "lblInputHeight"
        Me.lblInputHeight.Size = New System.Drawing.Size(116, 16)
        Me.lblInputHeight.TabIndex = 0
        Me.lblInputHeight.Text = "Height (inches):"
        '
        'btnCalcVolume
        '
        Me.btnCalcVolume.Location = New System.Drawing.Point(192, 275)
        Me.btnCalcVolume.Name = "btnCalcVolume"
        Me.btnCalcVolume.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcVolume.TabIndex = 8
        Me.btnCalcVolume.Text = "&Calculate"
        Me.btnCalcVolume.UseVisualStyleBackColor = True
        '
        'btnClearInput
        '
        Me.btnClearInput.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearInput.Location = New System.Drawing.Point(26, 275)
        Me.btnClearInput.Name = "btnClearInput"
        Me.btnClearInput.Size = New System.Drawing.Size(75, 23)
        Me.btnClearInput.TabIndex = 9
        Me.btnClearInput.Text = "C&lear"
        Me.btnClearInput.UseVisualStyleBackColor = True
        '
        'picFishTankWireFrame
        '
        Me.picFishTankWireFrame.Image = CType(resources.GetObject("picFishTankWireFrame.Image"), System.Drawing.Image)
        Me.picFishTankWireFrame.Location = New System.Drawing.Point(432, 219)
        Me.picFishTankWireFrame.Name = "picFishTankWireFrame"
        Me.picFishTankWireFrame.Size = New System.Drawing.Size(286, 193)
        Me.picFishTankWireFrame.TabIndex = 1
        Me.picFishTankWireFrame.TabStop = False
        Me.picFishTankWireFrame.Visible = False
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(298, 318)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(61, 16)
        Me.lblHeight.TabIndex = 0
        Me.lblHeight.Text = "Height: "
        Me.lblHeight.Visible = False
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.Location = New System.Drawing.Point(610, 190)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(55, 16)
        Me.lblWidth.TabIndex = 0
        Me.lblWidth.Text = "Width: "
        Me.lblWidth.Visible = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(510, 416)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(62, 16)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length: "
        Me.lblLength.Visible = False
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.Location = New System.Drawing.Point(310, 136)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(77, 16)
        Me.lblCapacity.TabIndex = 0
        Me.lblCapacity.Text = "Capacity: "
        Me.lblCapacity.Visible = False
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(319, 109)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(68, 16)
        Me.lblVolume.TabIndex = 0
        Me.lblVolume.Text = "Volume: "
        Me.lblVolume.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radLongLifeFilter)
        Me.GroupBox2.Controls.Add(Me.radSuperQtFilter)
        Me.GroupBox2.Controls.Add(Me.radBasicFilter)
        Me.GroupBox2.Controls.Add(Me.lstFishSelect)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 99)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'radLongLifeFilter
        '
        Me.radLongLifeFilter.AutoSize = True
        Me.radLongLifeFilter.Location = New System.Drawing.Point(149, 68)
        Me.radLongLifeFilter.Name = "radLongLifeFilter"
        Me.radLongLifeFilter.Size = New System.Drawing.Size(94, 17)
        Me.radLongLifeFilter.TabIndex = 7
        Me.radLongLifeFilter.TabStop = True
        Me.radLongLifeFilter.Text = "Long Life Filter"
        Me.radLongLifeFilter.UseVisualStyleBackColor = True
        '
        'radSuperQtFilter
        '
        Me.radSuperQtFilter.AutoSize = True
        Me.radSuperQtFilter.Location = New System.Drawing.Point(149, 45)
        Me.radSuperQtFilter.Name = "radSuperQtFilter"
        Me.radSuperQtFilter.Size = New System.Drawing.Size(106, 17)
        Me.radSuperQtFilter.TabIndex = 6
        Me.radSuperQtFilter.TabStop = True
        Me.radSuperQtFilter.Text = "Super Quiet Filter"
        Me.radSuperQtFilter.UseVisualStyleBackColor = True
        '
        'radBasicFilter
        '
        Me.radBasicFilter.AutoSize = True
        Me.radBasicFilter.Location = New System.Drawing.Point(149, 22)
        Me.radBasicFilter.Name = "radBasicFilter"
        Me.radBasicFilter.Size = New System.Drawing.Size(76, 17)
        Me.radBasicFilter.TabIndex = 5
        Me.radBasicFilter.TabStop = True
        Me.radBasicFilter.Text = "Basic Filter"
        Me.radBasicFilter.UseVisualStyleBackColor = True
        '
        'lstFishSelect
        '
        Me.lstFishSelect.FormattingEnabled = True
        Me.lstFishSelect.Items.AddRange(New Object() {"Guppies - $1.00/fish", "Angel Fish - $1.50/fish", "Clown Fish - $2.00/fish"})
        Me.lstFishSelect.Location = New System.Drawing.Point(12, 32)
        Me.lstFishSelect.Name = "lstFishSelect"
        Me.lstFishSelect.Size = New System.Drawing.Size(125, 43)
        Me.lstFishSelect.TabIndex = 4
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(131, 61)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(53, 20)
        Me.txtTotal.TabIndex = 8
        '
        'txtFilterSubtotal
        '
        Me.txtFilterSubtotal.Location = New System.Drawing.Point(131, 38)
        Me.txtFilterSubtotal.Name = "txtFilterSubtotal"
        Me.txtFilterSubtotal.Size = New System.Drawing.Size(53, 20)
        Me.txtFilterSubtotal.TabIndex = 7
        Me.txtFilterSubtotal.TabStop = False
        '
        'txtFishSubtotal
        '
        Me.txtFishSubtotal.Location = New System.Drawing.Point(131, 15)
        Me.txtFishSubtotal.Name = "txtFishSubtotal"
        Me.txtFishSubtotal.Size = New System.Drawing.Size(53, 20)
        Me.txtFishSubtotal.TabIndex = 6
        Me.txtFishSubtotal.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total:"
        '
        'lblFilterSubTotal
        '
        Me.lblFilterSubTotal.AutoSize = True
        Me.lblFilterSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterSubTotal.Location = New System.Drawing.Point(32, 41)
        Me.lblFilterSubTotal.Name = "lblFilterSubTotal"
        Me.lblFilterSubTotal.Size = New System.Drawing.Size(90, 13)
        Me.lblFilterSubTotal.TabIndex = 0
        Me.lblFilterSubTotal.Text = "Filter Subtotal:"
        '
        'lblFishSubTotal
        '
        Me.lblFishSubTotal.AutoSize = True
        Me.lblFishSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFishSubTotal.Location = New System.Drawing.Point(37, 18)
        Me.lblFishSubTotal.Name = "lblFishSubTotal"
        Me.lblFishSubTotal.Size = New System.Drawing.Size(85, 13)
        Me.lblFishSubTotal.TabIndex = 0
        Me.lblFishSubTotal.Text = "Fish Subtotal:"
        '
        'lblFishCapacity
        '
        Me.lblFishCapacity.AutoSize = True
        Me.lblFishCapacity.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lblFishCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFishCapacity.Location = New System.Drawing.Point(298, 163)
        Me.lblFishCapacity.Name = "lblFishCapacity"
        Me.lblFishCapacity.Size = New System.Drawing.Size(93, 16)
        Me.lblFishCapacity.TabIndex = 0
        Me.lblFishCapacity.Text = "Max # Fish:  "
        Me.lblFishCapacity.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblFilterSubTotal)
        Me.GroupBox3.Controls.Add(Me.lblFishSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.txtFishSubtotal)
        Me.GroupBox3.Controls.Add(Me.txtFilterSubtotal)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 318)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 94)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estimated Totals"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(450, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(26, 426)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'LengthEst
        '
        Me.LengthEst.Controls.Add(Me.btnEstimate)
        Me.LengthEst.Controls.Add(Me.txtInputMaxLength)
        Me.LengthEst.Controls.Add(Me.lblInputMaxLength)
        Me.LengthEst.Location = New System.Drawing.Point(292, 37)
        Me.LengthEst.Name = "LengthEst"
        Me.LengthEst.Size = New System.Drawing.Size(152, 69)
        Me.LengthEst.TabIndex = 13
        Me.LengthEst.TabStop = False
        Me.LengthEst.Text = "Length Estimator"
        '
        'btnEstimate
        '
        Me.btnEstimate.Location = New System.Drawing.Point(71, 38)
        Me.btnEstimate.Name = "btnEstimate"
        Me.btnEstimate.Size = New System.Drawing.Size(75, 23)
        Me.btnEstimate.TabIndex = 14
        Me.btnEstimate.Text = "Es&timate"
        Me.btnEstimate.UseVisualStyleBackColor = True
        '
        'txtInputMaxLength
        '
        Me.txtInputMaxLength.Location = New System.Drawing.Point(99, 12)
        Me.txtInputMaxLength.Name = "txtInputMaxLength"
        Me.txtInputMaxLength.Size = New System.Drawing.Size(47, 20)
        Me.txtInputMaxLength.TabIndex = 5
        '
        'lblInputMaxLength
        '
        Me.lblInputMaxLength.AutoSize = True
        Me.lblInputMaxLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputMaxLength.Location = New System.Drawing.Point(6, 16)
        Me.lblInputMaxLength.Name = "lblInputMaxLength"
        Me.lblInputMaxLength.Size = New System.Drawing.Size(90, 16)
        Me.lblInputMaxLength.TabIndex = 4
        Me.lblInputMaxLength.Text = "Max Length:"
        '
        'Aquarium
        '
        Me.AcceptButton = Me.btnCalcVolume
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.CancelButton = Me.btnClearInput
        Me.ClientSize = New System.Drawing.Size(759, 461)
        Me.Controls.Add(Me.LengthEst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcVolume)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClearInput)
        Me.Controls.Add(Me.lblFishCapacity)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.picFishTankWireFrame)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aquarium"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Aquarium Design"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picFishTankWireFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LengthEst.ResumeLayout(False)
        Me.LengthEst.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInputHeight As System.Windows.Forms.Label
    Friend WithEvents btnClearInput As System.Windows.Forms.Button
    Friend WithEvents txtInputHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtInputLength As System.Windows.Forms.TextBox
    Friend WithEvents txtInputWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblInputWidth As System.Windows.Forms.Label
    Friend WithEvents lblInputLength As System.Windows.Forms.Label
    Friend WithEvents picFishTankWireFrame As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents btnCalcVolume As System.Windows.Forms.Button
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radBasicFilter As System.Windows.Forms.RadioButton
    Friend WithEvents lstFishSelect As System.Windows.Forms.ListBox
    Friend WithEvents lblFishSubTotal As System.Windows.Forms.Label
    Friend WithEvents radLongLifeFilter As System.Windows.Forms.RadioButton
    Friend WithEvents radSuperQtFilter As System.Windows.Forms.RadioButton
    Friend WithEvents lblFilterSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtFilterSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtFishSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblFishCapacity As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents LengthEst As System.Windows.Forms.GroupBox
    Friend WithEvents txtInputMaxLength As System.Windows.Forms.TextBox
    Friend WithEvents lblInputMaxLength As System.Windows.Forms.Label
    Friend WithEvents btnEstimate As System.Windows.Forms.Button

End Class
