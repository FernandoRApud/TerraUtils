using Terraria.ID;
using Terraria.ModLoader;

namespace TerraUtils.Items
{
	public class FakePick : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("La espadita.");
		}

		public override void SetDefaults() 
		{
			item.damage = 950;
			item.melee = true;
			item.pick = 500;
			item.width = 30;
			item.height = 30;
			item.useTime = 3;
			item.useAnimation = 6;
			item.useStyle = 1;
			item.knockBack = 60;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}