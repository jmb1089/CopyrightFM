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
    public partial class frmBrowse : Form
    {
        List<Person> people = new List<Person>();
        public frmBrowse()
        {
            InitializeComponent();
          

        }

        private void frmBrowse_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.AllApplicants();

           // lbAllFound.DataSource = people;
           // lbAllFound.DisplayMember = "FullInfo";

            
            
            foreach(Person p in people)
            {
                ListViewItem item = new ListViewItem(p.Lastname);
                item.SubItems.Add(p.FirstName);
                item.SubItems.Add(p.OrderID.ToString());
                item.SubItems.Add(p.Date.ToString());
                item.SubItems.Add(p.Initial);
                item.SubItems.Add(p.Release);
                lvFound.Items.Add(item);
            }
        }
    }
}
