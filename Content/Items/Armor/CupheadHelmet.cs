using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cuprarria.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MagicHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(silver: 0);
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }
    }
}
