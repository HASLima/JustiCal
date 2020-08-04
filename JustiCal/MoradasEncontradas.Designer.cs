namespace JustiCal
{
    partial class MoradasEncontradas
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
            this.moradasEncontradasListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // moradasEncontradasListBox
            // 
            this.moradasEncontradasListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moradasEncontradasListBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.moradasEncontradasListBox.FormattingEnabled = true;
            this.moradasEncontradasListBox.ItemHeight = 20;
            this.moradasEncontradasListBox.Location = new System.Drawing.Point(0, 0);
            this.moradasEncontradasListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moradasEncontradasListBox.Name = "moradasEncontradasListBox";
            this.moradasEncontradasListBox.Size = new System.Drawing.Size(387, 209);
            this.moradasEncontradasListBox.TabIndex = 0;
            this.moradasEncontradasListBox.DoubleClick += new System.EventHandler(this.moradasEncontradasListBox_DoubleClick);
            // 
            // MoradasEncontradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 209);
            this.Controls.Add(this.moradasEncontradasListBox);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MoradasEncontradas";
            this.Text = "Moradas Encontradas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox moradasEncontradasListBox;
    }
}