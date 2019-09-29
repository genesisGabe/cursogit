using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AnotherBank
{
    public partial class Form1 : Form
    {
       
        public static List<Account> accounts = new List<Account>();

        Account a1 = new Account("Gabriel Francisco", 17100, 4800.00);
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int textoNumero = Convert.ToInt32(textBox1.Text);
            if (accounts.Exists(x => textoNumero == a1.Number))
            {
                txtName.Text = a1.Name;
                txtCash.Text = Convert.ToString(a1.Cash);
            }
            else
            {
                MessageBox.Show("This account doesn't exist!");
                textBox1.Text = null;
            }
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            double getCash = Convert.ToDouble(txtGetCash.Text);
            a1.Deposit(getCash);
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BtnTake_Click(object sender, EventArgs e)
        {
            double takeCash = Convert.ToDouble(txtTakeCash.Text);
            a1.TakeOut(takeCash);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NewAccount createNewAccount = new NewAccount();
            createNewAccount.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
