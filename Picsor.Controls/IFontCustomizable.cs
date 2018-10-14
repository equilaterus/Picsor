using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picsor.Controls
{
    /// <summary>
    /// Changes the font only for the specified components in SetCustomFont
    /// </summary>
    public interface IFontCustomizable
    {
        void SetCustomFont(FontFamily font);
    }
}
