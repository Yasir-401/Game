using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Binders;
using MyGame.interfaces;
using IDrawable = MyGame.interfaces.IDrawable;
using IUpdateable = MyGame.interfaces.IUpdateable;

namespace MyGame.Menus
{
    public class StartMenu : IMenu, IDrawable, IUpdateable
    {
        #region Fields

        private readonly Texture2D _texture;
        private Rectangle _rectangle;

        #endregion

        #region Properties

        public List<Button> Buttons { get; set; }
        public IButtonToStateBinder StateBinder { get; set; }

        #endregion

        #region Methods

        public StartMenu(Texture2D textureIn, List<Button> buttons)
        {
            Buttons = buttons;
            _texture = textureIn;
            StateBinder = ButtonToStateBinder.GetInstance();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, new Vector2(0, 0), Color.DarkBlue);
            for (var i = 0; i < Buttons.Count; i++)
                if (Buttons[i] is IDrawable d)
                    d.Draw(spriteBatch);
        }

        public void Update()
        {
            for (var i = 0; i < Buttons.Count; i++)
                if (Buttons[i] is IClickableButton d)
                    d.Update();
        }

        #endregion
    }
}