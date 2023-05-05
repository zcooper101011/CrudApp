namespace Cooper_CC_Capstone
{
    partial class MenuItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItems));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMenuItems = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMenuItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenuItemType = new System.Windows.Forms.TextBox();
            this.menuItemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resturantDataSet = new Cooper_CC_Capstone.ResturantDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMenuItemDescription = new System.Windows.Forms.TextBox();
            this.txtMenuItemPrice = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearchPrice = new System.Windows.Forms.TextBox();
            this.btnSearchPrice = new System.Windows.Forms.Button();
            this.txtSearchItemName = new System.Windows.Forms.TextBox();
            this.btnSearchItemName = new System.Windows.Forms.Button();
            this.MenuTypeId = new System.Windows.Forms.Label();
            this.txtSearchMenuTypeId = new System.Windows.Forms.TextBox();
            this.btnSearchMenuTypeId = new System.Windows.Forms.Button();
            this.txtSearchDescription = new System.Windows.Forms.TextBox();
            this.btnDescription = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuItemsTableAdapter = new Cooper_CC_Capstone.ResturantDataSetTableAdapters.MenuItemsTableAdapter();
            this.tableAdapterManager = new Cooper_CC_Capstone.ResturantDataSetTableAdapters.TableAdapterManager();
            this.menuTypesTableAdapter1 = new Cooper_CC_Capstone.ResturantDataSetTableAdapters.MenuTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingNavigator)).BeginInit();
            this.menuItemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(55, 591);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 41);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMenuItems
            // 
            this.btnMenuItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMenuItems.Location = new System.Drawing.Point(240, 574);
            this.btnMenuItems.Name = "btnMenuItems";
            this.btnMenuItems.Size = new System.Drawing.Size(120, 58);
            this.btnMenuItems.TabIndex = 33;
            this.btnMenuItems.Text = "Insert Record";
            this.btnMenuItems.UseVisualStyleBackColor = true;
            this.btnMenuItems.Click += new System.EventHandler(this.btnMenuItems_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Item Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Item Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMenuItemName
            // 
            this.txtMenuItemName.Location = new System.Drawing.Point(205, 324);
            this.txtMenuItemName.Name = "txtMenuItemName";
            this.txtMenuItemName.Size = new System.Drawing.Size(409, 20);
            this.txtMenuItemName.TabIndex = 30;
            this.txtMenuItemName.TextChanged += new System.EventHandler(this.txtMenuItemName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Menu Type Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMenuItemType
            // 
            this.txtMenuItemType.Location = new System.Drawing.Point(205, 270);
            this.txtMenuItemType.Name = "txtMenuItemType";
            this.txtMenuItemType.Size = new System.Drawing.Size(409, 20);
            this.txtMenuItemType.TabIndex = 26;
            this.txtMenuItemType.TextChanged += new System.EventHandler(this.txtMenuItemType_TextChanged);
            // 
            // menuItemsBindingNavigator
            // 
            this.menuItemsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.menuItemsBindingNavigator.BindingSource = this.menuItemsBindingSource;
            this.menuItemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.menuItemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.menuItemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.menuItemsBindingNavigatorSaveItem});
            this.menuItemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.menuItemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.menuItemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.menuItemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.menuItemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.menuItemsBindingNavigator.Name = "menuItemsBindingNavigator";
            this.menuItemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.menuItemsBindingNavigator.Size = new System.Drawing.Size(1281, 25);
            this.menuItemsBindingNavigator.TabIndex = 37;
            this.menuItemsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.resturantDataSet;
            // 
            // resturantDataSet
            // 
            this.resturantDataSet.DataSetName = "ResturantDataSet";
            this.resturantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuItemsBindingNavigatorSaveItem
            // 
            this.menuItemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("menuItemsBindingNavigatorSaveItem.Image")));
            this.menuItemsBindingNavigatorSaveItem.Name = "menuItemsBindingNavigatorSaveItem";
            this.menuItemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.menuItemsBindingNavigatorSaveItem.Text = "Save Data";
            this.menuItemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.menuItemsBindingNavigatorSaveItem_Click);
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.AutoGenerateColumns = false;
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.menuItemsDataGridView.DataSource = this.menuItemsBindingSource;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.Size = new System.Drawing.Size(1205, 220);
            this.menuItemsDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MenuItemId";
            this.dataGridViewTextBoxColumn1.HeaderText = "MenuItemId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MenuTypeId";
            this.dataGridViewTextBoxColumn2.HeaderText = "MenuTypeId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MenuItemName";
            this.dataGridViewTextBoxColumn3.HeaderText = "MenuItemName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MenuItemPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "MenuItemPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MenuItemDescription";
            this.dataGridViewTextBoxColumn5.HeaderText = "MenuItemDescription";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // txtMenuItemDescription
            // 
            this.txtMenuItemDescription.Location = new System.Drawing.Point(205, 432);
            this.txtMenuItemDescription.Name = "txtMenuItemDescription";
            this.txtMenuItemDescription.Size = new System.Drawing.Size(409, 20);
            this.txtMenuItemDescription.TabIndex = 39;
            this.txtMenuItemDescription.TextChanged += new System.EventHandler(this.txtMenuItemDescription_TextChanged);
            // 
            // txtMenuItemPrice
            // 
            this.txtMenuItemPrice.Location = new System.Drawing.Point(205, 378);
            this.txtMenuItemPrice.Name = "txtMenuItemPrice";
            this.txtMenuItemPrice.Size = new System.Drawing.Size(409, 20);
            this.txtMenuItemPrice.TabIndex = 38;
            this.txtMenuItemPrice.TextChanged += new System.EventHandler(this.txtMenuItemPrice_TextChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(569, 585);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(106, 53);
            this.btnShowAll.TabIndex = 49;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // txtSearchPrice
            // 
            this.txtSearchPrice.Location = new System.Drawing.Point(817, 476);
            this.txtSearchPrice.Name = "txtSearchPrice";
            this.txtSearchPrice.Size = new System.Drawing.Size(400, 20);
            this.txtSearchPrice.TabIndex = 47;
            // 
            // btnSearchPrice
            // 
            this.btnSearchPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPrice.Location = new System.Drawing.Point(817, 513);
            this.btnSearchPrice.Name = "btnSearchPrice";
            this.btnSearchPrice.Size = new System.Drawing.Size(400, 36);
            this.btnSearchPrice.TabIndex = 46;
            this.btnSearchPrice.Text = "Search Price";
            this.btnSearchPrice.UseVisualStyleBackColor = true;
            this.btnSearchPrice.Click += new System.EventHandler(this.btnSearchPrice_Click);
            // 
            // txtSearchItemName
            // 
            this.txtSearchItemName.Location = new System.Drawing.Point(817, 373);
            this.txtSearchItemName.Name = "txtSearchItemName";
            this.txtSearchItemName.Size = new System.Drawing.Size(400, 20);
            this.txtSearchItemName.TabIndex = 44;
            // 
            // btnSearchItemName
            // 
            this.btnSearchItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItemName.Location = new System.Drawing.Point(817, 410);
            this.btnSearchItemName.Name = "btnSearchItemName";
            this.btnSearchItemName.Size = new System.Drawing.Size(400, 36);
            this.btnSearchItemName.TabIndex = 43;
            this.btnSearchItemName.Text = "Search Item Name";
            this.btnSearchItemName.UseVisualStyleBackColor = true;
            this.btnSearchItemName.Click += new System.EventHandler(this.btnSearchItemName_Click);
            // 
            // MenuTypeId
            // 
            this.MenuTypeId.AutoSize = true;
            this.MenuTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTypeId.Location = new System.Drawing.Point(684, 270);
            this.MenuTypeId.Name = "MenuTypeId";
            this.MenuTypeId.Size = new System.Drawing.Size(127, 24);
            this.MenuTypeId.TabIndex = 42;
            this.MenuTypeId.Text = "Menu Type Id";
            this.MenuTypeId.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSearchMenuTypeId
            // 
            this.txtSearchMenuTypeId.Location = new System.Drawing.Point(817, 270);
            this.txtSearchMenuTypeId.Name = "txtSearchMenuTypeId";
            this.txtSearchMenuTypeId.Size = new System.Drawing.Size(400, 20);
            this.txtSearchMenuTypeId.TabIndex = 41;
            // 
            // btnSearchMenuTypeId
            // 
            this.btnSearchMenuTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMenuTypeId.Location = new System.Drawing.Point(817, 307);
            this.btnSearchMenuTypeId.Name = "btnSearchMenuTypeId";
            this.btnSearchMenuTypeId.Size = new System.Drawing.Size(400, 36);
            this.btnSearchMenuTypeId.TabIndex = 40;
            this.btnSearchMenuTypeId.Text = "Search  TypeId";
            this.btnSearchMenuTypeId.UseVisualStyleBackColor = true;
            this.btnSearchMenuTypeId.Click += new System.EventHandler(this.btnSearchMenuTypeId_Click);
            // 
            // txtSearchDescription
            // 
            this.txtSearchDescription.Location = new System.Drawing.Point(817, 571);
            this.txtSearchDescription.Name = "txtSearchDescription";
            this.txtSearchDescription.Size = new System.Drawing.Size(400, 20);
            this.txtSearchDescription.TabIndex = 51;
            // 
            // btnDescription
            // 
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescription.Location = new System.Drawing.Point(817, 608);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(400, 36);
            this.btnDescription.TabIndex = 50;
            this.btnDescription.Text = "Search Description ";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(684, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(684, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Item Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(681, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Description";
            // 
            // menuItemsTableAdapter
            // 
            this.menuItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.MenuItemsTableAdapter = this.menuItemsTableAdapter;
            this.tableAdapterManager.MenuTypesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ResturantTableTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cooper_CC_Capstone.ResturantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // menuTypesTableAdapter1
            // 
            this.menuTypesTableAdapter1.ClearBeforeFill = true;
            // 
            // MenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 680);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchDescription);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSearchPrice);
            this.Controls.Add(this.btnSearchPrice);
            this.Controls.Add(this.txtSearchItemName);
            this.Controls.Add(this.btnSearchItemName);
            this.Controls.Add(this.MenuTypeId);
            this.Controls.Add(this.txtSearchMenuTypeId);
            this.Controls.Add(this.btnSearchMenuTypeId);
            this.Controls.Add(this.txtMenuItemDescription);
            this.Controls.Add(this.txtMenuItemPrice);
            this.Controls.Add(this.menuItemsDataGridView);
            this.Controls.Add(this.menuItemsBindingNavigator);
            this.Controls.Add(this.btnMenuItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMenuItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenuItemType);
            this.Controls.Add(this.btnBack);
            this.Name = "MenuItems";
            this.Text = "MenuItems";
            this.Load += new System.EventHandler(this.MenuItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingNavigator)).EndInit();
            this.menuItemsBindingNavigator.ResumeLayout(false);
            this.menuItemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMenuItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMenuItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenuItemType;
        private ResturantDataSet resturantDataSet;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private ResturantDataSetTableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private ResturantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator menuItemsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton menuItemsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtMenuItemDescription;
        private System.Windows.Forms.TextBox txtMenuItemPrice;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSearchPrice;
        private System.Windows.Forms.Button btnSearchPrice;
        private System.Windows.Forms.TextBox txtSearchItemName;
        private System.Windows.Forms.Button btnSearchItemName;
        private System.Windows.Forms.Label MenuTypeId;
        private System.Windows.Forms.TextBox txtSearchMenuTypeId;
        private System.Windows.Forms.Button btnSearchMenuTypeId;
        private System.Windows.Forms.TextBox txtSearchDescription;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private ResturantDataSetTableAdapters.MenuTypesTableAdapter menuTypesTableAdapter1;
    }
}