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
        private formGameScreen gameScreen;

        GAMEUSER gameUser = new GAMEUSER();


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

        public formMainMenu(formGameScreen gameScreen)
        {
            InitializeComponent();
            this.gameScreen = gameScreen;

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
            
           MarioCraftModel ctx = new MarioCraftModel();
           //gameUser = ctx.GAMEUSERs.First();
           
           var user = from u in ctx.GAMEUSERs where u.USEREMAIL == txtEmail.Text select u;
           //var gu = from u in ctx.GAMEUSERs where u.USERPASSWORD == txtPassword.Text select u;

            //if either email or password field empty display error message
            if (txtEmail.Text.Equals("") && txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Email and Password field must not be empty", "Email or Password field empty",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //https://dotprogramming.blogspot.com/2015/09/login-form-using-entity-framework-in.html

            //check if user email matches database
            var userExist = user.FirstOrDefault(a => a.USEREMAIL.Equals(txtEmail.Text));

            //if email does not match records in database
            if (userExist != null)
            {
                //if password matches records in database
                if (userExist.USERPASSWORD.Equals(txtPassword.Text))
                {
                    MessageBox.Show("Log in success!", "Log In Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();

                    formGameScreen gameScreen = new formGameScreen (this);
                    this.Close();
                    gameScreen.Show();
                }
                else
                {
                    errorProvider1.SetError(txtPassword,"Password does not match record,please try again");
                    txtPassword.Focus();
                    return;
                }

            }
            else
            {
                MessageBox.Show("Game user not found",
                "Invalid Email address",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            
           
        }

        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

    }
}
