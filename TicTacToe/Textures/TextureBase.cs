using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TicTacToe.Textures;

internal abstract class TextureBase : IDisposable
{
    #region Enum

    internal enum TextureDirection
    {
        Down = 0,
        Up = 1,
        Left = 2,
        Right = 3
    }

    #endregion

    #region Data Members

    private readonly Color color;
    protected Texture2D texture;
    private readonly Vector2 position;
    private float rotation;
    private readonly float scale;

    #endregion

    #region Constructor

    internal TextureBase(ContentManager content, string assetName, Vector2 position, float rotation, float scale)
    {
        this.position = position;
        this.rotation = rotation;
        this.scale = scale;
        texture = content.Load<Texture2D>(assetName);

        color = Color.White;
    }

    #endregion

    #region Methods

    /// <inheritdoc />
    public virtual void Dispose()
    {
        texture.Dispose();
    }

    internal void Draw(SpriteBatch batch)
    {
        batch.Draw(texture, position, null, color, Rotation, Vector2.Zero,
            scale, SpriteEffects.None, 1.0f);
    }

    internal void ModifyRotation(float offset)
    {
        rotation += offset;

        if (rotation >= 360f) // 360 degree is equal to 0
            rotation -= 360f;

        if (rotation <= -360f) // -360 degree is equal to 0
            rotation += 360f;
    }

    internal virtual void ModifySprite(TextureDirection direction)
    {
    }

    internal virtual void SetDefaultSprite()
    {
    }

    #endregion

    #region Properties

    private float Rotation => rotation * float.Pi / 180f;

    #endregion
}