using MyGame.GameCharacters;

namespace MyGame.BaseClasses.SpecificCharacterStates
{
    public abstract class TileState : BaseCharacterState
    {
        #region Methods
        public TileState(Tile tile) : base(tile) { }
        #endregion
    }
}