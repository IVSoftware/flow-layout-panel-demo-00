
namespace flow_layout_panel_demo_00
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownGroupboxes = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonHorizontal = new System.Windows.Forms.RadioButton();
            this.radioButtonVertical = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGroupboxes)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownGroupboxes
            // 
            this.numericUpDownGroupboxes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownGroupboxes.Location = new System.Drawing.Point(27, 32);
            this.numericUpDownGroupboxes.Name = "numericUpDownGroupboxes";
            this.numericUpDownGroupboxes.Size = new System.Drawing.Size(138, 50);
            this.numericUpDownGroupboxes.TabIndex = 0;
            this.numericUpDownGroupboxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(192, 29);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(985, 567);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // radioButtonHorizontal
            // 
            this.radioButtonHorizontal.AutoSize = true;
            this.radioButtonHorizontal.Checked = true;
            this.radioButtonHorizontal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonHorizontal.Location = new System.Drawing.Point(27, 131);
            this.radioButtonHorizontal.Name = "radioButtonHorizontal";
            this.radioButtonHorizontal.Size = new System.Drawing.Size(129, 32);
            this.radioButtonHorizontal.TabIndex = 2;
            this.radioButtonHorizontal.TabStop = true;
            this.radioButtonHorizontal.Text = "Horizontal";
            this.radioButtonHorizontal.UseVisualStyleBackColor = true;
            // 
            // radioButtonVertical
            // 
            this.radioButtonVertical.AutoSize = true;
            this.radioButtonVertical.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonVertical.Location = new System.Drawing.Point(27, 183);
            this.radioButtonVertical.Name = "radioButtonVertical";
            this.radioButtonVertical.Size = new System.Drawing.Size(101, 32);
            this.radioButtonVertical.TabIndex = 2;
            this.radioButtonVertical.Text = "Vertical";
            this.radioButtonVertical.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.radioButtonVertical);
            this.Controls.Add(this.radioButtonHorizontal);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.numericUpDownGroupboxes);
            this.Name = "MainForm";
            this.Text = "Form with FlowLayoutPanel";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGroupboxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownGroupboxes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.RadioButton radioButtonHorizontal;
        private System.Windows.Forms.RadioButton radioButtonVertical;
    }
}

