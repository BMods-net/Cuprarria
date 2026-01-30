using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cuprarria.Content.Projectiles
{
    public class ProjectileForFMA : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;

            Projectile.friendly = true;  
            Projectile.hostile = false;

            Projectile.DamageType = DamageClass.Magic;
            Projectile.knockBack = 5f;

            Projectile.timeLeft = 450;
            Projectile.penetrate = 5;

            Projectile.aiStyle = 1;      
            AIType = ProjectileID.Bullet;
        }
    }
}
