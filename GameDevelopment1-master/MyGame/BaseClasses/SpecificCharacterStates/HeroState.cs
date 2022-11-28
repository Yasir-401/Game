using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.GameCharacters;
using MyGame.interfaces;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.BaseClasses
{
    public abstract class HeroState : BaseCharacterState, IDrawable, IStateWithTime
    {
        #region Methods
        public HeroState(Hero hero) : base(hero) { }
        #endregion
    }
}