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

        

        public Form1()
        {

            //Initializing an account to test if the system is working properly
            InitializeComponent();
            Account.accounts.Add(new Account("Gabriel Francisco", 17100, 4800.00));
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

        //Searching block---------------------------------------------------------------------------------
        private void Button1_Click(object sender, EventArgs e)
        {
            //This is the search method using the lambda expression to search for 
            //an account number, then showing in the respective text boxes.

            int textoNumero = Convert.ToInt32(textBox1.Text);
            if (Account.accounts.Exists(i => i.Number == textoNumero))
            {
                Account account = Account.accounts.Find(i => i.Number == textoNumero);
                txtName.Text = account.Name;
                txtCash.Text = Convert.ToString(account.Cash);
            }
            else
            {
                MessageBox.Show("This account doesn't exist!");
                textBox1.Text = null;
                txtName.Text = null;
                txtCash.Text = null;
            }
        }

        //Deposit operation method==============================================================================
        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                int textoNumero = Convert.ToInt32(textBox1.Text);
                double getCash = Convert.ToDouble(txtGetCash.Text);
                Account account = Account.accounts.Find(i => i.Number == textoNumero);
                account.Deposit(getCash);
            }
            catch
            {
                MessageBox.Show("You need to search an account in the ''Account'' field to make operations!");
            }
        }
        //======================================================================================================

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        //TakeCash operation method==============================================================================
        private void BtnTake_Click(object sender, EventArgs e)
        {
            try
            {
                int textoNumero = Convert.ToInt32(textBox1.Text);
                double takeCash = Convert.ToDouble(txtTakeCash.Text);
                Account account = Account.accounts.Find(i => i.Number == textoNumero);
                account.TakeOut(takeCash);
            }
            catch
            {
                MessageBox.Show("You need to search an account in the ''Account'' field to make operations!");
            }
        }
        //======================================================================================================

        //Creating a new account in other window
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
