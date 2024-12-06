using CSharp_Expert.Opdracht4.Components;
using CSharp_Expert.Opdracht4.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace CSharp_Expert.Opdracht4.Behaviour;

public class SpriteRenderer : Component, IDrawableComponent
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
    
    public void Draw(SpriteBatch spriteBatch)
    {
        //draws sprite with
        spriteBatch.Draw(Texture,_gameObject.Transform.Position,null,Color,MathHelper.ToRadians(_gameObject.Transform.Rotation),_gameObject.Transform.Origin * _textureSize,_gameObject.Transform.Scale,SpriteEffects.None,LayerDepth);
    }
}