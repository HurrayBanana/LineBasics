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
    internal class Rock : Polygon
    {
        /// <summary>
        /// event to move the rock
        /// </summary>
        private Event evLogic;
        Vector3[] myverts = new Vector3[] {
                new Vector3(100,100,0),
                new Vector3(200,90,0),
                new Vector3(210,100,0),
                new Vector3(150,200,0),
                new Vector3(100,230,0) 
        };
        /// <summary>
        /// pass vertices holder length and draw style to base class
        /// then apply any other settings
        /// </summary>
        public Rock()
            :base(new Vector3[5] , LineType.PolygonClosed)
        {
            //copy my vert data over
            for (int i = 0; i < myverts.Length; i++)
                verts[i] = myverts[i];

            //change settings
            mypolyline.Settings.Thickness = 1;
            mypolyline.Settings.Wash = Color.Red;
            mypolyline.Settings.Alpha = 0.8f;

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