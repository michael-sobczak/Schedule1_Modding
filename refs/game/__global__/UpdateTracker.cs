internal class UpdateTracker // TypeDefIndex: 16192
{
	// Fields
	private static Dictionary<Transform, UpdateTracker.UpdateStatus> mUpdateStatus; // 0x0
	private static List<Transform> sToDelete; // 0x8
	private static float mLastUpdateTime; // 0x10

	// Methods

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0xC275B0 Offset: 0xC25FB0 VA: 0x180C275B0
	private static void InitializeModule() { }

	// RVA: 0xC276E0 Offset: 0xC260E0 VA: 0x180C276E0
	private static void UpdateTargets(UpdateTracker.UpdateClock currentClock) { }

	// RVA: 0xC27370 Offset: 0xC25D70 VA: 0x180C27370
	public static UpdateTracker.UpdateClock GetPreferredUpdate(Transform target) { }

	// RVA: 0xC27620 Offset: 0xC26020 VA: 0x180C27620
	public static void OnUpdate(UpdateTracker.UpdateClock currentClock) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xC27A40 Offset: 0xC26440 VA: 0x180C27A40
	private static void .cctor() { }
}
