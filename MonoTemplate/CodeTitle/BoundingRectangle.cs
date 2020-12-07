using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
//--engine import
using Engine;

namespace Template.CodeTitle
{
    internal class BoundingRectangle : Sprite
    {

        public BoundingRectangle(int x, int y, int w, int h, Color c)
        {
            GM.engineM.AddSprite(this);
            Frame.Define(Tex.SingleWhitePixel);

            Align = Align.topLeft;
            X = x;
            Y = y;
            SX = w;
            SY = h;

            Wash = c;
            Alpha = 0.4f;
        }
    }
}