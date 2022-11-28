using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.BaseClasses
{
public abstract   class BaseCharacterStateLeft:BaseCharacterState
    {
        #region Methods
        public BaseCharacterStateLeft(IGameObject obj) : base(obj) { }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(((Sprite)instance)._texture, instance.Position, Animation.CurrentFrame.SourceRectangle,
                Color.White, 0.0f, Vector2.Zero, 1.0f, SpriteEffects.FlipHorizontally, 0.0f);
        } 
        #endregion
    }
}
