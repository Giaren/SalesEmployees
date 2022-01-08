<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalespersonsPay
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
        Me.txtSalesperson = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblClassification = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblAverageSales = New System.Windows.Forms.Label()
        Me.lblHighestSales = New System.Windows.Forms.Label()
        Me.lblHighestSalesMonth = New System.Windows.Forms.Label()
        Me.lblLowestSales = New System.Windows.Forms.Label()
        Me.lblLowestSalesMonth = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lstSalespersons = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClearSalesperson = New System.Windows.Forms.Button()
        Me.btnClearListbox = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtClassificationCode = New System.Windows.Forms.TextBox()
        Me.txtJanSales = New System.Windows.Forms.TextBox()
        Me.txtFebSales = New System.Windows.Forms.TextBox()
        Me.txtMarchSales = New System.Windows.Forms.TextBox()
        Me.txtAprilSales = New System.Windows.Forms.TextBox()
        Me.txtMaySales = New System.Windows.Forms.TextBox()
        Me.txtJuneSales = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSalesperson
        '
        Me.txtSalesperson.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesperson.Location = New System.Drawing.Point(321, 79)
        Me.txtSalesperson.Name = "txtSalesperson"
        Me.txtSalesperson.Size = New System.Drawing.Size(200, 29)
        Me.txtSalesperson.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Salesperson:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cl&assification code:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Jan sales:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Feb sales:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "&March sales:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(215, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "&April sales:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(215, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Ma&y sales:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(215, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "&June sales:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClassification
        '
        Me.lblClassification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClassification.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassification.Location = New System.Drawing.Point(719, 79)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(148, 23)
        Me.lblClassification.TabIndex = 18
        Me.lblClassification.Text = " "
        Me.lblClassification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(719, 116)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(148, 23)
        Me.lblTotalSales.TabIndex = 20
        Me.lblTotalSales.Text = " "
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverageSales
        '
        Me.lblAverageSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSales.Location = New System.Drawing.Point(719, 150)
        Me.lblAverageSales.Name = "lblAverageSales"
        Me.lblAverageSales.Size = New System.Drawing.Size(148, 23)
        Me.lblAverageSales.TabIndex = 22
        Me.lblAverageSales.Text = " "
        Me.lblAverageSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighestSales
        '
        Me.lblHighestSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighestSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestSales.Location = New System.Drawing.Point(719, 182)
        Me.lblHighestSales.Name = "lblHighestSales"
        Me.lblHighestSales.Size = New System.Drawing.Size(148, 23)
        Me.lblHighestSales.TabIndex = 24
        Me.lblHighestSales.Text = " "
        Me.lblHighestSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighestSalesMonth
        '
        Me.lblHighestSalesMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighestSalesMonth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestSalesMonth.Location = New System.Drawing.Point(719, 214)
        Me.lblHighestSalesMonth.Name = "lblHighestSalesMonth"
        Me.lblHighestSalesMonth.Size = New System.Drawing.Size(148, 23)
        Me.lblHighestSalesMonth.TabIndex = 26
        Me.lblHighestSalesMonth.Text = " "
        Me.lblHighestSalesMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLowestSales
        '
        Me.lblLowestSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLowestSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowestSales.Location = New System.Drawing.Point(719, 246)
        Me.lblLowestSales.Name = "lblLowestSales"
        Me.lblLowestSales.Size = New System.Drawing.Size(148, 23)
        Me.lblLowestSales.TabIndex = 28
        Me.lblLowestSales.Text = " "
        Me.lblLowestSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLowestSalesMonth
        '
        Me.lblLowestSalesMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLowestSalesMonth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowestSalesMonth.Location = New System.Drawing.Point(719, 278)
        Me.lblLowestSalesMonth.Name = "lblLowestSalesMonth"
        Me.lblLowestSalesMonth.Size = New System.Drawing.Size(148, 23)
        Me.lblLowestSalesMonth.TabIndex = 30
        Me.lblLowestSalesMonth.Text = " "
        Me.lblLowestSalesMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommission.Location = New System.Drawing.Point(719, 310)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(148, 23)
        Me.lblCommission.TabIndex = 32
        Me.lblCommission.Text = "  "
        Me.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBonus
        '
        Me.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonus.Location = New System.Drawing.Point(719, 346)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(148, 23)
        Me.lblBonus.TabIndex = 34
        Me.lblBonus.Text = " "
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalary
        '
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalary.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(719, 380)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(148, 23)
        Me.lblSalary.TabIndex = 36
        Me.lblSalary.Text = " "
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPay
        '
        Me.lblTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPay.Location = New System.Drawing.Point(719, 420)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(148, 23)
        Me.lblTotalPay.TabIndex = 38
        Me.lblTotalPay.Text = " "
        Me.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(570, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 23)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Classification:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(570, 113)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(143, 23)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Total sales:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(570, 149)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 23)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Average sales:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(570, 179)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(143, 23)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Highest sales:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(546, 213)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(167, 23)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "Highest sales month:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(570, 246)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 23)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Lowest sales:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(551, 278)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(162, 23)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Lowest sales month:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(570, 310)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(143, 23)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Commission:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(570, 346)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(143, 23)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Bonus:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(570, 380)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(143, 23)
        Me.Label29.TabIndex = 35
        Me.Label29.Text = "Salary:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(570, 420)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(143, 23)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "Total pay:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstSalespersons
        '
        Me.lstSalespersons.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSalespersons.FormattingEnabled = True
        Me.lstSalespersons.ItemHeight = 15
        Me.lstSalespersons.Location = New System.Drawing.Point(37, 483)
        Me.lstSalespersons.Name = "lstSalespersons"
        Me.lstSalespersons.Size = New System.Drawing.Size(1113, 229)
        Me.lstSalespersons.TabIndex = 39
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(197, 747)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(122, 38)
        Me.btnCalculate.TabIndex = 40
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClearSalesperson
        '
        Me.btnClearSalesperson.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSalesperson.Location = New System.Drawing.Point(384, 747)
        Me.btnClearSalesperson.Name = "btnClearSalesperson"
        Me.btnClearSalesperson.Size = New System.Drawing.Size(183, 38)
        Me.btnClearSalesperson.TabIndex = 41
        Me.btnClearSalesperson.Text = "Clear &Salesperson"
        Me.btnClearSalesperson.UseVisualStyleBackColor = True
        '
        'btnClearListbox
        '
        Me.btnClearListbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearListbox.Location = New System.Drawing.Point(635, 747)
        Me.btnClearListbox.Name = "btnClearListbox"
        Me.btnClearListbox.Size = New System.Drawing.Size(165, 38)
        Me.btnClearListbox.TabIndex = 42
        Me.btnClearListbox.Text = "Clear &List Box"
        Me.btnClearListbox.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(865, 747)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 38)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtClassificationCode
        '
        Me.txtClassificationCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassificationCode.Location = New System.Drawing.Point(321, 116)
        Me.txtClassificationCode.Name = "txtClassificationCode"
        Me.txtClassificationCode.Size = New System.Drawing.Size(70, 29)
        Me.txtClassificationCode.TabIndex = 4
        '
        'txtJanSales
        '
        Me.txtJanSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJanSales.Location = New System.Drawing.Point(321, 150)
        Me.txtJanSales.Name = "txtJanSales"
        Me.txtJanSales.Size = New System.Drawing.Size(70, 29)
        Me.txtJanSales.TabIndex = 6
        '
        'txtFebSales
        '
        Me.txtFebSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFebSales.Location = New System.Drawing.Point(321, 182)
        Me.txtFebSales.Name = "txtFebSales"
        Me.txtFebSales.Size = New System.Drawing.Size(70, 29)
        Me.txtFebSales.TabIndex = 8
        '
        'txtMarchSales
        '
        Me.txtMarchSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarchSales.Location = New System.Drawing.Point(321, 214)
        Me.txtMarchSales.Name = "txtMarchSales"
        Me.txtMarchSales.Size = New System.Drawing.Size(70, 29)
        Me.txtMarchSales.TabIndex = 10
        '
        'txtAprilSales
        '
        Me.txtAprilSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAprilSales.Location = New System.Drawing.Point(321, 246)
        Me.txtAprilSales.Name = "txtAprilSales"
        Me.txtAprilSales.Size = New System.Drawing.Size(70, 29)
        Me.txtAprilSales.TabIndex = 12
        '
        'txtMaySales
        '
        Me.txtMaySales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaySales.Location = New System.Drawing.Point(321, 278)
        Me.txtMaySales.Name = "txtMaySales"
        Me.txtMaySales.Size = New System.Drawing.Size(70, 29)
        Me.txtMaySales.TabIndex = 14
        '
        'txtJuneSales
        '
        Me.txtJuneSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuneSales.Location = New System.Drawing.Point(321, 310)
        Me.txtJuneSales.Name = "txtJuneSales"
        Me.txtJuneSales.Size = New System.Drawing.Size(70, 29)
        Me.txtJuneSales.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(358, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(469, 37)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sales Employees Payroll Processing"
        '
        'frmSalespersonsPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 834)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtJuneSales)
        Me.Controls.Add(Me.txtMaySales)
        Me.Controls.Add(Me.txtAprilSales)
        Me.Controls.Add(Me.txtMarchSales)
        Me.Controls.Add(Me.txtFebSales)
        Me.Controls.Add(Me.txtJanSales)
        Me.Controls.Add(Me.txtClassificationCode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearListbox)
        Me.Controls.Add(Me.btnClearSalesperson)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstSalespersons)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.lblLowestSalesMonth)
        Me.Controls.Add(Me.lblLowestSales)
        Me.Controls.Add(Me.lblHighestSalesMonth)
        Me.Controls.Add(Me.lblHighestSales)
        Me.Controls.Add(Me.lblAverageSales)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.lblClassification)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSalesperson)
        Me.Name = "frmSalespersonsPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salespersons Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSalesperson As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblClassification As System.Windows.Forms.Label
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents lblAverageSales As System.Windows.Forms.Label
    Friend WithEvents lblHighestSales As System.Windows.Forms.Label
    Friend WithEvents lblHighestSalesMonth As System.Windows.Forms.Label
    Friend WithEvents lblLowestSales As System.Windows.Forms.Label
    Friend WithEvents lblLowestSalesMonth As System.Windows.Forms.Label
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents lblBonus As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents lblTotalPay As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lstSalespersons As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClearSalesperson As System.Windows.Forms.Button
    Friend WithEvents btnClearListbox As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtClassificationCode As TextBox
    Friend WithEvents txtJanSales As TextBox
    Friend WithEvents txtFebSales As TextBox
    Friend WithEvents txtMarchSales As TextBox
    Friend WithEvents txtAprilSales As TextBox
    Friend WithEvents txtMaySales As TextBox
    Friend WithEvents txtJuneSales As TextBox
    Friend WithEvents Label9 As Label
End Class
