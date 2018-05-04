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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1.准备一个容器，可以容纳3个员工对象
        public Employee[] emps = new Employee[5];
        private void Form1_Load(object sender, EventArgs e)
        {
            lvList.GridLines = true; //显示窗格
            lvList.MultiSelect = false;//不让你多选，看你怎么办？
            //选中整行
            lvList.FullRowSelect = true;//整行选中  
            LoadData();
            //2.将容器中的数据拿出来，放到ListView上 ，每一条员工信息，对应一条记录
            foreach (var item in emps)
            {
                //一个item就是一个员工对象，那么就应该形成一个ListViewItem项目
                ListViewItem lvItem = new ListViewItem(item.EmpID);
                lvItem.SubItems.Add(item.EmpName);
                lvItem.SubItems.Add(item.EmpAge.ToString());
                lvItem.SubItems.Add(item.EemAssert);
                lvItem.SubItems.Add(item.EmpScore.ToString());

                //将内存中游离的一行，bind到lvList上
                lvList.Items.Add(lvItem);
            }
        }

        private void LoadData()
        {
            emps[0] = new Employee();
            emps[0].EmpID = "001";
            emps[0].EmpName="油炸丸子";
            emps[0].EmpAge=12;
            emps[0].EemAssert=string.Empty;
            emps[0].EmpScore=0;


            emps[1] = new Employee();
            emps[1].EmpID = "002";
            emps[1].EmpName = "缺心眼子";
            emps[1].EmpAge = 22;
            emps[1].EemAssert = string.Empty;
            emps[1].EmpScore = 0;

            emps[2] = new Employee();
            emps[2].EmpID = "003";
            emps[2].EmpName = "唾沫星子";
            emps[2].EmpAge =32;
            emps[2].EemAssert = string.Empty;
            emps[2].EmpScore = 0;

            emps[3] = new Employee();
            emps[3].EmpID = "004";
            emps[3].EmpName = "鼠标垫子";
            emps[3].EmpAge = 33;
            emps[3].EemAssert = string.Empty;
            emps[3].EmpScore = 0;

            emps[4] = new Employee();
            emps[4].EmpID = "005";
            emps[4].EmpName = "啤酒瓶子";
            emps[4].EmpAge = 34;
            emps[4].EemAssert = string.Empty;
            emps[4].EmpScore = 0;
        }

        private void lvList_DoubleClick(object sender, EventArgs e)
        {

           ListViewItem selectItem= lvList.SelectedItems[0];
            
            FrmScore frm = new FrmScore();
            frm.selectItem = selectItem;
            frm.Show();
        }
    }
}
