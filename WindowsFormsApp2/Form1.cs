using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool bButton = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, System.EventArgs e)
        {
            if (bButton == false)
            {
                FactButton.Text = "더블 클릭 당함";
                bButton = true;
            }
            else
            {
                FactButton.Text = "헬로 지옥으로";
                bButton = false;

            }
        }

        private void FactButton_MouseMove(object sender, MouseEventArgs e)
        {
            FactButton.Text = "마우스 올라 옴";

        }

        private void FactButton_MouseLeave(object sender, System.EventArgs e)
        {
            this.Text = "마우스 치웠다...";

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                FactButton.Text = textBox1.Text;
            }
        }

        private void FactButton_Click(object sender, System.EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }

}
