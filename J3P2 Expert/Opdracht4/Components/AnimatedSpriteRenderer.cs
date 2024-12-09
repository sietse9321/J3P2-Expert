using System;
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
    private Color _color = Color.White;

    public Color Color
    {
        get => _color;
        set => _color = value;
    }
    private float _layerDepth;

    private int _spriteIndex;
    private Rectangle[] _sourceRects;
    private Rectangle _currentSourceRect;
    private Vector2 _textureSize;


    private float _elapsedTime;
    private int _startIndex;
    private int _endIndex;

    public AnimatedSpriteRenderer(Texture2D spriteSheet, int horizontalSpriteCount, int verticalSpriteCount, float speed, Color color, float layerDepth, int startIndex, int endIndex, int totalPadding = 0)
    {
        _spriteSheet = spriteSheet;
        _horizontalSpriteCount = horizontalSpriteCount;
        _verticalSpriteCount = verticalSpriteCount;
        _animationSpeed = speed;
        _color = color;
        _layerDepth = layerDepth;
        _startIndex = startIndex;
        _endIndex = endIndex;


        int spriteWidth = (_spriteSheet.Width - (totalPadding * (_horizontalSpriteCount - 1))) / _horizontalSpriteCount;
        int spriteHeight = (_spriteSheet.Height - (totalPadding * (_verticalSpriteCount - 1))) / _verticalSpriteCount;

        int totalSprites = _endIndex - _startIndex + 1;
        _sourceRects = new Rectangle[totalSprites];

        for (int i = 0; i < totalSprites; i++)
        {
            int index = _startIndex + i;
            _sourceRects[i] = new Rectangle((index % _horizontalSpriteCount) * (spriteWidth + totalPadding), (index / _horizontalSpriteCount) * (spriteHeight + totalPadding), spriteWidth, spriteHeight);
        }

        _spriteIndex = 0;
        _currentSourceRect = _sourceRects[_spriteIndex];
        _textureSize = _currentSourceRect.Size.ToVector2();

    }

    public void Update(GameTime gameTime)
    {
        _elapsedTime += (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (_elapsedTime >= _animationSpeed)
        {
            _elapsedTime = 0f;
            _spriteIndex++;

            if (_spriteIndex >= _sourceRects.Length)
            {
                _spriteIndex = 0;
            }

            _currentSourceRect = _sourceRects[_spriteIndex];
        }
    }


    public void Draw(SpriteBatch spriteBatch)
    {
        //spriteBatch.Draw(_spriteSheet, _gameObject.Transform.Position, _currentSourceRect, _color, MathHelper.ToRadians(_gameObject.Transform.Rotation), _gameObject.Transform.Origin, _gameObject.Transform.Scale, SpriteEffects.None, _layerDepth);
        spriteBatch.Draw(_spriteSheet, _gameObject.Transform.Position, _currentSourceRect, _color, MathHelper.ToRadians(_gameObject.Transform.Rotation), _gameObject.Transform.Origin * _textureSize, _gameObject.Transform.Scale, SpriteEffects.None, _layerDepth);
    }
}
