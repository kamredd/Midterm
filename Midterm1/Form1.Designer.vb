<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuilding
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
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.rbtnGroup = New System.Windows.Forms.GroupBox()
        Me.rbtnMeter = New System.Windows.Forms.RadioButton()
        Me.rbtnIn = New System.Windows.Forms.RadioButton()
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.rbtnGroup.SuspendLayout()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvert.Location = New System.Drawing.Point(299, 55)
        Me.lblConvert.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(236, 37)
        Me.lblConvert.TabIndex = 4
        Me.lblConvert.Text = "Converter App"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter a value and"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(303, 127)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(210, 25)
        Me.label3.TabIndex = 6
        Me.label3.Text = "choose conversion"
        '
        'rbtnGroup
        '
        Me.rbtnGroup.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.rbtnGroup.Controls.Add(Me.rbtnMeter)
        Me.rbtnGroup.Controls.Add(Me.rbtnIn)
        Me.rbtnGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnGroup.ForeColor = System.Drawing.Color.White
        Me.rbtnGroup.Location = New System.Drawing.Point(390, 204)
        Me.rbtnGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnGroup.Name = "rbtnGroup"
        Me.rbtnGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.rbtnGroup.Size = New System.Drawing.Size(273, 100)
        Me.rbtnGroup.TabIndex = 7
        Me.rbtnGroup.TabStop = False
        Me.rbtnGroup.Text = "Convert Measurement"
        '
        'rbtnMeter
        '
        Me.rbtnMeter.AutoSize = True
        Me.rbtnMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMeter.Location = New System.Drawing.Point(7, 60)
        Me.rbtnMeter.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnMeter.Name = "rbtnMeter"
        Me.rbtnMeter.Size = New System.Drawing.Size(146, 24)
        Me.rbtnMeter.TabIndex = 1
        Me.rbtnMeter.Text = "Meters to Inches"
        Me.rbtnMeter.UseVisualStyleBackColor = True
        '
        'rbtnIn
        '
        Me.rbtnIn.AutoSize = True
        Me.rbtnIn.Checked = True
        Me.rbtnIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIn.Location = New System.Drawing.Point(7, 26)
        Me.rbtnIn.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnIn.Name = "rbtnIn"
        Me.rbtnIn.Size = New System.Drawing.Size(146, 24)
        Me.rbtnIn.TabIndex = 0
        Me.rbtnIn.TabStop = True
        Me.rbtnIn.Text = "Inches to Meters"
        Me.rbtnIn.UseVisualStyleBackColor = True
        '
        'picBuilding
        '
        Me.picBuilding.Image = Global.Midterm1.My.Resources.Resources.building
        Me.picBuilding.Location = New System.Drawing.Point(1, 12)
        Me.picBuilding.Margin = New System.Windows.Forms.Padding(4)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(243, 188)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuilding.TabIndex = 8
        Me.picBuilding.TabStop = False
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.lblCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCon.Location = New System.Drawing.Point(405, 342)
        Me.lblCon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(0, 24)
        Me.lblCon.TabIndex = 9
        Me.lblCon.Visible = False
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.MediumPurple
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(29, 390)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(184, 48)
        Me.btnConvert.TabIndex = 10
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumPurple
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(316, 390)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(184, 48)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumPurple
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(588, 390)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(184, 48)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.ForeColor = System.Drawing.Color.White
        Me.txtValue.Location = New System.Drawing.Point(578, 112)
        Me.txtValue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(96, 31)
        Me.txtValue.TabIndex = 13
        Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmBuilding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblCon)
        Me.Controls.Add(Me.picBuilding)
        Me.Controls.Add(Me.rbtnGroup)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblConvert)
        Me.Name = "frmBuilding"
        Me.Text = "Building Plans Conversion"
        Me.rbtnGroup.ResumeLayout(False)
        Me.rbtnGroup.PerformLayout()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConvert As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents rbtnGroup As GroupBox
    Friend WithEvents rbtnMeter As RadioButton
    Friend WithEvents rbtnIn As RadioButton
    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblCon As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtValue As TextBox
End Class
