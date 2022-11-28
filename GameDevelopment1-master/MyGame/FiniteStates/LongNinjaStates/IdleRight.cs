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
  public  class IdleRight:LongNinjaState
    {
        #region Methods
        public IdleRight(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.IdleRight, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((LongNinja)instance).InputStatus)
            {
                case CharacterStatus.WalkingRight:
                    ((LongNinja)instance).ChangeState(new WalkingRight((LongNinja)instance));
                    break;
                case CharacterStatus.WalkingLeft:
                    ((LongNinja)instance).ChangeState(new IdleLeft((LongNinja)instance));
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
