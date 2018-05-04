using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_0200单例
{
    public partial class FrmPlay : Form
    {
        private FrmPlay()
        {
            InitializeComponent();
        }
        public string path;
        public static FrmPlay onlyOne;
        //Load执行一次
        private void FrmPlay_Load(object sender, EventArgs e)
        {
            
        }
        public void PlaySong() 
        {
            Player1.URL = path;
        }

        public static FrmPlay getInstance()
        {
            if (onlyOne==null)
            {
                onlyOne = new FrmPlay();
            }
            return onlyOne;
        }

        private void FrmPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            //托管代码：被CLR监管的代码
            onlyOne = null;
        }
    }
}
