using System;
using Microsoft.Xna.Framework;

namespace CSharp_Expert.Opdracht4.Behaviour;

public class Bouncer : MonoBehaviour
{
    //speed in periods per second
    private float _speed;
    private Vector2 _bounceDirection;
    private float _amplitude;
    private Vector2 _originalPos;
    public Bouncer(float speed, Vector2 direction, float amplitude)
    {
        _speed = speed;
        _bounceDirection = Vector2.Normalize(direction);
        _amplitude = amplitude;
    }
    public override void Update(GameTime gameTime)
    {
        if(_originalPos == Vector2.Zero)
        {
            _originalPos = _gameObject.Transform.Position;
        }
        float deltaTime = (float)gameTime.TotalGameTime.TotalSeconds;
        Vector2 offset = (MathF.Sin(deltaTime * MathHelper.TwoPi * _speed) + 1) * 0.5f * _bounceDirection;

        _gameObject.Transform.Position = new Vector2(
            _originalPos.X + offset.X * _amplitude,
            _originalPos.Y + offset.Y * _amplitude
        );

        base.Update(gameTime);
    }
}