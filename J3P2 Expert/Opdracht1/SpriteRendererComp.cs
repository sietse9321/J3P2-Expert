using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht1;

public class SpriteRendererComp
{
    private Texture2D _texture;

    public SpriteRendererComp(Texture2D texture)
    {
        _texture = texture;
    }
    public void Draw(SpriteBatch spriteBatch, TransformComp transform)
    {
        spriteBatch.Draw();
    }
}