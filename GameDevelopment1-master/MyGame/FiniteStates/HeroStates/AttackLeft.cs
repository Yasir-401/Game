using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;
using MyGame.Inventories;

namespace MyGame.FiniteStates.HeroStates
{
    public class AttackLeft : HeroLeftStateBase, IStateWithTime
    {
        #region Methods

        public AttackLeft(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.AttackLeft, instance.Position);
        }
        public void Handle(GameTime time)
        {

            if (Animation.CurrentFrame == Animation.Frames[Animation.Frames.Count - 1])
            {
                CharacterInventory.GetInstance().Items.Add(new Arrow(TextureInventory.GetInstance().GiveRequestedResource("arrow"),"left",(int)instance.Position.X-70,(int)(instance.Position.Y+55)));

                ((Hero)instance).ChangeState(new IdleLeft((Hero)instance));
            }
               
            base.Handle(time);
        }

        #endregion
    }
}