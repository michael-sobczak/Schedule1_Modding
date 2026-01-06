internal static class UnityThreadUtils // TypeDefIndex: 19107
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	[CompilerGenerated]
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; // 0x8

	// Properties
	internal static TaskScheduler UnityThreadScheduler { get; set; }
	public static bool IsRunningOnUnityThread { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2B9A0D0 Offset: 0x2B98AD0 VA: 0x182B9A0D0
	internal static TaskScheduler get_UnityThreadScheduler() { }

	[CompilerGenerated]
	// RVA: 0x2B9A110 Offset: 0x2B98B10 VA: 0x182B9A110
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x2B99F90 Offset: 0x2B98990 VA: 0x182B99F90
	private static void CaptureUnityThreadInfo() { }

	// RVA: 0x2B9A070 Offset: 0x2B98A70 VA: 0x182B9A070
	public static bool get_IsRunningOnUnityThread() { }
}
