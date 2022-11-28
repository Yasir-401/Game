using System.Diagnostics;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.FiniteStates.HeroStates
{
    public class WalkingRight : HeroState
    {
        #region Fields

        #endregion
        #region Methods
        public WalkingRight(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.WalkRight, instance.Position);
        }
        public override void Handle(GameTime time)
        {
            switch (((Hero)instance).InputStatus)
            {
                case CharacterStatus.WalkingLeft:
                    ((Hero)instance).ChangeState(new IdleLeft((Hero)instance));
                    break;
                case CharacterStatus.Idle:
                    ((Hero)instance).ChangeState(new IdleRight((Hero)instance));
                    break;
                case CharacterStatus.Falling:
                    ((Hero)instance).ChangeState(new FallingRight((Hero)instance));
                    break;
                case CharacterStatus.jumping:
                    ((Hero)instance).ChangeState(new JumpRight((Hero)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((Hero)instance).ChangeState(new AttackRight((Hero)instance));
                    break;
            }
            if(((Hero)instance).State!=this)
                return;
            base.Handle(time);
        }

        #endregion
    }
}