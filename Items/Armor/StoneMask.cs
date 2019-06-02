using System;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;


namespace JoJoStands.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class StoneMask : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("An odd archaeological find. When worn, you gain superhuman abilities, but you burn in the sunlight.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 8;
			item.defense = 12;
		}

        public override void UpdateEquip(Player player)
        {
            player.AddBuff(mod.BuffType("Vampire"), 999999999);
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.SoulofFright, 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
