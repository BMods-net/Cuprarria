using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cuprarria.Content.Items
{
    public class Chaser : ModItem
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
            Item.damage = 10;
            Item.knockBack = 0;

            Item.mana = 0;

            Item.shoot = ModContent.ProjectileType<Projectiles.ProjectileChaser>();
            Item.shootSpeed = 14f;

            Item.rare = ItemRarityID.Green;
            Item.value = Item.buyPrice(silver: 0);

            Item.UseSound = SoundID.Item20;
        }
    }
}