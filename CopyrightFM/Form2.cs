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
    public partial class frmLookup : Form
    {
        /// <summary>
        /// list that holds the people that were found in the database
        /// </summary>
        List<Person> people = new List<Person>();
        public frmLookup()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Looks up the applicant based on the last name provided 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(txtLookup.Text);

            if (people.Count == 0)
                MessageBox.Show("No Data Exists for this information.");
            else
            {
                lbFound.DataSource = people;
                lbFound.DisplayMember = "FullInfo";
            }


        }
    }
}
