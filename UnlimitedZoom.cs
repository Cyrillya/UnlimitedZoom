using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UnlimitedZoom
{
	public class UnlimitedZoom : Mod
	{
		public UnlimitedZoom()
		{
        }
        public override void Load()
        {
            base.Load();
            ModTranslation text = CreateTranslation("Common.GameZoom");
            text.SetDefault("Game screen zoom value (%) (0 means not open this mode)");
            text.AddTranslation(GameCulture.Chinese, "游戏画面缩放值(%)(为0即不开启此模式)");
            AddTranslation(text);
            text = CreateTranslation("Common.UIZoom");
            text.SetDefault("UI screen zoom value (%) (0 means not open this mode)");
            text.AddTranslation(GameCulture.Chinese, "UI画面缩放值(%)(为0即不开启此模式)");
            AddTranslation(text);
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
            if (UnlimitedZoomConfig.Instance.UIZoom >= 1)
            {
                Main.UIScale = ((float)UnlimitedZoomConfig.Instance.UIZoom) / 100f;
            }
        }
        
    }
}