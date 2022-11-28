using MyGame.GameCharacters;

namespace MyGame.BaseClasses.SpecificCharacterStates
{
    public abstract class SpikyTrapState : BaseCharacterState
    {
        #region Methods
        public SpikyTrapState(SpikyTrap trap) : base(trap) { }
        #endregion
    }
}