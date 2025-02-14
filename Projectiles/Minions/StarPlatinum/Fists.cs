using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace JoJoStands.Projectiles.Minions.StarPlatinum
{
    public class Fists : ModProjectile
    {  
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;         
            projectile.damage = 84;
            projectile.melee = true;
            projectile.timeLeft = 8;
            projectile.alpha = 255;     //completely transparent
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/sound/ora_short2"));
            base.OnHitNPC(target, damage, knockback, crit);
        }
    }
}