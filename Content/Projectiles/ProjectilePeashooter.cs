using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cuprarria.Content.Projectiles
{
    public class ProjectilePeashooter : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 20;
            Projectile.height = 20;

            Projectile.friendly = true;  
            Projectile.hostile = false;

            Projectile.DamageType = DamageClass.Magic;
            Projectile.knockBack = 0f;

            Projectile.timeLeft = 450;
            Projectile.penetrate = 5;

            Projectile.aiStyle = 0;      
            AIType = ProjectileID.Bullet;
        }
    }
}
