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
    public partial class Settings : Form
    {
        private PictureBox item;
        private int value;
        public Settings()
        {
            FieldItem.Instance.OnNameChange += new OnPictureBoxChangeHandler(OnObjectChange);
            InitializeComponent();
            this.item = null;
            this.value = (int)MoveBy.Value;
        }

        private void OnObjectChange(object source)
        {
            item = FieldItem.Instance.Item;
            ItemName.Text = item.Name;
            UpdateProperties();
        }

        private void UpdateProperties()
        {
            if(item != null)
            {
                X.Text = item.Location.X.ToString();
                Y.Text = item.Location.Y.ToString();
                Width.Text = item.Size.Width.ToString();
                Height.Text = item.Size.Height.ToString();
            }
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            if(item != null)
            {
                if (!(item.Location.X - this.value < 0))
                {
                    item.Location = new Point(item.Location.X - this.value, item.Location.Y);
                    UpdateProperties();
                }
            }
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                if (!(item.Location.Y - this.value < 0))
                {
                    item.Location = new Point(item.Location.X, item.Location.Y - this.value);
                    UpdateProperties();
                }
            }
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                label1.Text = "Item X: " + item.Location.X + "\nValue: " + this.value + "\nField Width: " + Globals.field.Size.Width + "\nItem Width: " + item.Size.Width;
                if (!(item.Location.X + this.value > Globals.field.Size.Width - item.Size.Width))
                {
                    
                    item.Location = new Point(item.Location.X + this.value, item.Location.Y);
                    UpdateProperties();
                }
            }
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                if (!(item.Location.Y + this.value > Globals.field.Size.Height - item.Size.Height))
                {
                    item.Location = new Point(item.Location.X, item.Location.Y + this.value);
                    UpdateProperties();
                }
            }
        }

        private void MoveBy_ValueChanged(object sender, EventArgs e)
        {
            this.value = (int)MoveBy.Value;
        }

        private void ScaleFix_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Width_TextChanged(object sender, EventArgs e)
        {
            item.Size = new Size(int.Parse(Width.Text), item.Size.Height);
        }

        private void Height_TextChanged(object sender, EventArgs e)
        {
            item.Size = new Size(item.Size.Width, int.Parse(Height.Text));
        }

        private void X_TextChanged(object sender, EventArgs e)
        {
            item.Location = new Point(int.Parse(X.Text), item.Location.Y);
        }

        private void Y_TextChanged(object sender, EventArgs e)
        {
            item.Location = new Point(item.Location.X, int.Parse(Y.Text));
        }
    }
}
