using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_0400TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParent_Click(object sender, EventArgs e)
        {

            //TreeView  树上   每个节点都是一个TreeNode类型  
            //1.获取文本框的值
            string nodeName = txtNodeName.Text;
            //2.将字符串包装成TreeNode
            TreeNode tn = new TreeNode();
            tn.Text = nodeName;

            //3,将TreeNode作为TreeView的一个项目
            tvList.Nodes.Add(tn);
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            string nodeName = txtNodeName.Text;
            TreeNode tn = new TreeNode();
            tn.Text = nodeName;
            //获取到用户在树上选中的节点
            TreeNode selectedNode = tvList.SelectedNode;
            foreach (TreeNode item in selectedNode.Nodes)
            {
                if (item.Text == nodeName)
                {
                    MessageBox.Show("该城市已经存在了，大爷，请换一个名称");
                    return;
                }
            }
            selectedNode.Nodes.Add(tn);
           
        }

        private void tvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = tvList.SelectedNode;
            MessageBox.Show(selectedNode.Text+selectedNode.Level);
        }
    }
}
