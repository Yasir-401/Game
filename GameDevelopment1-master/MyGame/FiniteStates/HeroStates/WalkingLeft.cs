using Microsoft.Xna.Framework;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.FiniteStates.HeroStates
{
    public class WalkingLeft : HeroLeftStateBase, IStateWithTime
    {
        #region Methods
        public WalkingLeft(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.WalkLeft, instance.Position);
        }

        public void Handle(GameTime time)
        {
            switch (((Hero)instance).InputStatus)
            {
                case CharacterStatus.WalkingRight:
                    ((Hero)instance).ChangeState(new IdleRight((Hero)instance)); //Left state
                    break;
                case CharacterStatus.Idle:
                    ((Hero)instance).ChangeState(new IdleLeft((Hero)instance));
                    return;
                    break;
                case CharacterStatus.jumping:
                    ((Hero)instance).ChangeState(new JumpLeft((Hero)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((Hero)instance).ChangeState(new AttackLeft((Hero)instance));
                    break;
            }
            if (((Hero)instance).State != this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}