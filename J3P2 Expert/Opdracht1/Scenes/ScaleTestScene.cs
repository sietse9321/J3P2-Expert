using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using CSharp_Expert.opdracht1;

namespace CSharp_Expert.Opdracht1.Scenes
{
    public class ScaleTestScene : SceneBase
    {
        private Texture2D _objectTexture;
        private SpriteFont _font;

        public ScaleTestScene(Texture2D objectTexture, SpriteFont font)
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
                new Vector2(250, 50),
                new Vector2(300, 200),
                new Vector2(400, 400),
                new Vector2(600, 200)
            ];
            float[] scales =
                [
                    1f,
                    0.5f,
                    0.1f,
                    3f,
                    1.5f
                ];


            for (int i = 0; i < 5; i++)
            {
                var gameObject = new GameObject(_objectTexture);
                gameObject.Transform.Position = positions[i];
                gameObject.Transform.Scale = scales[i];
                gameObject.AddTextRenderer(_font, $"Object {i + 1} Scale: {gameObject.Transform.Scale}", Color.Red);
                GameObjects.Add(gameObject);
            }
        }


    }
}
