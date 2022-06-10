<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_receipts_a174807
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_receipts_a174807))
        Me.Cust_Label1 = New System.Windows.Forms.Label()
        Me.Cust_Label2 = New System.Windows.Forms.Label()
        Me.Back_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.ThankYouLabel = New System.Windows.Forms.Label()
        Me.grd_receipt = New System.Windows.Forms.DataGridView()
        Me.btn_invoices = New System.Windows.Forms.Button()
        CType(Me.grd_receipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cust_Label1
        '
        Me.Cust_Label1.AutoSize = True
        Me.Cust_Label1.BackColor = System.Drawing.Color.Transparent
        Me.Cust_Label1.Font = New System.Drawing.Font("Forte", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_Label1.Location = New System.Drawing.Point(28, 28)
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
        Me.Cust_Label2.Location = New System.Drawing.Point(30, 75)
        Me.Cust_Label2.Name = "Cust_Label2"
        Me.Cust_Label2.Size = New System.Drawing.Size(201, 24)
        Me.Cust_Label2.TabIndex = 6
        Me.Cust_Label2.Text = "Receipts Informations : "
        '
        'Back_btn
        '
        Me.Back_btn.BackColor = System.Drawing.Color.GhostWhite
        Me.Back_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_btn.Location = New System.Drawing.Point(34, 280)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(80, 34)
        Me.Back_btn.TabIndex = 12
        Me.Back_btn.Text = "Back"
        Me.Back_btn.UseVisualStyleBackColor = False
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.GhostWhite
        Me.Exit_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.Location = New System.Drawing.Point(676, 280)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(80, 34)
        Me.Exit_btn.TabIndex = 14
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'ThankYouLabel
        '
        Me.ThankYouLabel.AutoSize = True
        Me.ThankYouLabel.BackColor = System.Drawing.Color.Transparent
        Me.ThankYouLabel.Font = New System.Drawing.Font("Lucida Calligraphy", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThankYouLabel.Location = New System.Drawing.Point(189, 320)
        Me.ThankYouLabel.Name = "ThankYouLabel"
        Me.ThankYouLabel.Size = New System.Drawing.Size(379, 19)
        Me.ThankYouLabel.TabIndex = 15
        Me.ThankYouLabel.Text = "**Thank You For Dealing With APerfume**"
        '
        'grd_receipt
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grd_receipt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_receipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_receipt.BackgroundColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_receipt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_receipt.ColumnHeadersHeight = 29
        Me.grd_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_receipt.DefaultCellStyle = DataGridViewCellStyle3
        Me.grd_receipt.GridColor = System.Drawing.Color.Black
        Me.grd_receipt.Location = New System.Drawing.Point(78, 116)
        Me.grd_receipt.Name = "grd_receipt"
        Me.grd_receipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grd_receipt.RowTemplate.Height = 24
        Me.grd_receipt.Size = New System.Drawing.Size(651, 149)
        Me.grd_receipt.TabIndex = 16
        '
        'btn_invoices
        '
        Me.btn_invoices.BackColor = System.Drawing.Color.Salmon
        Me.btn_invoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_invoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoices.ForeColor = System.Drawing.Color.White
        Me.btn_invoices.Location = New System.Drawing.Point(419, 44)
        Me.btn_invoices.Name = "btn_invoices"
        Me.btn_invoices.Size = New System.Drawing.Size(337, 42)
        Me.btn_invoices.TabIndex = 54
        Me.btn_invoices.Text = "Invoice"
        Me.btn_invoices.UseVisualStyleBackColor = False
        '
        'frm_receipts_a174807
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_APERFUME_A174807.My.Resources.Resources.rename
        Me.ClientSize = New System.Drawing.Size(800, 348)
        Me.Controls.Add(Me.btn_invoices)
        Me.Controls.Add(Me.grd_receipt)
        Me.Controls.Add(Me.ThankYouLabel)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Back_btn)
        Me.Controls.Add(Me.Cust_Label2)
        Me.Controls.Add(Me.Cust_Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_receipts_a174807"
        Me.Text = "APerfume - RECEIPTS"
        CType(Me.grd_receipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cust_Label1 As Label
    Friend WithEvents Cust_Label2 As Label
    Friend WithEvents Back_btn As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents ThankYouLabel As Label
    Friend WithEvents grd_receipt As DataGridView
    Friend WithEvents btn_invoices As Button
End Class
