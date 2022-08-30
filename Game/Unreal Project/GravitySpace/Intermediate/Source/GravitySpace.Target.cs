using UnrealBuildTool;

public class GravitySpaceTarget : TargetRules
{
	public GravitySpaceTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GravitySpace");
	}
}
