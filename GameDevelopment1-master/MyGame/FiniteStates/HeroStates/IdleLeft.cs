using Microsoft.Xna.Framework;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.FiniteStates.HeroStates
{
    public class IdleLeft : HeroLeftStateBase, IStateWithTime
    {
        #region Methods

        public IdleLeft(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.IdleLeft, instance.Position);
        }

        public void Handle(GameTime time)
        {
            switch (((Hero)instance).InputStatus)
            {
                case CharacterStatus.WalkingRight:
                    ((Hero)instance).ChangeState(new IdleRight((Hero)instance));
                    break;
                case CharacterStatus.WalkingLeft:
                    ((Hero)instance).ChangeState(new WalkingLeft((Hero)instance));
                    break;
                case CharacterStatus.Falling:
                    ((Hero)instance).ChangeState(new FallingLeft((Hero)instance));
                    break;
                case CharacterStatus.jumping:
                    ((Hero)instance).ChangeState(new JumpLeft((Hero)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((Hero)instance).ChangeState(new AttackLeft((Hero)instance));
                    break;
            }
            if(((Hero)instance).State!=this)
                return;
            base.Handle(time);

            #endregion
        }
    }
}