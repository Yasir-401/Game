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
 public   class FallingRight:SmallNinjaState
    {
        #region Methods
        public FallingRight(SmallNinja ninja) : base(ninja)
        {
            Animation = new SmallNinjaAnimationFactory().CreateAnimation(AnimationType.FallingRight, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((SmallNinja)instance).InputStatus)
            {
                case CharacterStatus.Idle:

                    ((SmallNinja)instance).ChangeState(new IdleRight((SmallNinja)instance));
                    break;
            }
            if (((SmallNinja)instance).State != this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
