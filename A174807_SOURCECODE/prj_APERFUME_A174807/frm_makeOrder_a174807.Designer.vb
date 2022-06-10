<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeOrder_a174807
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeOrder_a174807))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_details = New System.Windows.Forms.GroupBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.lbl_IDorder = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_staffID = New System.Windows.Forms.Label()
        Me.lbl_customerID = New System.Windows.Forms.Label()
        Me.lbl_orderID = New System.Windows.Forms.Label()
        Me.btn_neworder = New System.Windows.Forms.Button()
        Me.cmb_staffID = New System.Windows.Forms.ComboBox()
        Me.cmb_customerID = New System.Windows.Forms.ComboBox()
        Me.lbl_step1 = New System.Windows.Forms.Label()
        Me.grp_totalprice = New System.Windows.Forms.GroupBox()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.lbl_TotalRM = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_STotal = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_step3 = New System.Windows.Forms.Label()
        Me.grp_order = New System.Windows.Forms.GroupBox()
        Me.btn_addtocart = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_scent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        Me.productid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_categories = New System.Windows.Forms.TextBox()
        Me.nud_quantity = New System.Windows.Forms.NumericUpDown()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_volume = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.lbl_warranty = New System.Windows.Forms.Label()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.lbl_productID = New System.Windows.Forms.Label()
        Me.cmb_productid = New System.Windows.Forms.ComboBox()
        Me.lbl_step2 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_details.SuspendLayout()
        Me.grp_totalprice.SuspendLayout()
        Me.grp_order.SuspendLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Salmon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1474, 35)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCoral
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(633, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MAKE YOUR ORDER"
        '
        'grp_details
        '
        Me.grp_details.BackColor = System.Drawing.Color.SeaShell
        Me.grp_details.Controls.Add(Me.txt_date)
        Me.grp_details.Controls.Add(Me.lbl_IDorder)
        Me.grp_details.Controls.Add(Me.lbl_date)
        Me.grp_details.Controls.Add(Me.lbl_staffID)
        Me.grp_details.Controls.Add(Me.lbl_customerID)
        Me.grp_details.Controls.Add(Me.lbl_orderID)
        Me.grp_details.Controls.Add(Me.btn_neworder)
        Me.grp_details.Controls.Add(Me.cmb_staffID)
        Me.grp_details.Controls.Add(Me.cmb_customerID)
        Me.grp_details.Controls.Add(Me.lbl_step1)
        Me.grp_details.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_details.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_details.Location = New System.Drawing.Point(28, 84)
        Me.grp_details.Name = "grp_details"
        Me.grp_details.Size = New System.Drawing.Size(466, 319)
        Me.grp_details.TabIndex = 6
        Me.grp_details.TabStop = False
        Me.grp_details.Text = "DETAILS"
        '
        'txt_date
        '
        Me.txt_date.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(238, 225)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(203, 27)
        Me.txt_date.TabIndex = 164
        '
        'lbl_IDorder
        '
        Me.lbl_IDorder.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDorder.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_IDorder.Location = New System.Drawing.Point(233, 64)
        Me.lbl_IDorder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_IDorder.Name = "lbl_IDorder"
        Me.lbl_IDorder.Size = New System.Drawing.Size(208, 33)
        Me.lbl_IDorder.TabIndex = 93
        Me.lbl_IDorder.Text = " ID"
        Me.lbl_IDorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_date
        '
        Me.lbl_date.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_date.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(20, 221)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(192, 32)
        Me.lbl_date.TabIndex = 92
        Me.lbl_date.Text = "Date :"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_staffID
        '
        Me.lbl_staffID.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_staffID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffID.ForeColor = System.Drawing.Color.White
        Me.lbl_staffID.Location = New System.Drawing.Point(20, 172)
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.Size = New System.Drawing.Size(192, 32)
        Me.lbl_staffID.TabIndex = 91
        Me.lbl_staffID.Text = "Staff ID :"
        Me.lbl_staffID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_customerID
        '
        Me.lbl_customerID.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_customerID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerID.ForeColor = System.Drawing.Color.White
        Me.lbl_customerID.Location = New System.Drawing.Point(20, 118)
        Me.lbl_customerID.Name = "lbl_customerID"
        Me.lbl_customerID.Size = New System.Drawing.Size(192, 32)
        Me.lbl_customerID.TabIndex = 90
        Me.lbl_customerID.Text = "Customer ID :"
        Me.lbl_customerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_orderID
        '
        Me.lbl_orderID.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_orderID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderID.ForeColor = System.Drawing.Color.White
        Me.lbl_orderID.Location = New System.Drawing.Point(20, 62)
        Me.lbl_orderID.Name = "lbl_orderID"
        Me.lbl_orderID.Size = New System.Drawing.Size(192, 32)
        Me.lbl_orderID.TabIndex = 89
        Me.lbl_orderID.Text = "Order ID :"
        Me.lbl_orderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_neworder
        '
        Me.btn_neworder.BackColor = System.Drawing.Color.Salmon
        Me.btn_neworder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_neworder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_neworder.ForeColor = System.Drawing.Color.White
        Me.btn_neworder.Location = New System.Drawing.Point(133, 271)
        Me.btn_neworder.Name = "btn_neworder"
        Me.btn_neworder.Size = New System.Drawing.Size(181, 39)
        Me.btn_neworder.TabIndex = 53
        Me.btn_neworder.Text = "NEW ORDER"
        Me.btn_neworder.UseVisualStyleBackColor = False
        '
        'cmb_staffID
        '
        Me.cmb_staffID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_staffID.FormattingEnabled = True
        Me.cmb_staffID.Location = New System.Drawing.Point(238, 177)
        Me.cmb_staffID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_staffID.Name = "cmb_staffID"
        Me.cmb_staffID.Size = New System.Drawing.Size(203, 26)
        Me.cmb_staffID.TabIndex = 51
        '
        'cmb_customerID
        '
        Me.cmb_customerID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_customerID.FormattingEnabled = True
        Me.cmb_customerID.Location = New System.Drawing.Point(237, 123)
        Me.cmb_customerID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_customerID.Name = "cmb_customerID"
        Me.cmb_customerID.Size = New System.Drawing.Size(203, 26)
        Me.cmb_customerID.TabIndex = 51
        '
        'lbl_step1
        '
        Me.lbl_step1.BackColor = System.Drawing.Color.Salmon
        Me.lbl_step1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step1.ForeColor = System.Drawing.Color.White
        Me.lbl_step1.Location = New System.Drawing.Point(339, 0)
        Me.lbl_step1.Name = "lbl_step1"
        Me.lbl_step1.Size = New System.Drawing.Size(127, 30)
        Me.lbl_step1.TabIndex = 0
        Me.lbl_step1.Text = "STEP 1"
        Me.lbl_step1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_totalprice
        '
        Me.grp_totalprice.BackColor = System.Drawing.Color.SeaShell
        Me.grp_totalprice.Controls.Add(Me.btn_invoice)
        Me.grp_totalprice.Controls.Add(Me.btn_confirm)
        Me.grp_totalprice.Controls.Add(Me.lbl_TotalRM)
        Me.grp_totalprice.Controls.Add(Me.lbl_total)
        Me.grp_totalprice.Controls.Add(Me.lbl_STotal)
        Me.grp_totalprice.Controls.Add(Me.lbl_subtotal)
        Me.grp_totalprice.Controls.Add(Me.lbl_step3)
        Me.grp_totalprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_totalprice.Location = New System.Drawing.Point(28, 429)
        Me.grp_totalprice.Name = "grp_totalprice"
        Me.grp_totalprice.Size = New System.Drawing.Size(466, 286)
        Me.grp_totalprice.TabIndex = 95
        Me.grp_totalprice.TabStop = False
        Me.grp_totalprice.Text = "TOTAL PRICE "
        '
        'btn_invoice
        '
        Me.btn_invoice.BackColor = System.Drawing.Color.LightSalmon
        Me.btn_invoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.ForeColor = System.Drawing.Color.Black
        Me.btn_invoice.Location = New System.Drawing.Point(243, 211)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(198, 39)
        Me.btn_invoice.TabIndex = 94
        Me.btn_invoice.Text = "INVOICE"
        Me.btn_invoice.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.Salmon
        Me.btn_confirm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.White
        Me.btn_confirm.Location = New System.Drawing.Point(13, 211)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(199, 39)
        Me.btn_confirm.TabIndex = 108
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'lbl_TotalRM
        '
        Me.lbl_TotalRM.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalRM.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_TotalRM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_TotalRM.Location = New System.Drawing.Point(228, 134)
        Me.lbl_TotalRM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_TotalRM.Name = "lbl_TotalRM"
        Me.lbl_TotalRM.Size = New System.Drawing.Size(194, 33)
        Me.lbl_TotalRM.TabIndex = 55
        Me.lbl_TotalRM.Text = "TOTAL"
        Me.lbl_TotalRM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(44, 139)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(151, 28)
        Me.lbl_total.TabIndex = 54
        Me.lbl_total.Text = "TOTAL (RM)"
        '
        'lbl_STotal
        '
        Me.lbl_STotal.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_STotal.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_STotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_STotal.Location = New System.Drawing.Point(232, 77)
        Me.lbl_STotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_STotal.Name = "lbl_STotal"
        Me.lbl_STotal.Size = New System.Drawing.Size(190, 33)
        Me.lbl_STotal.TabIndex = 53
        Me.lbl_STotal.Text = "SUBTOTAL"
        Me.lbl_STotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(22, 82)
        Me.lbl_subtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(202, 28)
        Me.lbl_subtotal.TabIndex = 52
        Me.lbl_subtotal.Text = "SUBTOTAL (RM)"
        '
        'lbl_step3
        '
        Me.lbl_step3.BackColor = System.Drawing.Color.Salmon
        Me.lbl_step3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step3.ForeColor = System.Drawing.Color.White
        Me.lbl_step3.Location = New System.Drawing.Point(339, 0)
        Me.lbl_step3.Name = "lbl_step3"
        Me.lbl_step3.Size = New System.Drawing.Size(127, 30)
        Me.lbl_step3.TabIndex = 7
        Me.lbl_step3.Text = "STEP 3"
        Me.lbl_step3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_order
        '
        Me.grp_order.BackColor = System.Drawing.Color.SeaShell
        Me.grp_order.Controls.Add(Me.btn_addtocart)
        Me.grp_order.Controls.Add(Me.btn_remove)
        Me.grp_order.Controls.Add(Me.pic_product)
        Me.grp_order.Controls.Add(Me.txt_type)
        Me.grp_order.Controls.Add(Me.txt_scent)
        Me.grp_order.Controls.Add(Me.Label3)
        Me.grp_order.Controls.Add(Me.Label2)
        Me.grp_order.Controls.Add(Me.grd_orderdetails)
        Me.grp_order.Controls.Add(Me.txt_categories)
        Me.grp_order.Controls.Add(Me.nud_quantity)
        Me.grp_order.Controls.Add(Me.lbl_quantity)
        Me.grp_order.Controls.Add(Me.btn_search)
        Me.grp_order.Controls.Add(Me.txt_volume)
        Me.grp_order.Controls.Add(Me.txt_brand)
        Me.grp_order.Controls.Add(Me.txt_price)
        Me.grp_order.Controls.Add(Me.txt_productname)
        Me.grp_order.Controls.Add(Me.lbl_warranty)
        Me.grp_order.Controls.Add(Me.lbl_weight)
        Me.grp_order.Controls.Add(Me.lbl_brand)
        Me.grp_order.Controls.Add(Me.lbl_price)
        Me.grp_order.Controls.Add(Me.lbl_productname)
        Me.grp_order.Controls.Add(Me.lbl_productID)
        Me.grp_order.Controls.Add(Me.cmb_productid)
        Me.grp_order.Controls.Add(Me.lbl_step2)
        Me.grp_order.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_order.Location = New System.Drawing.Point(520, 84)
        Me.grp_order.Name = "grp_order"
        Me.grp_order.Size = New System.Drawing.Size(925, 726)
        Me.grp_order.TabIndex = 96
        Me.grp_order.TabStop = False
        Me.grp_order.Text = "ORDER"
        '
        'btn_addtocart
        '
        Me.btn_addtocart.BackColor = System.Drawing.Color.Salmon
        Me.btn_addtocart.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtocart.ForeColor = System.Drawing.Color.White
        Me.btn_addtocart.Location = New System.Drawing.Point(325, 530)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(179, 41)
        Me.btn_addtocart.TabIndex = 99
        Me.btn_addtocart.Text = "ADD TO CART"
        Me.btn_addtocart.UseVisualStyleBackColor = False
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.Crimson
        Me.btn_remove.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.ForeColor = System.Drawing.Color.White
        Me.btn_remove.Location = New System.Drawing.Point(613, 530)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(179, 41)
        Me.btn_remove.TabIndex = 99
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.LightPink
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(641, 141)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(204, 278)
        Me.pic_product.TabIndex = 164
        Me.pic_product.TabStop = False
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(260, 374)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(291, 27)
        Me.txt_type.TabIndex = 163
        Me.txt_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_scent
        '
        Me.txt_scent.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_scent.Location = New System.Drawing.Point(259, 426)
        Me.txt_scent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_scent.Name = "txt_scent"
        Me.txt_scent.Size = New System.Drawing.Size(383, 27)
        Me.txt_scent.TabIndex = 162
        Me.txt_scent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightCoral
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 33)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Type :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightCoral
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 33)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Scent :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grd_orderdetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_orderdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderdetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_orderdetails.BackgroundColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_orderdetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productid, Me.quantity, Me.price})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Salmon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_orderdetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.grd_orderdetails.GridColor = System.Drawing.Color.Black
        Me.grd_orderdetails.Location = New System.Drawing.Point(16, 578)
        Me.grd_orderdetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.ReadOnly = True
        Me.grd_orderdetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grd_orderdetails.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grd_orderdetails.Size = New System.Drawing.Size(889, 139)
        Me.grd_orderdetails.TabIndex = 159
        '
        'productid
        '
        Me.productid.HeaderText = "PRODUCT ID"
        Me.productid.MinimumWidth = 6
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "QUANTITY"
        Me.quantity.MinimumWidth = 6
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "PRICE (RM)"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'txt_categories
        '
        Me.txt_categories.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_categories.Location = New System.Drawing.Point(260, 326)
        Me.txt_categories.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_categories.Name = "txt_categories"
        Me.txt_categories.Size = New System.Drawing.Size(291, 27)
        Me.txt_categories.TabIndex = 155
        Me.txt_categories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nud_quantity
        '
        Me.nud_quantity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_quantity.Location = New System.Drawing.Point(381, 483)
        Me.nud_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.nud_quantity.Name = "nud_quantity"
        Me.nud_quantity.Size = New System.Drawing.Size(204, 26)
        Me.nud_quantity.TabIndex = 154
        '
        'lbl_quantity
        '
        Me.lbl_quantity.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_quantity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.White
        Me.lbl_quantity.Location = New System.Drawing.Point(46, 481)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(306, 33)
        Me.lbl_quantity.TabIndex = 103
        Me.lbl_quantity.Text = "Quantity :"
        Me.lbl_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Salmon
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(571, 65)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(333, 39)
        Me.btn_search.TabIndex = 102
        Me.btn_search.Text = "SHOW PRODUCT DETAILS"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_volume
        '
        Me.txt_volume.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_volume.Location = New System.Drawing.Point(260, 274)
        Me.txt_volume.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_volume.Name = "txt_volume"
        Me.txt_volume.Size = New System.Drawing.Size(291, 27)
        Me.txt_volume.TabIndex = 99
        Me.txt_volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(260, 225)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(291, 27)
        Me.txt_brand.TabIndex = 97
        Me.txt_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(260, 179)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(291, 27)
        Me.txt_price.TabIndex = 96
        Me.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_productname
        '
        Me.txt_productname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productname.Location = New System.Drawing.Point(260, 129)
        Me.txt_productname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.Size = New System.Drawing.Size(291, 27)
        Me.txt_productname.TabIndex = 95
        Me.txt_productname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_warranty
        '
        Me.lbl_warranty.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_warranty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_warranty.ForeColor = System.Drawing.Color.White
        Me.lbl_warranty.Location = New System.Drawing.Point(47, 322)
        Me.lbl_warranty.Name = "lbl_warranty"
        Me.lbl_warranty.Size = New System.Drawing.Size(188, 33)
        Me.lbl_warranty.TabIndex = 93
        Me.lbl_warranty.Text = "Category :"
        Me.lbl_warranty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_weight
        '
        Me.lbl_weight.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_weight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_weight.ForeColor = System.Drawing.Color.White
        Me.lbl_weight.Location = New System.Drawing.Point(47, 270)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(188, 33)
        Me.lbl_weight.TabIndex = 92
        Me.lbl_weight.Text = "Volume :"
        Me.lbl_weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_brand
        '
        Me.lbl_brand.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_brand.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.Color.White
        Me.lbl_brand.Location = New System.Drawing.Point(47, 222)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(192, 33)
        Me.lbl_brand.TabIndex = 91
        Me.lbl_brand.Text = "Product Brand :"
        Me.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_price
        '
        Me.lbl_price.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_price.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.White
        Me.lbl_price.Location = New System.Drawing.Point(47, 174)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(192, 34)
        Me.lbl_price.TabIndex = 90
        Me.lbl_price.Text = "Product Price (RM):"
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_productname
        '
        Me.lbl_productname.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_productname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.ForeColor = System.Drawing.Color.White
        Me.lbl_productname.Location = New System.Drawing.Point(47, 123)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(192, 34)
        Me.lbl_productname.TabIndex = 89
        Me.lbl_productname.Text = "Product Name :"
        Me.lbl_productname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_productID
        '
        Me.lbl_productID.BackColor = System.Drawing.Color.LightCoral
        Me.lbl_productID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productID.ForeColor = System.Drawing.Color.White
        Me.lbl_productID.Location = New System.Drawing.Point(47, 65)
        Me.lbl_productID.Name = "lbl_productID"
        Me.lbl_productID.Size = New System.Drawing.Size(192, 32)
        Me.lbl_productID.TabIndex = 88
        Me.lbl_productID.Text = "Product ID :"
        Me.lbl_productID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_productid
        '
        Me.cmb_productid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_productid.FormattingEnabled = True
        Me.cmb_productid.Location = New System.Drawing.Point(260, 64)
        Me.cmb_productid.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_productid.Name = "cmb_productid"
        Me.cmb_productid.Size = New System.Drawing.Size(203, 26)
        Me.cmb_productid.TabIndex = 87
        '
        'lbl_step2
        '
        Me.lbl_step2.BackColor = System.Drawing.Color.Salmon
        Me.lbl_step2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step2.ForeColor = System.Drawing.Color.White
        Me.lbl_step2.Location = New System.Drawing.Point(795, 0)
        Me.lbl_step2.Name = "lbl_step2"
        Me.lbl_step2.Size = New System.Drawing.Size(130, 30)
        Me.lbl_step2.TabIndex = 1
        Me.lbl_step2.Text = "STEP 2"
        Me.lbl_step2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Salmon
        Me.btn_back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(41, 751)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(179, 41)
        Me.btn_back.TabIndex = 97
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Crimson
        Me.btn_exit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.Location = New System.Drawing.Point(271, 751)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(179, 41)
        Me.btn_exit.TabIndex = 98
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'frm_makeOrder_a174807
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_APERFUME_A174807.My.Resources.Resources.rename
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1473, 827)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grp_order)
        Me.Controls.Add(Me.grp_totalprice)
        Me.Controls.Add(Me.grp_details)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_makeOrder_a174807"
        Me.Text = "APerfume - MAKE ORDER"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_details.ResumeLayout(False)
        Me.grp_details.PerformLayout()
        Me.grp_totalprice.ResumeLayout(False)
        Me.grp_totalprice.PerformLayout()
        Me.grp_order.ResumeLayout(False)
        Me.grp_order.PerformLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grp_details As GroupBox
    Friend WithEvents lbl_IDorder As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_staffID As Label
    Friend WithEvents lbl_customerID As Label
    Friend WithEvents lbl_orderID As Label
    Friend WithEvents btn_neworder As Button
    Friend WithEvents cmb_staffID As ComboBox
    Friend WithEvents cmb_customerID As ComboBox
    Friend WithEvents lbl_step1 As Label
    Friend WithEvents grp_totalprice As GroupBox
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents lbl_TotalRM As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_STotal As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_step3 As Label
    Friend WithEvents grp_order As GroupBox
    Friend WithEvents grd_orderdetails As DataGridView
    Friend WithEvents productid As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents txt_categories As TextBox
    Friend WithEvents nud_quantity As NumericUpDown
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_volume As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents lbl_warranty As Label
    Friend WithEvents lbl_weight As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_productname As Label
    Friend WithEvents lbl_productID As Label
    Friend WithEvents cmb_productid As ComboBox
    Friend WithEvents lbl_step2 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_scent As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_addtocart As Button
End Class
