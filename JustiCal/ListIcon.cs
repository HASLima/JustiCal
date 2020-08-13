using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    namespace View
    {
    class ListIcon : PictureBox
    {
            public object objectPassed;
            public ListIcon(Image image)
            {
                SizeMode = PictureBoxSizeMode.StretchImage;
                ClientSize = new Size(30, 30);
                Image = (Image)new Bitmap(image);
                Anchor = AnchorStyles.None;
            }

    }

    }
}
