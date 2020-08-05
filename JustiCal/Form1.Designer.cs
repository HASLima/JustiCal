namespace JustiCal
{
    namespace View
    {
        partial class Form1
        {
            /// <summary>
            /// Variável de designer necessária.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Limpar os recursos que estão sendo usados.
            /// </summary>
            /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Código gerado pelo Windows Form Designer

            /// <summary>
            /// Método necessário para suporte ao Designer - não modifique 
            /// o conteúdo deste método com o editor de código.
            /// </summary>
            private void InitializeComponent()
            {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createPersonButton = new System.Windows.Forms.Button();
            this.printPersonsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 428);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // createPersonButton
            // 
            this.createPersonButton.Location = new System.Drawing.Point(328, 252);
            this.createPersonButton.Name = "createPersonButton";
            this.createPersonButton.Size = new System.Drawing.Size(187, 135);
            this.createPersonButton.TabIndex = 3;
            this.createPersonButton.Text = "Criar Pessoa";
            this.createPersonButton.UseVisualStyleBackColor = true;
            this.createPersonButton.Click += new System.EventHandler(this.createPersonButton_Click);
            // 
            // printPersonsButton
            // 
            this.printPersonsButton.Location = new System.Drawing.Point(236, 74);
            this.printPersonsButton.Name = "printPersonsButton";
            this.printPersonsButton.Size = new System.Drawing.Size(206, 60);
            this.printPersonsButton.TabIndex = 4;
            this.printPersonsButton.Text = "ImprimirPessoas";
            this.printPersonsButton.UseVisualStyleBackColor = true;
            this.printPersonsButton.Click += new System.EventHandler(this.printPersonsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.printPersonsButton);
            this.Controls.Add(this.createPersonButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.Button createPersonButton;
            private System.Windows.Forms.Button printPersonsButton;
        } 
    }
}

