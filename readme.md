﻿The Model-First project for MEF.DEV serverless platform is autogenerated and ready-to-build a Model-First solution within MEF.DEV serverless platform, that aims to host MEF-applications as a plugin. This MEF.DEV Model-First project based on an XML schema file that controls input sets of Entities & Actions data from external sources, like Database or Visual Modeling Tools. The MEF.DEV project is aimed to use with Visual Studio or Visual Code, but it can run without Visual Studio or Visual Code by using MSBuild. By invoking msbuild.exe, you can orchestrate and build products in environments where Visual Studio isn't installed.

Important to understand, that MEF.DEV projects are using the UCP.Common.Plugin NuGet package from https://nuget.mef.dev. The UCP.Common.Plugin is the MEF.DEV core provider into your solution, that you should follow general development principles on-base Entities & Actions approach.

From a technical perspective, the UCP.Common.Plugin library contains a description of the iBackendPlugin and iPluginСonfig interfaces, as well as the base class BaseEntity, which are part of the contract the Managed Extensibility Framework infrastructure, namely [Export ("plugin_name", typeof (IBackendPlugin))] and required for each self-development Plugin for integration into the mef.dev serverless platform.

For more information on MEF.DEV, see the Developer's Guide on mef.dev

Build Status
The current development branch of UCP.Common.Plugin is master. Changes in master will go into a future update of MEF.DEV Model-First project template, the current release UCP.Common.Plugin is 1.2.0.

Building
Building MEF.DEV Model-First with Visual Studio 2019 on Windows
For the full supported experience, you will need to have Visual Studio 2019 or higher.

To get started on Visual Studio 2019:

Install Visual Studio 2019. Select the following Workloads:
ASP.NET and web development
.NET Core cross-platform development
Open plugin_name.sln in Visual Studio 2019.
(optional) Make changes in Entities & Actions schemas into .\models.xml file in the root of the repo
Run .\build_for_deploy.cmd from the root of the repo to build the code. This also will generate new Entities & Actions classes from .\models.xml needed to build new version of Plugin.
Open \bin\Deploy folder and use file plugin_name.zip that consists of all files from build.
Building MSBuild in Unix (Mac & Linux)
MSBuild can be run on Unix systems that support .NET Core. Set-up instructions can be viewed on the wiki: Building Testing and Debugging on .Net Core MSBuild

Onboarding Plugin to MEF.DEV platform
To complete this operation, you will need to log on to mef.dev platform. The logon process is the registration required, to register please follow the link invite to preview

Login to preview version of mef.dev platform on preview.mef.dev

Create new package plugin_name into mef.dev platform - the minimal set of information is:

PLUGIN MEFNAME - the unique (within the ALIAS) Plugin name, must be equal to the namespace from the build solution above (in this case value = plugin_name)
ALIAS - a unique logical name that unites all entities and actions of one subject area (business domain), if unknown - please input value in ddmmyyhhmm format
SERVICE NAME - the unique friendly Plugin name for UI, if unknown - please input specific to your build plugin_name
Upload created at building step 5 plugin_name.zip to plugin package, created on step 2. This also register new version of plugin and start the generation process of technical specification for future review.

After click SAVE button, mef.dev platform will run this version of plugin and you can use it after the rights assessment procedure.

Getting Started to contribute
Before you contribute, please read through the developer guides

Developer Guide on:
First Backend plugin
First UI plugin
Video lessons
Looking for something to work on? This group of MEF.DEV project is a great place to start a discussion. You are also encouraged to start a discussion by filing an issue or creating a gist.

MSBuild Components
PluginProjectGenerator. The tool that is uses to auto-generate source code into MEF.DEV projects, provided by MEF.DEV authors.

UCP.Common.Plugin. The UCP.Common.Plugin nuget contains a description of the iBackendPlugin and iPluginСonfig interfaces, as well as the base class BaseEntity, which are part of the contract the Managed Extensibility Framework infrastructure, namely [Export ("plugin_name", typeof (IBackendPlugin))] and required for each self-development Plugin for integration into the mef.dev serverless platform..

License
MEF.DEV Model-First project is licensed under the GNU AGPL 3.0.