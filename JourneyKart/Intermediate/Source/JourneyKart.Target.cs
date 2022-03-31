using UnrealBuildTool;

public class JourneyKartTarget : TargetRules
{
	public JourneyKartTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("JourneyKart");
	}
}
