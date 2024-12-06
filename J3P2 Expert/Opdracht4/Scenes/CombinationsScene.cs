using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CSharp_Expert.Opdracht4.BaseClass;

namespace CSharp_Expert.Opdracht4.Scenes
{
    public class CombinationsScene : StarPrefabScene
    {


        //Fields used in the CreateObjects function for ease of use: CreateStar(pos, A|B|C|D) vs CreateStar(pos, PrefabComponent.A|PrefabComponent.B|PrefabComponent.C|PrefabComponent.D)
        private const PrefabComponent A = PrefabComponent.Rotater;
        private const PrefabComponent B = PrefabComponent.Bouncer;
        private const PrefabComponent C = PrefabComponent.Scaler;
        private const PrefabComponent D = PrefabComponent.ColorShifter;
        Viewport _viewport;

       
        //consturctor
        public CombinationsScene(GraphicsDeviceManager graphicsDevice, Texture2D objectTexture, SpriteFont font) : base(graphicsDevice, objectTexture, font)
        {
            _viewport = graphicsDevice.GraphicsDevice.Viewport;
        }

        public override void Initialize()
        {
            CreateObjects(_viewport);
            base.Initialize();
        }

        //Methods
        private void CreateObjects(Viewport pViewport)
        {
            //First row
            //Creates one star, containing no prefabComponents
            float rowHeight = pViewport.Height * 0.10f;
            CreateStar(new Vector2(pViewport.Width * 0.50f, rowHeight), 0); // Default

            //Second row
            rowHeight = pViewport.Height * 0.25f;
            //TODO Create 4 stars, each containing a single prefabComponent
            CreateStar(new Vector2(pViewport.Width * 0.100f, rowHeight), A);
            CreateStar(new Vector2(pViewport.Width * 0.360f, rowHeight), B);
            CreateStar(new Vector2(pViewport.Width * 0.630f, rowHeight), C);
            CreateStar(new Vector2(pViewport.Width * 0.900f, rowHeight), D);

            //Third row
            //TODO Create 3 stars, each containing two prefabComponents
            rowHeight = pViewport.Height * 0.45f;
            CreateStar(new Vector2(pViewport.Width * 0.250f, rowHeight), A | B);
            CreateStar(new Vector2(pViewport.Width * 0.500f, rowHeight), B | C);
            CreateStar(new Vector2(pViewport.Width * 0.750f, rowHeight), C | D);

            //Fourth row
            //TODO Create 2 stars, each containing three prefabComponents
            rowHeight = pViewport.Height * 0.65f;
            CreateStar(new Vector2(pViewport.Width * 0.375f, rowHeight), A | B | C);
            CreateStar(new Vector2(pViewport.Width * 0.625f, rowHeight), B | C | D);

            //Fifth row
            //TODO Create one star, containing all prefabComponents
            rowHeight = pViewport.Height * 0.85f;
            CreateStar(new Vector2(pViewport.Width * 0.500f, rowHeight), A | B | C | D);
        }
    }
}