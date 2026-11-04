namespace Hra2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            board1.Focus();
        }

        private void board1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                board1.DoMovement(-1 , 0);
            if (e.KeyCode == Keys.D)
                board1.DoMovement(1, 0);
            if (e.KeyCode == Keys.W)
                board1.DoMovement(0, 1);
            if (e.KeyCode == Keys.S)
                board1.DoMovement(0, -1);
        }
    }
}
