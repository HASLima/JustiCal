﻿namespace JustiCal
{
    partial class AdicionarContactoTelefonico
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
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.indicativoTextBox = new System.Windows.Forms.TextBox();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.submeterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // indicativoTextBox
            // 
            this.indicativoTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.indicativoTextBox.Location = new System.Drawing.Point(131, 103);
            this.indicativoTextBox.Name = "indicativoTextBox";
            this.indicativoTextBox.Size = new System.Drawing.Size(92, 27);
            this.indicativoTextBox.TabIndex = 34;
            this.indicativoTextBox.Leave += new System.EventHandler(this.indicativoTextBox_Leave);
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.numeroLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numeroLabel.Location = new System.Drawing.Point(12, 105);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(85, 23);
            this.numeroLabel.TabIndex = 33;
            this.numeroLabel.Text = "Número:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.numeroTextBox.Location = new System.Drawing.Point(239, 103);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(444, 27);
            this.numeroTextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Detentor:";
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.descricaoComboBox.FormattingEnabled = true;
            this.descricaoComboBox.Location = new System.Drawing.Point(131, 6);
            this.descricaoComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.Size = new System.Drawing.Size(552, 28);
            this.descricaoComboBox.TabIndex = 45;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.textBox3.Location = new System.Drawing.Point(131, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(552, 27);
            this.textBox3.TabIndex = 37;
            // 
            // paisComboBox
            // 
            this.paisComboBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(131, 150);
            this.paisComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(552, 28);
            this.paisComboBox.TabIndex = 47;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.countryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.countryLabel.Location = new System.Drawing.Point(12, 153);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(54, 23);
            this.countryLabel.TabIndex = 46;
            this.countryLabel.Text = "Pais:";
            // 
            // submeterButton
            // 
            this.submeterButton.Font = new System.Drawing.Font("Arial", 10F);
            this.submeterButton.Location = new System.Drawing.Point(16, 201);
            this.submeterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submeterButton.Name = "submeterButton";
            this.submeterButton.Size = new System.Drawing.Size(668, 35);
            this.submeterButton.TabIndex = 48;
            this.submeterButton.Text = "Submeter";
            this.submeterButton.UseVisualStyleBackColor = true;
            // 
            // AdicionarContactoTelefonico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 256);
            this.Controls.Add(this.submeterButton);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.descricaoComboBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.indicativoTextBox);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.descricaoLabel);
            this.Name = "AdicionarContactoTelefonico";
            this.Text = "Adicionar Contacto Telefónico";
            this.Load += new System.EventHandler(this.AdicionarContactoTelefonico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.TextBox indicativoTextBox;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button submeterButton;
    }
}