using MyGame.BaseClasses;

namespace MyGame.interfaces
{
    public interface IButtonToStateBinder
    {
        public GameState BindButtonToState(Button button);
    }
}