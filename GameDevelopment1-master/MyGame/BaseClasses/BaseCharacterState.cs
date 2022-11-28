using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.Animations;
using MyGame.GameCharacters;
using MyGame.interfaces;
using System;
using System.Collections.Generic;
using MyGame.Hitboxes;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.BaseClasses
{
    public abstract class BaseCharacterState : IStateWithTime,IDrawable
    {
        #region Properties
        public IGameObject instance { get; set; }
        public Animation Animation { get; set; } 
        #endregion
        #region Methods

        public BaseCharacterState(IGameObject obj)
        {
            instance = obj;
        }
        public virtual void Handle(GameTime time)
        {
            Animation.Update(time, (Sprite)instance);
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(((Sprite)instance)._texture, instance.Position, Animation.CurrentFrame.SourceRectangle, Color.White);
        }

        public IList<HitBox> GetHitboxes()
        {
            return this.Animation.CurrentFrame.HitBoxes;
        }

        #endregion


    }
}