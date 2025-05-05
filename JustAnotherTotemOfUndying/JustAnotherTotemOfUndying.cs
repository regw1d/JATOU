using Terraria.ModLoader;
using Terraria.Audio;

namespace JustAnotherTotemOfUndying
{
    public class JustAnotherTotemOfUndying : Mod
    {
        public static SoundStyle TotemSound { get; private set; }

        public override void Load()
        {
            TotemSound = new SoundStyle($"{Name}/Sounds/TotemSound");
        }
    }
}