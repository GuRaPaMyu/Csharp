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
        Channel channel1 = new Channel();
        Monitor monitor1 = new Monitor();
    
        public OSC()
        {
          InitializeComponent();
        }
  
        private void form1Load(object sender, EventArgs e)
        {
            picturebox1Init();
            //serialForm.Show();
            //serialForm.Activate();  
            this.AddOwnedForm(serialForm);
        }

        private void form1Closed(object sender, FormClosedEventArgs e)
        {
            serialForm.SerialClose();
        }
        
        private void picturebox1Init()
        {
            Point originPicturebox1 = new Point();
            originPicturebox1.X = 12;
            originPicturebox1.Y = 12;
            pictureBox1.Location = originPicturebox1;

            monitor1.Width = pictureBox1.Width;
            monitor1.Height = pictureBox1.Height;

            label1.Text = numericUpDown1.Value.ToString() + " V/Div";
            label2.Text = numericUpDown2.Value.ToString() + " ms/Div";
        }

        private void form1SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 24);
            monitor1.Width = pictureBox1.Width;
            monitor1.Height = pictureBox1.Height;
            pictureBox1.Invalidate();
        }

        private void picturebox1Paint(object sender, PaintEventArgs e)
        {
            monitor1.DrawAxis(e.Graphics);
            channel1.DataInput();
            channel1.DataConvert();
            channel1.DrawReceivedData(e.Graphics);
        }

    }
}