// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        Color GreenGrass = new Color("ace1af");
        Color BunnyBody = new Color("d8bab4");
        Color PinkBody = new Color("d98584");
        Color SunYellow = new Color("eeb422");
        Color Rainblue = new Color("839db3");
        Color GreyCloud = new Color("e7e7e7");
        Color SkyBlue = new Color("cfe2f3");
        Color NoseBrown = new Color("574332");
        Color Black = new Color("000000");



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

            Window.SetTitle("Spring Day");
            Window.SetSize(400, 400);
            Draw.LineSize = 0;

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()

        {

            // Draw sky
            Window.ClearBackground(SkyBlue);

            // Draw sun
            Draw.FillColor = SunYellow;
            Draw.Circle(380, 30, 60);

            // Draw a circle at mouse position
            Draw.FillColor = Color.LightGray; ;
            Draw.LineColor = Color.LightGray; ;
            Draw.Ellipse(Input.GetMouseX(), Input.GetMouseY(), 100, 90);

            // Draw an ellipse at mouse position
            Draw.FillColor = Color.LightGray;
            Draw.LineColor = Color.LightGray;
            Draw.Ellipse(Input.GetMouseX(), Input.GetMouseY(), 170, 65);

            // Draw bunny

            //Bunny body
            Draw.FillColor = BunnyBody;
            Draw.Ellipse(200, 200, 90, 120);


            // Draw Bunny ear
            Draw.FillColor = BunnyBody;
            Draw.Ellipse(180, 75, 20, 80);

            // Draw Bunny other ear
            Draw.FillColor = BunnyBody;
            Draw.Ellipse(220, 75, 20, 80);

            // Draw Bunny body fur
            Draw.FillColor = GreyCloud;
            Draw.Ellipse(200, 200, 50, 70);

            // Draw Bunny ears inside fur
            Draw.FillColor = GreyCloud;
            Draw.Ellipse(220, 75, 10, 50);

            // Draw Bunny ears inside fur
            Draw.FillColor = GreyCloud;
            Draw.Ellipse(180, 75, 10, 50);

            // Draw Bunny head
            Draw.FillColor = BunnyBody;
            Draw.Circle(200, 120, 38);

            // Draw nose
            Draw.FillColor = NoseBrown;
            Draw.Circle(200, 130, 3);

            // Draw Eyes
            Draw.FillColor = Black;
            Draw.Circle(190, 120, 4);

            // Draw Eyes
            Draw.FillColor = Black;
            Draw.Circle(210, 120, 4);

            // Draw arms

            Draw.FillColor = BunnyBody;
            Draw.Circle(155, 170, 15);

            Draw.FillColor = BunnyBody;
            Draw.Circle(245, 170, 15);

            // Draw arm inner bits

            Draw.FillColor = GreyCloud;
            Draw.Circle(155, 170, 8);

            Draw.FillColor = GreyCloud;
            Draw.Circle(245, 170, 8);


            // Draw ground

            Draw.FillColor = GreenGrass;
            Draw.Rectangle(0, 265, 600, 400);

            // Draw feet

            Draw.FillColor = BunnyBody;
            Draw.Ellipse(225, 260, 40, 20);

            Draw.FillColor = BunnyBody;
            Draw.Ellipse(175, 260, 40, 20);

            // draw sun
            Draw.FillColor = SunYellow;
            Draw.Circle(380, 30, 60);

        }
    }

}
