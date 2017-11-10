﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Aquarium
{
    public interface ICreator
    {
        IFish Create(int x, int y, Graphics g);
    }
}
