using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.LongNinjaStates
{
public    class AttackRight:LongNinjaState
    {
        #region Methods
        public AttackRight(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.AttackRight, instance.Position);
        }
        public override void Handle(GameTime time)
        {
            if (Animation.CurrentFrame == Animation.Frames[Animation.Frames.Count - 1]) 
                ((LongNinja)instance).ChangeState(new IdleRight((LongNinja)instance));
            base.Handle(time);
        } 
        #endregion
    }
}
