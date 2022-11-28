using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.Animations;
using MyGame.Enums;
using MyGame.Hitboxes;
using MyGame.interfaces;

namespace MyGame.Factory_Classes
{
  public  class SpikyTrapAnimationFactory:IAnimationFactory
    {
        #region Methods
        public Animation CreateAnimation(AnimationType type, Vector2 position)
        {
            Animation createdAnimation = new Animation();
            switch (type)
            {
                case AnimationType.IdleRight:
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(80, 84, 87, 33));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>()
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(87, 33), HitBoxType.Normal, new Rectangle(6,0, 11, 4)),
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    break;
            }
            return createdAnimation;
        } 
        #endregion
    }
}
