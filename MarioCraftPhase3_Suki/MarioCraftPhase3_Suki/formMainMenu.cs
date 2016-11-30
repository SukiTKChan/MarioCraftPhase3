using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace MarioCraftPhase3_Suki
{
    public partial class formMainMenu : Form
    {
        private formRegister registerMenu;

        private GAMEUSER gameUser = new GAMEUSER();

        public formMainMenu()
        {
            InitializeComponent();

            //to make sure the window screen is display at centre
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        public formMainMenu(formRegister registerMenu)
        {
            InitializeComponent();
            this.registerMenu = registerMenu;

            //to make sure the window screen is display at centre
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            formRegister formRegister = new formRegister(this);

            this.Hide();
            formRegister.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            
            //if email field display error message
            if(txtEmail.Text == "")
            {
                
                MessageBox.Show("You must enter an email address!", 
                    "Email field empty",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //if email does not match records in database
           else if (txtEmail.Text == gameUser.USEREMAIL)
            {
                MessageBox.Show("Email not found, try again",
                    "Email not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            
                


            //if password field empty
            if (txtPassword.Text == "")
            {
                MessageBox.Show("You must enter a password!",
                    "Password field empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
                
            //if password does not match records in database
            else if (gameUser.USERPASSWORD != txtPassword.Text)
            {
                MessageBox.Show("Password does not match record,please try again",
                   "Invalid Password",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
           
            
           MessageBox.Show("Log In Success!", "Comfirm Log In!", 
               MessageBoxButtons.OK);
           ClearForm();
        }

        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }
    }
}
