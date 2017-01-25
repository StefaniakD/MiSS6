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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxEquation = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTStart = new System.Windows.Forms.TextBox();
            this.textBoxTEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEquation
            // 
            this.pictureBoxEquation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEquation.Image")));
            this.pictureBoxEquation.Location = new System.Drawing.Point(246, 12);
            this.pictureBoxEquation.Name = "pictureBoxEquation";
            this.pictureBoxEquation.Size = new System.Drawing.Size(239, 85);
            this.pictureBoxEquation.TabIndex = 0;
            this.pictureBoxEquation.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 218);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(697, 269);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "t_start [s]";
            // 
            // textBoxTStart
            // 
            this.textBoxTStart.Location = new System.Drawing.Point(128, 117);
            this.textBoxTStart.Name = "textBoxTStart";
            this.textBoxTStart.Size = new System.Drawing.Size(43, 20);
            this.textBoxTStart.TabIndex = 3;
            // 
            // textBoxTEnd
            // 
            this.textBoxTEnd.Location = new System.Drawing.Point(128, 143);
            this.textBoxTEnd.Name = "textBoxTEnd";
            this.textBoxTEnd.Size = new System.Drawing.Size(43, 20);
            this.textBoxTEnd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "t_end [s]";
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(128, 169);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(43, 20);
            this.textBoxTempo.TabIndex = 7;
            this.textBoxTempo.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tempo [*]";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(246, 117);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(43, 20);
            this.textBoxR.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "R [m]";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(328, 167);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Location = new System.Drawing.Point(328, 505);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(75, 23);
            this.buttonStartPause.TabIndex = 11;
            this.buttonStartPause.Text = "Start";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(246, 505);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonReverse.TabIndex = 12;
            this.buttonReverse.Text = "<<";
            this.buttonReverse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(512, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 9);
            this.label5.TabIndex = 13;
            this.label5.Text = "Anna Cholewczyńska, Kamil Gersten, Dominik Stefaniak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 557);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonStartPause);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pictureBoxEquation);
            this.Name = "Form1";
            this.Text = "MiSS6 - Symulator Falowania Wody";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEquation;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTStart;
        private System.Windows.Forms.TextBox textBoxTEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Label label5;
    }
}

