<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_a174807
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoice_a174807))
        Me.pnl_totalreceipt = New System.Windows.Forms.Panel()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_tel = New System.Windows.Forms.Label()
        Me.lbl_receipt = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_shop = New System.Windows.Forms.Label()
        Me.lbl_PDate = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_custid = New System.Windows.Forms.Label()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_idorder = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_totalRM = New System.Windows.Forms.Label()
        Me.lbl_idstaff = New System.Windows.Forms.Label()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.pnl_totalreceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_totalreceipt
        '
        Me.pnl_totalreceipt.BackColor = System.Drawing.Color.Salmon
        Me.pnl_totalreceipt.Controls.Add(Me.lbl_email)
        Me.pnl_totalreceipt.Controls.Add(Me.lbl_title)
        Me.pnl_totalreceipt.Controls.Add(Me.lbl_tel)
        Me.pnl_totalreceipt.Controls.Add(Me.lbl_receipt)
        Me.pnl_totalreceipt.Location = New System.Drawing.Point(17, 25)
        Me.pnl_totalreceipt.Margin = New System.Windows.Forms.Padding(4)
        Me.pnl_totalreceipt.Name = "pnl_totalreceipt"
        Me.pnl_totalreceipt.Size = New System.Drawing.Size(483, 115)
        Me.pnl_totalreceipt.TabIndex = 111
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(117, 89)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(257, 16)
        Me.lbl_email.TabIndex = 65
        Me.lbl_email.Text = "EMAIL : a174807@siswa.ukm.edu.my"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Forte", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(185, 43)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(120, 26)
        Me.lbl_title.TabIndex = 58
        Me.lbl_title.Text = "APerfume"
        '
        'lbl_tel
        '
        Me.lbl_tel.AutoSize = True
        Me.lbl_tel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tel.Location = New System.Drawing.Point(179, 73)
        Me.lbl_tel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tel.Name = "lbl_tel"
        Me.lbl_tel.Size = New System.Drawing.Size(126, 16)
        Me.lbl_tel.TabIndex = 63
        Me.lbl_tel.Text = "TEL : 0184734516"
        '
        'lbl_receipt
        '
        Me.lbl_receipt.AutoSize = True
        Me.lbl_receipt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_receipt.ForeColor = System.Drawing.Color.White
        Me.lbl_receipt.Location = New System.Drawing.Point(126, 8)
        Me.lbl_receipt.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_receipt.Name = "lbl_receipt"
        Me.lbl_receipt.Size = New System.Drawing.Size(244, 32)
        Me.lbl_receipt.TabIndex = 22
        Me.lbl_receipt.Text = "Receipt / Invoice"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 510)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(445, 22)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "THANK YOU FOR SHOPPING WITH APERFUME"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_shop
        '
        Me.lbl_shop.AutoSize = True
        Me.lbl_shop.Font = New System.Drawing.Font("Forte", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shop.Location = New System.Drawing.Point(174, 456)
        Me.lbl_shop.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_shop.Name = "lbl_shop"
        Me.lbl_shop.Size = New System.Drawing.Size(176, 41)
        Me.lbl_shop.TabIndex = 121
        Me.lbl_shop.Text = "APerfume"
        Me.lbl_shop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_PDate
        '
        Me.lbl_PDate.AutoSize = True
        Me.lbl_PDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PDate.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_PDate.Location = New System.Drawing.Point(155, 319)
        Me.lbl_PDate.Name = "lbl_PDate"
        Me.lbl_PDate.Size = New System.Drawing.Size(167, 23)
        Me.lbl_PDate.TabIndex = 132
        Me.lbl_PDate.Text = "Date Purchased"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(164, 291)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(178, 23)
        Me.lbl_date.TabIndex = 131
        Me.lbl_date.Text = "Date Purchased :"
        '
        'lbl_custid
        '
        Me.lbl_custid.AutoSize = True
        Me.lbl_custid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custid.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_custid.Location = New System.Drawing.Point(272, 253)
        Me.lbl_custid.Name = "lbl_custid"
        Me.lbl_custid.Size = New System.Drawing.Size(132, 23)
        Me.lbl_custid.TabIndex = 130
        Me.lbl_custid.Text = "Customer ID"
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_staffid.Location = New System.Drawing.Point(272, 218)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(82, 23)
        Me.lbl_staffid.TabIndex = 129
        Me.lbl_staffid.Text = "Staff ID"
        '
        'lbl_idorder
        '
        Me.lbl_idorder.AutoSize = True
        Me.lbl_idorder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idorder.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_idorder.Location = New System.Drawing.Point(272, 182)
        Me.lbl_idorder.Name = "lbl_idorder"
        Me.lbl_idorder.Size = New System.Drawing.Size(95, 23)
        Me.lbl_idorder.TabIndex = 128
        Me.lbl_idorder.Text = "Order ID"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_total.Location = New System.Drawing.Point(271, 382)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(92, 28)
        Me.lbl_total.TabIndex = 127
        Me.lbl_total.Text = "TOTAL"
        '
        'lbl_totalRM
        '
        Me.lbl_totalRM.AutoSize = True
        Me.lbl_totalRM.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalRM.Location = New System.Drawing.Point(134, 382)
        Me.lbl_totalRM.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_totalRM.Name = "lbl_totalRM"
        Me.lbl_totalRM.Size = New System.Drawing.Size(127, 28)
        Me.lbl_totalRM.TabIndex = 126
        Me.lbl_totalRM.Text = "Total : RM"
        '
        'lbl_idstaff
        '
        Me.lbl_idstaff.AutoSize = True
        Me.lbl_idstaff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idstaff.Location = New System.Drawing.Point(164, 218)
        Me.lbl_idstaff.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_idstaff.Name = "lbl_idstaff"
        Me.lbl_idstaff.Size = New System.Drawing.Size(93, 23)
        Me.lbl_idstaff.TabIndex = 125
        Me.lbl_idstaff.Text = "Staff ID :"
        '
        'lbl_customerid
        '
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.Location = New System.Drawing.Point(113, 253)
        Me.lbl_customerid.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(143, 23)
        Me.lbl_customerid.TabIndex = 124
        Me.lbl_customerid.Text = "Customer ID :"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(150, 182)
        Me.lbl_orderid.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(106, 23)
        Me.lbl_orderid.TabIndex = 123
        Me.lbl_orderid.Text = "Order ID :"
        '
        'frm_invoice_a174807
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(515, 564)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_shop)
        Me.Controls.Add(Me.lbl_PDate)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_custid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.lbl_idorder)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_totalRM)
        Me.Controls.Add(Me.lbl_idstaff)
        Me.Controls.Add(Me.lbl_customerid)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.pnl_totalreceipt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_invoice_a174807"
        Me.Text = "INVOICE"
        Me.pnl_totalreceipt.ResumeLayout(False)
        Me.pnl_totalreceipt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnl_totalreceipt As Panel
    Friend WithEvents lbl_receipt As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_shop As Label
    Friend WithEvents lbl_PDate As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_custid As Label
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_idorder As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_totalRM As Label
    Friend WithEvents lbl_idstaff As Label
    Friend WithEvents lbl_customerid As Label
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_tel As Label
End Class
