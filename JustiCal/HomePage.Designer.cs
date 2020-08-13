namespace JustiCal
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PeopleTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.individualsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.objectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarProcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PeopleTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.PeopleTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1268, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1252, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(648, 540);
            this.listBox1.TabIndex = 0;
            // 
            // PeopleTabPage
            // 
            this.PeopleTabPage.Controls.Add(this.pictureBox1);
            this.PeopleTabPage.Controls.Add(this.pictureBox2);
            this.PeopleTabPage.Controls.Add(this.individualsTableLayoutPanel);
            this.PeopleTabPage.Location = new System.Drawing.Point(8, 46);
            this.PeopleTabPage.Name = "PeopleTabPage";
            this.PeopleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PeopleTabPage.Size = new System.Drawing.Size(1252, 504);
            this.PeopleTabPage.TabIndex = 1;
            this.PeopleTabPage.Text = "Pessoas";
            this.PeopleTabPage.UseVisualStyleBackColor = true;
            this.PeopleTabPage.Enter += new System.EventHandler(this.PeopleTabPage_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Image = global::JustiCal.Properties.Resources.militaryIco;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox2.Image = global::JustiCal.Properties.Resources.findIco;
            this.pictureBox2.InitialImage = global::JustiCal.Properties.Resources.findIco;
            this.pictureBox2.Location = new System.Drawing.Point(500, 356);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // individualsTableLayoutPanel
            // 
            this.individualsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.individualsTableLayoutPanel.ColumnCount = 2;
            this.individualsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.individualsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.individualsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.individualsTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.individualsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.individualsTableLayoutPanel.Name = "individualsTableLayoutPanel";
            this.individualsTableLayoutPanel.RowCount = 2;
            this.individualsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.individualsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.individualsTableLayoutPanel.Size = new System.Drawing.Size(1246, 498);
            this.individualsTableLayoutPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // objectosToolStripMenuItem
            // 
            this.objectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.processosToolStripMenuItem});
            this.objectosToolStripMenuItem.Name = "objectosToolStripMenuItem";
            this.objectosToolStripMenuItem.Size = new System.Drawing.Size(129, 38);
            this.objectosToolStripMenuItem.Text = "Objectos";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarPessoaToolStripMenuItem});
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // criarPessoaToolStripMenuItem
            // 
            this.criarPessoaToolStripMenuItem.Name = "criarPessoaToolStripMenuItem";
            this.criarPessoaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.criarPessoaToolStripMenuItem.Text = "Criar Pessoa";
            this.criarPessoaToolStripMenuItem.Click += new System.EventHandler(this.criarPessoaToolStripMenuItem_Click);
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarProcessoToolStripMenuItem});
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.processosToolStripMenuItem.Text = "Processos";
            // 
            // criarProcessoToolStripMenuItem
            // 
            this.criarProcessoToolStripMenuItem.Name = "criarProcessoToolStripMenuItem";
            this.criarProcessoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.criarProcessoToolStripMenuItem.Text = "Criar Processo";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomePage";
            this.Text = "JustiCal";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PeopleTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage PeopleTabPage;
        private System.Windows.Forms.TableLayoutPanel individualsTableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem objectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarProcessoToolStripMenuItem;
    }
}