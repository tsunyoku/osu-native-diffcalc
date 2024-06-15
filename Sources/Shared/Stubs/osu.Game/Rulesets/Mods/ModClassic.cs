using osu.Framework.Graphics.Sprites;
using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mods;

public abstract class ModClassic : Mod
{
    public override string Name => "Classic";

    public override string Acronym => "CL";

    public override double ScoreMultiplier => 0.96;

    public override IconUsage? Icon => FontAwesome.Solid.History;

    public override LocalisableString Description => "Feeling nostalgic?";

    public override ModType Type => ModType.Conversion;

    public sealed override bool Ranked => false;
}
