using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Bakgrund
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Sprite mSprite;
        Sprite mSpriteTwo;
        Sprite mBackgroundOne;
        Sprite mBackgroundTwo;
        Sprite mBackgroundThree;
        Sprite mBackgroundFour;
        Sprite mBackgroundFive;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            mSprite = new Sprite();
            mSpriteTwo = new Sprite();

            mBackgroundOne = new Sprite();
            mBackgroundOne.scale = 2.0f;

            mBackgroundTwo = new Sprite();
            mBackgroundTwo.scale = 2.0f;

            mBackgroundThree = new Sprite();
            mBackgroundThree.scale = 2.0f;

            mBackgroundFour = new Sprite();
            mBackgroundFour.scale = 2.0f;

            mBackgroundFive = new Sprite();
            mBackgroundFive.scale = 2.0f;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            mSprite.LoadContent(this.Content, "OrangeLink");
            mSprite.position = new Vector2(125, 125);

            mSpriteTwo.LoadContent(this.Content, "SquareGuy");
            mSpriteTwo.position = new Vector2(245, 125);

            mBackgroundOne.LoadContent(this.Content, "Background01");
            mBackgroundOne.position = new Vector2(0, 0);

            mBackgroundTwo.LoadContent(this.Content, "Background02");
            mBackgroundTwo.position = new Vector2(mBackgroundOne.position.X + mBackgroundOne.size.Width, 0);

            mBackgroundThree.LoadContent(this.Content, "Background03");
            mBackgroundThree.position = new Vector2(mBackgroundTwo.position.X + mBackgroundTwo.size.Width, 0);

            mBackgroundFour.LoadContent(this.Content, "Background04");
            mBackgroundFour.position = new Vector2(mBackgroundThree.position.X + mBackgroundThree.size.Width, 0);

            mBackgroundFive.LoadContent(this.Content, "Background05");
            mBackgroundFive.position = new Vector2(mBackgroundThree.position.X + mBackgroundThree.size.Width, 0);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            if (mBackgroundOne.position.X < -mBackgroundOne.size.Width)
            {
                mBackgroundOne.position.X = mBackgroundFive.position.X + mBackgroundFive.size.Width;
            }

            if (mBackgroundTwo.position.X < -mBackgroundTwo.size.Width)
            {
                mBackgroundThree.position.X = mBackgroundOne.position.X + mBackgroundOne.size.Width;
            }

            if (mBackgroundThree.position.X < -mBackgroundThree.size.Width)
            {
                mBackgroundThree.position.X = mBackgroundTwo.position.X + mBackgroundTwo.size.Width;
            }

            if (mBackgroundFour.position.X < -mBackgroundFour.size.Width)
            {
                mBackgroundFour.position.X = mBackgroundThree.position.X + mBackgroundThree.size.Width;
            }

            if (mBackgroundFive.position.X < -mBackgroundFive.size.Width)
            {
                mBackgroundFive.position.X = mBackgroundFour.position.X + mBackgroundFour.size.Width;
            }

            Vector2 aDirection = new Vector2(-1, 0);
            Vector2 aSpeed = new Vector2(160, 0);

            mBackgroundOne.position += aDirection * aSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            mBackgroundTwo.position += aDirection * aSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            mBackgroundThree.position += aDirection * aSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            mBackgroundFour.position += aDirection * aSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            mBackgroundFive.position += aDirection * aSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.Firebrick);

            spriteBatch.Begin();

            mBackgroundOne.Draw(this.spriteBatch);
            mBackgroundTwo.Draw(this.spriteBatch);
            mBackgroundThree.Draw(this.spriteBatch);
            mBackgroundFour.Draw(this.spriteBatch);
            mBackgroundFive.Draw(this.spriteBatch);

            mSprite.Draw(this.spriteBatch);
            mSpriteTwo.Draw(this.spriteBatch);



            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}