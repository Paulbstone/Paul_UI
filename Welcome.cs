using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace howto_shaped_button
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void wel_start_button_Click(object sender, EventArgs e)
        {
            var welstartclick = new intro_form();
            welstartclick.Show();
        }
    }
}
