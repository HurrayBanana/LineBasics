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
    internal class Polygon
    {
        /// <summary>
        /// Protected values are accessible by inherited classes
        /// </summary>
        protected Vector3[] verts;
        /// <summary>
        /// reference to line object for manipulation of line properties
        /// </summary>
        protected Line mypolyline;
        /// <summary>
        /// creates a polygon line and adds it to the line manager
        /// of the game engine
        /// </summary>
        /// <param name="myverts">array of vector3 values that make up the polygon</param>
        /// <param name="style">closed or open polygon drawing</param>
        public Polygon(Vector3[] myverts, LineType style)
        {
            verts = myverts;
            mypolyline = new Line(verts, style);
            GM.engineM.AddLine(mypolyline);
        }

    }
}