using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht4.Interfaces;

public interface IDrawableComponent
{
    //Vector2 Size { get; }
    void Draw(SpriteBatch spriteBatch);
}