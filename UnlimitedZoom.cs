using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics;
using Terraria.ModLoader;

namespace UnlimitedZoom
{
	public class UnlimitedZoom : Mod
	{
		public UnlimitedZoom()
		{
        }
        public override void ModifyTransformMatrix(ref SpriteViewMatrix Transform)
        {
            if (Main.gameMenu)
            {
                return;
            }
            if (UnlimitedZoomConfig.Instance.SuperZoom >= 1)
            {
                Transform.Zoom = new Vector2(((float)UnlimitedZoomConfig.Instance.SuperZoom) / 100f);
            }
        }
    }
}