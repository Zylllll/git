using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02_0700ManagerScore
{
    
    public partial class FrmScore : Form
    {
        public ListViewItem selectItem = null;
        public FrmScore()
        {
            InitializeComponent();
        }

        private void FrmScore_Load(object sender, EventArgs e)
        {
            txtName.Text=selectItem.SubItems[1].Text;
            txtName.ReadOnly = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            selectItem.SubItems[3].Text=txtAssert.Text;
            selectItem.SubItems[4].Text = txtScore.Text;
            this.Close();
        }
    }
}
