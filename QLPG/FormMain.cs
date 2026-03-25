using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPG
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GT updateDeletecs = new GT();
            updateDeletecs.Show();
            this.Hide();
        }

        private void btnAddHV_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void btnDSHV_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }

        private void btnDSPT_Click(object sender, EventArgs e)
        {
            ViewPT viewPT = new ViewPT();
            viewPT.Show();
            this.Hide();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            Tk tk = new Tk();
            tk.Show();
            this.Hide();

        }
    }
}
