﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KeppyDriverConfigurator
{
    public partial class KeppyDriverInformation : Form
    {
        public KeppyDriverInformation()
        {
            InitializeComponent();
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
        }

        private void KeppyDriverInformation_Load(object sender, EventArgs e)
        {
            FileVersionInfo Driver = FileVersionInfo.GetVersionInfo(Environment.SystemDirectory + "\\keppydrv\\keppydrv.dll");
            Label8.Text = "Keppy's Driver by Keppy Studios\nVersion " + Driver.FileVersion.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
