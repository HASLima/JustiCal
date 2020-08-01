namespace JustiCal
{
    partial class AdicionarEnderecoEmail
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
            this.components = new System.ComponentModel.Container();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.submeterButton = new System.Windows.Forms.Button();
            this.AdicionarEnderecoEmailToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.descricaoTextBox.Location = new System.Drawing.Point(87, 5);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(369, 21);
            this.descricaoTextBox.TabIndex = 32;
            this.AdicionarEnderecoEmailToolTip.SetToolTip(this.descricaoTextBox, "Uma descrição do mail a ser introduzido. Ex: Institucional, Pessoal");
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.descricaoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.descricaoLabel.Location = new System.Drawing.Point(8, 6);
            this.descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(75, 16);
            this.descricaoLabel.TabIndex = 31;
            this.descricaoLabel.Text = "Descrição:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.enderecoTextBox.Location = new System.Drawing.Point(87, 38);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(369, 21);
            this.enderecoTextBox.TabIndex = 34;
            this.AdicionarEnderecoEmailToolTip.SetToolTip(this.enderecoTextBox, "O endereço de email a introduzir. Ex: cadeteatento@exercito.pt");
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.enderecoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enderecoLabel.Location = new System.Drawing.Point(8, 39);
            this.enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(73, 16);
            this.enderecoLabel.TabIndex = 33;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // submeterButton
            // 
            this.submeterButton.Font = new System.Drawing.Font("Arial", 10F);
            this.submeterButton.Location = new System.Drawing.Point(11, 72);
            this.submeterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submeterButton.Name = "submeterButton";
            this.submeterButton.Size = new System.Drawing.Size(445, 31);
            this.submeterButton.TabIndex = 35;
            this.submeterButton.Text = "Submeter";
            this.submeterButton.UseVisualStyleBackColor = true;
            this.submeterButton.Click += new System.EventHandler(this.submeterButton_Click);
            // 
            // AdicionarEnderecoEmailToolTip
            // 
            this.AdicionarEnderecoEmailToolTip.IsBalloon = true;
            this.AdicionarEnderecoEmailToolTip.OwnerDraw = true;
            this.AdicionarEnderecoEmailToolTip.ShowAlways = true;
            this.AdicionarEnderecoEmailToolTip.ToolTipTitle = "Ajuda:";
            this.AdicionarEnderecoEmailToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.AdicionarEnderecoEmailToolTip_Popup);
            // 
            // AdicionarEnderecoEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 114);
            this.Controls.Add(this.submeterButton);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.descricaoLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdicionarEnderecoEmail";
            this.Text = "Adicionar Endereço de Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Button submeterButton;
        private System.Windows.Forms.ToolTip AdicionarEnderecoEmailToolTip;
    }
}