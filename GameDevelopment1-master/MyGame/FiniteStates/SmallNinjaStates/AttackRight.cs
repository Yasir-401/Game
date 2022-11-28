using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.SmallNinjaStates
{
  public  class AttackRight:SmallNinjaState
    {
        #region Methods
        public AttackRight(SmallNinja ninja) : base(ninja)
        {
            Animation = new SmallNinjaAnimationFactory().CreateAnimation(AnimationType.AttackRight, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            if (Animation.CurrentFrame == Animation.Frames[Animation.Frames.Count - 1])
            {

                ((SmallNinja)instance).ChangeState(new IdleRight((SmallNinja)instance));
            }

            base.Handle(time);
        } 
        #endregion
    }
}
