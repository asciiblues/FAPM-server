﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAPM_server
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
