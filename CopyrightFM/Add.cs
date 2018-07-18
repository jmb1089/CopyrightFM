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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.AddUser(txtFirst.Text, txtLast.Text, txtOrderID.Text, txtDate.Text, txtInitial.Text, txtPhoneNum.Text);
            //set text fields to empty 
        }
    }
}
