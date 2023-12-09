namespace FrambosEngine;
using static Frambos;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Engine : Game {
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Engine() {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize() {
        base.Initialize();
    }

    protected override void LoadContent() {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime) {
        // TODO: Add your update logic here
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        // TODO: Add your drawing code here
        base.Draw(gameTime);
    }
}
