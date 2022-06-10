<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products_a174807
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_products_a174807))
        Me.Cust_Label1 = New System.Windows.Forms.Label()
        Me.Cust_Label2 = New System.Windows.Forms.Label()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ThankYouLabel = New System.Windows.Forms.Label()
        Me.Exit_btn = New System.Windows.Forms.Button()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cust_Label1
        '
        Me.Cust_Label1.AutoSize = True
        Me.Cust_Label1.BackColor = System.Drawing.Color.Transparent
        Me.Cust_Label1.Font = New System.Drawing.Font("Forte", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_Label1.Location = New System.Drawing.Point(33, 31)
        Me.Cust_Label1.Name = "Cust_Label1"
        Me.Cust_Label1.Size = New System.Drawing.Size(153, 36)
        Me.Cust_Label1.TabIndex = 3
        Me.Cust_Label1.Text = "APerfume"
        '
        'Cust_Label2
        '
        Me.Cust_Label2.AutoSize = True
        Me.Cust_Label2.BackColor = System.Drawing.Color.Transparent
        Me.Cust_Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_Label2.Location = New System.Drawing.Point(35, 79)
        Me.Cust_Label2.Name = "Cust_Label2"
        Me.Cust_Label2.Size = New System.Drawing.Size(204, 24)
        Me.Cust_Label2.TabIndex = 6
        Me.Cust_Label2.Text = "Products Informations : "
        '
        'grd_products
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grd_products.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_products.BackgroundColor = System.Drawing.Color.Ivory
        Me.grd_products.ColumnHeadersHeight = 29
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_products.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_products.Location = New System.Drawing.Point(13, 114)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(998, 309)
        Me.grd_products.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GhostWhite
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ThankYouLabel
        '
        Me.ThankYouLabel.AutoSize = True
        Me.ThankYouLabel.BackColor = System.Drawing.Color.Transparent
        Me.ThankYouLabel.Font = New System.Drawing.Font("Lucida Calligraphy", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThankYouLabel.Location = New System.Drawing.Point(312, 463)
        Me.ThankYouLabel.Name = "ThankYouLabel"
        Me.ThankYouLabel.Size = New System.Drawing.Size(379, 19)
        Me.ThankYouLabel.TabIndex = 13
        Me.ThankYouLabel.Text = "**Thank You For Dealing With APerfume**"
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.GhostWhite
        Me.Exit_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.Location = New System.Drawing.Point(911, 448)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(80, 34)
        Me.Exit_btn.TabIndex = 14
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'frm_products_a174807
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_APERFUME_A174807.My.Resources.Resources.rename
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1023, 505)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.ThankYouLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.Cust_Label2)
        Me.Controls.Add(Me.Cust_Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_products_a174807"
        Me.Text = "APerfume - PRODUCTS"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cust_Label1 As Label
    Friend WithEvents Cust_Label2 As Label
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ThankYouLabel As Label
    Friend WithEvents Exit_btn As Button
End Class
