﻿using System;
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
    public partial class AdicionarMorada : Form
    {
        public AdicionarMorada()
        {
            InitializeComponent();
        }

        private void AdicionarMorada_Load(object sender, EventArgs e)
        {
            countryComboBox.Text = "Portugal";
        }
    }
}
