namespace Cooper_CC_Capstone
{
    partial class MenuTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTypes));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMenuTypes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTypeDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.resturantDataSet = new Cooper_CC_Capstone.ResturantDataSet();
            this.menuTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTypesTableAdapter = new Cooper_CC_Capstone.ResturantDataSetTableAdapters.MenuTypesTableAdapter();
            this.tableAdapterManager = new Cooper_CC_Capstone.ResturantDataSetTableAdapters.TableAdapterManager();
            this.menuTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.menuTypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.menuTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearchTypeDescription = new System.Windows.Forms.TextBox();
            this.btnSearchTypeDescription = new System.Windows.Forms.Button();
            this.txtSearchTypeName = new System.Windows.Forms.TextBox();
            this.btnSearchTypeName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resturantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTypesBindingNavigator)).BeginInit();
            this.menuTypesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(47, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 41);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMenuTypes
            // 
            this.btnMenuTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMenuTypes.Location = new System.Drawing.Point(277, 478);
            this.btnMenuTypes.Name = "btnMenuTypes";
            this.btnMenuTypes.Size = new System.Drawing.Size(109, 58);
            this.btnMenuTypes.TabIndex = 46;
            this.btnMenuTypes.Text = "Insert Record";
            this.btnMenuTypes.UseVisualStyleBackColor = true;
            this.btnMenuTypes.Click += new System.EventHandler(this.btnMenuTypes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Type Description";
            // 
            // txtTypeDescription
            // 
            this.txtTypeDescription.Location = new System.Drawing.Point(184, 399);
            this.txtTypeDescription.Name = "txtTypeDescription";
            this.txtTypeDescription.Size = new System.Drawing.Size(424, 20);
            this.txtTypeDescription.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Type Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(184, 321);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(424, 20);
            this.txtTypeName.TabIndex = 40;
            // 
            // resturantDataSet
            // 
            this.resturantDataSet.DataSetName = "ResturantDataSet";
            this.resturantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTypesBindingSource
            // 
            this.menuTypesBindingSource.DataMember = "MenuTypes";
            this.menuTypesBindingSource.DataSource = this.resturantDataSet;
            // 
            // menuTypesTableAdapter
            // 
            this.menuTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.MenuItemsTableAdapter = null;
            this.tableAdapterManager.MenuTypesTableAdapter = this.menuTypesTableAdapter;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ResturantTableTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cooper_CC_Capstone.ResturantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // menuTypesBindingNavigator
            // 
            this.menuTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.menuTypesBindingNavigator.BindingSource = this.menuTypesBindingSource;
            this.menuTypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.menuTypesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.menuTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.menuTypesBindingNavigatorSaveItem});
            this.menuTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.menuTypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.menuTypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.menuTypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.menuTypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.menuTypesBindingNavigator.Name = "menuTypesBindingNavigator";
            this.menuTypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.menuTypesBindingNavigator.Size = new System.Drawing.Size(1307, 25);
            this.menuTypesBindingNavigator.TabIndex = 49;
            this.menuTypesBindingNavigator.Text = "bindingNavigator1";
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
            // menuTypesBindingNavigatorSaveItem
            // 
            this.menuTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuTypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("menuTypesBindingNavigatorSaveItem.Image")));
            this.menuTypesBindingNavigatorSaveItem.Name = "menuTypesBindingNavigatorSaveItem";
            this.menuTypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.menuTypesBindingNavigatorSaveItem.Text = "Save Data";
            this.menuTypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.menuTypesBindingNavigatorSaveItem_Click);
            // 
            // menuTypesDataGridView
            // 
            this.menuTypesDataGridView.AutoGenerateColumns = false;
            this.menuTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.menuTypesDataGridView.DataSource = this.menuTypesBindingSource;
            this.menuTypesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.menuTypesDataGridView.Name = "menuTypesDataGridView";
            this.menuTypesDataGridView.Size = new System.Drawing.Size(1085, 220);
            this.menuTypesDataGridView.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MenuTypeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "MenuTypeId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MenuTypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "MenuTypeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MenuTypeDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "MenuTypeDescription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShowAll.Location = new System.Drawing.Point(959, 561);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(109, 58);
            this.btnShowAll.TabIndex = 54;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtSearchTypeDescription
            // 
            this.txtSearchTypeDescription.Location = new System.Drawing.Point(799, 429);
            this.txtSearchTypeDescription.Name = "txtSearchTypeDescription";
            this.txtSearchTypeDescription.Size = new System.Drawing.Size(400, 20);
            this.txtSearchTypeDescription.TabIndex = 59;
            // 
            // btnSearchTypeDescription
            // 
            this.btnSearchTypeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTypeDescription.Location = new System.Drawing.Point(799, 466);
            this.btnSearchTypeDescription.Name = "btnSearchTypeDescription";
            this.btnSearchTypeDescription.Size = new System.Drawing.Size(400, 36);
            this.btnSearchTypeDescription.TabIndex = 58;
            this.btnSearchTypeDescription.Text = "Search Type Description";
            this.btnSearchTypeDescription.UseVisualStyleBackColor = true;
            this.btnSearchTypeDescription.Click += new System.EventHandler(this.btnSearchTypeDescription_Click);
            // 
            // txtSearchTypeName
            // 
            this.txtSearchTypeName.Location = new System.Drawing.Point(799, 307);
            this.txtSearchTypeName.Name = "txtSearchTypeName";
            this.txtSearchTypeName.Size = new System.Drawing.Size(400, 20);
            this.txtSearchTypeName.TabIndex = 56;
            // 
            // btnSearchTypeName
            // 
            this.btnSearchTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTypeName.Location = new System.Drawing.Point(799, 344);
            this.btnSearchTypeName.Name = "btnSearchTypeName";
            this.btnSearchTypeName.Size = new System.Drawing.Size(400, 36);
            this.btnSearchTypeName.TabIndex = 55;
            this.btnSearchTypeName.Text = "Search  Type Name";
            this.btnSearchTypeName.UseVisualStyleBackColor = true;
            this.btnSearchTypeName.Click += new System.EventHandler(this.btnSearchTypeName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 61;
            this.label2.Text = "Type Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(641, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "Type Description";
            // 
            // MenuTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 674);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchTypeDescription);
            this.Controls.Add(this.btnSearchTypeDescription);
            this.Controls.Add(this.txtSearchTypeName);
            this.Controls.Add(this.btnSearchTypeName);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.menuTypesDataGridView);
            this.Controls.Add(this.menuTypesBindingNavigator);
            this.Controls.Add(this.btnMenuTypes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTypeDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.btnBack);
            this.Name = "MenuTypes";
            this.Text = "MenuTypes";
            this.Load += new System.EventHandler(this.MenuTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resturantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuTypesBindingNavigator)).EndInit();
            this.menuTypesBindingNavigator.ResumeLayout(false);
            this.menuTypesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMenuTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTypeDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTypeName;
        private ResturantDataSet resturantDataSet;
        private System.Windows.Forms.BindingSource menuTypesBindingSource;
        private ResturantDataSetTableAdapters.MenuTypesTableAdapter menuTypesTableAdapter;
        private ResturantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator menuTypesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton menuTypesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView menuTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSearchTypeDescription;
        private System.Windows.Forms.Button btnSearchTypeDescription;
        private System.Windows.Forms.TextBox txtSearchTypeName;
        private System.Windows.Forms.Button btnSearchTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}