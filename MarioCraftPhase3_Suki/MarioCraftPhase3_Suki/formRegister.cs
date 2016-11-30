using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioCraftPhase3_Suki
{
    public partial class formRegister : Form
    {
        private GAMEUSER gameUser = new GAMEUSER();

        private formMainMenu mainMenu;


        public formRegister()
        {
            InitializeComponent();
        }

        public formRegister(formMainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void formRegister_Load(object sender, EventArgs e)
        {
            toolTipEmail.SetToolTip(txtEmail, "Email address must contains @ ");

            toolTipPassword.SetToolTip(txtPassword, "Password must be at between 6-20 characters in length " +
                                 "\nMust must contain a number " +
                                 "\nAn uppercase and a lowercase ");


        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            formMainMenu mainMenu = new formMainMenu(this);
            this.Close();
            mainMenu.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if email field display error message
            if (txtEmail.Text.Equals(""))
            {

                MessageBox.Show("You must enter an email address!",
                    "Email field empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //if password field empty
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("You must enter a password!",
                    "Password field empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }



        }

        private void toolTipPassword_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTipEmail_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
