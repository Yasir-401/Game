using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MyGame.Animations;
using MyGame.BaseClasses;
using MyGame.Buttons;
using MyGame.Factory_Classes;
using MyGame.FiniteStates.GameStates;
using MyGame.GameCharacters;
using MyGame.interfaces;
using MyGame.Inventories;
using MyGame.Menus;
using MyGame.TrulyGame;

namespace MyGame
{
    public class Game1 : Game
    {
        private readonly GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _texture;
        private readonly MyGameWrapper game = new MyGameWrapper();
        private int _previousLevel =0;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _previousLevel = game.Level;
            _graphics.PreferredBackBufferWidth = ScreenBoundsInventory.GetInstance().ScreenWidth;
            _graphics.PreferredBackBufferHeight = ScreenBoundsInventory.GetInstance().ScreenHeight;
          
            //_graphics.IsFullScreen = true;
        }
        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _texture = new Texture2D(GraphicsDevice, 1, 1);
            _texture.SetData(new[] { Color.White });
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("StartButton"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("BackgroundStartMenu"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("BackgroundTile"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("archer"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("ninja1"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("ninja2n"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("tileset"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("spikeyTrap"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("arrow"));
            TextureInventory.GetInstance().Items.Add(Content.Load<Texture2D>("3background2"));
            FontInventory.GetInstance().Items.Add(Content.Load<SpriteFont>("File"));
            game.ChangeState(new Intro(game,
                new StartMenu(TextureInventory.GetInstance().GiveRequestedResource("BackgroundStartMenu"),
                    new List<Button>
                        { new StartButton(TextureInventory.GetInstance().GiveRequestedResource("StartButton")) })));
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (_previousLevel != game.Level)
            {
                _graphics.PreferredBackBufferWidth = ScreenBoundsInventory.GetInstance().ScreenWidth*game.Level;
                _graphics.PreferredBackBufferHeight = ScreenBoundsInventory.GetInstance().ScreenHeight*game.Level;
                this._graphics.ApplyChanges();
                _previousLevel = game.Level;

            }

            game.Update(gameTime);
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            game.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}