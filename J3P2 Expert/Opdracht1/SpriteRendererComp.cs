using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht1;

public class SpriteRendererComp
{
    public Texture2D Texture { get; private set; }
    public Color Color { get; private set; } = Color.White;
    public float LayerDepth { get; private set; } = 0.9f;

    private Vector2 originNormalized = Vector2.Zero;

    private Vector2 _textureSize;
    public Vector2 Origin
    {
        get => originNormalized;
        set => originNormalized = value;
    }

    public SpriteRendererComp(Texture2D texture)
    {
        Texture = texture;
        //converts the texture dimension size to a vector 2
        _textureSize = Texture.Bounds.Size.ToVector2();
    }

    /// <summary>
    /// draws the texture at the given transform position etc
    /// </summary>
    /// <param name="spriteBatch"></param>
    /// <param name="transform"></param>
    public void Draw(SpriteBatch spriteBatch, TransformComp transform)
    {
        spriteBatch.Draw(Texture,transform.Position,null,Color,MathHelper.ToRadians(transform.Rotation),transform.Origin * _textureSize,transform.Scale,SpriteEffects.None,LayerDepth);
    }
}