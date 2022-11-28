using System.Collections.Generic;
using MyGame.BaseClasses;

namespace MyGame.interfaces
{
    public interface IComplexCollider
    {
        public bool HasCollided(Sprite sprite, List<Sprite> sprites);
    }
}