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
  public class TileAnimationFactory:IAnimationFactory
    {
        #region Methods
        public Animation CreateAnimation(AnimationType type, Vector2 position)
        {
            Animation createdAnimation = new Animation();
            switch (type)
            {

                case AnimationType.IdleRight:
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(48, 48, 34, 33));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>()
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(34, 33), HitBoxType.Left, new Rectangle(0, 0, 34, 0)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(34, 33), HitBoxType.Right, new Rectangle(34, 0, 32, 0)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(34, 33), HitBoxType.Top, new Rectangle(0, 0, 0, 31)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(34, 33), HitBoxType.Bottom, new Rectangle(0, 33, 0, 31)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(34, 33), HitBoxType.Normal, new Rectangle(0,0,0,0)),

                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    break;

            }

            return createdAnimation;
        } 
        #endregion
    }
}
