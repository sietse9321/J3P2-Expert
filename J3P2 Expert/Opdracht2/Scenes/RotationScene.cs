using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSharp_Expert.Opdracht2.Scenes
{
    public class RotationScene : SceneBase
    {
        private Texture2D _objectTexture;
        private SpriteFont _font;

        public RotationScene(Texture2D objectTexture, SpriteFont font)
        {
            _objectTexture = objectTexture;
            _font = font;
        }

        public override void Initialize()
        {
            base.Initialize();

            Vector2[] positions =
            [
                new(300, 200),
                new(150, 200),
                new(500, 200),
                new(650, 200),
                new(250, 400),
                new(600, 400)


            ];

            ObjectInitialize(_objectTexture, positions[0], 0.5f, true);
            ObjectInitialize(_objectTexture, positions[1], 1, true);
            ObjectInitialize(_objectTexture, positions[2], 0.5f, false);
            ObjectInitialize(_objectTexture, positions[3], 1, false);
            ObjectInitialize(_objectTexture, positions[4], 1.5f, true);
            ObjectInitialize(_objectTexture, positions[5], 1.5f, false);
        }

        private void ObjectInitialize(Texture2D texture, Vector2 position, float rotationSpeed, bool direction)
        {
            var gameObject = new RotaterObject(_objectTexture, rotationSpeed, direction);
            gameObject.AddTextRenderer(_font, $"Rotation speed: {rotationSpeed},\ndirection: {direction}", Color.Red);
            gameObject.Transform.Position = position;
            GameObjects.Add(gameObject);
        }
    }
}