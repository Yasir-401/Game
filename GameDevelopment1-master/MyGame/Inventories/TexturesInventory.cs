using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using MyGame.interfaces;

namespace MyGame.Inventories
{
    public class TextureInventory : IInventory<Texture2D>
    {
        #region Fields

        private static readonly TextureInventory _instance = new TextureInventory();

        #endregion

        #region Properties

        public List<Texture2D> Items { get; set; } = new List<Texture2D>();

        #endregion

        #region Methods

        private TextureInventory()
        {
            Items = new List<Texture2D>();
        }

        public static TextureInventory GetInstance()
        {
            return _instance;
        }

        public Texture2D GiveRequestedResource(string name)
        {
            Texture2D resource = null;
            for (var i = 0; i < Items.Count; i++)
                if (Items[i].Name == name)
                {
                    resource = Items[i];
                    break;
                }

            return resource;
        }

        #endregion
    }
}