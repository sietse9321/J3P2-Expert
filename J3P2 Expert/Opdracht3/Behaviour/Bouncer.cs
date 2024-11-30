using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht3.Behaviour;

public class Bouncer : MonoBehaviour
{
    //speed in periods per second
    private float _speed;
    private Vector2 _bounceDirection;
    private float _amplitude;
    private Vector2 _originalPos;
    public Bouncer(float speed, Vector2 direction, float amplitude, Vector2 originalPos)
    {
        _speed = speed;
        _bounceDirection = Vector2.Normalize(direction);
        _amplitude = amplitude;
        _originalPos = originalPos;
    }
    public override void Update(GameTime gameTime)
    {
        float deltaTime = (float)gameTime.TotalGameTime.TotalSeconds;
        Vector2 offset = (MathF.Sin(deltaTime * MathHelper.TwoPi * _speed) + 1) * 0.5f * _bounceDirection;

        _gameObject.Transform.Position = new Vector2(
            _originalPos.X + offset.X * _amplitude,
            _originalPos.Y + offset.Y * _amplitude
        );

        base.Update(gameTime);
    }
}