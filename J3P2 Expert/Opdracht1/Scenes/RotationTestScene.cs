using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using CSharp_Expert.opdracht1;

namespace CSharp_Expert.Opdracht1.Scenes
{
    public class RotationTestScene : SceneBase
    {

        private Texture2D _objectTexture;
        private SpriteFont _font;
        private GameObject _rotateObject;

        public RotationTestScene(Texture2D objectTexture, SpriteFont font)
        {
            _objectTexture = objectTexture;
            _font = font;
        }

        public override void Initialize()
        {
            base.Initialize();

            Vector2[] positions =
            [
                new Vector2(400, 100),
                new Vector2(300, 250),
                new Vector2(500, 250),
                new Vector2(400, 350),
                new Vector2(400, 500),
                new Vector2(700, 500),
                new Vector2(100, 500),

            ];
            float[] rotations =
            [
                0f,
                90f,
                -90f,
                180f,
                270f,
                360f,
                450f,

            ];


            for (int i = 0; i < 7; i++)
            {
                var gameObject = new GameObject(_objectTexture);
                gameObject.Transform.Position = positions[i];
                gameObject.Transform.Rotation = rotations[i];
                gameObject.AddTextRenderer(_font, $"Object {i + 1} Rotation: {gameObject.Transform.Rotation}", Color.Red);
                GameObjects.Add(gameObject);
            }
            _rotateObject = GameObjects[0];
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            _rotateObject.TextRenderer.SetText($"Object 1 Rotation: {_rotateObject.Transform.Rotation}");
            _rotateObject.Transform.Rotation += 2f;
        }
    }
}