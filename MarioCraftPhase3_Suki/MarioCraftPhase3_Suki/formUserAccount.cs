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
    public partial class formUserAccount : Form
    {

        MarioCraftModel ctx = new MarioCraftModel();

        private formMainMenu mainMenu;

        GAMEUSER gu = new GAMEUSER();
        GAMEUSERDETAIL u = new GAMEUSERDETAIL();

        private String email;
       

        public formUserAccount()
        {
            InitializeComponent();
        }

        public formUserAccount(String email)
        {
            InitializeComponent();
          
            this.email = email;
        }
        public formUserAccount(formMainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnUserDetail_Click(object sender, EventArgs e)
        {
            /*MarioCraftModel ctx = new MarioCraftModel();
            GAMEUSER viewUser = new GAMEUSER();

            var user = from u in ctx.GAMEUSERs where u.USERID == 73 select u;
            
            
            this.txtEmail.Text = user.FirstOrDefault().USEREMAIL;*/

            //this show current login user details
            this.gAMEUSERDETAILSTableAdapter.FillBy(dataSet1.GAMEUSERDETAILS, email.Trim());
            grdDetails.Show();
            
            
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            formMainMenu mainMenu = new formMainMenu(this);
            this.Close();
            mainMenu.Show();
        }

        private void formGameScreen_Load(object sender, EventArgs e)
        {
            

        }

        private void grdDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpAmend.Show();

            //var userID = from u in ctx.GAMEUSERs where u.USERID == id  select u;
            var userEmail = from u in ctx.GAMEUSERs where u.USEREMAIL == email select u;
            //var userPassword = from u in ctx.GAMEUSERs where u.USERPASSWORD == password select u;

            //this.txtID.Text = userID.FirstOrDefault().USERID.ToString();
            this.txtEmail.Text = userEmail.FirstOrDefault().USEREMAIL.Trim();
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email field cannot be empty", "Email field empty",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            var user = (from u in ctx.GAMEUSERs where u.USEREMAIL == txtEmail.Text select u);
            var emailExist = user.FirstOrDefault(a => a.USEREMAIL.Equals(txtEmail.Text));

            //if amended email does not already exist in db
            if(emailExist == null)
            {
                using (var context = new MarioCraftModel())
                {
                    try//update new email
                    {
                        gu.USEREMAIL = txtEmail.Text;
                        
                        context.SaveChanges();
                        MessageBox.Show("Details updated", "Account Details updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }     

        }   
    }
}
