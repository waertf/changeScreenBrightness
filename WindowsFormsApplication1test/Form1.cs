using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

namespace WindowsFormsApplication1test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing +=Form1_FormClosing;
            HookManager.KeyPress += HookManager_KeyPress;
            
        }

        void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    this.Opacity -= 1/100.0;
                    break;
                case '-':
                    this.Opacity += 1/100.0;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }
        void Form1_Load(object sender, EventArgs e)
        {
            WindowWrapper.SetWindowLong(this.Handle, WindowWrapper.GWL.ExStyle, WindowWrapper.WS_EX.Layered | WindowWrapper.WS_EX.Transparent);
        }
    }
}
