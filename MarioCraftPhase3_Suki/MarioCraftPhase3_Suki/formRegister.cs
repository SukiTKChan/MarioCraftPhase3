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

            MarioCraftModel ctx = new MarioCraftModel();
            GAMEUSER addGameUser = new GAMEUSER();

            var user = from u in ctx.GAMEUSERs where u.USEREMAIL == txtEmail.Text select u;

            //check if user email matches database
            var userExist = user.FirstOrDefault(a => a.USEREMAIL.Equals(txtEmail.Text));

            //if either email or password field empty display error message
            if (txtEmail.Text.Equals("") && txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Email and Password field must not be empty", "Email or Password field empty",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //if email does not match records in database
            if (userExist != null)
            {
                //if password matches records in database
                if (userExist.USERPASSWORD.Equals(txtPassword.Text))
                {
                    MessageBox.Show("Game User already exist, please log in", "Registeration error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    formMainMenu mainMenu = new formMainMenu(this);
                    this.Close();
                    mainMenu.Show();
                    
                }
                    
             }
            else //insert user
            {
                using (var context = new MarioCraftModel())
                {

                    addGameUser.USEREMAIL = txtEmail.Text;
                    addGameUser.USERPASSWORD = txtPassword.Text;

                    try
                    {
                        context.GAMEUSERs.Add(addGameUser);
                        context.SaveChanges();
                        MessageBox.Show(addGameUser.USEREMAIL + "\n" + addGameUser.USERPASSWORD + "\n" +
                            "You have Successfully Registered, Please log in", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        formMainMenu mainMenu = new formMainMenu(this);
                        this.Close();
                        mainMenu.Show();

                        ClearForm();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                } 
             }
        }
        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }
        
      } 
}
