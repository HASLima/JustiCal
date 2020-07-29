namespace JustiCal
{
    partial class AdicionarCartaoDeCidadao
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
            this.nrLabel = new System.Windows.Forms.Label();
            this.nrTextBox = new System.Windows.Forms.TextBox();
            this.expiryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nrLabel
            // 
            this.nrLabel.AutoSize = true;
            this.nrLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.nrLabel.Location = new System.Drawing.Point(12, 9);
            this.nrLabel.Name = "nrLabel";
            this.nrLabel.Size = new System.Drawing.Size(61, 16);
            this.nrLabel.TabIndex = 0;
            this.nrLabel.Text = "Número:";
            this.nrLabel.Click += new System.EventHandler(this.nrLabel_Click);
            // 
            // nrTextBox
            // 
            this.nrTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.nrTextBox.Location = new System.Drawing.Point(138, 7);
            this.nrTextBox.Name = "nrTextBox";
            this.nrTextBox.Size = new System.Drawing.Size(257, 21);
            this.nrTextBox.TabIndex = 1;
            this.nrTextBox.Leave += new System.EventHandler(this.nrTextBox_Leave);
            this.nrTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nrTextBox_Validating);
            // 
            // expiryDateDateTimePicker
            // 
            this.expiryDateDateTimePicker.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.expiryDateDateTimePicker.Location = new System.Drawing.Point(138, 42);
            this.expiryDateDateTimePicker.Name = "expiryDateDateTimePicker";
            this.expiryDateDateTimePicker.Size = new System.Drawing.Size(257, 21);
            this.expiryDateDateTimePicker.TabIndex = 2;
            this.expiryDateDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.expiryDateLabel.Location = new System.Drawing.Point(12, 44);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(120, 16);
            this.expiryDateLabel.TabIndex = 3;
            this.expiryDateLabel.Text = "Data de Validade:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial", 10F);
            this.submitButton.Location = new System.Drawing.Point(15, 79);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(380, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submeter";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AdicionarCartaoDeCidadao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 116);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.expiryDateDateTimePicker);
            this.Controls.Add(this.nrTextBox);
            this.Controls.Add(this.nrLabel);
            this.Name = "AdicionarCartaoDeCidadao";
            this.Text = "Adicionar Cartão de Cidadão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nrLabel;
        private System.Windows.Forms.TextBox nrTextBox;
        private System.Windows.Forms.DateTimePicker expiryDateDateTimePicker;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.Button submitButton;
    }
}