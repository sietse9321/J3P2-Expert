using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using CSharp_Expert.opdracht1;

namespace CSharp_Expert.Opdracht1.Scenes
{
    public class PositionTestScene : SceneBase
    {

        private Texture2D _objectTexture;
        private SpriteFont _font;

        public PositionTestScene(Texture2D objectTexture, SpriteFont font)
        {
            _objectTexture = objectTexture;
            _font = font;
        }

        public override void Initialize()
        {
            base.Initialize();

            Vector2[] positions =
            [
                new Vector2(100, 100),
                new Vector2(200, 150),
                new Vector2(300, 200),
                new Vector2(400, 250),
                new Vector2(500, 300)
            ];


            for (int i = 0; i < 5; i++)
            {
                var gameObject = new GameObject(_objectTexture);
                gameObject.Transform.Position = positions[i];
                gameObject.AddTextRenderer(_font, $"Object {i + 1} position: {gameObject.Transform.Position}", Color.Red);
                GameObjects.Add(gameObject);
            }

        }
    }
}