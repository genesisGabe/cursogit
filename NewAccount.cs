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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e) { }
        private void NewAccount_Load(object sender, EventArgs e) { }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //Signing in a new account

            if(txtName.Text != null && txtNumber.Text != null)
            {
                try
                {
                    string name = txtName.Text;
                    int number = Convert.ToInt32(txtNumber.Text);

                    Account.accounts.Add(new Account(name, number));
                    Close();
                }
                catch
                {
                    MessageBox.Show("Enter a name and number to go forward!");
                }
            }
           
        }
    }
}
