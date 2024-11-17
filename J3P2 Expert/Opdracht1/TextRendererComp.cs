using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht1
{
    public class TextRendererComp
    {
        private SpriteFont _font;
        private string _text;
        private Color _color;

        public TextRendererComp(SpriteFont font, string text, Color color)
        {
            _font = font;
            _text = text;
            _color = color;
        }

        public void Draw(SpriteBatch spriteBatch, TransformComp transform)
        {
            spriteBatch.DrawString(_font, _text, transform.Position, _color);
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public void SetColor(Color color)
        {
            _color = color;
        }
    }
}
