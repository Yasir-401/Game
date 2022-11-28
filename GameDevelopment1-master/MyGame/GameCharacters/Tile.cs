using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.Animations;
using MyGame.BaseClasses;
using MyGame.FiniteStates.TileStates;
using MyGame.Hitboxes;
using MyGame.interfaces;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.GameCharacters
{
    public class Tile : Sprite
    {
        #region Methods
        public Tile(Texture2D texture,Vector2 position) : base(texture,position)
        {
            State = new IdleRight(this);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if(State is IDrawable d)
                d.Draw(spriteBatch);
        }
        public override void Update(GameTime time)
        {
            if(State is IStateWithTime d)
                d.Handle(time);
            else if(State is IStateWithoutTime t)
                t.Handle();
        }

        #endregion
    }
}