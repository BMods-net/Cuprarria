using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Microsoft.Xna.Framework;

namespace Cuprarria.Content.NPCs
{
    [AutoloadHead]
    public class Kettle : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 16;
        }

        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 18;
            NPC.height = 40;
            NPC.aiStyle = 7;
            NPC.damage = 10;
            NPC.defense = 15;
            NPC.lifeMax = 250;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
        }

      
        public override bool CanTownNPCSpawn(int numTownNPCs)
        {
            foreach (var player in Main.player)
            {
                if (!player.active) continue;
                if (player.HasItem(ItemID.DirtBlock)) return true;
            }
            return false;
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Shop";
        }

        public override void OnChatButtonClicked(bool firstButton, ref string shopName)
        {
            if (firstButton)
            {
                shopName = "Shop";
            }
        }

        public override string GetChat()
        {
            WeightedRandom<string> chat = new WeightedRandom<string>();

            chat.Add("Hello");
            chat.Add("Test");

            Player player = Main.LocalPlayer;
        }

        public override List<string> SetNPCNameList()
        {
            return new List<string>() {
                "Kettle"
    };
        }

        // Настройка магазина
        public override void AddShops()
        {
            var npcShop = new NPCShop(Type)
                .Add(ItemID.IronAxe);
            npcShop.Register();
        }
    }
}
