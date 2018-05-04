using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grade grade = new Grade();

            Student s1 = new Student();
            s1.StuName = "甄子丹";


            Student s2 = new Student();
            s2.StuName = "成龙";


            Student s3 = new Student();
            s3.StuName = "李小龙";

            Student s4 = new Student();
            s4.StuName = "吴京";

            Student s5 = new Student();
            s5.StuName = "洪金宝";

            Student s6 = new Student();
            s6.StuName = "元彪";

            grade.AddStudent(s1);
            grade.AddStudent(s2);

            grade.AddStudent(s3);
            grade.AddStudent(s4);

            grade.AddStudent(s5);
            grade.AddStudent(s6);

            List<string> list=grade.DisplayStudent(new Point(){X=1,Y=1});

            foreach (string item in list)
            {
                string[] temp = item.Split(':');
                string t1 = temp[0];//学生姓名

                int x = Convert.ToInt32(temp[1]);//x轴坐标
                int y = Convert.ToInt32(temp[2]);//Y轴坐标
                Button btn = new Button();
                btn.Text = t1;
                btn.Size = new System.Drawing.Size(60, 25);//按钮本身的大小
                btn.TextAlign = ContentAlignment.MiddleCenter;//文本居中显示
                //设置位置
                btn.Location = new Point(20+x , 30+y );
                this.Controls.Add(btn);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">时间源</param>
        /// <param name="e">事件的参数</param>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

       
    }
}
