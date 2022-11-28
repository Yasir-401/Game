using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.SmallNinjaStates
{
  public  class IdleLeft:SmallNinjaLeftBase
    {
        #region Methods
        public IdleLeft(SmallNinja ninja) : base(ninja)
        {
            Animation = new SmallNinjaAnimationFactory().CreateAnimation(AnimationType.IdleLeft, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((SmallNinja)instance).InputStatus)
            {
                case CharacterStatus.WalkingRight:

                    ((SmallNinja)instance).ChangeState(new IdleRight((SmallNinja)instance));
                    break;
                case CharacterStatus.WalkingLeft:
                    ((SmallNinja)instance).ChangeState(new WalkingLeft((SmallNinja)instance));
                    break;
                case CharacterStatus.Falling:
                    ((SmallNinja)instance).ChangeState(new FallingLeft((SmallNinja)instance));
                    break;
                case CharacterStatus.jumping:
                    ((SmallNinja)instance).ChangeState(new JumpLeft((SmallNinja)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((SmallNinja)instance).ChangeState(new AttackLeft((SmallNinja)instance));
                    break;
            }
            if (((SmallNinja)instance).State != this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
