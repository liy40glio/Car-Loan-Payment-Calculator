<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.txtStepRate = New System.Windows.Forms.TextBox()
        Me.cbStartRate = New System.Windows.Forms.ComboBox()
        Me.cbYears = New System.Windows.Forms.ComboBox()
        Me.cbEndRate = New System.Windows.Forms.ComboBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.ListBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Loan Payment Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Loan Amount "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start Rate (%)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rate Step Size"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Years "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "End Rate (%)"
        '
        'txtLoan
        '
        Me.txtLoan.Location = New System.Drawing.Point(161, 81)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(150, 31)
        Me.txtLoan.TabIndex = 6
        '
        'txtStepRate
        '
        Me.txtStepRate.Location = New System.Drawing.Point(161, 218)
        Me.txtStepRate.Name = "txtStepRate"
        Me.txtStepRate.Size = New System.Drawing.Size(150, 31)
        Me.txtStepRate.TabIndex = 7
        '
        'cbStartRate
        '
        Me.cbStartRate.FormattingEnabled = True
        Me.cbStartRate.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbStartRate.Location = New System.Drawing.Point(161, 148)
        Me.cbStartRate.Name = "cbStartRate"
        Me.cbStartRate.Size = New System.Drawing.Size(117, 33)
        Me.cbStartRate.TabIndex = 8
        '
        'cbYears
        '
        Me.cbYears.FormattingEnabled = True
        Me.cbYears.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbYears.Location = New System.Drawing.Point(458, 79)
        Me.cbYears.Name = "cbYears"
        Me.cbYears.Size = New System.Drawing.Size(117, 33)
        Me.cbYears.TabIndex = 9
        '
        'cbEndRate
        '
        Me.cbEndRate.FormattingEnabled = True
        Me.cbEndRate.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbEndRate.Location = New System.Drawing.Point(458, 148)
        Me.cbEndRate.Name = "cbEndRate"
        Me.cbEndRate.Size = New System.Drawing.Size(117, 33)
        Me.cbEndRate.TabIndex = 10
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(133, 275)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(178, 34)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(340, 275)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(178, 34)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.FormattingEnabled = True
        Me.lblOutput.ItemHeight = 25
        Me.lblOutput.Location = New System.Drawing.Point(25, 331)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(707, 279)
        Me.lblOutput.TabIndex = 13
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(620, 641)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(112, 34)
        Me.btnList.TabIndex = 14
        Me.btnList.Text = "Car List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(30, 641)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(71, 25)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "NAME :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 778)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.cbEndRate)
        Me.Controls.Add(Me.cbYears)
        Me.Controls.Add(Me.cbStartRate)
        Me.Controls.Add(Me.txtStepRate)
        Me.Controls.Add(Me.txtLoan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLoan As TextBox
    Friend WithEvents txtStepRate As TextBox
    Friend WithEvents cbStartRate As ComboBox
    Friend WithEvents cbYears As ComboBox
    Friend WithEvents cbEndRate As ComboBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblOutput As ListBox
    Friend WithEvents btnList As Button
    Friend WithEvents lblName As Label
End Class
