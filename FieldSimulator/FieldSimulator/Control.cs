using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldSimulator
{
    public partial class Control : Form
    {
        private ControlCommand[] cmds;
        private int pos;

        public Control()
        {
            InitializeComponent();
            cmds = new ControlCommand[10];
            pos = 0;
        }

        private void UpdateCmdsInfoLabel()
        {
            CmdsInfoLabel.Text = "";

            for(int i = 0; i < pos; i++)
            {
                CmdsInfoLabel.Text += cmds[i].Display + "\n";
            }
        }

        private void AddCmd_Click(object sender, EventArgs e)
        {
            AddCommand(int.Parse(X.Text), int.Parse(Y.Text));
        }

        private void AddCommand(int x, int y)
        {
            if (pos == 0)
            {
                cmds[pos] = new ControlCommand(int.Parse(InitialX.Text), int.Parse(InitialY.Text), x, y);
            }

            else
            {
                cmds[pos] = new ControlCommand(cmds[pos - 1].EndX, cmds[pos - 1].EndY, x, y);
            }

            pos++;
            UpdateCmdsInfoLabel();
        }
    }
}
