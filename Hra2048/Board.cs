using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hra2048
{
    public partial class Board : UserControl
    {
        private Random generator = new Random();
        const int size = 4;
        Cell[,] cells;

        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            InitGame();
        }

        public void InitGame()
        {
            cells = new Cell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    cells[i, j] = new Cell();
                    Controls.Add(cells[i, j]);
                    cells[i, j].Location = new Point(
                        j * cells[i, j].Width,
                        i * cells[i, j].Height
                        );
                    cells[i, j].Val = 0;
                }
            }

            FillRandomCell();
            FillRandomCell();
        }

        private void FillRandomCell()
        {
            int x, y;
            do
            {
                x = generator.Next(size);
                y = generator.Next(size);
            } while (cells[x, y].Val > 0);

            int newVal = generator.Next(100) < 71 ? 2 : 4;
            cells[x, y].Val = newVal; 
        }
    
        public void DoMovement(int x, int y)
        {
            //i, j -> řádek, sloupec
            List<int> cisla = new List<int>(size);

            // horizontal
            // <- / A
            for (int i = 0; i < size; i++) // řádek po řádku
            {
                cisla.Clear();
                for(int j = 0; j < size; j++) // buňky v řádku
                {
                    if (cells[i, j].Val != 0)
                        cisla.Add(cells[i, j].Val);
                }
                MergeValues(cisla);
                for (int j = 0; j < size; j++)
                {
                    if (j < cisla.Count)
                        cells[i, j].Val = cisla[j];
                    else
                        cells[i, j].Val = 0;
                }
            }


            FillRandomCell();
        }

        private void MergeValues(List<int> cisla)
        {
            if (cisla.Count <= 1) return;
            for(int i = 0; i < cisla.Count - 1; i++)
            {
                if (cisla[i] == cisla[i + 1])
                {
                    cisla[i] *= 2;
                    cisla.RemoveAt(i + 1);
                }
            }
        }
    }
}
