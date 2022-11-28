using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.LongNinjaStates
{
  public  class AttackLeft:LongNinjaLeftStateBase
    {
        #region Methods
        public AttackLeft(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.AttackLeft, instance.Position);// attackLeft animation
        }

        public override void Handle(GameTime time)
        {
            if (Animation.CurrentFrame == Animation.Frames[Animation.Frames.Count - 1]) 
                ((LongNinja)instance).ChangeState(new IdleLeft((LongNinja)instance));
            base.Handle(time);
        } 
        #endregion
    }
}
