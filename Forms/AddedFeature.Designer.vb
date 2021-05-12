<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddedFeature
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCheckStocks = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OMSysStocksDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.OMSys_StocksDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter()
        Me.lblMaterialName = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblStockList = New System.Windows.Forms.Label()
        Me.OmSysOrdersDBDataSet1 = New OMSys.OMSysOrdersDBDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgvCheckStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmSysOrdersDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCheckStocks
        '
        Me.dgvCheckStocks.AllowUserToAddRows = False
        Me.dgvCheckStocks.AllowUserToDeleteRows = False
        Me.dgvCheckStocks.AllowUserToResizeColumns = False
        Me.dgvCheckStocks.AllowUserToResizeRows = False
        Me.dgvCheckStocks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvCheckStocks.AutoGenerateColumns = False
        Me.dgvCheckStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheckStocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCheckStocks.ColumnHeadersHeight = 29
        Me.dgvCheckStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCheckStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MaterialNameDataGridViewTextBoxColumn, Me.Size, Me.Color, Me.StockDataGridViewTextBoxColumn})
        Me.dgvCheckStocks.DataSource = Me.OMSysStocksDBBindingSource
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCheckStocks.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvCheckStocks.EnableHeadersVisualStyles = False
        Me.dgvCheckStocks.Location = New System.Drawing.Point(13, 84)
        Me.dgvCheckStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCheckStocks.Name = "dgvCheckStocks"
        Me.dgvCheckStocks.ReadOnly = True
        Me.dgvCheckStocks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheckStocks.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvCheckStocks.RowHeadersVisible = False
        Me.dgvCheckStocks.RowHeadersWidth = 51
        Me.dgvCheckStocks.Size = New System.Drawing.Size(645, 318)
        Me.dgvCheckStocks.TabIndex = 214
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 90
        '
        'MaterialNameDataGridViewTextBoxColumn
        '
        Me.MaterialNameDataGridViewTextBoxColumn.DataPropertyName = "Material_Name"
        Me.MaterialNameDataGridViewTextBoxColumn.HeaderText = "Material Name"
        Me.MaterialNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaterialNameDataGridViewTextBoxColumn.Name = "MaterialNameDataGridViewTextBoxColumn"
        Me.MaterialNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaterialNameDataGridViewTextBoxColumn.Width = 125
        '
        'Size
        '
        Me.Size.DataPropertyName = "Size"
        Me.Size.HeaderText = "Size"
        Me.Size.MinimumWidth = 6
        Me.Size.Name = "Size"
        Me.Size.ReadOnly = True
        Me.Size.Width = 90
        '
        'Color
        '
        Me.Color.DataPropertyName = "Color"
        Me.Color.HeaderText = "Color"
        Me.Color.MinimumWidth = 6
        Me.Color.Name = "Color"
        Me.Color.ReadOnly = True
        Me.Color.Width = 90
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Width = 90
        '
        'OMSysStocksDBBindingSource
        '
        Me.OMSysStocksDBBindingSource.DataMember = "OMSys_StocksDB"
        Me.OMSysStocksDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSysOrdersDBDataSet
        '
        Me.OMSysOrdersDBDataSet.DataSetName = "OMSysOrdersDBDataSet"
        Me.OMSysOrdersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OMSys_StocksDBTableAdapter
        '
        Me.OMSys_StocksDBTableAdapter.ClearBeforeFill = True
        '
        'lblMaterialName
        '
        Me.lblMaterialName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMaterialName.AutoSize = True
        Me.lblMaterialName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterialName.Location = New System.Drawing.Point(667, 164)
        Me.lblMaterialName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaterialName.Name = "lblMaterialName"
        Me.lblMaterialName.Size = New System.Drawing.Size(120, 19)
        Me.lblMaterialName.TabIndex = 106
        Me.lblMaterialName.Text = "Material Name: "
        '
        'txt_ID
        '
        Me.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Material_Name", True))
        Me.txt_ID.Enabled = False
        Me.txt_ID.Location = New System.Drawing.Point(796, 164)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(111, 22)
        Me.txt_ID.TabIndex = 107
        '
        'lblStock
        '
        Me.lblStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(667, 197)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(128, 19)
        Me.lblStock.TabIndex = 110
        Me.lblStock.Text = "Remaining Stock:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Stock", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(796, 196)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(47, 22)
        Me.TextBox1.TabIndex = 111
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(753, 306)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 42)
        Me.btnSave.TabIndex = 112
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblStockList
        '
        Me.lblStockList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStockList.AutoSize = True
        Me.lblStockList.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockList.Location = New System.Drawing.Point(11, 25)
        Me.lblStockList.Name = "lblStockList"
        Me.lblStockList.Size = New System.Drawing.Size(164, 40)
        Me.lblStockList.TabIndex = 215
        Me.lblStockList.Text = "Stock List"
        '
        'OmSysOrdersDBDataSet1
        '
        Me.OmSysOrdersDBDataSet1.DataSetName = "OMSysOrdersDBDataSet"
        Me.OmSysOrdersDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(667, 246)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 218
        Me.Label1.Text = "Order quantity:"
        '
        'numUpDown
        '
        Me.numUpDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.numUpDown.Location = New System.Drawing.Point(797, 246)
        Me.numUpDown.Name = "numUpDown"
        Me.numUpDown.Size = New System.Drawing.Size(111, 22)
        Me.numUpDown.TabIndex = 220
        '
        'AddedFeature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 423)
        Me.Controls.Add(Me.numUpDown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStockList)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lblMaterialName)
        Me.Controls.Add(Me.dgvCheckStocks)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddedFeature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Stocks"
        CType(Me.dgvCheckStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmSysOrdersDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCheckStocks As DataGridView
    Friend WithEvents OMSysOrdersDBDataSet As OMSysOrdersDBDataSet
    Friend WithEvents OMSysStocksDBBindingSource As BindingSource
    Friend WithEvents OMSys_StocksDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter
    Friend WithEvents lblMaterialName As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblStockList As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents Color As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OmSysOrdersDBDataSet1 As OMSysOrdersDBDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents numUpDown As NumericUpDown
End Class
