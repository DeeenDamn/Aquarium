using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Aquarium
{
    public interface IFish
    {
        void Create(int x, int y, Graphics g);
    }
}
