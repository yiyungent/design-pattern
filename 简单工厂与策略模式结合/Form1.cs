using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单工厂与策略模式结合
{
    public partial class Form1 : Form
    {
        private double _total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            CashContext csct = new CashContext(cboMode.SelectedItem.ToString());
            double totalPrice = 0.0d;
            totalPrice = csct.GetResult(Convert.ToDouble(textPrice.Text) * Convert.ToDouble(textNum.Text));
            this._total += totalPrice;
            listBox1.Items.Add("单价：" + textPrice.Text + "数量" + textNum.Text + "  " + cboMode.SelectedItem.ToString() + "  " + "总计：" + totalPrice.ToString());
            lblTotal.Text = this._total.ToString();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this._total = 0.0d;
            textPrice.Clear();
            textNum.Clear();
            listBox1.Items.Clear();
            lblTotal.Text = "0.00";
        }
    }
}
