<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_catalogue_a174807
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_catalogue_a174807))
        Me.Cust_Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lst_products = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cust_Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Category = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_Vol = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_scent = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.ThankYouLabel = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cust_Label1
        '
        Me.Cust_Label1.AutoSize = True
        Me.Cust_Label1.BackColor = System.Drawing.Color.Transparent
        Me.Cust_Label1.Font = New System.Drawing.Font("Forte", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_Label1.Location = New System.Drawing.Point(33, 25)
        Me.Cust_Label1.Name = "Cust_Label1"
        Me.Cust_Label1.Size = New System.Drawing.Size(153, 36)
        Me.Cust_Label1.TabIndex = 12
        Me.Cust_Label1.Text = "APerfume"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Select a Product ID :"
        '
        'lst_products
        '
        Me.lst_products.BackColor = System.Drawing.Color.White
        Me.lst_products.FormattingEnabled = True
        Me.lst_products.ItemHeight = 16
        Me.lst_products.Location = New System.Drawing.Point(23, 106)
        Me.lst_products.Name = "lst_products"
        Me.lst_products.Size = New System.Drawing.Size(185, 292)
        Me.lst_products.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GhostWhite
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(39, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 34)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cust_Label2
        '
        Me.Cust_Label2.AutoSize = True
        Me.Cust_Label2.BackColor = System.Drawing.Color.Transparent
        Me.Cust_Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_Label2.Location = New System.Drawing.Point(414, 37)
        Me.Cust_Label2.Name = "Cust_Label2"
        Me.Cust_Label2.Size = New System.Drawing.Size(204, 24)
        Me.Cust_Label2.TabIndex = 27
        Me.Cust_Label2.Text = "Products Informations : "
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.White
        Me.txt_name.Location = New System.Drawing.Point(234, 117)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(173, 22)
        Me.txt_name.TabIndex = 29
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Name"
        '
        'txt_Category
        '
        Me.txt_Category.BackColor = System.Drawing.Color.White
        Me.txt_Category.Location = New System.Drawing.Point(234, 215)
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.ReadOnly = True
        Me.txt_Category.Size = New System.Drawing.Size(173, 22)
        Me.txt_Category.TabIndex = 31
        Me.txt_Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Category"
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.Color.White
        Me.txt_price.Location = New System.Drawing.Point(462, 117)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(107, 22)
        Me.txt_price.TabIndex = 33
        Me.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Vol
        '
        Me.txt_Vol.BackColor = System.Drawing.Color.White
        Me.txt_Vol.Location = New System.Drawing.Point(462, 215)
        Me.txt_Vol.Name = "txt_Vol"
        Me.txt_Vol.ReadOnly = True
        Me.txt_Vol.Size = New System.Drawing.Size(107, 22)
        Me.txt_Vol.TabIndex = 34
        Me.txt_Vol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_brand
        '
        Me.txt_brand.BackColor = System.Drawing.Color.White
        Me.txt_brand.Location = New System.Drawing.Point(620, 117)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(136, 22)
        Me.txt_brand.TabIndex = 35
        Me.txt_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_type
        '
        Me.txt_type.BackColor = System.Drawing.Color.White
        Me.txt_type.Location = New System.Drawing.Point(620, 215)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(136, 22)
        Me.txt_type.TabIndex = 36
        Me.txt_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(495, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(484, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Volume"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(660, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Brand"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(660, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Type"
        '
        'txt_scent
        '
        Me.txt_scent.BackColor = System.Drawing.Color.White
        Me.txt_scent.Location = New System.Drawing.Point(331, 306)
        Me.txt_scent.Name = "txt_scent"
        Me.txt_scent.ReadOnly = True
        Me.txt_scent.Size = New System.Drawing.Size(372, 22)
        Me.txt_scent.TabIndex = 41
        Me.txt_scent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Scent Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(484, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Stock"
        '
        'txt_stock
        '
        Me.txt_stock.BackColor = System.Drawing.Color.White
        Me.txt_stock.Location = New System.Drawing.Point(453, 367)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.ReadOnly = True
        Me.txt_stock.Size = New System.Drawing.Size(107, 22)
        Me.txt_stock.TabIndex = 44
        Me.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ThankYouLabel
        '
        Me.ThankYouLabel.AutoSize = True
        Me.ThankYouLabel.BackColor = System.Drawing.Color.Transparent
        Me.ThankYouLabel.Font = New System.Drawing.Font("Lucida Calligraphy", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThankYouLabel.Location = New System.Drawing.Point(327, 463)
        Me.ThankYouLabel.Name = "ThankYouLabel"
        Me.ThankYouLabel.Size = New System.Drawing.Size(379, 19)
        Me.ThankYouLabel.TabIndex = 45
        Me.ThankYouLabel.Text = "**Thank You For Dealing With APerfume**"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("FIFA Welcome", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lbl_date.Location = New System.Drawing.Point(414, 438)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(41, 19)
        Me.lbl_date.TabIndex = 46
        Me.lbl_date.Text = "Date"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.LightPink
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(792, 86)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(204, 278)
        Me.pic_product.TabIndex = 47
        Me.pic_product.TabStop = False
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.Location = New System.Drawing.Point(837, 376)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(107, 22)
        Me.txt_id.TabIndex = 48
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(848, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Product ID"
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.GhostWhite
        Me.Exit_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.Location = New System.Drawing.Point(916, 435)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(80, 34)
        Me.Exit_btn.TabIndex = 50
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.Salmon
        Me.btn_refresh.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(800, 30)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(187, 38)
        Me.btn_refresh.TabIndex = 77
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'frm_catalogue_a174807
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_APERFUME_A174807.My.Resources.Resources.rename
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1023, 505)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.ThankYouLabel)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_scent)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_Vol)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Category)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Cust_Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lst_products)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Cust_Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_catalogue_a174807"
        Me.Text = "APerfume - CATALOGUE"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cust_Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lst_products As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Cust_Label2 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Category As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_Vol As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_scent As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents ThankYouLabel As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Exit_btn As Button
    Friend WithEvents btn_refresh As Button
End Class
