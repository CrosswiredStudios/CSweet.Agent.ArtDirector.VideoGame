using CSweet.VideoGame.AgentKit;

namespace CSweet.Agent.ArtDirector.VideoGame;

public sealed class SpecialistAgent : VideoGameSpecialistAgentBase
{
    public override string AgentId => "com.csweet.video-game-art-director";
    public override string Version => "1.0.0";
    public override string PrimaryCapability => "video-game.art-director.execute.v1";
    protected override string RoleKey => "game-art-director";
    protected override string ArtifactTypeKey => "video-game.art-bible.v1";
    protected override string RolePrompt => "Own the visual language, art bible, target references, asset briefs, consistency review, and final visual findings. Judge actual image and build evidence against explicit pillars.";
    protected override IReadOnlyList<string> RequiredSections => ["Visual Pillars", "Shape Language", "Color and Lighting", "Asset Standards", "Reference Targets", "Review Criteria"];
}

