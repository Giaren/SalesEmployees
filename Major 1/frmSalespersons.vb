' Author - Giancarlo Rengifo, Simon Li
' Date Written - 10/23/2018

' This program develops an application that will allow the user to enter a salesperson’s name, the salesperson’s classification code and sales figures for the first six months of 2017.   


Option Explicit On
Option Strict On
Option Infer Off
Public Class frmSalespersonsPay

    ' define output variables - output variables defined at class level because they will be
    '                           referenced by multiple event procedures calculate & clear salesperson
    Dim strSalesPersonOUT As String = ""
    Dim strClassificationOUT As String = ""
    Dim strLowestSalesMonthOUT As String = ""
    Dim strHighestSalesMonthOUT As String = ""
    Dim strTotalSalesOUT As String
    Dim strAverageSalesOUT As String
    Dim strHighestSalesOUT As String
    Dim strLowestSalesOUT As String
    Dim strCommissionOUT As String
    Dim strBonusOUT As String
    Dim strSalaryOUT As String
    Dim strTotalPayOUT As String

    Private bln_Exiting As Boolean = False





    ' listbox zone configuration - defined at the class level because it will be referenced in
    '                              multiple event procedures
    Dim listboxZoneConfig As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        bln_Exiting = True
        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' define program constants
        Const decCOMMISION_TEN_PERCENT_CONDITION As Decimal = 10000D
        Const decCOMMISION_TWELVE_PERCENT_CONDITION As Decimal = 20000D
        Const decCOMMISION_FIFTEEN_PERCENT_CONDITION As Decimal = 30000D
        Const decBONUSRATE As Decimal = 0.02D
        Const intFIXED_SALARY As Integer = 500
        Const intSALES_PERSON_INCREASE_CONDITION As Integer = 35000



        ' define input variables
        Dim strSalesperson As String
        Dim strClassificationCode As String

        ' define processing variables
        Dim decMonthSales(5) As Decimal
        Dim decTotalSales_Process As Decimal
        Dim decAverageSales_Process As Decimal
        Dim decHighestSales_Process As Decimal
        Dim decLowestSales_Process As Decimal
        Dim decCommission_Process As Decimal
        Dim decBonus_Process As Decimal
        Dim decSalary_Process As Decimal
        Dim decTotalPay_Process As Decimal
        Dim decCommission_Increase As Decimal

        ' define output variables
        Dim strSalesPersonOUT As String = ""
        Dim strClassificationOUT As String = ""
        Dim strLowestSalesMonthOUT As String = ""
        Dim strHighestSalesMonthOUT As String = ""
        Dim strTotalSalesOUT As String
        Dim strAverageSalesOUT As String
        Dim strHighestSalesOUT As String
        Dim strLowestSalesOUT As String
        Dim strCommissionOUT As String
        Dim strBonusOUT As String
        Dim strSalaryOUT As String
        Dim strTotalPayOUT As String


        ' all output variables will have to be defined as class level variables 
        ' since they will have to be referenced in multiple event procedure (calculate & clear)

        ' copy textbox data to input variables

        strSalesperson = txtSalesperson.Text
        strClassificationCode = txtClassificationCode.Text
        For intMonthSales As Integer = 0 To 5
            Decimal.TryParse(txtSalesMonth(intMonthSales).Text, decMonthSales(intMonthSales))
        Next intMonthSales
        ' perform processing operations

        decTotalSales_Process = decMonthSales(0) + decMonthSales(1) + decMonthSales(2) + decMonthSales(3) + decMonthSales(4) + decMonthSales(5)

        For intHighestSale As Integer = 0 To 5
            If decMonthSales(intHighestSale) > decHighestSales_Process Then
                decHighestSales_Process = decMonthSales(intHighestSale)
                strHighestSalesMonthOUT = strHighest_LowestSale(intHighestSale)
            End If
        Next intHighestSale

        For intLowestSale As Integer = 0 To 5
            If decMonthSales(intLowestSale) < decHighestSales_Process Then
                decLowestSales_Process = decMonthSales(intLowestSale)
                strLowestSalesMonthOUT = strHighest_LowestSale(intLowestSale)
            End If
        Next intLowestSale

        If decTotalSales_Process <= decCOMMISION_TEN_PERCENT_CONDITION Then
            decCommission_Process = 0.1D
        ElseIf decTotalSales_Process > decCOMMISION_TEN_PERCENT_CONDITION And decTotalSales_Process < decCOMMISION_TWELVE_PERCENT_CONDITION Then
            decCommission_Process = 0.12D
        ElseIf decTotalSales_Process > decCOMMISION_TWELVE_PERCENT_CONDITION And decTotalSales_Process < decCOMMISION_FIFTEEN_PERCENT_CONDITION Then
            decCommission_Process = 0.15D
        ElseIf decTotalSales_Process > decCOMMISION_FIFTEEN_PERCENT_CONDITION Then
            decCommission_Process = 0.18D
        Else
            decCommission_Process = 0

        End If

        If decTotalSales_Process > intSALES_PERSON_INCREASE_CONDITION Then
            decBonus_Process = decTotalSales_Process * decBONUSRATE
        Else
            decBonus_Process = 0
        End If

        Select Case strClassificationCode
            Case "C"
                decSalary_Process = 0
                strClassificationOUT = "Commission"
            Case "c"
                decSalary_Process = 0
                strClassificationOUT = "Commission"
            Case "S"
                strClassificationOUT = "Salaried"
                decSalary_Process = 500
                decTotalPay_Process = decTotalPay_Process + intFIXED_SALARY
            Case "s"
                strClassificationOUT = "Salaried"
                decSalary_Process = 500
                decTotalPay_Process = decTotalPay_Process + intFIXED_SALARY
            Case Else
                MessageBox.Show("There are just two options [S/C]:")
                txtClassificationCode.Focus()

        End Select

        decCommission_Increase = decTotalSales_Process * decCommission_Process
        decTotalPay_Process = decCommission_Increase + decBonus_Process + decSalary_Process
        decAverageSales_Process = (decTotalSales_Process / 6)
        ' format output
        strSalaryOUT = decSalary_Process.ToString("c2")
        strTotalPayOUT = decTotalPay_Process.ToString("c2")
        strTotalSalesOUT = decTotalSales_Process.ToString("c2")
        strAverageSalesOUT = decAverageSales_Process.ToString("c2")
        strLowestSalesOUT = decLowestSales_Process.ToString("c2")
        strHighestSalesOUT = decHighestSales_Process.ToString("c2")
        strCommissionOUT = decCommission_Increase.ToString("c2")
        strBonusOUT = decBonus_Process.ToString("c2")


        ' copy output to the form
        lblClassification.Text = strClassificationOUT
        lblAverageSales.Text = strAverageSalesOUT
        lblBonus.Text = strBonusOUT
        lblCommission.Text = strCommissionOUT
        lblHighestSales.Text = strHighestSalesOUT
        lblLowestSales.Text = strLowestSalesOUT
        lblSalary.Text = strSalaryOUT
        lblTotalPay.Text = strTotalPayOUT
        lblTotalSales.Text = strTotalSalesOUT
        lblLowestSalesMonth.Text = strLowestSalesMonthOUT
        lblHighestSalesMonth.Text = strHighestSalesMonthOUT

        ' set textboxes to read only to prevent changing input data
        txtJanSales.ReadOnly = True
        txtSalesperson.ReadOnly = True
        txtClassificationCode.ReadOnly = True
        txtFebSales.ReadOnly = True
        txtJuneSales.ReadOnly = True
        txtMaySales.ReadOnly = True
        txtMarchSales.ReadOnly = True
        txtAprilSales.ReadOnly = True

        btnClearSalesperson.Enabled = True
        btnCalculate.Enabled = False
        ' set focus to clear salesperson to copy current salespersons output to listbox
        ' and clear interface to enter next salesperson's input data
        btnClearSalesperson.Focus()

    End Sub

    Private Sub frmSalespersonsPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listboxZoneConfig = "{0,-14} {1,-14} {2,-13} {3,-10} {4,-10} {5,-14} {6,-10} {7,-14} {8,-13} {9,-8} {10,-9} {11,-12}"

        lstSalespersons.Items.Add(String.Format(listboxZoneConfig, "Salesperson", "Classification", "Total Sales", "Average", "Highest", "Highest    ", "Lowest", "Lowest     ", "Commission", "Bonus   ", "Salary", "Total Pay"))
        lstSalespersons.Items.Add(String.Format(listboxZoneConfig, "           ", "              ", "           ", "Sales  ", "Sales  ", "Sales Month", "Sales ", "Sales Month", "          ", "        ", "      ", "         "))

        btnClearSalesperson.Enabled = False
        btnCalculate.Enabled = False
        btnClearListbox.Enabled = False

    End Sub

    Private Sub btnClearSalesperson_Click(sender As Object, e As EventArgs) Handles btnClearSalesperson.Click

        lstSalespersons.Items.Add(String.Format(listboxZoneConfig, txtSalesperson.Text, lblClassification.Text, lblTotalSales.Text, lblAverageSales.Text, lblHighestSales.Text, lblHighestSalesMonth.Text, lblLowestSales.Text, lblLowestSalesMonth.Text, lblCommission.Text, lblBonus.Text, lblSalary.Text, lblTotalPay.Text))

        ' clear textboxes input data
        txtFebSales.Clear()
        txtJanSales.Clear()
        txtAprilSales.Clear()
        txtMarchSales.Clear()
        txtMaySales.Clear()
        txtSalesperson.Clear()
        txtClassificationCode.Clear()
        txtJuneSales.Clear()
        ' clear output labels 
        lblAverageSales.ResetText()
        lblBonus.ResetText()
        lblClassification.ResetText()
        lblCommission.ResetText()
        lblSalary.ResetText()
        lblTotalPay.ResetText()
        lblTotalSales.ResetText()
        lblHighestSalesMonth.ResetText()
        lblHighestSales.ResetText()
        lblLowestSales.ResetText()
        lblLowestSalesMonth.ResetText()


        ' prepare textboxes to receive new data setting read only to false
        txtFebSales.ReadOnly = False
        txtJanSales.ReadOnly = False
        txtAprilSales.ReadOnly = False
        txtMarchSales.ReadOnly = False
        txtMaySales.ReadOnly = False
        txtSalesperson.ReadOnly = False
        txtClassificationCode.ReadOnly = False
        txtJuneSales.ReadOnly = False

        btnClearListbox.Enabled = True
        btnClearSalesperson.Enabled = False

    End Sub

    Private Sub btnClearListbox_Click(sender As Object, e As EventArgs) Handles btnClearListbox.Click
        ' clear the listbox
        lstSalespersons.Items.Clear()

        ' reset the listbox headings
        lstSalespersons.Items.Add(String.Format(listboxZoneConfig, "Salesperson", "Classification", "Total Sales", "Average", "Highest", "Highest    ", "Lowest", "Lowest     ", "Commission", "Bonus   ", "Salary", "Total Pay"))
        lstSalespersons.Items.Add(String.Format(listboxZoneConfig, "           ", "              ", "           ", "Sales  ", "Sales  ", "Sales Month", "Sales ", "Sales Month", "          ", "        ", "      ", "         "))

        txtSalesperson.Focus()

        btnClearListbox.Enabled = False

    End Sub

    Private Sub txtClassificationCode_Leave(sender As Object, e As EventArgs) Handles txtClassificationCode.Leave
        Dim strclassificationCode As String
        If txtClassificationCode.Text = String.Empty Then
            MessageBox.Show("Salesperson's Classification Code Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
            txtClassificationCode.Focus()
        End If

        If txtClassificationCode.Text <> "C" And txtClassificationCode.Text <> "S" And txtClassificationCode.Text <> "c" And txtClassificationCode.Text <> "s" Then
            strclassificationCode = InputBox("Salesperson's Classification code Is S or C; Please Re-enter", "Incorrect Salesperson's Classification Code")
            If strclassificationCode <> "C" And strclassificationCode <> "S" And strclassificationCode <> "c" And strclassificationCode <> "s" Then
                MessageBox.Show("Salesperson's Classification Code Is Still Incorrect", "Classification Code Error")
                txtClassificationCode.Focus()
            Else
                txtClassificationCode.Text = strclassificationCode

            End If

        End If

    End Sub

    Private Sub txtSalesperson_Leave(sender As Object, e As EventArgs) Handles txtSalesperson.Leave
        If bln_Exiting = False Then
            If txtSalesperson.Text = String.Empty Then
                txtSalesperson.Text = InputBox("Salesperson's Name Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                If txtSalesperson.Text = String.Empty Then
                    MessageBox.Show("Salesperson's Name Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                    txtSalesperson.Focus()
                End If
            End If
        End If

    End Sub
    Private Sub txtJanSales_Leave(sender As Object, e As EventArgs) Handles txtJanSales.Leave
        ' validate Jan Sales
        Const intSALES_LIMIT As Integer = 9000
        Dim decJanSales As Decimal

        Decimal.TryParse(txtJanSales.Text, decJanSales)
        If decJanSales < 0 Or decJanSales > intSALES_LIMIT Or txtJanSales.Text = "" Then
            txtJanSales.Text = InputBox("You must entry a valid value; The value has to be less than 9000; Please Re-Enter.")
            Decimal.TryParse(txtJanSales.Text, decJanSales)
            If decJanSales < 0 Or decJanSales > intSALES_LIMIT Or txtJanSales.Text = "" Then
                MessageBox.Show("The value is still incorrect; The value has to be less than 9000", "January sales entry error")
                txtJanSales.Focus()

            End If

        End If

    End Sub

    Private Sub txtFebSales_Leave(sender As Object, e As EventArgs) Handles txtFebSales.Leave
        Const intSALES_LIMIT As Integer = 9000
        Dim decFebSales As Decimal

        Decimal.TryParse(txtFebSales.Text, decFebSales)
        If decFebSales < 0 Or decFebSales > intSALES_LIMIT Or txtFebSales.Text = "" Then
            txtFebSales.Text = InputBox("You must entry a valid value; The value has to be less than 9000; Please Re-Enter.")
            Decimal.TryParse(txtFebSales.Text, decFebSales)
            If decFebSales < 0 Or decFebSales > intSALES_LIMIT Or txtFebSales.Text = "" Then
                MessageBox.Show("The value is still incorrect; The value has to be less than 9000", "January sales entry error")
                txtFebSales.Focus()

            End If

        End If

    End Sub

    Private Sub txtMarchSales_Leave(sender As Object, e As EventArgs) Handles txtMarchSales.Leave
        Const intSALES_LIMIT As Integer = 9000
        Dim decMarchSales As Decimal

        Decimal.TryParse(txtMarchSales.Text, decMarchSales)
        If decMarchSales < 0 Or decMarchSales > intSALES_LIMIT Or txtMarchSales.Text = "" Then
            txtMarchSales.Text = InputBox("You must entry a valid value; The value has to be less than 9000; Please Re-Enter.")
            Decimal.TryParse(txtMarchSales.Text, decMarchSales)
            If decMarchSales < 0 Or decMarchSales > intSALES_LIMIT Or txtMarchSales.Text = "" Then
                MessageBox.Show("The value is still incorrect; The value has to be less than 9000", "January sales entry error")
                txtMarchSales.Focus()

            End If

        End If

    End Sub

    Private Sub txtAprilSales_Leave(sender As Object, e As EventArgs) Handles txtAprilSales.Leave
        Const intSALES_LIMIT As Integer = 9000
        Dim decAprilSales As Decimal

        Decimal.TryParse(txtAprilSales.Text, decAprilSales)
        If decAprilSales < 0 Or decAprilSales > intSALES_LIMIT Or txtAprilSales.Text = "" Then
            txtAprilSales.Text = InputBox("You must entry a valid value; The value has to be less than 9000; Please Re-Enter.")
            Decimal.TryParse(txtAprilSales.Text, decAprilSales)
            If decAprilSales < 0 Or decAprilSales > intSALES_LIMIT Or txtAprilSales.Text = "" Then
                MessageBox.Show("The value is still incorrect; The value has to be less than 9000", "January sales entry error")
                txtAprilSales.Focus()


            End If

        End If

    End Sub

    Private Sub txtMaySales_Leave(sender As Object, e As EventArgs) Handles txtMaySales.Leave
        Const intSALES_LIMIT As Integer = 9000
        Dim decMaySales As Decimal

        Decimal.TryParse(txtMaySales.Text, decMaySales)
        If decMaySales < 0 Or decMaySales > intSALES_LIMIT Or txtMaySales.Text = "" Then
            txtMaySales.Text = InputBox("You must entry a valid value; The value has to be less than 9000; Please Re-Enter.")
            Decimal.TryParse(txtMaySales.Text, decMaySales)
            If decMaySales < 0 Or decMaySales > intSALES_LIMIT Or txtMaySales.Text = "" Then
                MessageBox.Show("The value is still incorrect; The value has to be less than 9000", "January sales entry error")
                txtMaySales.Focus()

            End If

        End If
        btnCalculate.Enabled = True
    End Sub

    Private Sub txtJuneSales_Leave(sender As Object, e As EventArgs) Handles txtJuneSales.Leave
        Const intSALES_LIMIT As Integer = 9000
        Dim decJuneSales As Decimal

        Decimal.TryParse(txtJuneSales.Text, decJuneSales)

        If decJuneSales < 0 Or decJuneSales > intSALES_LIMIT Or txtJuneSales.Text = "" Then
            txtJuneSales.Text = InputBox("You must entry a valid value; The value has to be less than 9000; Please Re-Enter.")
            Decimal.TryParse(txtJuneSales.Text, decJuneSales)
            If decJuneSales < 0 Or decJuneSales > intSALES_LIMIT Or txtJuneSales.Text = "" Then
                MessageBox.Show("The value is still incorrect; The value has to be less than 9000", "January sales entry error")
                txtJuneSales.Focus()


            End If

        End If
        btnCalculate.Enabled = True
        ' enable calculate button if June sales was properly entered

    End Sub

    Private Sub txtJanSales_Enter(sender As Object, e As EventArgs) Handles txtJanSales.Enter

        txtJanSales.SelectAll()
    End Sub

    Private Sub txtJuneSales_Enter(sender As Object, e As EventArgs) Handles txtJuneSales.Enter

        txtJuneSales.SelectAll()
    End Sub

    Private Sub txtMarchSales_Enter(sender As Object, e As EventArgs) Handles txtMarchSales.Enter

        txtMarchSales.SelectAll()
    End Sub

    Private Sub txtMaySales_Enter(sender As Object, e As EventArgs) Handles txtMaySales.Enter

        txtMaySales.SelectAll()
    End Sub

    Private Sub txtAprilSales_Enter(sender As Object, e As EventArgs) Handles txtAprilSales.Enter


        txtAprilSales.SelectAll()
    End Sub

    Private Sub txtClassificationCode_Enter(sender As Object, e As EventArgs) Handles txtClassificationCode.Enter

        txtClassificationCode.SelectAll()
    End Sub

    Private Sub txtSalesperson_Enter(sender As Object, e As EventArgs) Handles txtSalesperson.Enter

        txtSalesperson.SelectAll()
    End Sub

    Private Sub txtFebSales_Enter(sender As Object, e As EventArgs) Handles txtFebSales.Enter

        txtFebSales.SelectAll()
    End Sub

    Private Sub txtSalesperson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalesperson.KeyPress
        ' suppress all characters that are not letters or blank space
        If (e.KeyChar < "A" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> Chr(8) AndAlso e.KeyChar <> Chr(32) Then
            e.Handled = True
            MessageBox.Show("Invalid Character; Name May Contain Only Letters And Space(s)", "Invalid Data Entry")
        End If
    End Sub

    Private Sub txtClassificationCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClassificationCode.KeyPress
        ' suppress all characters that are not S or C
        If (e.KeyChar < "A" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("Invalid Character; Name May Contain Only Letters And Space(s)", "Invalid Data Entry")
        End If
    End Sub

    Private Sub txtJanSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJanSales.KeyPress
        ' suppress all characters that are not 0 to 9 or backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) AndAlso e.KeyChar <> Chr(46) Then
            e.Handled = True
            MessageBox.Show("Invalid Character;You cannot backspace in this textbox; it must be just digit numbers")
        End If

    End Sub

    Private Sub txtFebSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFebSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) AndAlso e.KeyChar <> Chr(46) Then
            e.Handled = True
            MessageBox.Show("Invalid Character;You cannot backspace in this textbox; it must be just digit numbers")
        End If

    End Sub

    Private Sub txtMarchSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarchSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) AndAlso e.KeyChar <> Chr(46) Then
            e.Handled = True
            MessageBox.Show("Invalid Character;You cannot backspace in this textbox; it must be just digit numbers")
        End If

    End Sub

    Private Sub txtAprilSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAprilSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) AndAlso e.KeyChar <> Chr(46) Then
            e.Handled = True
            MessageBox.Show("Invalid Character;You cannot backspace in this textbox; it must be just digit numbers")
        End If

    End Sub

    Private Sub txtMaySales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaySales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) AndAlso e.KeyChar <> Chr(46) Then
            e.Handled = True
            MessageBox.Show("Invalid Character;You cannot backspace in this textbox; it must be just digit numbers")
        End If

    End Sub

    Private Sub txtJuneSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJuneSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) AndAlso e.KeyChar <> Chr(46) Then
            e.Handled = True
            MessageBox.Show("Invalid Character;You cannot backspace in this textbox; it must be just digit numbers")
        End If

    End Sub
End Class

