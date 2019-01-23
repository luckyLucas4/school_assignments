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

namespace Animationer
{
    public class Sprite
    {
        public Vector2 position = new Vector2(0,0);
        public float scale = 1.0f;
        private Texture2D mSpriteTexture;
        public Rectangle size;
        const int animationsHastighet = 50;
        int bild, tid2;
            
        public void LoadContent(ContentManager theContentManager, string theAssetName)
        {
            mSpriteTexture = theContentManager.Load<Texture2D>(theAssetName);
            size = new Rectangle(0, 0, (int)(mSpriteTexture.Width * scale), (int)(mSpriteTexture.Height * scale));
        }
        public void Draw(SpriteBatch theSpriteBatch, int tid)
        {
            tid2 += tid;
            if (tid2 >= animationsHastighet)
            {
                tid2 = 0;
                bild++;
                if (bild > 15)
                {
                    bild = 0;
                }
            }
            Rectangle tmp = new Rectangle((bild % 4) * 64, (bild / 4) * 64, 64, 64);
            theSpriteBatch.Draw(mSpriteTexture, position, tmp, Color.White);
        }
    }
}
