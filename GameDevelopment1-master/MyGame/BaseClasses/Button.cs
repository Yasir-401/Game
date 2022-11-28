using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.Animations;
using MyGame.interfaces;

namespace MyGame.BaseClasses
{
    public abstract class Button
    {
        #region Fields
        protected ISimpleCollider collider;
        protected Color color = Color.White;
        protected Texture2D _texture;
        #endregion
        #region Properties

        public Vector2 Position { get; set; }
        protected Animation Animation { get; set; }

        #endregion
        #region Methods
        public Button(Texture2D texture)
        {
            _texture = texture;
            Position = new Vector2(0, 0);
        }
        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract event EventHandler Click;
        #endregion
    }
}