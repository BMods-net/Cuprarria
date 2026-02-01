using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cuprarria.Content.Items
{
    public class Roundabout : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            Item.noMelee = true;
            Item.DamageType = DamageClass.Magic;
            Item.damage = 30;
            Item.knockBack = 0;

            Item.mana = 0;

            Item.shoot = ModContent.ProjectileType<Projectiles.ProjectileChaser>();
            Item.shootSpeed = 12f;

            Item.rare = ItemRarityID.Cyan;
            Item.value = Item.buyPrice(silver: 0);

            Item.UseSound = SoundID.Item20;
        }
    }
}