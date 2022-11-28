using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Buttons;
using MyGame.Enums;

namespace MyGame.Abstract_Classes
{
    public class ButtonFactory
    {
        #region Methods

        public static Button CreateButton(ButtonTypes type, Texture2D texture)
        {
            Button mustCreated = null;
            switch (type)
            {
                case ButtonTypes.Start:
                    mustCreated = new StartButton(texture);
                    break;
            }

            return mustCreated;
        }

        #endregion
    }
}