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
    internal partial class FormGameSettings : Form
    {

        private void FormGameSettings_Load(object sender, EventArgs e)
        {

        }
        internal string GetFirstPlayerName()
        {
            return tbPlayer1Name.Text;
        }
        internal string GetSecondPlayerName()
        {
            return tbPlayer2Name.Text;
        }
        internal int GetBoardSize()
        {
            return m_BoardSize;
            
        }
        internal int GetGameMode()
        {
            int gameMode;
            if(cbPlayer2.Enabled)
            {
                gameMode = 2;
            }
            else
            {
                gameMode = 1;
            }
            return gameMode;
        }

        private void cbPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            tbPlayer2Name.Enabled = !tbPlayer2Name.Enabled;
        }



        private void rbBoardSize10_CheckedChanged(object sender, EventArgs e)
        {
            m_BoardSize = 10;
        }

        private void rbBoardSize8_CheckedChanged(object sender, EventArgs e)
        {
            m_BoardSize = 8;
        }

        private void rbBoardSize6_CheckedChanged(object sender, EventArgs e)
        {
            m_BoardSize = 6;
        }
    }
}
