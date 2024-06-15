using System;
using System.Linq;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Game.Configuration;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.Osu.UI;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.Osu.Objects;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.Osu.Scoring;

namespace osu.Game.Rulesets.Osu.Mods;

public class OsuModClassic : ModClassic
{
    public BindableBool NoSliderHeadAccuracy { get; } = new BindableBool(true);
    public BindableBool ClassicNoteLock { get; } = new BindableBool(true);
    public BindableBool AlwaysPlayTailSample { get; } = new BindableBool(true);
    public BindableBool FadeHitCircleEarly { get; } = new BindableBool(true);
    public BindableBool ClassicHealth { get; } = new BindableBool(true);

    public void ApplyToHitObject(HitObject hitObject)
    {
        switch (hitObject)
        {
            case Slider slider:
                slider.ClassicSliderBehaviour = NoSliderHeadAccuracy.Value;
                break;
        }
    }

    public HealthProcessor? CreateHealthProcessor(double drainStartTime) => ClassicHealth.Value ? new OsuLegacyHealthProcessor(drainStartTime) : null;
}