using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;

namespace OrderWinForm
{
    public partial class Form2 : Form
    {
        //两个comboBox的数据
        public Customer[] CustomersList { set; get; }
        public Goods[] GoodsList { set; get; }
        //下面五个都是用来创建order的
        public List<OrderDetails> OrderDetailsList { set; get; }
        public Customer CustomerSelected { set; get; }
        public Goods GoodsSelected { set; get; }
        public int OrderID { set; get; }
        public int Number { set; get; }
        //一个bool用来表示这是create来的还是update来的 true:create   false:update 用于显示在Form的text
        public Form2(bool mode)
        {
            InitializeComponent();
            OrderDetailsList = new List<OrderDetails>();
            bindingSourceOrderDt.DataSource = OrderDetailsList;
            if (mode)
            {
                this.Text = "Create";
            }
            else
            {
                this.Text = "Update";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxCustomer.DataSource = CustomersList;
            comboBoxCustomer.SelectedIndex = 0;
            CustomerSelected = CustomersList[0];
            comboBoxCustomer.DisplayMember = "CustomerName";
            comboBoxCustomer.DataBindings.Add("SelectedItem", this, "CustomerSelected");

            comboBoxGoods.DataSource = GoodsList;
            comboBoxGoods.SelectedIndex = 0;
            GoodsSelected = GoodsList[0];
            comboBoxGoods.DisplayMember = "GoodsName";
            comboBoxGoods.DataBindings.Add("SelectedItem", this, "GoodsSelected");

            textBoxOrderID.DataBindings.Add("Text", this, "OrderID");
            textBoxNum.DataBindings.Add("Text", this, "Number");
        }

        private void buttonAddOrderDt_Click(object sender, EventArgs e)
        {
            OrderDetails newOrderDetails = new OrderDetails(GoodsSelected, Number);
            if (OrderDetailsList.Contains(newOrderDetails)) return;
            OrderDetailsList.Add(newOrderDetails);
            bindingSourceOrderDt.ResetBindings(false);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order(OrderID, CustomerSelected, OrderDetailsList);
            Form1 form1 = (Form1)this.Owner;
            form1.NewOrder = newOrder;
            this.Close();
        }
    }
}
