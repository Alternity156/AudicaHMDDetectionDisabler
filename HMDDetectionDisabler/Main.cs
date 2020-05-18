using MelonLoader;
using NET_SDK;
using NET_SDK.Harmony;
using System;

namespace HMDDetectionDisabler
{
    public static class BuildInfo
    {
        public const string Name = "HMDDetectionDisabler"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "Alternity"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class HMDDetectionDisabler : MelonMod
    {
        public static Patch PauseHandler_HMDMounted;
        public static Patch PauseHandler_HMDUnmounted;

        public override void OnApplicationStart()
        {
            Instance instance = Manager.CreateInstance("HMDDetectionDisabler");

            PauseHandler_HMDMounted = instance.Patch(SDK.GetClass("PauseHandler").GetMethod("HMDMounted"), typeof(HMDDetectionDisabler).GetMethod("HMDMounted"));
            PauseHandler_HMDUnmounted = instance.Patch(SDK.GetClass("PauseHandler").GetMethod("HMDUnmounted"), typeof(HMDDetectionDisabler).GetMethod("HMDUnmounted"));
        }

        public static unsafe void HMDMounted(IntPtr @this)
        {
            //PauseHandler_HMDMounted.InvokeOriginal(@this);
            MelonModLogger.Log("HMDMounted");
        }

        public static unsafe void HMDUnmounted(IntPtr @this)
        {
            //PauseHandler_HMDMounted.InvokeOriginal(@this);
            MelonModLogger.Log("HMDUnmounted");
        }

        /*
        public override void OnLevelWasLoaded(int level)
        {
            MelonModLogger.Log("OnLevelWasLoaded: " + level.ToString());
        }

        public override void OnLevelWasInitialized(int level)
        {
            MelonModLogger.Log("OnLevelWasInitialized: " + level.ToString());
        }

        public override void OnUpdate()
        {
            MelonModLogger.Log("OnUpdate");
        }

        public override void OnFixedUpdate()
        {
            MelonModLogger.Log("OnFixedUpdate");
        }

        public override void OnLateUpdate()
        {
            MelonModLogger.Log("OnLateUpdate");
        }

        public override void OnGUI()
        {
            MelonModLogger.Log("OnGUI");
        }

        public override void OnApplicationQuit()
        {
            MelonModLogger.Log("OnApplicationQuit");
        }

        public override void OnModSettingsApplied()
        {
            MelonModLogger.Log("OnModSettingsApplied");
        }

        public override void VRChat_OnUiManagerInit() // Only works in VRChat
        {
            MelonModLogger.Log("VRChat_OnUiManagerInit");
        }
        */
    }
}
