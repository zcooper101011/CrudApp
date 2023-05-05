namespace Cooper_CC_Capstone
{
    partial class ResturantTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResturantTable));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.resturantDataSet = new Cooper_CC_Capstone.ResturantDataSet();
            this.resturantTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resturantTableTableAdapter = new Cooper_CC_Capstone.ResturantDataSetTableAdapters.ResturantTableTableAdapter();
            this.tableAdapterManager = new Cooper_CC_Capstone.ResturantDataSetTableAdapters.TableAdapterManager();
            this.resturantTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.resturantTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.resturantTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchTableDescription = new System.Windows.Forms.TextBox();
            this.btnSearchTableDescription = new System.Windows.Forms.Button();
            this.txtSearchTableNumber = new System.Windows.Forms.TextBox();
            this.btnSearchTableNumber = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resturantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantTableBindingNavigator)).BeginInit();
            this.resturantTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resturantTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(54, 544);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 41);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTable
            // 
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTable.Location = new System.Drawing.Point(410, 527);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(120, 58);
            this.btnTable.TabIndex = 46;
            this.btnTable.Text = "Insert Record";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Table Description";
            // 
            // txtTableDescription
            // 
            this.txtTableDescription.Location = new System.Drawing.Point(184, 451);
            this.txtTableDescription.Name = "txtTableDescription";
            this.txtTableDescription.Size = new System.Drawing.Size(409, 20);
            this.txtTableDescription.TabIndex = 43;
            this.txtTableDescription.TextChanged += new System.EventHandler(this.txtTableDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Table Number";
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Location = new System.Drawing.Point(184, 359);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(409, 20);
            this.txtTableNumber.TabIndex = 40;
            // 
            // resturantDataSet
            // 
            this.resturantDataSet.DataSetName = "ResturantDataSet";
            this.resturantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resturantTableBindingSource
            // 
            this.resturantTableBindingSource.DataMember = "ResturantTable";
            this.resturantTableBindingSource.DataSource = this.resturantDataSet;
            // 
            // resturantTableTableAdapter
            // 
            this.resturantTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.MenuItemsTableAdapter = null;
            this.tableAdapterManager.MenuTypesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ResturantTableTableAdapter = this.resturantTableTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cooper_CC_Capstone.ResturantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // resturantTableBindingNavigator
            // 
            this.resturantTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.resturantTableBindingNavigator.BindingSource = this.resturantTableBindingSource;
            this.resturantTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.resturantTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.resturantTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.resturantTableBindingNavigatorSaveItem});
            this.resturantTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.resturantTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.resturantTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.resturantTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.resturantTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.resturantTableBindingNavigator.Name = "resturantTableBindingNavigator";
            this.resturantTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.resturantTableBindingNavigator.Size = new System.Drawing.Size(1328, 25);
            this.resturantTableBindingNavigator.TabIndex = 49;
            this.resturantTableBindingNavigator.Text = "bindingNavigator1";
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
            // resturantTableBindingNavigatorSaveItem
            // 
            this.resturantTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resturantTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("resturantTableBindingNavigatorSaveItem.Image")));
            this.resturantTableBindingNavigatorSaveItem.Name = "resturantTableBindingNavigatorSaveItem";
            this.resturantTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.resturantTableBindingNavigatorSaveItem.Text = "Save Data";
            this.resturantTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.resturantTableBindingNavigatorSaveItem_Click);
            // 
            // resturantTableDataGridView
            // 
            this.resturantTableDataGridView.AutoGenerateColumns = false;
            this.resturantTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resturantTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.resturantTableDataGridView.DataSource = this.resturantTableBindingSource;
            this.resturantTableDataGridView.Location = new System.Drawing.Point(16, 28);
            this.resturantTableDataGridView.Name = "resturantTableDataGridView";
            this.resturantTableDataGridView.Size = new System.Drawing.Size(1272, 220);
            this.resturantTableDataGridView.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TableId";
            this.dataGridViewTextBoxColumn1.HeaderText = "TableId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TableDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "TableDescription";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // txtSearchTableDescription
            // 
            this.txtSearchTableDescription.Location = new System.Drawing.Point(805, 438);
            this.txtSearchTableDescription.Name = "txtSearchTableDescription";
            this.txtSearchTableDescription.Size = new System.Drawing.Size(400, 20);
            this.txtSearchTableDescription.TabIndex = 67;
            // 
            // btnSearchTableDescription
            // 
            this.btnSearchTableDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTableDescription.Location = new System.Drawing.Point(805, 475);
            this.btnSearchTableDescription.Name = "btnSearchTableDescription";
            this.btnSearchTableDescription.Size = new System.Drawing.Size(400, 36);
            this.btnSearchTableDescription.TabIndex = 66;
            this.btnSearchTableDescription.Text = "Search Table Description";
            this.btnSearchTableDescription.UseVisualStyleBackColor = true;
            this.btnSearchTableDescription.Click += new System.EventHandler(this.btnSearchTableDescription_Click);
            // 
            // txtSearchTableNumber
            // 
            this.txtSearchTableNumber.Location = new System.Drawing.Point(805, 316);
            this.txtSearchTableNumber.Name = "txtSearchTableNumber";
            this.txtSearchTableNumber.Size = new System.Drawing.Size(400, 20);
            this.txtSearchTableNumber.TabIndex = 65;
            // 
            // btnSearchTableNumber
            // 
            this.btnSearchTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTableNumber.Location = new System.Drawing.Point(805, 353);
            this.btnSearchTableNumber.Name = "btnSearchTableNumber";
            this.btnSearchTableNumber.Size = new System.Drawing.Size(400, 36);
            this.btnSearchTableNumber.TabIndex = 64;
            this.btnSearchTableNumber.Text = "Search  TableNumber";
            this.btnSearchTableNumber.UseVisualStyleBackColor = true;
            this.btnSearchTableNumber.Click += new System.EventHandler(this.btnSearchTableNumber_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShowAll.Location = new System.Drawing.Point(965, 570);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(109, 58);
            this.btnShowAll.TabIndex = 63;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Table Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Table Number";
            // 
            // ResturantTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 726);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchTableDescription);
            this.Controls.Add(this.btnSearchTableDescription);
            this.Controls.Add(this.txtSearchTableNumber);
            this.Controls.Add(this.btnSearchTableNumber);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.resturantTableDataGridView);
            this.Controls.Add(this.resturantTableBindingNavigator);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTableDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTableNumber);
            this.Controls.Add(this.btnBack);
            this.Name = "ResturantTable";
            this.Text = "ResturantTable";
            this.Load += new System.EventHandler(this.ResturantTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resturantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantTableBindingNavigator)).EndInit();
            this.resturantTableBindingNavigator.ResumeLayout(false);
            this.resturantTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resturantTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTableDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableNumber;
        private ResturantDataSet resturantDataSet;
        private System.Windows.Forms.BindingSource resturantTableBindingSource;
        private ResturantDataSetTableAdapters.ResturantTableTableAdapter resturantTableTableAdapter;
        private ResturantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator resturantTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton resturantTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView resturantTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtSearchTableDescription;
        private System.Windows.Forms.Button btnSearchTableDescription;
        private System.Windows.Forms.TextBox txtSearchTableNumber;
        private System.Windows.Forms.Button btnSearchTableNumber;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}