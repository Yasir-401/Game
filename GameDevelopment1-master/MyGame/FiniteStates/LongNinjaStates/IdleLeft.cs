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
  public  class IdleLeft:LongNinjaLeftStateBase
    {
        #region Methods
        public IdleLeft(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.IdleLeft, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((LongNinja)instance).InputStatus)
            {
                case CharacterStatus.WalkingRight:
                    ((LongNinja)instance).ChangeState(new IdleRight((LongNinja)instance));
                    break;
                case CharacterStatus.WalkingLeft:
                    ((LongNinja)instance).ChangeState(new WalkLeft((LongNinja)instance));
                    break;
                case CharacterStatus.jumping:
                    ((LongNinja)instance).ChangeState(new JumpLeft((LongNinja)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((LongNinja)instance).ChangeState(new AttackLeft((LongNinja)instance));
                    break;
            }
             if(((LongNinja)instance).State!=this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
