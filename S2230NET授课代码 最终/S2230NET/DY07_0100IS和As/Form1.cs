using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DY07_0100IS和As
{
    public partial class Form1 : Gdu.WinFormUI.GMForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


         int count= this.Controls.Count;
           MessageBox.Show(count.ToString());
        //            1.获取到窗体上所有的控件
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) //A对象  是不是  B类型
                {
                    //TextBox box = (TextBox)item;
                    TextBox box = item as TextBox;//as 做类型转换
                    box.Text = "";
                }
            }//2.循环判定该控件的类型是不是TextBox


        //3.如果是，那么Text="";

        }
    }
}
