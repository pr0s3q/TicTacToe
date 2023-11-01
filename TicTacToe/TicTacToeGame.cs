using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TicTacToe.Textures;

namespace TicTacToe;

internal sealed class TicTacToeGame : Game
{
    #region Variables

    private SpriteBatch batch = null!;
    private readonly List<TextureBase> textures = new();

    #endregion

    #region Constructor

    internal TicTacToeGame()
    {
        _ = new GraphicsDeviceManager(this)
        {
            PreferredBackBufferWidth = 1280,
            PreferredBackBufferHeight = 720,
            IsFullScreen = false,
            SynchronizeWithVerticalRetrace = true
        };

        IsFixedTimeStep = true;

        Content.RootDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName + "\\Images";
    }

    #endregion

    #region Operations

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        batch = new SpriteBatch(GraphicsDevice);

        textures.AddRange(new TextureBase[]
        {
            new XTexture(Content, new Vector2(0, 0)),
            new OTexture(Content, new Vector2(256, 0))
        });
    }

    protected override void UnloadContent()
    {
        batch.Dispose();
        foreach(var texture in textures)
            texture.Dispose();
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.White);

        batch.Begin();

        foreach(var texture in textures)
            texture.Draw(batch);

        batch.End();

        base.Draw(gameTime);
    }

    #endregion
}