using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.interfaces;

namespace MyGame.BaseClasses
{
    public abstract class Sprite : FiniteStateMachine, IGameObject
    {
        #region Fields
        internal Texture2D _texture;
        #endregion
        #region Properties
        public  Vector2 Position { get; set; }
        #endregion
        #region Methods

        public Sprite(Texture2D texture,Vector2 position):this(texture)
        {
            this.Position = position;
        }
        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }
        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Update(GameTime time);
        #endregion
    }
}