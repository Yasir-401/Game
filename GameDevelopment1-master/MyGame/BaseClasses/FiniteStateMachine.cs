using MyGame.interfaces;

namespace MyGame.BaseClasses
{
    public class FiniteStateMachine
    {
        #region Properties

        public IState State { get; protected set; }

        #endregion
        #region Methods
        public void ChangeState(IState state)
        {
            State = state;
        }
        #endregion
    }
}