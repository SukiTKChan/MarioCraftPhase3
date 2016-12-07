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
    public partial class formGameScreen : Form
    {
        private formMainMenu mainMenu;

        GAMEUSER gu = new GAMEUSER();

        String email;

        public formGameScreen()
        {
            InitializeComponent();
            //KeyDown += new KeyEventHandler(formGameScreen_KeyDown);
        }

        public formGameScreen(String email)
        {
            InitializeComponent();
            this.email = email;
        }
        public formGameScreen(formMainMenu mainMenu)
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
            this.gAMEUSERDETAILSTableAdapter.FillBy(dataSet1.GAMEUSERDETAILS, email);
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

        private void formGameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            
            //movement on player
            if (e.KeyCode == Keys.W)
            {
                player.Top -= 10;
            }
                
            if (e.KeyCode == Keys.S)
            {
                player.Top += 10;
            }

            if (e.KeyCode == Keys.A)
            {
                player.Left -= 10;
            }

            if (e.KeyCode == Keys.D)
            {
                player.Left += 10;
            }

            //player health
            if (e.KeyCode == Keys.H)
            {
                playerHealthBar.Value -= 10;
            }
            if(playerHealthBar.Value == 0)
            {
                MessageBox.Show("Player Health reached 0",
                "Game Over",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnViewRucksack_Click(object sender, EventArgs e)
        {
            //http://www.worldbestlearningcenter.com/index_files/csharp-entity-framework-datagridview.htm
            var ctx = new MarioCraftModel();
            BindingSource bi = new BindingSource();
            bi.DataSource = ctx.TOOLs;
            grdRucksack.DataSource = bi;
            grdRucksack.Refresh();
        }

   

    }
}
