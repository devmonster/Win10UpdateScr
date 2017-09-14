using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win10UpgradeSS
{
    public partial class ScreenSaverMain : Form
    {
        public ScreenSaverMain()
        {
            InitializeComponent();
        }

        private void ScreenSaverMain_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverMain_Load(object sender, EventArgs e)
        {
          
        }

        private void ScreenSaverMain_Shown(object sender, EventArgs e)
        {
              var screenBounds = Screen.FromControl(this).Bounds;

            this.Width = screenBounds.Width;
            this.Height = screenBounds.Height;
            this.Top = 0;
            this.Left = 0;

            uxCenterPanel.Top = this.Height / 2 - (uxCenterPanel.Height / 2);
            uxCenterPanel.Left = this.Width / 2 - (uxCenterPanel.Width / 2);
        }
    }
}
