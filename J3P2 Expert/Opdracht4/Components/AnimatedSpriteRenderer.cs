using CSharp_Expert.Opdracht4.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht4.Components;

public class AnimatedSpriteRenderer : Component, IUpdateableComponent, IDrawableComponent
{
    private Texture2D _spriteSheet;
    private int _horizontalSpriteCount;
    private int _verticalSpriteCount;
    private float _animationSpeed;
    //might not need
    private Color _color;
    private float _layerDepth;
    
    private int _spriteIndex;
    private Rectangle[] _sourceRects;
    private Rectangle _currentSourceRect;

    public AnimatedSpriteRenderer(Texture2D spriteSheet, int horizontalSpriteCount, int verticalSpriteCount, float speed, Color color, float layerDepth)
    {
        
    }
    
    public void Update(GameTime gameTime)
    {
    }

    public void Draw(SpriteBatch spriteBatch)
    {
    }
}