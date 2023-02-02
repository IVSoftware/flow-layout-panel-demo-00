Your question states these objectives:

- Dynamically add a `GroupBox` based on an event (like button click).
- Assign the new `GroupBox` location.
- Pad the location with "some distance away".

You say you "feel that there should be a better a way to go about it" and there is!

***
Try experimenting with a `FlowLayoutPanel` which handles all three of these by its nature.

[![screenshot][1]][1]

***
Here's the code I used to add and remove instances of `CustomGroupBox`. _This is a UserControl that I added to my project, but this will work with any type of control.)_

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

When the numeric up-down changes, compare the expected number of groupboxes to the current count. Alternatively, you can continue to use a button click and go straight to `flowLayoutPanel.Controls.Add(...)`.

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

The _direction_ of the flow can also be specified.

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


  [1]: https://i.stack.imgur.com/Egczm.png