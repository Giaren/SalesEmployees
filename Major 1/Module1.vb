Module Module1
    ' define textbox control array for textbox input data
    Public txtSalesMonth() As TextBox = {frmSalespersonsPay.txtJanSales, frmSalespersonsPay.txtFebSales, frmSalespersonsPay.txtMarchSales, frmSalespersonsPay.txtAprilSales, frmSalespersonsPay.txtMaySales, frmSalespersonsPay.txtJuneSales}

    Public strHighest_LowestSale() As String = {"January", "February", "March", "April", "May", "June"}
End Module
