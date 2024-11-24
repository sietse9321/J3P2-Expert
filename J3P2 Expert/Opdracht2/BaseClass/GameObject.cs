using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht2;

public class GameObject
{
    public TransformComp Transform { get; private set; }
    public SpriteRendererComp SpriteRenderer { get; private set; }
    public TextRendererComp TextRenderer { get; private set; }



    public GameObject(Texture2D texture)
    {
        Transform = new TransformComp();
        SpriteRenderer = new SpriteRendererComp(texture);
    }
    public void AddTextRenderer(SpriteFont font, string text, Color color)
    {
        TextRenderer = new TextRendererComp(font, text, color);
    }
    public virtual void Update(GameTime gameTime)
    {
    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        TextRenderer?.Draw(spriteBatch, Transform);
        SpriteRenderer?.Draw(spriteBatch, Transform);
    }
}
