using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class MyPictureBox : PictureBox
    {
        
        internal int Row { get; set; }
        internal int Col { get; set; }

       internal MyPictureBox(int i_row,int i_col)
        {
            Row = i_row;
            Col = i_col;
        }
        internal bool IsPossibleMove { get; set; }


    }

}
