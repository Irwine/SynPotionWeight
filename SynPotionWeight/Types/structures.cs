using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace SynPotionWeight.Types
{
    public class Settings
    {
        [SettingName("Multiplicateur de poids")]
        public float WeightMult = 1.0f;
    }
}
