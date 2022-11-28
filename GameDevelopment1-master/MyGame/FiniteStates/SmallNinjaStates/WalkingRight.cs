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
 public   class WalkingRight:SmallNinjaState
    {
        #region Methods
        public WalkingRight(SmallNinja ninja) : base(ninja)
        {
            Animation = new SmallNinjaAnimationFactory().CreateAnimation(AnimationType.WalkRight, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((SmallNinja)instance).InputStatus)
            {
                case CharacterStatus.Idle:
                    ((SmallNinja)instance).ChangeState(new IdleRight((SmallNinja)instance));
                    break;
                case CharacterStatus.Falling:
                    ((SmallNinja)instance).ChangeState(new FallingRight((SmallNinja)instance));
                    break;
                case CharacterStatus.jumping:
                    ((SmallNinja)instance).ChangeState(new JumpingRight((SmallNinja)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((SmallNinja)instance).ChangeState(new AttackRight((SmallNinja)instance));
                    break;
                case CharacterStatus.WalkingLeft:
                    ((SmallNinja)instance).ChangeState(new IdleLeft((SmallNinja)instance));
                    break;
            }
            if (((SmallNinja)instance).State != this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
