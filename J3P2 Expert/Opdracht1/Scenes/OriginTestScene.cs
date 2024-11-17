using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using CSharp_Expert.opdracht1;

namespace CSharp_Expert.Opdracht1.Scenes
{
    public class OriginTestScene : SceneBase
    {
        private Texture2D _objectTexture;
        private SpriteFont _font;

        public OriginTestScene(Texture2D objectTexture, SpriteFont font)
        {
            _objectTexture = objectTexture;
            _font = font;
        }

        public override void Initialize()
        {
            base.Initialize();

            Vector2[] positions =
            [
                new Vector2(100, 200),
                new Vector2(250, 150),
                new Vector2(400, 300),
            ];
            Vector2[] origins =
                [
                    new Vector2(0f, 0f),
                    new Vector2(1f, 1f),
                    new Vector2(0.5f, 0.5f)
                ];


            for (int i = 0; i < 3; i++)
            {
                var gameObject = new GameObject(_objectTexture);
                gameObject.Transform.Position = positions[i];
                gameObject.Transform.Origin = origins[i];
                gameObject.AddTextRenderer(_font, $"Object {i + 1} Origin: {gameObject.Transform.Origin}", Color.Red);
                GameObjects.Add(gameObject);
            }
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            foreach (var gameObject in GameObjects)
            {
                gameObject.Transform.Rotation += 2f;
            }
        }
    }
}
