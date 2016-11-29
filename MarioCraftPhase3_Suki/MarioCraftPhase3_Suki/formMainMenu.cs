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

        public formMainMenu()
        {
            InitializeComponent();
        }

        public formMainMenu(formRegister registerMenu)
        {
            InitializeComponent();
            this.registerMenu = registerMenu;
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
    }
}
