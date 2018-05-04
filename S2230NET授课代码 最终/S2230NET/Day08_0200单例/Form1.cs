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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //将右键菜单和dgv绑定
            dgvList.ContextMenuStrip = contextMenuStrip1;
            //1.准备静态数据
            List<Song> list = new List<Song>() 
            {
                new Song("不要太早遇到对的人   柠檬.mp3","E:\\KuGou\\不要太早遇到对的人   柠檬.mp3"),
                new Song("妈妈.mp3","E:\\KuGou\\妈妈.mp3"),
                new Song("吴雨霏 - 生命树.mp3","E:\\KuGou\\吴雨霏 - 生命树.mp3")
            };

            //2.将静态数据绑定到dgv上
            dgvList.DataSource = new BindingList<Song>(list);



            //Dog dog = Dog.getInstance();

            //Dog dog2 = Dog.getInstance();

            //if (dog==dog2)
            //{
            //    MessageBox.Show("==");
            //}
        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlay frm = FrmPlay.getInstance();
            //获取到选择的歌曲
            string path = dgvList.SelectedRows[0].Cells[1].Value.ToString();
            //赋值给播放窗体的path变量
            frm.path = path;
            frm.PlaySong();
            frm.Show();
        }
    }
}
