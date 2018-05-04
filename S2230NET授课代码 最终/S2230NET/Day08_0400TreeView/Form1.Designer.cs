namespace Day08_0400TreeView
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tvList = new System.Windows.Forms.TreeView();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParent = new System.Windows.Forms.Button();
            this.btnChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvList
            // 
            this.tvList.Location = new System.Drawing.Point(52, 38);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(339, 284);
            this.tvList.TabIndex = 0;
            this.tvList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvList_AfterSelect);
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(490, 42);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(100, 20);
            this.txtNodeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "节点名称";
            // 
            // btnParent
            // 
            this.btnParent.Location = new System.Drawing.Point(409, 98);
            this.btnParent.Name = "btnParent";
            this.btnParent.Size = new System.Drawing.Size(75, 23);
            this.btnParent.TabIndex = 3;
            this.btnParent.Text = "添加根节点";
            this.btnParent.UseVisualStyleBackColor = true;
            this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(515, 98);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(75, 23);
            this.btnChild.TabIndex = 3;
            this.btnChild.Text = "添加子节点";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 443);
            this.Controls.Add(this.btnChild);
            this.Controls.Add(this.btnParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.tvList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView案例演示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvList;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParent;
        private System.Windows.Forms.Button btnChild;
    }
}

