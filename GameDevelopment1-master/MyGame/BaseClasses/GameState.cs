using MyGame.interfaces;
using MyGame.TrulyGame;

namespace MyGame.BaseClasses
{
    public abstract class GameState : IState
    {
        #region Methods
        public GameState(MyGameWrapper machine)
        {
            Machine = machine;
        }
        #endregion
        #region Properties

        public MyGameWrapper Machine { get; set; }

        #endregion
    }
}