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
  public  class WalkLeft:LongNinjaLeftStateBase
    {
        #region Methods
        public WalkLeft(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.WalkLeft, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((LongNinja)instance).InputStatus)
            {
                case CharacterStatus.WalkingRight:
                    ((LongNinja)instance).ChangeState(new IdleRight((LongNinja)instance));
                    break;
                case CharacterStatus.Idle:
                    ((LongNinja)instance).ChangeState(new IdleLeft((LongNinja)instance));
                    break;
                case CharacterStatus.jumping:
                    ((LongNinja)instance).ChangeState(new JumpLeft((LongNinja)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((LongNinja)instance).ChangeState(new AttackLeft((LongNinja)instance));
                    break;
            }
            if (((LongNinja)instance).State != this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
