
namespace OrderWinForm
{
    partial class Form2
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
            this.labelOrderID = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelGoods = new System.Windows.Forms.Label();
            this.comboBoxGoods = new System.Windows.Forms.ComboBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.buttonAddOrderDt = new System.Windows.Forms.Button();
            this.dataGridViewOrderDt = new System.Windows.Forms.DataGridView();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.orderGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderGoodsNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderGoodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceOrderDt = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDt)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderDt)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(36, 35);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(106, 24);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "OrderID:";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(148, 32);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(136, 35);
            this.textBoxOrderID.TabIndex = 1;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(24, 89);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(118, 24);
            this.labelCustomer.TabIndex = 2;
            this.labelCustomer.Text = "Customer:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(148, 89);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(136, 32);
            this.comboBoxCustomer.TabIndex = 3;
            // 
            // labelGoods
            // 
            this.labelGoods.AutoSize = true;
            this.labelGoods.Location = new System.Drawing.Point(60, 168);
            this.labelGoods.Name = "labelGoods";
            this.labelGoods.Size = new System.Drawing.Size(82, 24);
            this.labelGoods.TabIndex = 4;
            this.labelGoods.Text = "Goods:";
            // 
            // comboBoxGoods
            // 
            this.comboBoxGoods.FormattingEnabled = true;
            this.comboBoxGoods.Location = new System.Drawing.Point(148, 168);
            this.comboBoxGoods.Name = "comboBoxGoods";
            this.comboBoxGoods.Size = new System.Drawing.Size(136, 32);
            this.comboBoxGoods.TabIndex = 5;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(356, 168);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(94, 24);
            this.labelNum.TabIndex = 6;
            this.labelNum.Text = "Number:";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(456, 165);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(142, 35);
            this.textBoxNum.TabIndex = 7;
            // 
            // buttonAddOrderDt
            // 
            this.buttonAddOrderDt.Location = new System.Drawing.Point(691, 151);
            this.buttonAddOrderDt.Name = "buttonAddOrderDt";
            this.buttonAddOrderDt.Size = new System.Drawing.Size(108, 58);
            this.buttonAddOrderDt.TabIndex = 8;
            this.buttonAddOrderDt.Text = "Add";
            this.buttonAddOrderDt.UseVisualStyleBackColor = true;
            this.buttonAddOrderDt.Click += new System.EventHandler(this.buttonAddOrderDt_Click);
            // 
            // dataGridViewOrderDt
            // 
            this.dataGridViewOrderDt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrderDt.AutoGenerateColumns = false;
            this.dataGridViewOrderDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderGoodsDataGridViewTextBoxColumn,
            this.orderGoodsNumDataGridViewTextBoxColumn,
            this.orderGoodsPriceDataGridViewTextBoxColumn});
            this.dataGridViewOrderDt.DataSource = this.bindingSourceOrderDt;
            this.dataGridViewOrderDt.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewOrderDt.Name = "dataGridViewOrderDt";
            this.dataGridViewOrderDt.RowHeadersWidth = 82;
            this.dataGridViewOrderDt.RowTemplate.Height = 37;
            this.dataGridViewOrderDt.Size = new System.Drawing.Size(830, 349);
            this.dataGridViewOrderDt.TabIndex = 9;
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Location = new System.Drawing.Point(12, 3);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(166, 24);
            this.labelOrderDetails.TabIndex = 10;
            this.labelOrderDetails.Text = "OrderDetails:";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonDone);
            this.panelTop.Controls.Add(this.buttonAddOrderDt);
            this.panelTop.Controls.Add(this.textBoxNum);
            this.panelTop.Controls.Add(this.labelNum);
            this.panelTop.Controls.Add(this.comboBoxGoods);
            this.panelTop.Controls.Add(this.labelGoods);
            this.panelTop.Controls.Add(this.comboBoxCustomer);
            this.panelTop.Controls.Add(this.labelCustomer);
            this.panelTop.Controls.Add(this.textBoxOrderID);
            this.panelTop.Controls.Add(this.labelOrderID);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(854, 221);
            this.panelTop.TabIndex = 11;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelOrderDetails);
            this.panelBottom.Controls.Add(this.dataGridViewOrderDt);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 221);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(854, 408);
            this.panelBottom.TabIndex = 12;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(691, 35);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(106, 64);
            this.buttonDone.TabIndex = 9;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // orderGoodsDataGridViewTextBoxColumn
            // 
            this.orderGoodsDataGridViewTextBoxColumn.DataPropertyName = "OrderGoods";
            this.orderGoodsDataGridViewTextBoxColumn.HeaderText = "OrderGoods";
            this.orderGoodsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderGoodsDataGridViewTextBoxColumn.Name = "orderGoodsDataGridViewTextBoxColumn";
            this.orderGoodsDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderGoodsNumDataGridViewTextBoxColumn
            // 
            this.orderGoodsNumDataGridViewTextBoxColumn.DataPropertyName = "OrderGoodsNum";
            this.orderGoodsNumDataGridViewTextBoxColumn.HeaderText = "OrderGoodsNum";
            this.orderGoodsNumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderGoodsNumDataGridViewTextBoxColumn.Name = "orderGoodsNumDataGridViewTextBoxColumn";
            this.orderGoodsNumDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderGoodsPriceDataGridViewTextBoxColumn
            // 
            this.orderGoodsPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderGoodsPrice";
            this.orderGoodsPriceDataGridViewTextBoxColumn.HeaderText = "OrderGoodsPrice";
            this.orderGoodsPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderGoodsPriceDataGridViewTextBoxColumn.Name = "orderGoodsPriceDataGridViewTextBoxColumn";
            this.orderGoodsPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // bindingSourceOrderDt
            // 
            this.bindingSourceOrderDt.DataSource = typeof(OrderManagement.OrderDetails);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 629);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(880, 700);
            this.Name = "Form2";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDt)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderDt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelGoods;
        private System.Windows.Forms.ComboBox comboBoxGoods;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button buttonAddOrderDt;
        private System.Windows.Forms.DataGridView dataGridViewOrderDt;
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.BindingSource bindingSourceOrderDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderGoodsNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderGoodsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonDone;
    }
}