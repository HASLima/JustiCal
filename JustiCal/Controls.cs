using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    class TitleLabel : Label
    {
        public TitleLabel(string text)
        {
            Anchor = AnchorStyles.None;
            Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Text = text;
            AutoSize = true;
        }

        public TitleLabel(string text, AnchorStyles anchorStyles) : this(text)
        {
            Anchor = anchorStyles;
        }
    }

    class MyLabel : Label
    {
        public MyLabel(string text)
        {
            Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Text = text;
            AutoSize = true;
        }

        public MyLabel(string text, AnchorStyles anchorStyles) : this(text)
        {
            Anchor = anchorStyles;
        }
    }
}
