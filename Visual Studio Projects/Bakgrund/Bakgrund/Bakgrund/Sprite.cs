using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Design;

namespace Bakgrund
{
    public class Sprite
    {
        public Vector2 position = new Vector2(0,0);
        public Rectangle size;
        private Texture2D mSpriteTexture;
        public float scale;

        public void LoadContent(ContentManager theContentManager, string theAssetName)
        {
            mSpriteTexture = theContentManager.Load<Texture2D>(theAssetName);
            size = new Rectangle(0, 0, (int)(mSpriteTexture.Width * scale), (int)(mSpriteTexture.Height * scale));
        }
        public void Draw(SpriteBatch theSpriteBatch)
        {

            theSpriteBatch.Draw(mSpriteTexture, position,
                new Rectangle(0, 0, mSpriteTexture.Width, mSpriteTexture.Height), Color.White,
                0.0f, Vector2.Zero, scale, SpriteEffects.None, 0);

        }
    }
}