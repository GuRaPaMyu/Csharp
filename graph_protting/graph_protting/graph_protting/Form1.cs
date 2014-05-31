using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace graph_protting
{
    public partial class OSC : Form
    {
        SerialCommunicator serialForm = new SerialCommunicator();
        Channel Channel1 = new Channel();
        Monitor Monitor1 = new Monitor();
    
        public OSC()
        {
          InitializeComponent();
        }
  
        private void Form1Load(object sender, EventArgs e)
        {
            Picturebox1Init();
            //serialForm.Show();
            //serialForm.Activate();  
            this.AddOwnedForm(serialForm);
        }

        private void Form1Closed(object sender, FormClosedEventArgs e)
        {
            serialForm.SerialClose();
        }
        
        private void Picturebox1Init()
        {
            Point originPicturebox1 = new Point();
            originPicturebox1.X = 12;
            originPicturebox1.Y = 12;
            pictureBox1.Location = originPicturebox1;

            Monitor1.Width = pictureBox1.Width;
            Monitor1.Height = pictureBox1.Height;

            label1.Text = numericUpDown1.Value.ToString() + " V/Div";
            label2.Text = numericUpDown2.Value.ToString() + " ms/Div";
        }

        private void Form1SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 24);
            Monitor1.Width = pictureBox1.Width;
            Monitor1.Height = pictureBox1.Height;
            pictureBox1.Invalidate();
        }

        private void Picturebox1Paint(object sender, PaintEventArgs e)
        {
            Monitor1.DrawAxis(e.Graphics);
            Channel1.DataInput();
            Channel1.DataConvert();
            Channel1.DrawReceivedData(e.Graphics);
        }
    }
}