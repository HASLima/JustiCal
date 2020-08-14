namespace JustiCal
{
    namespace View
    {
        partial class AdicionarBilheteDeIdentidade
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
            this.DocumentNumberLabel = new System.Windows.Forms.Label();
            this.CivilianNumberTextBox = new System.Windows.Forms.TextBox();
            this.IssueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.CheckDigitTextBox = new System.Windows.Forms.TextBox();
            this.IssueDateLabel = new System.Windows.Forms.Label();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.expiryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IssuePlaceLabel = new System.Windows.Forms.Label();
            this.IssuePlaceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DocumentNumberLabel
            // 
            this.DocumentNumberLabel.AutoSize = true;
            this.DocumentNumberLabel.Location = new System.Drawing.Point(20, 12);
            this.DocumentNumberLabel.Name = "DocumentNumberLabel";
            this.DocumentNumberLabel.Size = new System.Drawing.Size(68, 32);
            this.DocumentNumberLabel.TabIndex = 0;
            this.DocumentNumberLabel.Text = "N.º: ";
            // 
            // CivilianNumberTextBox
            // 
            this.CivilianNumberTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.CivilianNumberTextBox.Location = new System.Drawing.Point(86, 11);
            this.CivilianNumberTextBox.Name = "CivilianNumberTextBox";
            this.CivilianNumberTextBox.Size = new System.Drawing.Size(315, 34);
            this.CivilianNumberTextBox.TabIndex = 1;
            // 
            // IssueDateDateTimePicker
            // 
            this.IssueDateDateTimePicker.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.IssueDateDateTimePicker.Location = new System.Drawing.Point(288, 87);
            this.IssueDateDateTimePicker.Name = "IssueDateDateTimePicker";
            this.IssueDateDateTimePicker.Size = new System.Drawing.Size(353, 34);
            this.IssueDateDateTimePicker.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(20, 316);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(621, 41);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submeter";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CheckDigitTextBox
            // 
            this.CheckDigitTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.CheckDigitTextBox.Location = new System.Drawing.Point(430, 11);
            this.CheckDigitTextBox.Name = "CheckDigitTextBox";
            this.CheckDigitTextBox.Size = new System.Drawing.Size(31, 34);
            this.CheckDigitTextBox.TabIndex = 2;
            this.CheckDigitTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CheckDigitTextBox_Validating);
            // 
            // IssueDateLabel
            // 
            this.IssueDateLabel.AutoSize = true;
            this.IssueDateLabel.Location = new System.Drawing.Point(20, 88);
            this.IssueDateLabel.Name = "IssueDateLabel";
            this.IssueDateLabel.Size = new System.Drawing.Size(239, 32);
            this.IssueDateLabel.TabIndex = 3;
            this.IssueDateLabel.Text = "Data de Emissão: ";
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.AutoSize = true;
            this.ExpiryDateLabel.Location = new System.Drawing.Point(20, 164);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.Size = new System.Drawing.Size(237, 32);
            this.ExpiryDateLabel.TabIndex = 5;
            this.ExpiryDateLabel.Text = "Data de Validade: ";
            // 
            // expiryDateDateTimePicker
            // 
            this.expiryDateDateTimePicker.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.expiryDateDateTimePicker.Location = new System.Drawing.Point(288, 163);
            this.expiryDateDateTimePicker.Name = "expiryDateDateTimePicker";
            this.expiryDateDateTimePicker.Size = new System.Drawing.Size(353, 34);
            this.expiryDateDateTimePicker.TabIndex = 6;
            // 
            // IssuePlaceLabel
            // 
            this.IssuePlaceLabel.AutoSize = true;
            this.IssuePlaceLabel.Location = new System.Drawing.Point(20, 240);
            this.IssuePlaceLabel.Name = "IssuePlaceLabel";
            this.IssuePlaceLabel.Size = new System.Drawing.Size(246, 32);
            this.IssuePlaceLabel.TabIndex = 7;
            this.IssuePlaceLabel.Text = "Local de Emissão: ";
            // 
            // IssuePlaceTextBox
            // 
            this.IssuePlaceTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.IssuePlaceTextBox.Location = new System.Drawing.Point(288, 239);
            this.IssuePlaceTextBox.Name = "IssuePlaceTextBox";
            this.IssuePlaceTextBox.Size = new System.Drawing.Size(353, 34);
            this.IssuePlaceTextBox.TabIndex = 8;
            // 
            // AdicionarBilheteDeIdentidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 368);
            this.Controls.Add(this.IssuePlaceTextBox);
            this.Controls.Add(this.IssuePlaceLabel);
            this.Controls.Add(this.expiryDateDateTimePicker);
            this.Controls.Add(this.ExpiryDateLabel);
            this.Controls.Add(this.IssueDateLabel);
            this.Controls.Add(this.CheckDigitTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.IssueDateDateTimePicker);
            this.Controls.Add(this.CivilianNumberTextBox);
            this.Controls.Add(this.DocumentNumberLabel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdicionarBilheteDeIdentidade";
            this.Text = "Adicionar Bilhete de Identidade";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label DocumentNumberLabel;
            private System.Windows.Forms.TextBox CivilianNumberTextBox;
            private System.Windows.Forms.DateTimePicker IssueDateDateTimePicker;
            private System.Windows.Forms.Button submitButton;
            private System.Windows.Forms.TextBox CheckDigitTextBox;
            private System.Windows.Forms.Label IssueDateLabel;
            private System.Windows.Forms.Label ExpiryDateLabel;
            private System.Windows.Forms.DateTimePicker expiryDateDateTimePicker;
            private System.Windows.Forms.Label IssuePlaceLabel;
            private System.Windows.Forms.TextBox IssuePlaceTextBox;
        } 
    }
}