using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snek
{
    public partial class Game : Form
    {
        Area area = new Area();
        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            area.Top = 100;
            area.Left = 100;

            this.Controls.Add(area);
            this.Height = 600;
            this.Width = 600;
        }
    }
}
