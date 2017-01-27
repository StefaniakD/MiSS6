using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public const int XSIZE = 1000;
        public const int ZSIZE = 400;

        public int FramesNumber;
        public double[,,,] Data;

        Bitmap bm;
        Graphics bmg;

        int ActualFrame = 0;

        public bool IsPlaying = false;
        public bool IsReversed = false;

        public Form1()
        {
            InitializeComponent();
            this.pictureBox.Paint += new PaintEventHandler(pictureBox_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.Controls.Add(this.pictureBox);

            this.timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (numericUpDownTEnd.Value <= numericUpDownTStart.Value) MessageBox.Show("t_end musi być większe niż t_start");
            else
            {
                this.buttonCalculate.Enabled = false;
                this.numericUpDownTStart.Enabled = false;
                this.numericUpDownTEnd.Enabled = false;
                this.numericUpDownTempo.Enabled = false;
                this.numericUpDownR.Enabled = false;
                this.buttonStartPause.Enabled = false;
                this.buttonReverse.Enabled = false;

                FramesNumber = (int)(numericUpDownTEnd.Value - numericUpDownTStart.Value)*60;
                Data = new double[FramesNumber, XSIZE, 2, 1];

                double R = (double)numericUpDownR.Value*100;
                double L = 2 * Math.PI * R;
                double c = 1.25 * Math.Sqrt(L);
                double w = (2*Math.PI)/ Math.Sqrt(L);

                for(int frame = 0; frame < FramesNumber; frame++)
                {
                    for(int x=0; x < XSIZE; x++)
                    {
                        double temp = (x - (c * frame /60)) /R;
                        if (temp < -1)
                        {
                            if ((int)temp % 2 == 0) temp = temp - (int)temp;
                            if ((int)temp % 2 == -1) temp = -1 - (temp - (int)temp);
                        }

                        if (temp > 1)
                        {
                            if ((int)temp % 2 == 0) temp = temp - (int)temp;
                            if ((int)temp % 2 == 1) temp = 1 - (temp - (int)temp);
                        }

                        if (temp < 0) temp = -temp;
                        double arccos = Math.Acos(temp);

                        double omega;
                        if (frame%30 ==0) omega = 0;
                        else omega = arccos / frame /60;
                        double z = R * Math.Sin(omega * frame/60);

                        Data[frame, x, 0, 0] = x;
                        Data[frame, x, 1, 0] = z;

                        
                    }
                }

                this.buttonCalculate.Enabled = true;
                this.numericUpDownTStart.Enabled = true;
                this.numericUpDownTEnd.Enabled = true;
                this.numericUpDownTempo.Enabled = true;
                this.numericUpDownR.Enabled = true;
                this.buttonStartPause.Enabled = true;

            }
        }
        
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (bm == null)
            {
                bm = new Bitmap(XSIZE, ZSIZE);
                bmg = Graphics.FromImage(bm);
                bmg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                bmg.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.GammaCorrected;
                bmg.Clear(Color.White);
            }
            if (IsPlaying == true) Render();
            e.Graphics.DrawImage(bm, 0, 0);
        }

        void Render()
        {
            bmg.Clear(Color.White);
            int wsp = 1000;
            double x0 = 0;
            double z0 = 0;
            for(int i = 0; i < XSIZE; i++)
            {
                double x = Data[ActualFrame, i, 0, 0];
                double z = Data[ActualFrame, i, 1, 0];
                if (z > 0) z = 200 + z * wsp;
                if (z < 0) z = 200 + z * wsp;
                if (i != 0) bmg.DrawLine(Pens.Blue, (float)x0, (float)z0, (float)x, (float)z);
                x0 = x;
                z0 = z;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ActualFrame == FramesNumber - 1)
            {
                this.timer1.Stop();
                ActualFrame = 0;
                IsPlaying = false;
                this.buttonStartPause.Text = "Start";
                bmg.Clear(Color.White);
                this.pictureBox.Invalidate();
            }
            else if (IsReversed == true && ActualFrame == 0)
            {
                ActualFrame = 0;
                IsPlaying = false;
                IsReversed = false;
                this.buttonStartPause.Text = "Start";
                this.timer1.Stop();
                bmg.Clear(Color.White);
                this.pictureBox.Invalidate();
            }
            else
            {
                if (IsReversed == false && ActualFrame < FramesNumber - 1) ActualFrame++;
                else if (ActualFrame > 0) ActualFrame--;
                this.pictureBox.Invalidate();
            }
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            if (IsPlaying == false)
            {
                this.timer1.Interval = (int)(30 / this.numericUpDownTempo.Value);
                IsPlaying = true;
                this.buttonStartPause.Text = "Pause";
                this.timer1.Start();
            }
            else
            {
                this.timer1.Stop();
                IsPlaying = false;
                this.buttonStartPause.Text = "Start";
            }
            this.buttonReverse.Enabled = true;
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (IsPlaying == false)
            {
                IsPlaying = true;
                IsReversed = true;
                this.timer1.Start();
                this.buttonStartPause.Text = "Pause";
            }
        }
    }
}
