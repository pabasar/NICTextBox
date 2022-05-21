using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NICTextBox
{
    public partial class NICTextBox: TextBox
    {
        public NICTextBox()
        {
            BackColor = Color.LightYellow;
            ForeColor = Color.SaddleBrown;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {        
                e.Handled = false;
            }
            else if (e.KeyChar == 'V')
            {
                if (Text.IndexOf("V") == -1)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 'X')
            {
                if (Text.IndexOf("X") == -1)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
