using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace flow_layout_panel_demo_00
{
    public partial class CustomGroupBox : UserControl
    {
        public CustomGroupBox() => InitializeComponent();
        public new string Text
        {
            get => groupBox.Text;
            set => groupBox.Text = value;
        }
    }
}
