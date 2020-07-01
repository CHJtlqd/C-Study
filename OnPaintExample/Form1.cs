using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnPaintExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)   // 화면이 시점에서 벗어났다 다시 시점으로 들어오면 호출된다.
        {
            // Call the OnPaint method of the base class.  
            base.OnPaint(e);
            // Call methods of the System.Drawing.Graphics object.  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics aGraphics = CreateGraphics();
            aGraphics.DrawString("하이", Font, new SolidBrush(ForeColor), ClientRectangle);
        }
    }
}
