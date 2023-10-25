namespace ColorMixerApp_2023_autumn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            redBox = new PictureBox();
            greenBox = new PictureBox();
            blueBox = new PictureBox();
            numericRed = new NumericUpDown();
            numericGreen = new NumericUpDown();
            numericBlue = new NumericUpDown();
            sliderRed = new TrackBar();
            sliderGreen = new TrackBar();
            sliderBlue = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)redBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderBlue).BeginInit();
            SuspendLayout();
            // 
            // redBox
            // 
            redBox.BackColor = SystemColors.Control;
            redBox.Location = new Point(70, 49);
            redBox.Name = "redBox";
            redBox.Size = new Size(200, 200);
            redBox.TabIndex = 0;
            redBox.TabStop = false;
            redBox.Click += redBox_Click;
            // 
            // greenBox
            // 
            greenBox.BackColor = SystemColors.Control;
            greenBox.Location = new Point(361, 49);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(200, 200);
            greenBox.TabIndex = 1;
            greenBox.TabStop = false;
            greenBox.Click += greenBox_Click;
            // 
            // blueBox
            // 
            blueBox.BackColor = SystemColors.Control;
            blueBox.Location = new Point(643, 49);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(200, 200);
            blueBox.TabIndex = 2;
            blueBox.TabStop = false;
            // 
            // numericRed
            // 
            numericRed.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericRed.Location = new Point(70, 285);
            numericRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericRed.Name = "numericRed";
            numericRed.Size = new Size(200, 50);
            numericRed.TabIndex = 3;
            numericRed.ValueChanged += numericRed_ValueChanged;
            // 
            // numericGreen
            // 
            numericGreen.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericGreen.Location = new Point(361, 285);
            numericGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericGreen.Name = "numericGreen";
            numericGreen.Size = new Size(200, 50);
            numericGreen.TabIndex = 4;
            numericGreen.ValueChanged += numericGreen_ValueChanged;
            // 
            // numericBlue
            // 
            numericBlue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericBlue.Location = new Point(643, 285);
            numericBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericBlue.Name = "numericBlue";
            numericBlue.Size = new Size(200, 50);
            numericBlue.TabIndex = 5;
            numericBlue.ValueChanged += numericBlue_ValueChanged;
            // 
            // sliderRed
            // 
            sliderRed.Location = new Point(70, 386);
            sliderRed.Maximum = 255;
            sliderRed.Name = "sliderRed";
            sliderRed.Size = new Size(200, 45);
            sliderRed.TabIndex = 6;
            sliderRed.TickStyle = TickStyle.None;
            sliderRed.Scroll += sliderRed_Scroll;
            // 
            // sliderGreen
            // 
            sliderGreen.Location = new Point(361, 386);
            sliderGreen.Maximum = 255;
            sliderGreen.Name = "sliderGreen";
            sliderGreen.Size = new Size(200, 45);
            sliderGreen.TabIndex = 7;
            sliderGreen.TickStyle = TickStyle.None;
            sliderGreen.Scroll += sliderGreen_Scroll;
            // 
            // sliderBlue
            // 
            sliderBlue.Location = new Point(643, 386);
            sliderBlue.Maximum = 255;
            sliderBlue.Name = "sliderBlue";
            sliderBlue.Size = new Size(200, 45);
            sliderBlue.TabIndex = 8;
            sliderBlue.TickStyle = TickStyle.None;
            sliderBlue.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 576);
            Controls.Add(sliderBlue);
            Controls.Add(sliderGreen);
            Controls.Add(sliderRed);
            Controls.Add(numericBlue);
            Controls.Add(numericGreen);
            Controls.Add(numericRed);
            Controls.Add(blueBox);
            Controls.Add(greenBox);
            Controls.Add(redBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)redBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox redBox;
        private PictureBox greenBox;
        private PictureBox blueBox;
        private NumericUpDown numericRed;
        private NumericUpDown numericGreen;
        private NumericUpDown numericBlue;
        private TrackBar sliderRed;
        private TrackBar sliderGreen;
        private TrackBar sliderBlue;
    }
}