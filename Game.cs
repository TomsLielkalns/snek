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
        int horVelocity = 0;
        int verVelocity = 0;
        int step = 20;

        Area area = new Area();
        Snake snake = new Snake();
        Timer mainTimer = new Timer();

        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            mainTimer.Interval = 500;
            mainTimer.Tick += new EventHandler(MainTimerTick);
            mainTimer.Start();
        }

        private void MainTimerTick(object sender, EventArgs e)
        {

        }

        private void InitializeGame()
        {
            area.Top = 100;
            area.Left = 100;

            this.Controls.Add(area);
            this.Height = 600;
            this.Width = 600;

            //snake body
            snake.Render(this);
        }
    }
}
