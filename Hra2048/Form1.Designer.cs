namespace Hra2048
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
            board1 = new Board();
            SuspendLayout();
            // 
            // board1
            // 
            board1.BackColor = Color.White;
            board1.Location = new Point(15, 17);
            board1.Margin = new Padding(6, 8, 6, 8);
            board1.Name = "board1";
            board1.Size = new Size(482, 482);
            board1.TabIndex = 0;
            board1.KeyDown += board1_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 517);
            Controls.Add(board1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Board board1;
    }
}
