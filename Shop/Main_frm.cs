using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }

        private void Main_frm_Load(object sender, EventArgs e)
        {

        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
           
            Guest_frm guest = new Guest_frm();
           // guest.Controls.Add(guest);
            guest.Show();
        }
    }
}
