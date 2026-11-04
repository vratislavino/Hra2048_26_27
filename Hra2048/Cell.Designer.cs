namespace Hra2048
{
    partial class Cell
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 78);
            label1.TabIndex = 0;
            label1.Text = "2048";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Enabled = false;
            Name = "Cell";
            Size = new Size(80, 80);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}
