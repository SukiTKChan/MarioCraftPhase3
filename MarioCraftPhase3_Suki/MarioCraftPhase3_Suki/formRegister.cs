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
        }


        private void formRegister_Load(object sender, EventArgs e)
        {

        }

        private void toolTipPassword_Popup(object sender, PopupEventArgs e)
        {
            toolTipPassword.Show("Password must be at between 6-20 characters in length " + 
                                 "Must must contain a number " +
                                 "An uppercase and a lowercase ",lblPassword);
        }

        private void toolTipEmail_Popup(object sender, PopupEventArgs e)
        {
            toolTipPassword.Show("Email address must contains @ ", lblEmail);
        }
    }
}
