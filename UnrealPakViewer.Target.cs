// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealPakViewerTarget : TargetRules
{
    public UnrealPakViewerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Program;
        LinkType = TargetLinkType.Monolithic;
        LaunchModuleName = "UnrealPakViewer";
        //SolutionDirectory = "ExternalPrograms";
		DefaultBuildSettings = BuildSettingsVersion.V4;

		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		//ExtraModuleNames.Add("EditorStyle");

		// Lean and mean
		bBuildDeveloperTools = true;

        // Currently this app is not linking against the engine, so we'll compile out references from Core to the rest of the engine
        bCompileAgainstEngine = false;
        bCompileAgainstCoreUObject = true;

        bUseLoggingInShipping = true;
        bCompileWithPluginSupport = false;

        bHasExports = false;

		GlobalDefinitions.Add("NOINITCRASHREPORTER=1");
		GlobalDefinitions.Add("WITH_CASE_PRESERVING_NAME=0");
		GlobalDefinitions.Add(string.Format("UNREAL_PAK_VIEWER_VERSION=TEXT(\"{0}\")", "1.4"));
	}
}

//bUseXGEController					= false;
//bCompileFreeType					= false;
//bLoggingToMemoryEnabled				= false;
//bCompileWithAccessibilitySupport	= false;
//bIncludePluginsForTargetPlatforms	= true;
//bWithServerCode						= false;
//bCompileNavmeshClusterLinks			= false;
//bCompileNavmeshSegmentLinks			= false;
//bCompileRecast						= false;
//bCompileICU 						= false;
//bWithLiveCoding						= false;
//bBuildWithEditorOnlyData			= true;
//bCompileAgainstApplicationCore		= true;
//bUsesSlate							= false;
//bIsBuildingConsoleApplication		= true;
//
//WindowsPlatform.bUseBundledDbgHelp = false;
//WindowsPlatform.bPixProfilingEnabled = false;
//WindowsPlatform.bMergeIdenticalCOMDATs = true;
//WindowsPlatform.bStripUnreferencedSymbols = true;
//
//GlobalDefinitions.Add("UE_TRACE_ENABLED=1");
//GlobalDefinitions.Add("UE_EXTERNAL_PROFILING_ENABLED=0");
