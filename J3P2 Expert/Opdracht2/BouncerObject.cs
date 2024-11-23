using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht2;

public class BouncerObject : GameObject
{
    private Texture2D _texture;
    //speed in periods per second
    private float _speed;
    private Vector2 _bounceDirection;
    private float _amplitude;
    private Vector2 _originalPos;
    public BouncerObject(Texture2D texture, float speed, Vector2 direction, float amplitude, Vector2 originalPos) : base(texture)
    {
        _texture = texture;
        _speed = speed;
        _bounceDirection = Vector2.Normalize(direction);
        _amplitude = amplitude;
        _originalPos = originalPos;
    }
    public override void Update(GameTime gameTime)
    {
        Console.WriteLine(_bounceDirection);
        float deltaTime = (float)gameTime.TotalGameTime.TotalSeconds;
        Vector2 offset = (MathF.Sin(deltaTime * MathHelper.TwoPi * _speed) + 1) * 0.5f * _bounceDirection;

        Transform.Position = new Vector2(
            _originalPos.X + offset.X * _amplitude,
            _originalPos.Y + offset.Y * _amplitude
        );

        base.Update(gameTime);
    }
}