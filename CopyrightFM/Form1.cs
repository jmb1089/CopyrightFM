using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyrightFM
{
    public partial class frmLoad : Form
    {
        
        public frmLoad()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the lookup form to seach for valid applicants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLookup_Click(object sender, EventArgs e)
        {
            frmLookup lookup = new frmLookup();
            lookup.Show();
        }
    }
}
