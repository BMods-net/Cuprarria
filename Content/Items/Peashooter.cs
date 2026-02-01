using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cuprarria.Content.Items
{
    public class Peashooter : ModItem
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
            Item.damage = 20;
            Item.knockBack = 0;

            Item.mana = 0;

            Item.shoot = ModContent.ProjectileType<Projectiles.ProjectilePeashooter>();
            Item.shootSpeed = 14f;

            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(silver: 0);

            Item.UseSound = SoundID.Item20;
        }
    }
}
