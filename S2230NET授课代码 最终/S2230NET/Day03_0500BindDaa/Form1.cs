using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day03_0500BindDaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Book> list = new List<Book>();

            //Book b1 = new Book();
            //b1.BookName = "追风筝的人";
            //b1.BookPrice = 32;

            //Book b2 = new Book();
            //b2.BookName = "窗边的小豆豆";
            //b2.BookPrice = 52;

            //list.Add(b1);
            //list.Add(b2);
            //dgvList.DataSource = list;
            ////有点类似于监听器：动态感知到集合元素的修改 （增，删 ，修改）
            //dgvList.DataSource = new BindingList<Book>(list);

            Dictionary<string, Book> dic = new Dictionary<string, Book>();

            Book b1 = new Book();
            b1.BookName = "追风筝的人";
            b1.BookPrice = 32;

            Book b2 = new Book();
            b2.BookName = "窗边的小豆豆";
            b2.BookPrice = 52;

            dic.Add(b1.BookName,b1);

            dic.Add(b2.BookName, b2);

            BindingSource bs = new BindingSource();

            bs.DataSource = dic.Values;

            dgvList.DataSource = bs;
        }
    }
}
