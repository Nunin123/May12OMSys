﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainScreen2
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.lblStockList = New System.Windows.Forms.Label()
        Me.lblOrderMgmtSys = New System.Windows.Forms.Label()
        Me.lblOMSYS = New System.Windows.Forms.Label()
        Me.dgvStocks = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Addedd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OMSysStocksDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.lblSearchFor = New System.Windows.Forms.Label()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_DateAdded = New System.Windows.Forms.Label()
        Me.txt_StockName = New System.Windows.Forms.TextBox()
        Me.date_added = New System.Windows.Forms.DateTimePicker()
        Me.lbl_StockName = New System.Windows.Forms.Label()
        Me.lbl_Stock = New System.Windows.Forms.Label()
        Me.txt_Stock = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.cmb_Size = New System.Windows.Forms.ComboBox()
        Me.lbl_Color = New System.Windows.Forms.Label()
        Me.txt_Color = New System.Windows.Forms.TextBox()
        Me.lbl_SellingPrice = New System.Windows.Forms.Label()
        Me.txt_SellingPrice = New System.Windows.Forms.TextBox()
        Me.lbl_UnitPrice = New System.Windows.Forms.Label()
        Me.txt_OriginalPrice = New System.Windows.Forms.TextBox()
        Me.OMSys_OrdersDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSys_OrdersDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.TableAdapterManager = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        Me.OMSys_StocksDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter()
        Me.lblAsterisk1 = New System.Windows.Forms.Label()
        Me.lblAsterisk3 = New System.Windows.Forms.Label()
        Me.lblAsterisk4 = New System.Windows.Forms.Label()
        Me.lblAsterisk6 = New System.Windows.Forms.Label()
        Me.lblAsterisk7 = New System.Windows.Forms.Label()
        Me.btnStatusReport = New System.Windows.Forms.Button()
        Me.OmSysOrdersDBDataSet1 = New OMSys.OMSysOrdersDBDataSet()
        Me.OmSys_OrdersDBTableAdapter1 = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.OmSys_StocksDBTableAdapter1 = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter()
        Me.TableAdapterManager1 = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmSysOrdersDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddStock
        '
        Me.btnAddStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddStock.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAddStock.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStock.ForeColor = System.Drawing.Color.White
        Me.btnAddStock.Location = New System.Drawing.Point(971, 55)
        Me.btnAddStock.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(112, 42)
        Me.btnAddStock.TabIndex = 3
        Me.btnAddStock.Text = "New Stock"
        Me.btnAddStock.UseVisualStyleBackColor = False
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteOrder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnDeleteOrder.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteOrder.Location = New System.Drawing.Point(1294, 448)
        Me.btnDeleteOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(85, 42)
        Me.btnDeleteOrder.TabIndex = 13
        Me.btnDeleteOrder.Text = "Delete"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateOrder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUpdateOrder.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateOrder.ForeColor = System.Drawing.Color.White
        Me.btnUpdateOrder.Location = New System.Drawing.Point(1162, 448)
        Me.btnUpdateOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(85, 42)
        Me.btnUpdateOrder.TabIndex = 12
        Me.btnUpdateOrder.Text = "Save"
        Me.btnUpdateOrder.UseVisualStyleBackColor = False
        '
        'lblStockList
        '
        Me.lblStockList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStockList.AutoSize = True
        Me.lblStockList.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockList.Location = New System.Drawing.Point(12, 32)
        Me.lblStockList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStockList.Name = "lblStockList"
        Me.lblStockList.Size = New System.Drawing.Size(228, 58)
        Me.lblStockList.TabIndex = 57
        Me.lblStockList.Text = "Stock List"
        '
        'lblOrderMgmtSys
        '
        Me.lblOrderMgmtSys.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOrderMgmtSys.AutoSize = True
        Me.lblOrderMgmtSys.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderMgmtSys.Location = New System.Drawing.Point(1168, 646)
        Me.lblOrderMgmtSys.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderMgmtSys.Name = "lblOrderMgmtSys"
        Me.lblOrderMgmtSys.Size = New System.Drawing.Size(209, 19)
        Me.lblOrderMgmtSys.TabIndex = 59
        Me.lblOrderMgmtSys.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'lblOMSYS
        '
        Me.lblOMSYS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOMSYS.AutoSize = True
        Me.lblOMSYS.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOMSYS.Location = New System.Drawing.Point(1118, 545)
        Me.lblOMSYS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOMSYS.Name = "lblOMSYS"
        Me.lblOMSYS.Size = New System.Drawing.Size(315, 96)
        Me.lblOMSYS.TabIndex = 58
        Me.lblOMSYS.Text = "OMSYS"
        '
        'dgvStocks
        '
        Me.dgvStocks.AllowUserToAddRows = False
        Me.dgvStocks.AllowUserToDeleteRows = False
        Me.dgvStocks.AllowUserToResizeColumns = False
        Me.dgvStocks.AllowUserToResizeRows = False
        Me.dgvStocks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvStocks.AutoGenerateColumns = False
        Me.dgvStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStocks.ColumnHeadersHeight = 29
        Me.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.Date_Addedd, Me.MaterialNameDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.Size, Me.Color, Me.SellingPriceDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn})
        Me.dgvStocks.DataSource = Me.OMSysStocksDBBindingSource
        Me.dgvStocks.EnableHeadersVisualStyles = False
        Me.dgvStocks.Location = New System.Drawing.Point(18, 119)
        Me.dgvStocks.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvStocks.Name = "dgvStocks"
        Me.dgvStocks.ReadOnly = True
        Me.dgvStocks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStocks.RowHeadersVisible = False
        Me.dgvStocks.RowHeadersWidth = 51
        Me.dgvStocks.RowTemplate.Height = 24
        Me.dgvStocks.Size = New System.Drawing.Size(1066, 556)
        Me.dgvStocks.TabIndex = 85
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "Stock ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 90
        '
        'Date_Addedd
        '
        Me.Date_Addedd.DataPropertyName = "Date_Addedd"
        DataGridViewCellStyle6.Format = "D"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Date_Addedd.DefaultCellStyle = DataGridViewCellStyle6
        Me.Date_Addedd.HeaderText = "Date Added"
        Me.Date_Addedd.MinimumWidth = 6
        Me.Date_Addedd.Name = "Date_Addedd"
        Me.Date_Addedd.ReadOnly = True
        Me.Date_Addedd.Width = 135
        '
        'MaterialNameDataGridViewTextBoxColumn
        '
        Me.MaterialNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaterialNameDataGridViewTextBoxColumn.DataPropertyName = "Material_Name"
        Me.MaterialNameDataGridViewTextBoxColumn.HeaderText = "Stock Name"
        Me.MaterialNameDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.MaterialNameDataGridViewTextBoxColumn.Name = "MaterialNameDataGridViewTextBoxColumn"
        Me.MaterialNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Width = 125
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
        Me.Color.Width = 125
        '
        'SellingPriceDataGridViewTextBoxColumn
        '
        Me.SellingPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling_Price"
        DataGridViewCellStyle7.Format = "C2"
        Me.SellingPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price"
        Me.SellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SellingPriceDataGridViewTextBoxColumn.Name = "SellingPriceDataGridViewTextBoxColumn"
        Me.SellingPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SellingPriceDataGridViewTextBoxColumn.Width = 116
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price"
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.UnitPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Original Price"
        Me.UnitPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn.Width = 126
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
        'lblSearchFor
        '
        Me.lblSearchFor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSearchFor.AutoSize = True
        Me.lblSearchFor.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchFor.Location = New System.Drawing.Point(288, 48)
        Me.lblSearchFor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearchFor.Name = "lblSearchFor"
        Me.lblSearchFor.Size = New System.Drawing.Size(134, 13)
        Me.lblSearchFor.TabIndex = 104
        Me.lblSearchFor.Text = "(ID, Stock Name, Size, Color)"
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewAll.BackColor = System.Drawing.Color.DarkCyan
        Me.btnViewAll.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(678, 52)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(112, 42)
        Me.btnViewAll.TabIndex = 2
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(544, 52)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 42)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Location = New System.Drawing.Point(291, 65)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(234, 23)
        Me.txtSearch.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(1110, 121)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(67, 19)
        Me.lblID.TabIndex = 105
        Me.lblID.Text = "Stock ID:"
        '
        'txt_ID
        '
        Me.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "ID", True))
        Me.txt_ID.Enabled = False
        Me.txt_ID.Location = New System.Drawing.Point(1230, 118)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(124, 23)
        Me.txt_ID.TabIndex = 4
        '
        'lbl_DateAdded
        '
        Me.lbl_DateAdded.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_DateAdded.AutoSize = True
        Me.lbl_DateAdded.Location = New System.Drawing.Point(1110, 152)
        Me.lbl_DateAdded.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_DateAdded.Name = "lbl_DateAdded"
        Me.lbl_DateAdded.Size = New System.Drawing.Size(99, 19)
        Me.lbl_DateAdded.TabIndex = 107
        Me.lbl_DateAdded.Text = "Date Added:"
        '
        'txt_StockName
        '
        Me.txt_StockName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_StockName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Material_Name", True))
        Me.txt_StockName.Location = New System.Drawing.Point(1230, 180)
        Me.txt_StockName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_StockName.Name = "txt_StockName"
        Me.txt_StockName.Size = New System.Drawing.Size(124, 23)
        Me.txt_StockName.TabIndex = 6
        '
        'date_added
        '
        Me.date_added.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.date_added.Checked = False
        Me.date_added.CustomFormat = ""
        Me.date_added.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMSysStocksDBBindingSource, "Date_Addedd", True))
        Me.date_added.Location = New System.Drawing.Point(1230, 148)
        Me.date_added.Margin = New System.Windows.Forms.Padding(4)
        Me.date_added.Name = "date_added"
        Me.date_added.ShowCheckBox = True
        Me.date_added.Size = New System.Drawing.Size(246, 23)
        Me.date_added.TabIndex = 5
        Me.date_added.Value = New Date(2021, 3, 30, 0, 0, 0, 0)
        '
        'lbl_StockName
        '
        Me.lbl_StockName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_StockName.AutoSize = True
        Me.lbl_StockName.Location = New System.Drawing.Point(1110, 182)
        Me.lbl_StockName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_StockName.Name = "lbl_StockName"
        Me.lbl_StockName.Size = New System.Drawing.Size(96, 19)
        Me.lbl_StockName.TabIndex = 110
        Me.lbl_StockName.Text = "Stock Name:"
        '
        'lbl_Stock
        '
        Me.lbl_Stock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Stock.AutoSize = True
        Me.lbl_Stock.Location = New System.Drawing.Point(1110, 214)
        Me.lbl_Stock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Stock.Name = "lbl_Stock"
        Me.lbl_Stock.Size = New System.Drawing.Size(50, 19)
        Me.lbl_Stock.TabIndex = 111
        Me.lbl_Stock.Text = "Stock:"
        '
        'txt_Stock
        '
        Me.txt_Stock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Stock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Stock", True))
        Me.txt_Stock.Location = New System.Drawing.Point(1230, 210)
        Me.txt_Stock.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Stock.Name = "txt_Stock"
        Me.txt_Stock.Size = New System.Drawing.Size(64, 23)
        Me.txt_Stock.TabIndex = 7
        '
        'lblSize
        '
        Me.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(1110, 248)
        Me.lblSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(38, 19)
        Me.lblSize.TabIndex = 113
        Me.lblSize.Text = "Size:"
        '
        'cmb_Size
        '
        Me.cmb_Size.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_Size.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Size", True))
        Me.cmb_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Size.FormattingEnabled = True
        Me.cmb_Size.Items.AddRange(New Object() {"XXS", "XS", "S", "M", "L", "XL", "XXL", "N/A"})
        Me.cmb_Size.Location = New System.Drawing.Point(1230, 241)
        Me.cmb_Size.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Size.Name = "cmb_Size"
        Me.cmb_Size.Size = New System.Drawing.Size(64, 25)
        Me.cmb_Size.TabIndex = 8
        '
        'lbl_Color
        '
        Me.lbl_Color.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Color.AutoSize = True
        Me.lbl_Color.Location = New System.Drawing.Point(1110, 278)
        Me.lbl_Color.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Color.Name = "lbl_Color"
        Me.lbl_Color.Size = New System.Drawing.Size(49, 19)
        Me.lbl_Color.TabIndex = 115
        Me.lbl_Color.Text = "Color:"
        '
        'txt_Color
        '
        Me.txt_Color.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Color.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Color", True))
        Me.txt_Color.Location = New System.Drawing.Point(1230, 274)
        Me.txt_Color.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Color.Name = "txt_Color"
        Me.txt_Color.Size = New System.Drawing.Size(124, 23)
        Me.txt_Color.TabIndex = 9
        '
        'lbl_SellingPrice
        '
        Me.lbl_SellingPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_SellingPrice.AutoSize = True
        Me.lbl_SellingPrice.Location = New System.Drawing.Point(1110, 310)
        Me.lbl_SellingPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_SellingPrice.Name = "lbl_SellingPrice"
        Me.lbl_SellingPrice.Size = New System.Drawing.Size(93, 19)
        Me.lbl_SellingPrice.TabIndex = 117
        Me.lbl_SellingPrice.Text = "Selling Price:"
        '
        'txt_SellingPrice
        '
        Me.txt_SellingPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_SellingPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Selling_Price", True))
        Me.txt_SellingPrice.Location = New System.Drawing.Point(1230, 304)
        Me.txt_SellingPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SellingPrice.Name = "txt_SellingPrice"
        Me.txt_SellingPrice.Size = New System.Drawing.Size(124, 23)
        Me.txt_SellingPrice.TabIndex = 10
        '
        'lbl_UnitPrice
        '
        Me.lbl_UnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_UnitPrice.AutoSize = True
        Me.lbl_UnitPrice.Location = New System.Drawing.Point(1110, 340)
        Me.lbl_UnitPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_UnitPrice.Name = "lbl_UnitPrice"
        Me.lbl_UnitPrice.Size = New System.Drawing.Size(103, 19)
        Me.lbl_UnitPrice.TabIndex = 119
        Me.lbl_UnitPrice.Text = "Original Price:"
        '
        'txt_OriginalPrice
        '
        Me.txt_OriginalPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_OriginalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Unit_Price", True))
        Me.txt_OriginalPrice.Location = New System.Drawing.Point(1230, 336)
        Me.txt_OriginalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_OriginalPrice.Name = "txt_OriginalPrice"
        Me.txt_OriginalPrice.Size = New System.Drawing.Size(124, 23)
        Me.txt_OriginalPrice.TabIndex = 11
        '
        'OMSys_OrdersDBBindingSource
        '
        Me.OMSys_OrdersDBBindingSource.DataMember = "OMSys_OrdersDB"
        Me.OMSys_OrdersDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSys_OrdersDBTableAdapter
        '
        Me.OMSys_OrdersDBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OMSys_OrdersDBTableAdapter = Me.OMSys_OrdersDBTableAdapter
        Me.TableAdapterManager.OMSys_OrdersV2DBTableAdapter = Nothing
        Me.TableAdapterManager.OMSys_StocksDBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OMSys_StocksDBTableAdapter
        '
        Me.OMSys_StocksDBTableAdapter.ClearBeforeFill = True
        '
        'lblAsterisk1
        '
        Me.lblAsterisk1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk1.AutoSize = True
        Me.lblAsterisk1.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk1.Location = New System.Drawing.Point(1172, 120)
        Me.lblAsterisk1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk1.Name = "lblAsterisk1"
        Me.lblAsterisk1.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk1.TabIndex = 121
        Me.lblAsterisk1.Text = "*"
        '
        'lblAsterisk3
        '
        Me.lblAsterisk3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk3.AutoSize = True
        Me.lblAsterisk3.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk3.Location = New System.Drawing.Point(1201, 182)
        Me.lblAsterisk3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk3.Name = "lblAsterisk3"
        Me.lblAsterisk3.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk3.TabIndex = 123
        Me.lblAsterisk3.Text = "*"
        '
        'lblAsterisk4
        '
        Me.lblAsterisk4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk4.AutoSize = True
        Me.lblAsterisk4.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk4.Location = New System.Drawing.Point(1155, 212)
        Me.lblAsterisk4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk4.Name = "lblAsterisk4"
        Me.lblAsterisk4.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk4.TabIndex = 124
        Me.lblAsterisk4.Text = "*"
        '
        'lblAsterisk6
        '
        Me.lblAsterisk6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk6.AutoSize = True
        Me.lblAsterisk6.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk6.Location = New System.Drawing.Point(1198, 308)
        Me.lblAsterisk6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk6.Name = "lblAsterisk6"
        Me.lblAsterisk6.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk6.TabIndex = 127
        Me.lblAsterisk6.Text = "*"
        '
        'lblAsterisk7
        '
        Me.lblAsterisk7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk7.AutoSize = True
        Me.lblAsterisk7.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk7.Location = New System.Drawing.Point(1209, 340)
        Me.lblAsterisk7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk7.Name = "lblAsterisk7"
        Me.lblAsterisk7.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk7.TabIndex = 128
        Me.lblAsterisk7.Text = "*"
        '
        'btnStatusReport
        '
        Me.btnStatusReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStatusReport.BackColor = System.Drawing.Color.DarkCyan
        Me.btnStatusReport.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatusReport.ForeColor = System.Drawing.Color.White
        Me.btnStatusReport.Location = New System.Drawing.Point(18, 688)
        Me.btnStatusReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStatusReport.Name = "btnStatusReport"
        Me.btnStatusReport.Size = New System.Drawing.Size(233, 32)
        Me.btnStatusReport.TabIndex = 14
        Me.btnStatusReport.Text = "Generate Status Report"
        Me.btnStatusReport.UseVisualStyleBackColor = False
        '
        'OmSysOrdersDBDataSet1
        '
        Me.OmSysOrdersDBDataSet1.DataSetName = "OMSysOrdersDBDataSet"
        Me.OmSysOrdersDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OmSys_OrdersDBTableAdapter1
        '
        Me.OmSys_OrdersDBTableAdapter1.ClearBeforeFill = True
        '
        'OmSys_StocksDBTableAdapter1
        '
        Me.OmSys_StocksDBTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.OMSys_OrdersDBTableAdapter = Nothing
        Me.TableAdapterManager1.OMSys_OrdersV2DBTableAdapter = Nothing
        Me.TableAdapterManager1.OMSys_StocksDBTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMainScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1490, 731)
        Me.Controls.Add(Me.btnStatusReport)
        Me.Controls.Add(Me.lblAsterisk7)
        Me.Controls.Add(Me.lblAsterisk6)
        Me.Controls.Add(Me.lblAsterisk4)
        Me.Controls.Add(Me.lblAsterisk3)
        Me.Controls.Add(Me.lblAsterisk1)
        Me.Controls.Add(Me.txt_OriginalPrice)
        Me.Controls.Add(Me.lbl_UnitPrice)
        Me.Controls.Add(Me.txt_SellingPrice)
        Me.Controls.Add(Me.lbl_SellingPrice)
        Me.Controls.Add(Me.txt_Color)
        Me.Controls.Add(Me.lbl_Color)
        Me.Controls.Add(Me.cmb_Size)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.txt_Stock)
        Me.Controls.Add(Me.lbl_Stock)
        Me.Controls.Add(Me.lbl_StockName)
        Me.Controls.Add(Me.date_added)
        Me.Controls.Add(Me.txt_StockName)
        Me.Controls.Add(Me.lbl_DateAdded)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblSearchFor)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvStocks)
        Me.Controls.Add(Me.lblOrderMgmtSys)
        Me.Controls.Add(Me.lblOMSYS)
        Me.Controls.Add(Me.lblStockList)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnUpdateOrder)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMainScreen2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "14"
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmSysOrdersDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddStock As Button
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents lblStockList As Label
    Friend WithEvents lblOrderMgmtSys As Label
    Friend WithEvents lblOMSYS As Label
    Friend WithEvents OMSysOrdersDBDataSet As OMSysOrdersDBDataSet
    Friend WithEvents OMSys_OrdersDBBindingSource As BindingSource
    Friend WithEvents OMSys_OrdersDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter
    Friend WithEvents TableAdapterManager As OMSysOrdersDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvStocks As DataGridView
    Friend WithEvents OMSysStocksDBBindingSource As BindingSource
    Friend WithEvents OMSys_StocksDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter
    Friend WithEvents lblSearchFor As Label
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lbl_DateAdded As Label
    Friend WithEvents txt_StockName As TextBox
    Friend WithEvents date_added As DateTimePicker
    Friend WithEvents lbl_StockName As Label
    Friend WithEvents lbl_Stock As Label
    Friend WithEvents txt_Stock As TextBox
    Friend WithEvents lblSize As Label
    Friend WithEvents cmb_Size As ComboBox
    Friend WithEvents lbl_Color As Label
    Friend WithEvents txt_Color As TextBox
    Friend WithEvents lbl_SellingPrice As Label
    Friend WithEvents txt_SellingPrice As TextBox
    Friend WithEvents lbl_UnitPrice As Label
    Friend WithEvents txt_OriginalPrice As TextBox
    Friend WithEvents lblAsterisk1 As Label
    Friend WithEvents lblAsterisk3 As Label
    Friend WithEvents lblAsterisk4 As Label
    Friend WithEvents lblAsterisk6 As Label
    Friend WithEvents lblAsterisk7 As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Date_Addedd As DataGridViewTextBoxColumn
    Friend WithEvents MaterialNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents Color As DataGridViewTextBoxColumn
    Friend WithEvents SellingPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnStatusReport As Button
    Friend WithEvents OmSysOrdersDBDataSet1 As OMSysOrdersDBDataSet
    Friend WithEvents OmSys_OrdersDBTableAdapter1 As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter
    Friend WithEvents OmSys_StocksDBTableAdapter1 As OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter
    Friend WithEvents TableAdapterManager1 As OMSysOrdersDBDataSetTableAdapters.TableAdapterManager
End Class
