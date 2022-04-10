
namespace OrderWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelInput = new System.Windows.Forms.Panel();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxGoods = new System.Windows.Forms.ComboBox();
            this.buttonFindCus = new System.Windows.Forms.Button();
            this.buttonFindPrice = new System.Windows.Forms.Button();
            this.buttonFindGoods = new System.Windows.Forms.Button();
            this.buttonFindNum = new System.Windows.Forms.Button();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelGoods = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.labelOrderNum = new System.Windows.Forms.Label();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.dataGridViewFind = new System.Windows.Forms.DataGridView();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAllOrder = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCustomerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allGoodsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFindOrder = new System.Windows.Forms.BindingSource(this.components);
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFind)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFindOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.comboBoxCustomer);
            this.panelInput.Controls.Add(this.comboBoxGoods);
            this.panelInput.Controls.Add(this.buttonFindCus);
            this.panelInput.Controls.Add(this.buttonFindPrice);
            this.panelInput.Controls.Add(this.buttonFindGoods);
            this.panelInput.Controls.Add(this.buttonFindNum);
            this.panelInput.Controls.Add(this.labelCustomer);
            this.panelInput.Controls.Add(this.labelGoods);
            this.panelInput.Controls.Add(this.textBoxPrice);
            this.panelInput.Controls.Add(this.labelPrice);
            this.panelInput.Controls.Add(this.textBoxOrderNumber);
            this.panelInput.Controls.Add(this.labelOrderNum);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1494, 172);
            this.panelInput.TabIndex = 0;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(957, 127);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(145, 32);
            this.comboBoxCustomer.TabIndex = 12;
            // 
            // comboBoxGoods
            // 
            this.comboBoxGoods.FormattingEnabled = true;
            this.comboBoxGoods.Location = new System.Drawing.Point(231, 124);
            this.comboBoxGoods.Name = "comboBoxGoods";
            this.comboBoxGoods.Size = new System.Drawing.Size(146, 32);
            this.comboBoxGoods.TabIndex = 11;
            // 
            // buttonFindCus
            // 
            this.buttonFindCus.Location = new System.Drawing.Point(1149, 114);
            this.buttonFindCus.Name = "buttonFindCus";
            this.buttonFindCus.Size = new System.Drawing.Size(123, 51);
            this.buttonFindCus.TabIndex = 10;
            this.buttonFindCus.Text = "Find";
            this.buttonFindCus.UseVisualStyleBackColor = true;
            this.buttonFindCus.Click += new System.EventHandler(this.buttonFindCus_Click);
            // 
            // buttonFindPrice
            // 
            this.buttonFindPrice.Location = new System.Drawing.Point(1149, 38);
            this.buttonFindPrice.Name = "buttonFindPrice";
            this.buttonFindPrice.Size = new System.Drawing.Size(123, 51);
            this.buttonFindPrice.TabIndex = 9;
            this.buttonFindPrice.Text = "Find";
            this.buttonFindPrice.UseVisualStyleBackColor = true;
            this.buttonFindPrice.Click += new System.EventHandler(this.buttonFindPrice_Click);
            // 
            // buttonFindGoods
            // 
            this.buttonFindGoods.Location = new System.Drawing.Point(426, 114);
            this.buttonFindGoods.Name = "buttonFindGoods";
            this.buttonFindGoods.Size = new System.Drawing.Size(123, 51);
            this.buttonFindGoods.TabIndex = 8;
            this.buttonFindGoods.Text = "Find";
            this.buttonFindGoods.UseVisualStyleBackColor = true;
            this.buttonFindGoods.Click += new System.EventHandler(this.buttonFindGoods_Click);
            // 
            // buttonFindNum
            // 
            this.buttonFindNum.Location = new System.Drawing.Point(426, 38);
            this.buttonFindNum.Name = "buttonFindNum";
            this.buttonFindNum.Size = new System.Drawing.Size(123, 51);
            this.buttonFindNum.TabIndex = 7;
            this.buttonFindNum.Text = "Find";
            this.buttonFindNum.UseVisualStyleBackColor = true;
            this.buttonFindNum.Click += new System.EventHandler(this.buttonFindNum_Click);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(811, 127);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(130, 24);
            this.labelCustomer.TabIndex = 6;
            this.labelCustomer.Text = "Customers:";
            // 
            // labelGoods
            // 
            this.labelGoods.AutoSize = true;
            this.labelGoods.Location = new System.Drawing.Point(130, 127);
            this.labelGoods.Name = "labelGoods";
            this.labelGoods.Size = new System.Drawing.Size(82, 24);
            this.labelGoods.TabIndex = 3;
            this.labelGoods.Text = "Goods:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(957, 46);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(144, 35);
            this.textBoxPrice.TabIndex = 2;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(859, 49);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(82, 24);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(231, 46);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(146, 35);
            this.textBoxOrderNumber.TabIndex = 0;
            // 
            // labelOrderNum
            // 
            this.labelOrderNum.AutoSize = true;
            this.labelOrderNum.Location = new System.Drawing.Point(58, 49);
            this.labelOrderNum.Name = "labelOrderNum";
            this.labelOrderNum.Size = new System.Drawing.Size(154, 24);
            this.labelOrderNum.TabIndex = 0;
            this.labelOrderNum.Text = "OrderNumber:";
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewAll.AutoGenerateColumns = false;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderCustomerDataGridViewTextBoxColumn,
            this.orderTotalPriceDataGridViewTextBoxColumn,
            this.allGoodsDataGridViewTextBoxColumn});
            this.dataGridViewAll.DataSource = this.bindingSourceAllOrder;
            this.dataGridViewAll.Location = new System.Drawing.Point(12, 6);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.RowHeadersWidth = 82;
            this.dataGridViewAll.RowTemplate.Height = 37;
            this.dataGridViewAll.Size = new System.Drawing.Size(722, 614);
            this.dataGridViewAll.TabIndex = 0;
            this.dataGridViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAll_CellContentClick);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.labelMessage);
            this.panelButtons.Controls.Add(this.buttonImport);
            this.panelButtons.Controls.Add(this.buttonExport);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Controls.Add(this.buttonCreate);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 172);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1494, 125);
            this.panelButtons.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(1149, 52);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(106, 24);
            this.labelMessage.TabIndex = 16;
            this.labelMessage.Text = "welcome!";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(794, 38);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(123, 51);
            this.buttonImport.TabIndex = 15;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(611, 38);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(123, 51);
            this.buttonExport.TabIndex = 14;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(426, 38);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(123, 51);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(243, 38);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(123, 51);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(62, 38);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(123, 51);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // dataGridViewFind
            // 
            this.dataGridViewFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewFind.AutoGenerateColumns = false;
            this.dataGridViewFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.orderCustomerDataGridViewTextBoxColumn1,
            this.orderTotalPriceDataGridViewTextBoxColumn1,
            this.allGoodsDataGridViewTextBoxColumn1});
            this.dataGridViewFind.DataSource = this.bindingSourceFindOrder;
            this.dataGridViewFind.Location = new System.Drawing.Point(761, 6);
            this.dataGridViewFind.Name = "dataGridViewFind";
            this.dataGridViewFind.RowHeadersWidth = 82;
            this.dataGridViewFind.RowTemplate.Height = 37;
            this.dataGridViewFind.Size = new System.Drawing.Size(722, 614);
            this.dataGridViewFind.TabIndex = 1;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.panel1);
            this.panelDataGridView.Controls.Add(this.panel2);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 297);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(1494, 632);
            this.panelDataGridView.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 632);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1494, 632);
            this.panel2.TabIndex = 1;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 25;
            // 
            // orderCustomerDataGridViewTextBoxColumn
            // 
            this.orderCustomerDataGridViewTextBoxColumn.DataPropertyName = "OrderCustomer";
            this.orderCustomerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.orderCustomerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderCustomerDataGridViewTextBoxColumn.Name = "orderCustomerDataGridViewTextBoxColumn";
            this.orderCustomerDataGridViewTextBoxColumn.Width = 75;
            // 
            // orderTotalPriceDataGridViewTextBoxColumn
            // 
            this.orderTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderTotalPrice";
            this.orderTotalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.orderTotalPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderTotalPriceDataGridViewTextBoxColumn.Name = "orderTotalPriceDataGridViewTextBoxColumn";
            this.orderTotalPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // allGoodsDataGridViewTextBoxColumn
            // 
            this.allGoodsDataGridViewTextBoxColumn.DataPropertyName = "AllGoods";
            this.allGoodsDataGridViewTextBoxColumn.HeaderText = "All Goods";
            this.allGoodsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.allGoodsDataGridViewTextBoxColumn.Name = "allGoodsDataGridViewTextBoxColumn";
            this.allGoodsDataGridViewTextBoxColumn.ReadOnly = true;
            this.allGoodsDataGridViewTextBoxColumn.Width = 200;
            // 
            // bindingSourceAllOrder
            // 
            this.bindingSourceAllOrder.DataSource = typeof(OrderManagement.Order);
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.Width = 25;
            // 
            // orderCustomerDataGridViewTextBoxColumn1
            // 
            this.orderCustomerDataGridViewTextBoxColumn1.DataPropertyName = "OrderCustomer";
            this.orderCustomerDataGridViewTextBoxColumn1.HeaderText = "Customer";
            this.orderCustomerDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.orderCustomerDataGridViewTextBoxColumn1.Name = "orderCustomerDataGridViewTextBoxColumn1";
            this.orderCustomerDataGridViewTextBoxColumn1.Width = 75;
            // 
            // orderTotalPriceDataGridViewTextBoxColumn1
            // 
            this.orderTotalPriceDataGridViewTextBoxColumn1.DataPropertyName = "OrderTotalPrice";
            this.orderTotalPriceDataGridViewTextBoxColumn1.HeaderText = "Total Price";
            this.orderTotalPriceDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.orderTotalPriceDataGridViewTextBoxColumn1.Name = "orderTotalPriceDataGridViewTextBoxColumn1";
            this.orderTotalPriceDataGridViewTextBoxColumn1.Width = 200;
            // 
            // allGoodsDataGridViewTextBoxColumn1
            // 
            this.allGoodsDataGridViewTextBoxColumn1.DataPropertyName = "AllGoods";
            this.allGoodsDataGridViewTextBoxColumn1.HeaderText = "All Goods";
            this.allGoodsDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.allGoodsDataGridViewTextBoxColumn1.Name = "allGoodsDataGridViewTextBoxColumn1";
            this.allGoodsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.allGoodsDataGridViewTextBoxColumn1.Width = 200;
            // 
            // bindingSourceFindOrder
            // 
            this.bindingSourceFindOrder.DataSource = typeof(OrderManagement.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 929);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelInput);
            this.MaximumSize = new System.Drawing.Size(1520, 2000);
            this.MinimumSize = new System.Drawing.Size(1520, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFind)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFindOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label labelOrderNum;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Button buttonFindCus;
        private System.Windows.Forms.Button buttonFindPrice;
        private System.Windows.Forms.Button buttonFindGoods;
        private System.Windows.Forms.Button buttonFindNum;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelGoods;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DataGridView dataGridViewFind;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSourceAllOrder;
        private System.Windows.Forms.BindingSource bindingSourceFindOrder;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxGoods;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCustomerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn allGoodsDataGridViewTextBoxColumn1;
    }
}

