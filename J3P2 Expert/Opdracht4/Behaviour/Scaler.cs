using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht4.Behaviour;

public class Scaler : MonoBehaviour
{
    private float _speed;
    private Vector2 _minScale;
    private Vector2 _maxScale;

    public Scaler(float speed, Vector2 minScale, Vector2 maxScale)
    {
        _speed = speed;
        _minScale = minScale;
        _maxScale = maxScale;
    }

    public override void Update(GameTime gameTime)
    {
        //delta time in total game time
        float deltaTime = (float)gameTime.TotalGameTime.TotalSeconds;

        // Genereert een waarde tussen 0 en 1 op basis van een sinusgolf.
        float factor = 0.5f + 0.5f * (float)Math.Sin(deltaTime * MathHelper.TwoPi * _speed);

        //calculates the x and y scale by minscale + the facot times the max scale - minscale
        float scaleX = _minScale.X + factor * (_maxScale.X - _minScale.X);
        float scaleY = _minScale.Y + factor * (_maxScale.Y - _minScale.Y);

        //Console.WriteLine(_gameObject.Transform.Scale);

        //sets the scale
        _gameObject.Transform.Scale = new Vector2(scaleX, scaleY);

        base.Update(gameTime);
    }
}