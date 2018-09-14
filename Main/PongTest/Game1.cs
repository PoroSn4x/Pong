using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PongTest
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D ballTexture;
        Texture2D player1Texture;
        Texture2D player2Texture;
        Color[] data;
        Vector2 coor = new Vector2(0, 0);
        Vector2 vel = new Vector2(1, 1);
        Vector2 acc = new Vector2(0.01F, 0.01F);
        readonly int width = 1700;
        readonly int height = 850;

        Ball ball;
        Player player1;
        Player player2;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = height;
            graphics.PreferredBackBufferWidth = width;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
  
            ball = new Ball();
            player1 = new Player();
            player2 = new Player();


            base.Initialize();
        }

        public Texture2D CreateTexture2D(int width,int height,Color color)
        {
            Texture2D texture = new Texture2D(graphics.GraphicsDevice, width, height);
            data = new Color[width * height];
            for (int i = 0; i < data.Length; ++i) data[i] = color;
            texture.SetData(data);
            return texture;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ballTexture = this.Content.Load<Texture2D>("ball");
            player1Texture = this.Content.Load<Texture2D>("Player1");
            player2Texture = this.Content.Load<Texture2D>("Player2");
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player1.Move(this.CheckKeyboardState());

            ball.MoveAndAccelerate();
            ball.CheckIfCollidedAndBounce(width,height);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(ballTexture, ball.coor);
            spriteBatch.Draw(player1Texture, player1.coor);
            spriteBatch.Draw(player2Texture, player2.coor);
            spriteBatch.End();

            base.Draw(gameTime);
        }
        
        public string CheckKeyboardState()
        {
            string ButtonPressed = "";
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.S))
            {
                ButtonPressed = "S";
            }
            if (state.IsKeyDown(Keys.W))
            {
                ButtonPressed = "W";
            }
            if (state.IsKeyDown(Keys.D))
            {
                ButtonPressed = "D";
            }
            if (state.IsKeyDown(Keys.A))
            {
                ButtonPressed = "A";
            }
            return ButtonPressed;
        }

        public string CheckKeyboardStatetest()
        {
            string ButtonPressed = "";
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.S))
            {
                ButtonPressed = "S";
            }
            if (state.IsKeyDown(Keys.W))
            {
                ButtonPressed = "W";
            }
            if (state.IsKeyDown(Keys.D))
            {
                ButtonPressed = "D";
            }
            if (state.IsKeyDown(Keys.A))
            {
                ButtonPressed = "A";
            }
            return ButtonPressed;
        }
    }
}
