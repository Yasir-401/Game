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
   public class WalkingRight:LongNinjaState
    {
        #region Methods
        public WalkingRight(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.WalkRight, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((LongNinja)instance).InputStatus)
            {
                case CharacterStatus.WalkingLeft:
                    ((LongNinja)instance).ChangeState(new IdleLeft((LongNinja)instance));
                    break;
                case CharacterStatus.Idle:
                    ((LongNinja)instance).ChangeState(new IdleRight((LongNinja)instance));
                    break;
                case CharacterStatus.jumping:
                    ((LongNinja)instance).ChangeState(new JumpRight((LongNinja)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((LongNinja)instance).ChangeState(new AttackRight((LongNinja)instance));
                    break;
            }
            
            if(((LongNinja)instance).State!=this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
