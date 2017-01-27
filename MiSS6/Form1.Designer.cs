namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxEquation = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownTStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTEnd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTempo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEquation
            // 
            this.pictureBoxEquation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEquation.Image")));
            this.pictureBoxEquation.Location = new System.Drawing.Point(404, 12);
            this.pictureBoxEquation.Name = "pictureBoxEquation";
            this.pictureBoxEquation.Size = new System.Drawing.Size(239, 85);
            this.pictureBoxEquation.TabIndex = 0;
            this.pictureBoxEquation.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 218);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1000, 400);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "t_start [s]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "t_end [s]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tempo [*]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "R [m]";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(486, 167);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Enabled = false;
            this.buttonStartPause.Location = new System.Drawing.Point(509, 624);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(75, 23);
            this.buttonStartPause.TabIndex = 11;
            this.buttonStartPause.Text = "Start";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Enabled = false;
            this.buttonReverse.Location = new System.Drawing.Point(428, 625);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonReverse.TabIndex = 12;
            this.buttonReverse.Text = "<<";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(841, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 9);
            this.label5.TabIndex = 13;
            this.label5.Text = "Anna Cholewczyńska, Kamil Gersten, Dominik Stefaniak";
            // 
            // numericUpDownTStart
            // 
            this.numericUpDownTStart.DecimalPlaces = 1;
            this.numericUpDownTStart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTStart.Location = new System.Drawing.Point(286, 118);
            this.numericUpDownTStart.Name = "numericUpDownTStart";
            this.numericUpDownTStart.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownTStart.TabIndex = 14;
            // 
            // numericUpDownTEnd
            // 
            this.numericUpDownTEnd.DecimalPlaces = 1;
            this.numericUpDownTEnd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTEnd.Location = new System.Drawing.Point(286, 144);
            this.numericUpDownTEnd.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTEnd.Name = "numericUpDownTEnd";
            this.numericUpDownTEnd.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownTEnd.TabIndex = 15;
            this.numericUpDownTEnd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownTempo
            // 
            this.numericUpDownTempo.DecimalPlaces = 1;
            this.numericUpDownTempo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTempo.Location = new System.Drawing.Point(285, 170);
            this.numericUpDownTempo.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTempo.Name = "numericUpDownTempo";
            this.numericUpDownTempo.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownTempo.TabIndex = 16;
            this.numericUpDownTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.DecimalPlaces = 2;
            this.numericUpDownR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownR.Location = new System.Drawing.Point(401, 118);
            this.numericUpDownR.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownR.TabIndex = 17;
            this.numericUpDownR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 657);
            this.Controls.Add(this.numericUpDownR);
            this.Controls.Add(this.numericUpDownTempo);
            this.Controls.Add(this.numericUpDownTEnd);
            this.Controls.Add(this.numericUpDownTStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonStartPause);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pictureBoxEquation);
            this.Name = "Form1";
            this.Text = "MiSS6 - Symulator Falowania Wody";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEquation;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownTStart;
        private System.Windows.Forms.NumericUpDown numericUpDownTEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownTempo;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.Timer timer1;
    }
}

