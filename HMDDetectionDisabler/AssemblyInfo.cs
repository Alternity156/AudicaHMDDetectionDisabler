using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(HMDDetectionDisabler.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(HMDDetectionDisabler.BuildInfo.Company)]
[assembly: AssemblyProduct(HMDDetectionDisabler.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + HMDDetectionDisabler.BuildInfo.Author)]
[assembly: AssemblyTrademark(HMDDetectionDisabler.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(HMDDetectionDisabler.BuildInfo.Version)]
[assembly: AssemblyFileVersion(HMDDetectionDisabler.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(HMDDetectionDisabler.HMDDetectionDisabler), HMDDetectionDisabler.BuildInfo.Name, HMDDetectionDisabler.BuildInfo.Version, HMDDetectionDisabler.BuildInfo.Author, HMDDetectionDisabler.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame(null, null)]