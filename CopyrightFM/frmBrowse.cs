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
            lvFound.Items.Clear();
            DataAccess db = new DataAccess();
            people = db.AllApplicants();

           // lbAllFound.DataSource = people;
           // lbAllFound.DisplayMember = "FullInfo";

            
            
            foreach(Person p in people)
            {
                ListViewItem item = new ListViewItem(p.Lastname);
                item.SubItems.Add(p.FirstName);
                item.SubItems.Add(p.OrderID.ToString());
                item.SubItems.Add(p.DateS);
                item.SubItems.Add(p.Initial);
                item.SubItems.Add(p.Release);
                item.SubItems.Add(p.PhoneNum.ToString());
                lvFound.Items.Add(item);
            }
        }
    }
}
