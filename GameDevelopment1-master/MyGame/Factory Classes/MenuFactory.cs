using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.interfaces;
using MyGame.Menus;

namespace MyGame.Factory_Classes
{
    public class MenuFactory
    {
        #region Methods

        public static IMenu CreateMenu(MenuTypes types, Texture2D texture, List<Button> buttons)
        {
            IMenu mustCreated = null;
            switch (types)
            {
                case MenuTypes.StartMenu:
                    mustCreated = new StartMenu(texture, buttons);
                    break;
            }

            return mustCreated;
        }

        #endregion
    }
}