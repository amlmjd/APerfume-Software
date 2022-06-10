<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_orderslist_a174807
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderslist_a174807))
        Me.Cust_Label1 = New System.Windows.Forms.Label()
        Me.Cust_Label2 = New System.Windows.Forms.Label()
        Me.ThankYouLabel = New System.Windows.Forms.Label()
        Me.grd_orders = New System.Windows.Forms.DataGridView()
        Me.Back_btnOrders = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.btn_makeOrder = New System.Windows.Forms.Button()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cust_Label1
        '
        Me.Cust_Label1.AutoSize = True
        Me.Cust_Label1.BackColor = System.Drawing.Color.Transparent
        Me.Cust_Label1.Font = New System.Drawing.Font("Forte", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_Label1.Location = New System.Drawing.Point(31, 29)
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
        Me.Cust_Label2.Location = New System.Drawing.Point(33, 78)
        Me.Cust_Label2.Name = "Cust_Label2"
        Me.Cust_Label2.Size = New System.Drawing.Size(186, 24)
        Me.Cust_Label2.TabIndex = 6
        Me.Cust_Label2.Text = "Orders Informations : "
        '
        'ThankYouLabel
        '
        Me.ThankYouLabel.AutoSize = True
        Me.ThankYouLabel.BackColor = System.Drawing.Color.Transparent
        Me.ThankYouLabel.Font = New System.Drawing.Font("Lucida Calligraphy", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThankYouLabel.Location = New System.Drawing.Point(195, 319)
        Me.ThankYouLabel.Name = "ThankYouLabel"
        Me.ThankYouLabel.Size = New System.Drawing.Size(379, 19)
        Me.ThankYouLabel.TabIndex = 13
        Me.ThankYouLabel.Text = "**Thank You For Dealing With APerfume**"
        '
        'grd_orders
        '
        Me.grd_orders.AllowUserToResizeColumns = False
        Me.grd_orders.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grd_orders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_orders.BackgroundColor = System.Drawing.Color.Ivory
        Me.grd_orders.ColumnHeadersHeight = 29
        Me.grd_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_orders.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_orders.GridColor = System.Drawing.Color.Black
        Me.grd_orders.Location = New System.Drawing.Point(108, 113)
        Me.grd_orders.Name = "grd_orders"
        Me.grd_orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grd_orders.RowTemplate.Height = 24
        Me.grd_orders.Size = New System.Drawing.Size(589, 149)
        Me.grd_orders.TabIndex = 14
        '
        'Back_btnOrders
        '
        Me.Back_btnOrders.BackColor = System.Drawing.Color.GhostWhite
        Me.Back_btnOrders.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_btnOrders.Location = New System.Drawing.Point(25, 282)
        Me.Back_btnOrders.Name = "Back_btnOrders"
        Me.Back_btnOrders.Size = New System.Drawing.Size(80, 34)
        Me.Back_btnOrders.TabIndex = 15
        Me.Back_btnOrders.Text = "Back"
        Me.Back_btnOrders.UseVisualStyleBackColor = False
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.GhostWhite
        Me.Exit_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.Location = New System.Drawing.Point(689, 282)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(80, 34)
        Me.Exit_btn.TabIndex = 16
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'btn_makeOrder
        '
        Me.btn_makeOrder.BackColor = System.Drawing.Color.Salmon
        Me.btn_makeOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_makeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeOrder.ForeColor = System.Drawing.Color.White
        Me.btn_makeOrder.Location = New System.Drawing.Point(432, 46)
        Me.btn_makeOrder.Name = "btn_makeOrder"
        Me.btn_makeOrder.Size = New System.Drawing.Size(337, 42)
        Me.btn_makeOrder.TabIndex = 52
        Me.btn_makeOrder.Text = "Make New Order"
        Me.btn_makeOrder.UseVisualStyleBackColor = False
        '
        'frm_orderslist_a174807
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_APERFUME_A174807.My.Resources.Resources.rename
        Me.ClientSize = New System.Drawing.Size(800, 347)
        Me.Controls.Add(Me.btn_makeOrder)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Back_btnOrders)
        Me.Controls.Add(Me.grd_orders)
        Me.Controls.Add(Me.ThankYouLabel)
        Me.Controls.Add(Me.Cust_Label2)
        Me.Controls.Add(Me.Cust_Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_orderslist_a174807"
        Me.Text = "APerfume - ORDER LIST"
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cust_Label1 As Label
    Friend WithEvents Cust_Label2 As Label
    Friend WithEvents ThankYouLabel As Label
    Friend WithEvents grd_orders As DataGridView
    Friend WithEvents Back_btnOrders As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents btn_makeOrder As Button
End Class
