using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht2;

public class ScalerObject : GameObject
{
    private Texture2D _texture;
    private float _speed;
    private Vector2 _minScale;
    private Vector2 _maxScale;

    public ScalerObject(Texture2D texture, float speed, Vector2 minScale, Vector2 maxScale) : base(texture)
    {
        _texture = texture;
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

        Console.WriteLine(Transform.Scale);

        //sets the scale
        Transform.Scale = new Vector2(scaleX,scaleY);

        base.Update(gameTime);
    }
}