using ItemChanger;
using ItemChanger.UIDefs;
using Modding;
using System.Collections.Generic;
using System.Linq;

namespace GrubNames
{
    public class GrubNames : Mod
    {
        new public string GetName() => "GrubNames";
        public override string GetVersion() => "1.0.0.0";

        readonly List<Grub> grubs = new()
        {
            new("Blimpy", "Grub-Fungal_Bouncy"),
            new("Thornando", "Grub-Fungal_Spore_Shroom"),
            new("Mimi", "Grub-Deepnest_Mimic"),
            new("Elon Mosk", "Grub-Deepnest_Nosk"),
            new("Ben", "Grub-Deepnest_Spike"),
            new("Jasper", "Grub-Crossroads_Stag"),
            new("Pogo", "Grub-Crossroads_Spike"),
            new("Saul", "Grub-Soul_Sanctum"),
            new("Betty", "Grub-City_of_Tears_Left"),
            new("Zelda", "Grub-Watcher's_Spire"),
            new("Danger", "Grub-City_of_Tears_Guarded"),
            new("Stefan", "Grub-Crossroads_Guarded"),
            new("Crystal", "Grub-Crystal_Peak_Spike"),
            new("Crissy", "Grub-Hallownest_Crown"),
            new("Christopher", "Grub-Crystal_Heart"),
            new("Chris", "Grub-Crystal_Peak_Crushers"),
            new("Crimble", "Grub-Crystal_Peak_Below_Chest"),
            new("Crispy Q", "Grub-Crystallized_Mound"),
            new("Cataquack", "Grub-Resting_Grounds"),
            new("Grubetheus", "Grub-Basin_Requires_Dive"),
            new("Wingothy", "Grub-Basin_Requires_Wings"),
            new("Hwurmples", "Grub-Waterways_Requires_Tram"),
            new("Ismoil", "Grub-Isma's_Grove"),
            new("Walter Ways", "Grub-Waterways_Main"),
            new("Honey", "Grub-Hive_Internal"),
            new("Bimble", "Grub-Hive_External"),
            new("Hoppita", "Grub-Kingdom's_Edge_Oro"),
            new("Perogi", "Grub-Kingdom's_Edge_Camp"),
            new("Ricky", "Grub-King's_Station"),
            new("AAAA", "Grub-Crossroads_Center"),
            new("Andy", "Grub-Crossroads_Acid"),
            new("Jellifer", "Grub-Fog_Canyon"),
            new("Mossy", "Grub-Greenpath_Journal"),
            new("Grassy", "Grub-Greenpath_Cornifer"),
            new("Pete", "Grub-Greenpath_MMC"),
            new("Frodo", "Grub-Queen's_Gardens_Stag"),
            new("Bilbo", "Grub-Queen's_Gardens_Marmu"),
            new("Smeagol", "Grub-Queen's_Gardens_Top"),
            new("Sauron", "Grub-Dark_Deepnest"),
            new("Leggy", "Grub-Beast's_Den"),
            new("Grubly", "Grub-Collector_1"),
            new("Grubles", "Grub-Collector_2"),
            new("Grubathy", "Grub-Collector_3"),
            new("Leaf", "Grub-Greenpath_Stag"),
            new("Stella", "Grub-Howling_Cliffs"),
            new("Christian", "Grub-Crystal_Peak_Mimic")
        };

        public override void Initialize()
        {
            AbstractItem.ModifyItemGlobal += args =>
            {
                if (args.Placement.Name.StartsWith("Grub") && args.Placement.Name != "Grubfather")
                {
                    Grub grub = grubs.First((grub) => grub.LocationName == args.Placement.Name);
                    string grubName = grub.Name + " (#" + (PlayerData.instance.grubsCollected + 1) + ")";

                    ((MsgUIDef)args.Item.UIDef).name = new BoxedString(grubName);
                }
            };
        }
    }
}
