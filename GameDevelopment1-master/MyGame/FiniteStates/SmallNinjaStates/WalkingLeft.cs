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
 public   class WalkingLeft:SmallNinjaLeftBase
    {
        #region Methods
        public WalkingLeft(SmallNinja ninja) : base(ninja)
        {
            Animation = new SmallNinjaAnimationFactory().CreateAnimation(AnimationType.WalkLeft, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((SmallNinja)instance).InputStatus)
            {
                case CharacterStatus.WalkingRight:
                    ((SmallNinja)instance).ChangeState(new IdleRight((SmallNinja)instance));
                    break;
                case CharacterStatus.Idle:
                    ((SmallNinja)instance).ChangeState(new IdleLeft((SmallNinja)instance));
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
