using System.Collections.Generic;

namespace MyGame.interfaces
{
    public interface IInventory<T>
    {
        public List<T> Items { get; set; }
    }
}