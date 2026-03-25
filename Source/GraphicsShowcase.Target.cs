// Copyright (c) Meta Platforms, Inc. and affiliates.All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GraphicsShowcaseTarget : TargetRules
{
	public GraphicsShowcaseTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;

		ExtraModuleNames.AddRange( new string[] { "GraphicsShowcase" } );
	}
}
