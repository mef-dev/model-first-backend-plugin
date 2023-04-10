# Model-First project for MEF.DEV serverless platfrom (MEF.DEV Model-First)

The Model-First project for MEF.DEV serverless platform is autogenerated and ready-to-build a Model-First solution within MEF.DEV serverless platform, that aims to host MEF-applications as a plugin. This MEF.DEV Model-First project based on an [XML schema file](https://github.com/mef-dev/model-first-backend-plugin/blob/master/models.xsd) that controls input sets of Entities & Actions data from external sources, like Database or Visual Modeling Tools. The MEF.DEV project is aimed to use with Visual Studio or Visual Code, but it can run without Visual Studio or Visual Code by using MSBuild. By invoking msbuild.exe, you can orchestrate and build products in environments where Visual Studio isn't installed.

Important to understand, that MEF.DEV projects are using the MEF.DEV.Common.Plugin NuGet package from https://www.nuget.org/packages/MEF.DEV.Common.Plugin. The MEF.DEV.Common.Plugin is the MEF.DEV core provider into your solution, that you should follow general development principles on-base Entities & Actions approach.

From a technical perspective, the MEF.DEV.Common.Plugin library contains a description of the iBackendPlugin and iPluginСonfig interfaces, as well as the base class BaseEntity, which are part of the contract the Managed Extensibility Framework infrastructure, namely [Export ("plugin_name", typeof (IBackendPlugin))] and required for each self-development Plugin for integration into the mef.dev serverless platform.

For more information on MEF.DEV, see the [Developer's Guide](https://mef.dev/en/plugin_basics/introduction.php) on mef.dev

### Build Status

The current development branch of MEF.DEV.Common.Plugin is `master`. Changes in `master` will go into a future update of MEF.DEV Model-First project template, the current release MEF.DEV.Common.Plugin is 1.3.4.

## Building

### Building MEF.DEV Model-First with Visual Studio 2019 on Windows

For the full supported experience, you will need to have Visual Studio 2019 or higher.

To get started on **Visual Studio 2019**:

1. [Install Visual Studio 2019](https://www.visualstudio.com/vs/).  Select the following Workloads:
  - ASP.NET and web development
  - .NET Core cross-platform development
2. Open `plugin_name.sln` in Visual Studio 2019.
3. (optional) Make changes in Entities & Actions schemas into `.\models.xml` file in the root of the repo
4. Run `.\build_for_deploy.cmd` from the root of the repo to build the code. This also will generate new Entities & Actions classes from `.\models.xml` needed to build new version of Plugin.
5. Open `\bin\Deploy` folder and use file `plugin_name.zip` that consists of all files from build.

### Building MSBuild in Unix (Mac & Linux)

MSBuild can be run on Unix systems that support .NET Core. Set-up instructions can be viewed on the wiki: [Building Testing and Debugging on .Net Core MSBuild](https://github.com/dotnet/msbuild/blob/main/documentation/wiki/Building-Testing-and-Debugging-on-.Net-Core-MSBuild.md)

## Onboarding Plugin to MEF.DEV platform

To complete this operation, you will need to log on to mef.dev platform. The logon process is the registration required, to register please follow the link [invite to preview](https://preview.mef.dev/rflnk/9fJaM6YPHEo5Dc1pCMTHO5ynrm2OON6atMe3df%2fSaM5F%2bJeD%2bDywFisySLXJiGv4)
1. Login to preview version of mef.dev platform on preview.mef.dev
2. [Create](https://preview.mef.dev/store/service/create) new package `plugin_name` into mef.dev platform - the minimal set of information is:
   - PLUGIN MEFNAME - the unique (within the ALIAS) Plugin name, must be equal to the namespace from the build solution above (in this case value = `plugin_name`)
   - ALIAS - a unique logical name that unites all entities and actions of one subject area (business domain), if unknown - please input value in `ddmmyyhhmm` format
   - SERVICE NAME - the unique friendly Plugin name for UI, if unknown - please input specific to your build `plugin_name`
	
3. Upload created at building step 5 `plugin_name.zip` to plugin package, created on step 2. This also register new version of plugin and start the generation process of technical specification for future review.
4. Create configuration for plugin to connect it to database - as business logic for models:	
	{
  		"RuntimeState": "Run",
 		"StartTime": "dd.mm.yyyy hh:ss",
  		"RuntimeStateDescription": "503 http code details description for manual operation with plugin",
  		"ConnectionStrings": {
   			"ConnectionString": "Server={servername};Database={database_name};Trusted_Connection=Yes;MultipleActiveResultSets=true"
	  	},
  		"DeadlockRetryCount" : 3
	}
5. After click SAVE button, mef.dev platform will run this version of plugin and you can use it after the rights assessment procedure.

#### Getting Started to contribute

Before you contribute, please read through the developer guides

* **Developer Guide on:**
   - [First Backend plugin](https://mef.dev/dev_guides/first_backend_plugin.md)
   - [First UI plugin](https://mef.dev/dev_guides/first_ui_plugin.md)

Looking for something to work on? This group of [MEF.DEV project](https://mef.dev/member-login.php) is a great place to start a discussion.
You are also encouraged to start a discussion by filing an issue or creating a gist.

### MSBuild Components

* **PluginProjectGenerator**. The tool that is uses to auto-generate source code into MEF.DEV projects, provided by MEF.DEV authors.

* **MEF.DEV.Common.Plugin**. The [MEF.DEV.Common.Plugin](https://www.nuget.org/packages/MEF.DEV.Common.Plugin) nuget contains a description of the iBackendPlugin and iPluginСonfig interfaces, as well as the base class BaseEntity, which are part of the contract the Managed Extensibility Framework infrastructure, namely [Export ("plugin_name", typeof (IBackendPlugin))] and required for each self-development Plugin for integration into the mef.dev serverless platform..

### License

MEF.DEV Model-First project is licensed under the [GNU AGPL 3.0](https://github.com/mef-dev/tutorial-backend-plugin/blob/master/LICENSE).
