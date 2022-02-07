using UnrealBuildTool;

public class ssssonicTarget : TargetRules
{
	public ssssonicTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ssssonic");
	}
}
