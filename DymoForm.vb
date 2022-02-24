Imports DymoSDK.Implementations
Public Class DymoForm
    Inherits System.Windows.Forms.Form
    Private Label As DymoSDK.Implementations.DymoLabel
    Public Sub SetupLabelObject()
        ' Get the variable objects on the label, there are 3 called OVEN, CURESTART and CUREEND
        Dim LabelTextObject1 As DymoSDK.Interfaces.ILabelObject
        Dim LabelTextObject2 As DymoSDK.Interfaces.ILabelObject
        Dim LabelTextObject3 As DymoSDK.Interfaces.ILabelObject

        If Label Is Nothing Then Exit Sub
        LabelTextObject1 = Label.GetLabelObject("OVEN")
        Label.UpdateLabelObject(LabelTextObject1, LabelForm.TimeLimit.Text)

        LabelTextObject2 = Label.GetLabelObject("CURESTART")
        Label.UpdateLabelObject(LabelTextObject2, LabelForm.CureStart.Text)

        LabelTextObject3 = Label.GetLabelObject("CUREEND")
        Label.UpdateLabelObject(LabelTextObject3, LabelForm.CureEnd.Text)
    End Sub
    Private Sub UpdateControls()
        PrintLabelBtn.Enabled = (Not Label Is Nothing) And (Not String.IsNullOrEmpty(PrintLabelBtn.Text))
    End Sub
    Public Sub SetupLabelWriterSelection()

        Dim Printer As DymoSDK.Interfaces.IPrinter
        ' clear all items first on the Dymo drop down
        LabelWriterCmb.Items.Clear()

        For Each Printer In DymoPrinter.Instance.GetPrinters()
            LabelWriterCmb.Items.Add(Printer.Name)
        Next

        If LabelWriterCmb.Items.Count = 0 Then
            MessageBox.Show("Dymo Printer not found! Make sure Dymo software is installed")
            Exit Sub
        End If

        If LabelWriterCmb.Items.Count > 0 Then
            LabelWriterCmb.SelectedIndex = 0
        End If
        LabelWriterCmb.Enabled = LabelWriterCmb.Items.Count > 0

    End Sub
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        ' create DYMO COM objects
        'DymoAddIn = New DYMO.DymoAddIn
        'DymoLabels = New DYMO.DymoLabels

        ' show the file name
        'FileNameEdit.Text = DymoAddIn.FileName

        ' populate label objects
        'SetupLabelObject()

        ' obtain the currently selected printer
        'SetupLabelWriterSelection()
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PrintLabelBtn As System.Windows.Forms.Button
    Friend WithEvents LabelWriterCmb As System.Windows.Forms.ComboBox
    Friend WithEvents label6 As Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.PrintLabelBtn = New System.Windows.Forms.Button()
        Me.LabelWriterCmb = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(147, 150)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 11
        Me.CloseBtn.Text = "Close"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.DefaultExt = "lwl"
        Me.openFileDialog1.Filter = "DYMO Label File (*.label)|*.label"
        Me.openFileDialog1.Title = "Open DYMO Label File"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.PrintLabelBtn)
        Me.groupBox2.Controls.Add(Me.LabelWriterCmb)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Location = New System.Drawing.Point(12, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(307, 132)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "LabelWriter Selection"
        '
        'PrintLabelBtn
        '
        Me.PrintLabelBtn.Location = New System.Drawing.Point(8, 96)
        Me.PrintLabelBtn.Name = "PrintLabelBtn"
        Me.PrintLabelBtn.Size = New System.Drawing.Size(84, 23)
        Me.PrintLabelBtn.TabIndex = 4
        Me.PrintLabelBtn.Text = "Print Label"
        '
        'LabelWriterCmb
        '
        Me.LabelWriterCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LabelWriterCmb.Location = New System.Drawing.Point(8, 64)
        Me.LabelWriterCmb.Name = "LabelWriterCmb"
        Me.LabelWriterCmb.Size = New System.Drawing.Size(280, 21)
        Me.LabelWriterCmb.TabIndex = 1
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 40)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(156, 16)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Select a LabelWriter here:"
        '
        'DymoForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(332, 180)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.CloseBtn)
        Me.MaximizeBox = False
        Me.Name = "DymoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DYMO Label Print"
        Me.groupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Sub PrintLabelNow()

        Dim printer As DymoSDK.Interfaces.IPrinter
        Dim copies As Integer

        If LabelForm.CheckBox1.Checked Then
            copies = 2
        Else
            copies = 1
        End If

        printer = DymoPrinter.Instance.GetPrinters(LabelWriterCmb.SelectedIndex)
        If (printer.PrinterType = "LabelWriterPrinter") Then
            DymoPrinter.Instance.PrintLabel(Label, printer.Name, copies)
        Else
            MessageBox.Show("Dymo Printer not found")
        End If
        'close the window after the label prints
        Close()
    End Sub
    Private Sub PrintLabelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintLabelBtn.Click
        PrintLabelNow()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Close()
    End Sub
    Private Shared Sub OnThreadException(ByVal sender As Object, ByVal t As Threading.ThreadExceptionEventArgs)
        MessageBox.Show(t.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Application.ThreadException, AddressOf OnThreadException
        DymoSDK.App.Init()
        Label = DymoLabel.Instance

        'Load Dymo Template
        'Load the label made with Dymo Label V8 or Dymo Connect since they are both supported. My sample is from v8.
        Label.LoadLabelFromFilePath(Application.StartupPath & "\Class5Limit.label")

        SetupLabelObject()
        SetupLabelWriterSelection()
        UpdateControls()

        If LabelForm.AutoPrint.CheckState = CheckState.Checked Then
            'If they only have one Dymo printer, let them skip the window where they choose a printer
            PrintLabelNow()
        End If
    End Sub

End Class
