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
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.submeterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.descricaoTextBox.Location = new System.Drawing.Point(131, 7);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(552, 27);
            this.descricaoTextBox.TabIndex = 32;
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.descricaoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.descricaoLabel.Location = new System.Drawing.Point(12, 9);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(104, 23);
            this.descricaoLabel.TabIndex = 31;
            this.descricaoLabel.Text = "Descrição:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.enderecoTextBox.Location = new System.Drawing.Point(131, 58);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(552, 27);
            this.enderecoTextBox.TabIndex = 34;
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.enderecoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enderecoLabel.Location = new System.Drawing.Point(12, 60);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(100, 23);
            this.enderecoLabel.TabIndex = 33;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // submeterButton
            // 
            this.submeterButton.Font = new System.Drawing.Font("Arial", 10F);
            this.submeterButton.Location = new System.Drawing.Point(16, 111);
            this.submeterButton.Name = "submeterButton";
            this.submeterButton.Size = new System.Drawing.Size(667, 47);
            this.submeterButton.TabIndex = 35;
            this.submeterButton.Text = "Submeter";
            this.submeterButton.UseVisualStyleBackColor = true;
            // 
            // AdicionarEnderecoEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 175);
            this.Controls.Add(this.submeterButton);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.descricaoLabel);
            this.Name = "AdicionarEnderecoEmail";
            this.Text = "AdicionarEnderecoEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Button submeterButton;
    }
}