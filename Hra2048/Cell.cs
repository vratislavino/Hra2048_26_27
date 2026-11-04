using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hra2048
{
    public partial class Cell : UserControl
    {
        private int val;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Val { 
            get { return val; }
            set
            {
                val = value;
                label1.Text = val == 0 ? "" : val.ToString();
                UpdateColor();
            }
        }

        public bool MergedThisRound = false;

        static Dictionary<int, Color> colors =
            new Dictionary<int, Color>() {
                { 0, Color.White },
                { 2, Color.AntiqueWhite },
                { 4, Color.LightYellow },
                { 8, Color.WhiteSmoke },
                { 16, Color.LightCoral },
                { 32, Color.LightGray },
                { 64, Color.LightPink },
                { 128, Color.LightSalmon },
                { 256, Color.LightSeaGreen },
                { 512, Color.LightSteelBlue },
                { 1024, Color.LightSkyBlue },
                { 2048, Color.LightCyan },
            };


        public Cell()
        {
            InitializeComponent();
        }

        private void UpdateColor()
        {
            BackColor = colors[val];
        }
    }
}
