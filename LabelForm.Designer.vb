<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabelForm
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
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabelForm))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PubVer = New System.Windows.Forms.Label()
        Me.AutoPrint = New System.Windows.Forms.CheckBox()
        Me.PrintLabelBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CureStart = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CureEnd = New System.Windows.Forms.DateTimePicker()
        Me.TimeLimit = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(376, 129)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 13)
        Label1.TabIndex = 20
        Label1.Text = "Version:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(379, 103)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 24)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Print 2"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Time Limit:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PubVer
        '
        Me.PubVer.AutoSize = True
        Me.PubVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PubVer.Location = New System.Drawing.Point(427, 129)
        Me.PubVer.Name = "PubVer"
        Me.PubVer.Size = New System.Drawing.Size(22, 13)
        Me.PubVer.TabIndex = 22
        Me.PubVer.Text = "1.0"
        Me.PubVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AutoPrint
        '
        Me.AutoPrint.AutoSize = True
        Me.AutoPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoPrint.Location = New System.Drawing.Point(379, 80)
        Me.AutoPrint.Name = "AutoPrint"
        Me.AutoPrint.Size = New System.Drawing.Size(98, 24)
        Me.AutoPrint.TabIndex = 21
        Me.AutoPrint.Text = "Auto Print"
        Me.AutoPrint.UseVisualStyleBackColor = True
        '
        'PrintLabelBtn
        '
        Me.PrintLabelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintLabelBtn.Location = New System.Drawing.Point(379, 12)
        Me.PrintLabelBtn.Name = "PrintLabelBtn"
        Me.PrintLabelBtn.Size = New System.Drawing.Size(104, 62)
        Me.PrintLabelBtn.TabIndex = 6
        Me.PrintLabelBtn.Text = "Print Label"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Run Time:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CureStart
        '
        Me.CureStart.CustomFormat = "MM/dd/yyyy h:mm tt"
        Me.CureStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CureStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CureStart.Location = New System.Drawing.Point(102, 12)
        Me.CureStart.Name = "CureStart"
        Me.CureStart.Size = New System.Drawing.Size(200, 26)
        Me.CureStart.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Expires on:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CureEnd
        '
        Me.CureEnd.CustomFormat = "MM/dd/yyyy h:mm tt"
        Me.CureEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CureEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CureEnd.Location = New System.Drawing.Point(102, 80)
        Me.CureEnd.Name = "CureEnd"
        Me.CureEnd.Size = New System.Drawing.Size(200, 26)
        Me.CureEnd.TabIndex = 5
        '
        'TimeLimit
        '
        Me.TimeLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLimit.FormattingEnabled = True
        Me.TimeLimit.ItemHeight = 20
        Me.TimeLimit.Items.AddRange(New Object() {"16", "48", "80"})
        Me.TimeLimit.Location = New System.Drawing.Point(102, 46)
        Me.TimeLimit.Name = "TimeLimit"
        Me.TimeLimit.Size = New System.Drawing.Size(120, 28)
        Me.TimeLimit.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Hours"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(309, 12)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(64, 26)
        Me.ButtonUpdate.TabIndex = 289
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'LabelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 153)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CureEnd)
        Me.Controls.Add(Me.CureStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TimeLimit)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PubVer)
        Me.Controls.Add(Me.AutoPrint)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PrintLabelBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LabelForm"
        Me.Text = "Time Limit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PubVer As Label
    Friend WithEvents AutoPrint As CheckBox
    Friend WithEvents PrintLabelBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CureStart As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents CureEnd As DateTimePicker
    Friend WithEvents TimeLimit As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents CheckBoxLabel2 As CheckBox
End Class
