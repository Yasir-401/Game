using Microsoft.Xna.Framework;

namespace MyGame.interfaces
{
    public interface IStateWithTime : IState
    {
        public void Handle(GameTime time);
    }
}