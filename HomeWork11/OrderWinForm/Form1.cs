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
    public partial class Form1 : Form
    {
        //两个comboBox用的数据数组：
        public Customer[] CustomersList { set; get; } = { new Customer("Bark", "18022483577"), new Customer("Karb", "13924530503") };
        public Goods[] GoodsList { set; get; } = { new Goods("Pen", 5), new Goods("Book", 10), new Goods("Ruler", 20) };
        //申明OrderService
        public OrderService Os { set; get; }
        //四个find组件的绑定数据：
        public int OrderNumber { set; get; }
        public double Price { set; get; }
        public Customer CustomerSelected { set; get; }
        public Goods GoodsSelected { set; get; }
        //接收子窗口传来的Order
        public Order NewOrder { set; get; }
        //DataGridView的选择的行号，delete用的绑定：
        public int RowChosen { set; get; }
        //查询窗口的数组
        public List<Order> FindOrderList { set; get; }

        public Form1()
        {
            InitializeComponent();
            Os = new OrderService();
            bindingSourceAllOrder.DataSource = Os.OrderList;
            bindingSourceFindOrder.DataSource = FindOrderList;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            comboBoxCustomer.DataSource = CustomersList;
            comboBoxCustomer.SelectedIndex = 0;
            comboBoxCustomer.DisplayMember = "CustomerName";
            comboBoxCustomer.DataBindings.Add("SelectedItem", this, "CustomerSelected");

            comboBoxGoods.DataSource = GoodsList;
            comboBoxGoods.SelectedIndex = 1;
            comboBoxGoods.DisplayMember = "GoodsName";
            comboBoxGoods.DataBindings.Add("SelectedItem", this, "GoodsSelected");

            textBoxOrderNumber.Text = "0";
            textBoxOrderNumber.DataBindings.Add("Text", this, "OrderNumber");

            textBoxPrice.Text = "0";
            textBoxPrice.DataBindings.Add("Text", this, "Price");

            RowChosen = -1;

        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(true);
            form2.CustomersList = CustomersList;
            form2.GoodsList = GoodsList;
            form2.Owner = this;
            form2.ShowDialog();
            try
            {
                Os.AddOrder(NewOrder);
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
                labelMessage.Text = e1.Message;

            }
            bindingSourceAllOrder.ResetBindings(false);

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (RowChosen >= Os.OrderList.Count || RowChosen < 0) return;
            Os.DelOrder(Os.OrderList[RowChosen].OrderID);
            bindingSourceAllOrder.ResetBindings(false);
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (RowChosen >= Os.OrderList.Count || RowChosen < 0) return;
            Form2 form2 = new Form2(false, Os.OrderList[RowChosen].OrderID);
            form2.CustomersList = CustomersList;
            form2.GoodsList = GoodsList;
            form2.Owner = this;
            form2.ShowDialog();
            try
            {
                Os.ChangeOrder(NewOrder);
            }
            catch (Exception e1)
            {
                labelMessage.Text = e1.Message;
            }
            bindingSourceAllOrder.ResetBindings(false);
        }
        private void buttonFindNum_Click(object sender, EventArgs e)
        {
            bindingSourceFindOrder.DataSource = new List<Order>() { Os.FindOrder(OrderNumber) };
            bindingSourceFindOrder.ResetBindings(false);
        }
        private void buttonFindPrice_Click(object sender, EventArgs e)
        {
            bindingSourceFindOrder.DataSource = Os.FindOrder(Price);
            bindingSourceFindOrder.ResetBindings(false);
        }
        private void buttonFindGoods_Click(object sender, EventArgs e)
        {
            bindingSourceFindOrder.DataSource = Os.FindOrder(GoodsSelected.GoodsName);
            bindingSourceFindOrder.ResetBindings(false);
        }
        private void buttonFindCus_Click(object sender, EventArgs e)
        {
            bindingSourceFindOrder.DataSource = Os.FindOrder(CustomerSelected);
            bindingSourceFindOrder.ResetBindings(false);
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Os.Export(sfd.FileName);
            }

        }
        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Os.Import(ofd.FileName);
                bindingSourceAllOrder.ResetBindings(false);
            }
        }
        private void dataGridViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowChosen = e.RowIndex;
            labelMessage.Text = "Choose row " + RowChosen.ToString();
        }
    }
}
