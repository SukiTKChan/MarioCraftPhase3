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

        public formGameScreen()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(formGameScreen_KeyDown);
        }
        public formGameScreen(formMainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnUserDetail_Click(object sender, EventArgs e)
        {

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
            int x = character.Location.X;
            int y = character.Location.Y;

            if (e.KeyCode == Keys.Right)
                x += 2;
            else if (e.KeyCode == Keys.Left)
                x -= 2;


            character.Location = new System.Drawing.Point(x, y);
        }
    }
}
