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

        Vector3[] verts;
        private Event evLogic;
        /// <summary>
        /// reference to line object for manipulation of line properties
        /// </summary>
        private Line mypolyline;

        public Polygon(Vector3[] myverts)
        {
            verts = myverts;
            mypolyline = new Line(verts, LineType.PolygonClosed);

            //change settings
            mypolyline.Settings.Thickness = 2;
            mypolyline.Settings.Wash = Color.Red;


            GM.engineM.AddLine(mypolyline);

            GM.eventM.AddEvent(evLogic = new Event(0.01f, "movepoly", Move));
        }
        /// <summary>
        /// interate through vertices
        /// </summary>
        private void Move()
        {
            for (int i = 0; i < verts.Length; i++)
            {
                verts[i].X++;
            }
        }
    }
}