using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FieldSimulator
{
    public delegate void OnPictureBoxChangeHandler(object source);

    class FieldItem
    {
        public event OnPictureBoxChangeHandler OnNameChange;
        private PictureBox item;
        public PictureBox Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
                OnNameChange(this);
            }
        }

        private static FieldItem instance;

        private FieldItem() { }

        public static FieldItem Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new FieldItem();
                }

                return instance;
            }
        }
    }
}
