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

        List<Vector3> verts = new List<Vector3>();
        private Event evLogic;

        public Polygon(List<Vector3> myverts)
        {
            verts = myverts;

            for (int i = 0; i < verts.Count - 1; i++)
            {
                GM.engineM.AddLine(new Line(verts[i], verts[i + 1]));
            }
            GM.engineM.AddLine(new Line(verts[verts.Count - 1], verts[0]));
        }

        public Polygon()
        {
            SetupVerts();

            evLogic = new Event(0.01f, "container logic", Move);
            GM.eventM.AddEvent(evLogic);
        }

        private void Move()
        {
            verts[0] = new Vector3(0,50,0);
        }

        private void SetupVerts()
        {
            verts.Add(new Vector3(100, 100, 0));
            verts.Add(new Vector3(300, 100, 0));
            verts.Add(new Vector3(300, 300, 0));
            verts.Add(new Vector3(100, 300, 0));

            for (int i = 0; i < verts.Count - 1; i++)
            {
                GM.engineM.AddLine(new Line(verts[i], verts[i + 1]));
            }
            GM.engineM.AddLine(new Line(verts[verts.Count - 1], verts[0]));
        }
    }
}