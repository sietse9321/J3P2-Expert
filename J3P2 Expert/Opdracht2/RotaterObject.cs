using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht2;

public class RotaterObject : GameObject
{
    private Texture2D _texture;
    private float _rotationSpeed;
    private float _direction;

    public RotaterObject(Texture2D texture, float rotationSpeed, bool direction) : base(texture)
    {
        _texture = texture;
        _rotationSpeed = rotationSpeed;
        _direction = direction ? 1 : -1;
    }

    public override void Update(GameTime gameTime)
    {
        float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        Transform.Rotation += _rotationSpeed * _direction * deltaTime * 360;

        base.Update(gameTime);
    }
}