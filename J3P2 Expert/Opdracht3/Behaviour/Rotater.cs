using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht3.Behaviour;

public class Rotater : MonoBehaviour
{
    private float _rotationSpeed;
    private float _direction;

    public Rotater(float rotationSpeed, bool direction)
    {
        _rotationSpeed = rotationSpeed;
        _direction = direction ? 1 : -1;
    }

    public override void Update(GameTime gameTime)
    {
        //object ortation is speed times direction times gametime times 360 degrees
        _gameObject.Transform.Rotation += _rotationSpeed * _direction * (float)gameTime.ElapsedGameTime.TotalSeconds * 360;
        base.Update(gameTime);
    }
}