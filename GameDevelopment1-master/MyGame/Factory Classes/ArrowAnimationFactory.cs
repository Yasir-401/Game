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
 public   class ArrowAnimationFactory:IAnimationFactory
    {
        #region Methods
        public Animation CreateAnimation(AnimationType type, Vector2 position)
        {
            Animation createdAnimation = new Animation();
            createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(16, 65, 85, 135));
            switch (type)
            {
                case AnimationType.IdleRight:

                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>()
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(85, 133), HitBoxType.Right, new Rectangle(0,3,29,124))
                    };

                    break;
                case AnimationType.IdleLeft:
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>()
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(85, 133), HitBoxType.Left, new Rectangle(28,3,29,124))
                    };

                    break;
            }
            createdAnimation.AddFrame(createdAnimation.CurrentFrame);
            return createdAnimation;
        } 
        #endregion
    }
}
