﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picsor.Controls
{
    public interface IFontCustomizable
    {
        void SetCustomFont(FontFamily font, int baseSize);
    }
}
