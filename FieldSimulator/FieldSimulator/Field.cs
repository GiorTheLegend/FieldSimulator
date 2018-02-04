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
    public partial class Field : Form
    {
        public Field()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = pictureBox1.Name;
            FieldItem.Instance.Item = pictureBox1;
        }
    }
}
