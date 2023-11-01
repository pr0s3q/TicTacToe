using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace TicTacToe.Textures;

internal sealed class XTexture : TextureBase
{
    #region Constructor

    public XTexture(ContentManager content, Vector2 position)
        : base(content, "X", position, 0f, 1f)
    {
    }

    #endregion
}