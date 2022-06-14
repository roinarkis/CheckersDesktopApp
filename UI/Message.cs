using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal partial class Message : Form
    {
        internal Message(string i_Message)
        {
            InitializeComponent();
            setMessage(i_Message);

        }
        private void setMessage(string i_Message)
        {
            labelMessage.Text = i_Message;
        }
        internal void setMessageToVisble()
        {
            labelIsAnotherTurn.Visible = true;
        }

    }
}
