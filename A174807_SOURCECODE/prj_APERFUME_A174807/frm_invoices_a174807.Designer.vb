<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoices_a174807
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoices_a174807))
        Me.INVOICE = New System.Windows.Forms.GroupBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_totalprice = New System.Windows.Forms.Label()
        Me.lbl_staffID = New System.Windows.Forms.Label()
        Me.lbl_handle = New System.Windows.Forms.Label()
        Me.grd_invoice = New System.Windows.Forms.DataGridView()
        Me.lbl_customerID = New System.Windows.Forms.Label()
        Me.lbl_custID = New System.Windows.Forms.Label()
        Me.cmb_orderid = New System.Windows.Forms.ComboBox()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_tel = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.INVOICE.SuspendLayout()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'INVOICE
        '
        Me.INVOICE.BackColor = System.Drawing.Color.MistyRose
        Me.INVOICE.Controls.Add(Me.btn_refresh)
        Me.INVOICE.Controls.Add(Me.btn_exit)
        Me.INVOICE.Controls.Add(Me.btn_back)
        Me.INVOICE.Controls.Add(Me.lbl_date)
        Me.INVOICE.Controls.Add(Me.lbl_price)
        Me.INVOICE.Controls.Add(Me.lbl_totalprice)
        Me.INVOICE.Controls.Add(Me.lbl_staffID)
        Me.INVOICE.Controls.Add(Me.lbl_handle)
        Me.INVOICE.Controls.Add(Me.grd_invoice)
        Me.INVOICE.Controls.Add(Me.lbl_customerID)
        Me.INVOICE.Controls.Add(Me.lbl_custID)
        Me.INVOICE.Controls.Add(Me.cmb_orderid)
        Me.INVOICE.Controls.Add(Me.lbl_ID)
        Me.INVOICE.Controls.Add(Me.lbl_email)
        Me.INVOICE.Controls.Add(Me.lbl_tel)
        Me.INVOICE.Controls.Add(Me.lbl_title)
        Me.INVOICE.Font = New System.Drawing.Font("Segoe UI Emoji", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INVOICE.Location = New System.Drawing.Point(0, 0)
        Me.INVOICE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.INVOICE.Name = "INVOICE"
        Me.INVOICE.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.INVOICE.Size = New System.Drawing.Size(852, 702)
        Me.INVOICE.TabIndex = 1
        Me.INVOICE.TabStop = False
        Me.INVOICE.Text = "INVOICE"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.Salmon
        Me.btn_refresh.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(487, 246)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(187, 38)
        Me.btn_refresh.TabIndex = 75
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Crimson
        Me.btn_exit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.Location = New System.Drawing.Point(636, 605)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(156, 43)
        Me.btn_exit.TabIndex = 74
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.White
        Me.btn_back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(23, 610)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(156, 38)
        Me.btn_back.TabIndex = 73
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.MistyRose
        Me.lbl_date.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_date.Location = New System.Drawing.Point(246, 546)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(143, 23)
        Me.lbl_date.TabIndex = 43
        Me.lbl_date.Text = "date and time"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_price.Location = New System.Drawing.Point(694, 494)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(115, 23)
        Me.lbl_price.TabIndex = 72
        Me.lbl_price.Text = "Total Price"
        '
        'lbl_totalprice
        '
        Me.lbl_totalprice.AutoSize = True
        Me.lbl_totalprice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalprice.Location = New System.Drawing.Point(510, 494)
        Me.lbl_totalprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_totalprice.Name = "lbl_totalprice"
        Me.lbl_totalprice.Size = New System.Drawing.Size(176, 23)
        Me.lbl_totalprice.TabIndex = 71
        Me.lbl_totalprice.Text = "Total Price (RM) :"
        '
        'lbl_staffID
        '
        Me.lbl_staffID.AutoSize = True
        Me.lbl_staffID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffID.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_staffID.Location = New System.Drawing.Point(127, 494)
        Me.lbl_staffID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.Size = New System.Drawing.Size(82, 23)
        Me.lbl_staffID.TabIndex = 70
        Me.lbl_staffID.Text = "Staff ID"
        '
        'lbl_handle
        '
        Me.lbl_handle.AutoSize = True
        Me.lbl_handle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_handle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_handle.Location = New System.Drawing.Point(28, 494)
        Me.lbl_handle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_handle.Name = "lbl_handle"
        Me.lbl_handle.Size = New System.Drawing.Size(93, 23)
        Me.lbl_handle.TabIndex = 69
        Me.lbl_handle.Text = "Staff ID :"
        '
        'grd_invoice
        '
        Me.grd_invoice.AllowUserToResizeColumns = False
        Me.grd_invoice.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink
        Me.grd_invoice.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_invoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grd_invoice.BackgroundColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_invoice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_invoice.ColumnHeadersHeight = 29
        Me.grd_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_invoice.DefaultCellStyle = DataGridViewCellStyle3
        Me.grd_invoice.GridColor = System.Drawing.Color.Black
        Me.grd_invoice.Location = New System.Drawing.Point(86, 294)
        Me.grd_invoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_invoice.Name = "grd_invoice"
        Me.grd_invoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grd_invoice.RowTemplate.Height = 28
        Me.grd_invoice.Size = New System.Drawing.Size(660, 171)
        Me.grd_invoice.TabIndex = 68
        '
        'lbl_customerID
        '
        Me.lbl_customerID.AutoSize = True
        Me.lbl_customerID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerID.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_customerID.Location = New System.Drawing.Point(366, 492)
        Me.lbl_customerID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_customerID.Name = "lbl_customerID"
        Me.lbl_customerID.Size = New System.Drawing.Size(132, 23)
        Me.lbl_customerID.TabIndex = 67
        Me.lbl_customerID.Text = "Customer ID"
        '
        'lbl_custID
        '
        Me.lbl_custID.AutoSize = True
        Me.lbl_custID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_custID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custID.Location = New System.Drawing.Point(223, 494)
        Me.lbl_custID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_custID.Name = "lbl_custID"
        Me.lbl_custID.Size = New System.Drawing.Size(143, 23)
        Me.lbl_custID.TabIndex = 66
        Me.lbl_custID.Text = "Customer ID :"
        '
        'cmb_orderid
        '
        Me.cmb_orderid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_orderid.FormattingEnabled = True
        Me.cmb_orderid.Location = New System.Drawing.Point(259, 253)
        Me.cmb_orderid.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_orderid.Name = "cmb_orderid"
        Me.cmb_orderid.Size = New System.Drawing.Size(169, 26)
        Me.cmb_orderid.TabIndex = 65
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(145, 251)
        Me.lbl_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(106, 23)
        Me.lbl_ID.TabIndex = 64
        Me.lbl_ID.Text = "Order ID :"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(195, 181)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(446, 33)
        Me.lbl_email.TabIndex = 62
        Me.lbl_email.Text = "EMAIL : a174807@siswa.ukm.edu.my"
        '
        'lbl_tel
        '
        Me.lbl_tel.AutoSize = True
        Me.lbl_tel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tel.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tel.Location = New System.Drawing.Point(299, 138)
        Me.lbl_tel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tel.Name = "lbl_tel"
        Me.lbl_tel.Size = New System.Drawing.Size(225, 33)
        Me.lbl_tel.TabIndex = 60
        Me.lbl_tel.Text = "TEL : 0184734516"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(269, 55)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(287, 66)
        Me.lbl_title.TabIndex = 57
        Me.lbl_title.Text = "APerfume"
        '
        'frm_invoices_a174807
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(833, 702)
        Me.Controls.Add(Me.INVOICE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_invoices_a174807"
        Me.Text = "APerfume - INVOICE"
        Me.INVOICE.ResumeLayout(False)
        Me.INVOICE.PerformLayout()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents INVOICE As GroupBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_totalprice As Label
    Friend WithEvents lbl_staffID As Label
    Friend WithEvents lbl_handle As Label
    Friend WithEvents grd_invoice As DataGridView
    Friend WithEvents lbl_customerID As Label
    Friend WithEvents lbl_custID As Label
    Friend WithEvents cmb_orderid As ComboBox
    Friend WithEvents lbl_ID As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_tel As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_refresh As Button
End Class
