using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.GameCharacters;

namespace MyGame.BaseClasses.SpecificCharacterStates
{
    public abstract class HeroLeftStateBase : BaseCharacterStateLeft
    {
        #region Methods
        public HeroLeftStateBase(Hero hero) : base(hero) { }
        #endregion
    }
}