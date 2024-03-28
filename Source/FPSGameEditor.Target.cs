// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FPSGameEditorTarget : TargetRules
{
	public FPSGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FPSGame");
        // Update build settings
        DefaultBuildSettings = BuildSettingsVersion.Latest;

        // Update include order version
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
    }
}
