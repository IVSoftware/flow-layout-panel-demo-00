using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flow_layout_panel_demo_00
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            numericUpDownGroupboxes.ValueChanged += onGroupBoxCountChanged;
            foreach (var radio in Controls.OfType<RadioButton>())
            {
                radio.CheckedChanged += onFlowLayoutDirectionChanged;
            }
        }

        private void onGroupBoxCountChanged(object sender, EventArgs e)
        {
            // Need an int for comparison.
            int 
                countIs = flowLayoutPanel.Controls.OfType<CustomGroupBox>().Count(),
                countShouldBe = (int)numericUpDownGroupboxes.Value;
            switch(countIs.CompareTo(countShouldBe))
            {
                case -1:
                    flowLayoutPanel.Controls.Add(
                        new CustomGroupBox
                        {
                            Name = $"groupBox{countShouldBe}",
                            Text = $"GroupBox {countShouldBe}",
                            Size = new Size(300, 150),
                            Margin = new Padding(10),
                            BackColor = Color.White,
                        });
                    break;
                case 1:
                    Control last = flowLayoutPanel.Controls.OfType<CustomGroupBox>().Last();
                    flowLayoutPanel.Controls.Remove(last);
                    break;
            }
        }

        private void onFlowLayoutDirectionChanged(object sender, EventArgs e)
        {
            if(radioButtonHorizontal.Checked)
            {
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            }
            else
            {
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            }
        }
    }
}
