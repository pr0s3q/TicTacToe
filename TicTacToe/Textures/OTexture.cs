using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace TicTacToe.Textures;

internal sealed class OTexture : TextureBase
{
    #region Constructor

    public OTexture(ContentManager content, Vector2 position)
        : base(content, "O", position, 0f, 1f)
    {
    }

    #endregion
}