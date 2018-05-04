using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_0100简单工厂计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //1.从界面获取两个操作数
            int numleft = Convert.ToInt32(txtLeft.Text);
            int numright = Convert.ToInt32(txtRight.Text);
            //2.获取运算符
            string oper = cboOper.Text;
            //3.用Switch结构判定  运算符 和底层   运算类的对应关系

            //创建对象的方案：四种
            //1.new 最低级别的
            //2.工厂
            //3.反射
            //4.克隆
            Calculator cal=CalculatorFactory.getInstance(oper);
            //4.给对应运算类的两个操作数赋值
            cal.NumLeft = numleft;

            cal.NumRight = numright;

            //5.调度计算方法
            try
            {
                //6.将结果返回
                int result=cal.Calc();
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtResult.Text ="";
            }

           
        }
    }
}
