using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CSharpExpert.Assignment3.StudentStartPoints
{
    public class CombinationsScene : StarPrefabScene
    {
        //Fields used in the CreateObjects function for ease of use: CreateStar(pos, A|B|C|D) vs CreateStar(pos, PrefabComponent.A|PrefabComponent.B|PrefabComponent.C|PrefabComponent.D)
        private const PrefabComponent A = PrefabComponent.Rotater;
        private const PrefabComponent B = PrefabComponent.Bouncer;
        private const PrefabComponent C = PrefabComponent.Scaler;
        private const PrefabComponent D = PrefabComponent.ColorShifter;

        //Constructors
        public CombinationsScene(Game1 pGame) : base(pGame) { }

        //Methods
        protected override void CreateObjects(ContentManager pContent, Viewport pViewport)
        {
            //First row
            //Creates one star, containing no prefabComponents
            float rowHeight = pViewport.Height * 0.10f;
            CreateStar(new Vector2(pViewport.Width * 0.50f, rowHeight), 0); // Default

            //Second row
            rowHeight = pViewport.Height * 0.25f;
            //TODO Create 4 stars, each containing a single prefabComponent
            CreateStar(new Vector2(pViewport.Width * 0.100f, rowHeight), A);
            //CreateStar(new Vector2(pViewport.Width * 0.360f, rowHeight), ...);
            //CreateStar(new Vector2(pViewport.Width * 0.630f, rowHeight), ...);
            //CreateStar(new Vector2(pViewport.Width * 0.900f, rowHeight), ...);

            //Third row
            //TODO Create 3 stars, each containing two prefabComponents
            rowHeight = pViewport.Height * 0.45f;
            //CreateStar(new Vector2(pViewport.Width * 0.250f, rowHeight), ...);
            //CreateStar(new Vector2(pViewport.Width * 0.500f, rowHeight), ...);
            //CreateStar(new Vector2(pViewport.Width * 0.750f, rowHeight), ...);

            //Fourth row
            //TODO Create 2 stars, each containing three prefabComponents
            rowHeight = pViewport.Height * 0.65f;
            //CreateStar(new Vector2(pViewport.Width * 0.375f, rowHeight), ...);
            //CreateStar(new Vector2(pViewport.Width * 0.625f, rowHeight), ...);

            //Fifth row
            //TODO Create one star, containing all prefabComponents
            rowHeight = pViewport.Height * 0.85f;
            CreateStar(new Vector2(pViewport.Width * 0.500f, rowHeight), A | B | C | D);
        }
    }
}