using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace CSharp_Expert.Opdracht4.Behaviour;

public class SpriteRenderer : MonoBehaviour
{
    public Texture2D Texture { get; private set; }

    public float LayerDepth { get; private set; } = 0.9f;

    private Vector2 originNormalized = Vector2.Zero;

    private Color _color = Color.White;

    private Vector2 _textureSize;
    public Vector2 Origin
    {
        get => originNormalized;
        set => originNormalized = value;
    }
    public Color Color
    {
        get => _color; 
        set => _color = value;
    }

    public SpriteRenderer(Texture2D texture)
    {
        Texture = texture;
        _textureSize = Texture.Bounds.Size.ToVector2();
    }
    
    public override void Draw(SpriteBatch spriteBatch, Transform transform)
    {
        //draws sprite with
        spriteBatch.Draw(Texture,transform.Position,null,Color,MathHelper.ToRadians(transform.Rotation),transform.Origin * _textureSize,transform.Scale,SpriteEffects.None,LayerDepth);
    }
}