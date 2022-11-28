using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;
using MyGame.Inventories;

namespace MyGame.FiniteStates.HeroStates
{
    public class AttackRight : HeroState, IStateWithTime
    {
        #region Fields
        #endregion
        #region Methods
        public AttackRight(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.AttackRight, instance.Position);
        }

        public void Handle(GameTime time)
        {
            if (Animation.CurrentFrame == Animation.Frames[Animation.Frames.Count - 1])
            {
                CharacterInventory.GetInstance().Items.Add(new Arrow(TextureInventory.GetInstance().GiveRequestedResource("arrow"),"right",(int)instance.Position.X+115,(int)instance.Position.Y+50));
                ((Hero)instance).ChangeState(new IdleRight((Hero)instance));
            }
                
            base.Handle(time);
        }

        #endregion
    }
}