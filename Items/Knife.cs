using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace JoJoStands.Items
{
	public class Knife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Knife");
			Tooltip.SetDefault("A sharp knife that is best suited to be thrown.");
		}
		public override void SetDefaults()
		{
			item.damage = 35;
			item.width = 9;
			item.height = 29;
            item.ranged = true;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
            item.consumable = true;
            item.noUseGraphic = true;
			item.maxStack = 999;
			item.knockBack = 1f;
			item.value = Item.buyPrice(0, 0, 0, 75);
			item.rare = 1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("Knife");
			item.shootSpeed = 32f;
		}

        public override bool UseItem(Player player)
        {
            player.ConsumeItem(mod.ItemType("Knife"));
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
