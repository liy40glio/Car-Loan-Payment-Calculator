Public Class Form1

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim strAmount As Double = CDbl(txtLoan.Text)
        Dim strYears As Integer = (cbYears.SelectedItem)
        Dim strsRate As Integer = (cbStartRate.SelectedItem)
        Dim strErate As Integer = (cbEndRate.SelectedItem)
        Dim strStepR As Double = CDbl(txtStepRate.Text)
        Dim result As Decimal
        Dim rate As Double
        Dim arrange As String = "{0}                  {1}"
        Dim month As Integer = strYears * 12

        strAmount = Double.Parse(txtLoan.Text.ToString())
        strYears = Double.Parse(cbYears.GetItemText(cbYears.SelectedItem))
        strsRate = Double.Parse(cbStartRate.GetItemText(cbStartRate.SelectedItem))
        strErate = Double.Parse(cbEndRate.GetItemText(cbEndRate.SelectedItem))
        strStepR = Double.Parse(txtStepRate.Text.ToString())

        For rate = strsRate To strErate Step strStepR
            'Interest rate = (rate / 12) / 100
            result = -Pmt((rate / 12) / 100, month, strAmount)
            lblOutput.Items.Add(String.Format(arrange, FormatPercent(rate.ToString / 100), FormatCurrency(result.ToString, 2)))

        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strName As String
        lblName.Text = "NAME : NUR AWLIYA NASUHA BT AHMAD ZUBIR (10DDT20F1051)"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoan.Text = ""
        txtStepRate.Text = ""
        cbEndRate.ResetText()
        cbStartRate.ResetText()
        cbYears.ResetText()
        lblOutput.Items.Clear()
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        MsgBox("
         Perodua Ativa
         5-Seater SUV
         From RM61,500

         Proton X50
         SUV
         From RM79,200

         Honda HR-V 
         Compact crossover SUV
         From RM104,000

         Nissan X-Trail
         Compact crossover SUV
         From RM128,630", MsgBoxStyle.OkCancel, "Car List")
    End Sub


End Class

