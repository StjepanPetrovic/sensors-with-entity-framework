﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sensors_with_entity_framework
{
    public partial class AddSensorForm : Form
    {
        public AddSensorForm()
        {
            InitializeComponent();
        }

        private void btnCancelNewSensor_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
