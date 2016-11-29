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
    public partial class formMainMenu : Form
    {
        private formRegister registerMenu;

        private int gameUserID;

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

        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
          
        }
    }
}
