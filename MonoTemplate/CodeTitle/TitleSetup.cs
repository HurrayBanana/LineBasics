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
using Template.CodeGame;

namespace Template.CodeTitle
{
    /// <summary>
    /// 
    /// </summary>
    public class TitleSetup : IGameMode
    {
        private Event evLogic;
        List<Sprite> mysprites = new List<Sprite>();
        /// <summary>
        /// reference to logic event
        /// </summary>

        //private MouseManager mouse;

        /// <summary>
        /// implements interface property using get form
        /// to set the mode text
        /// </summary>
        public string Description { get { return "WILMINGTON GRAMMAR SCHOOL FOR BOYS"; } }

        /// <summary>
        /// constructor startpoint for mode create initial actions here
        /// </summary>
        public TitleSetup() 
        {
            GM.engineM.ScreenColour = Color.Gray;


            new Polygon();
            Sprite r = new BoundingRectangle(200, 200, 50, 100, Color.Lime);


            evLogic = new Event(0.01f, "container logic", Logic);
            GM.eventM.AddEvent(evLogic);
        }
        string message = "WELCOME TO GCSE COMPUTER SCIENCE AT WILMINGTON GRAMMAR SCHOOL FOR BOYS";

        /// <summary>
        /// general logic loop for mode
        /// any general non object specific stuff should be performed here
        /// </summary>
        private void Logic()
        {

            //launch game mode
            if (GM.inputM.KeyPressed(Keys.D1))
            {
                StartGame();
            }

            //check for quit key
            if (GM.inputM.KeyPressed(Keys.Escape))
            {
                GM.eventM.Remove(evLogic);
                GM.ClearAllManagedObjects();
                GM.CloseSystem();
            }

        }

        private void StartGame()
        {
            //tidy up before moving to another mode
            GM.eventM.Remove(evLogic);
            GM.ClearAllManagedObjects();

            GM.active = new GameSetup();
        }
    }
}
