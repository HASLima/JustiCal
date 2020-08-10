using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            individualsTableLayoutPanel.ColumnCount = 3;
            individualsTableLayoutPanel.RowCount = 1;
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            individualsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            individualsTableLayoutPanel.Controls.Add(new Label() { Text = "Vai" }, 0, 0);
            individualsTableLayoutPanel.Controls.Add(new Label() { Text = "à" }, 1, 0);
            individualsTableLayoutPanel.Controls.Add(new Label() { Text = "Merda" }, 2, 0);
            individualsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        private void ShowPersonTable(List<object> person)
        {
            individualsTableLayoutPanel.ColumnCount = 6;
            individualsTableLayoutPanel.RowCount = 1;
            for (int i = 0; i < individualsTableLayoutPanel.ColumnCount; i++)
            {
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
            individualsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            individualsTableLayoutPanel.Controls.Add(new Label() { Text = "N.º Documento" }, 0, 0);
            individualsTableLayoutPanel.Controls.Add(new Label() { Text = "Primeiro Nome" }, 1, 0);
            individualsTableLayoutPanel.Controls.Add(new Label() { Text = "Apelido" }, 2, 0);
            //individualsTableLayoutPanel.Controls.Add(new Image() { }
            individualsTableLayoutPanel.Controls.Add(new Label() { Text = "N.º Documento" }, 0, 0);
            individualsTableLayoutPanel.Controls.Add(new Label() { Text = "N.º Documento" }, 0, 0);
        }
    }
}
