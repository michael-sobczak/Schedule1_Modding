internal class DebugUpdater : MonoBehaviour // TypeDefIndex: 13681
{
	// Fields
	private static DebugUpdater s_Instance; // 0x0
	private ScreenOrientation m_Orientation; // 0x20
	private bool m_RuntimeUiWasVisibleLastFrame; // 0x24

	// Methods

	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void RuntimeInit() { }

	// RVA: 0x29FD9D0 Offset: 0x29FC3D0 VA: 0x1829FD9D0
	internal static void SetEnabled(bool enabled) { }

	// RVA: 0x29FD480 Offset: 0x29FBE80 VA: 0x1829FD480
	private static void EnableRuntime() { }

	// RVA: 0x29FD2D0 Offset: 0x29FBCD0 VA: 0x1829FD2D0
	private static void DisableRuntime() { }

	// RVA: 0x29FD8C0 Offset: 0x29FC2C0 VA: 0x1829FD8C0
	internal static void HandleInternalEventSystemComponents(bool uiEnabled) { }

	// RVA: 0x29FD610 Offset: 0x29FC010 VA: 0x1829FD610
	private void EnsureExactlyOneEventSystem() { }

	[IteratorStateMachine(typeof(DebugUpdater.<DoAfterInputModuleUpdated>d__9))]
	// RVA: 0x29FD410 Offset: 0x29FBE10 VA: 0x1829FD410
	private IEnumerator DoAfterInputModuleUpdated(Action action) { }

	// RVA: 0x29FCF00 Offset: 0x29FB900 VA: 0x1829FCF00
	private void CheckInputModuleExists() { }

	// RVA: 0x29FCCB0 Offset: 0x29FB6B0 VA: 0x1829FCCB0
	private void AssignDefaultActions() { }

	// RVA: 0x29FD010 Offset: 0x29FBA10 VA: 0x1829FD010
	private void CreateDebugEventSystem() { }

	// RVA: 0x29FD140 Offset: 0x29FBB40 VA: 0x1829FD140
	private void DestroyDebugEventSystem() { }

	// RVA: 0x29FDC90 Offset: 0x29FC690 VA: 0x1829FDC90
	private void Update() { }

	[IteratorStateMachine(typeof(DebugUpdater.<RefreshRuntimeUINextFrame>d__15))]
	// RVA: 0x29FD980 Offset: 0x29FC380 VA: 0x1829FD980
	private static IEnumerator RefreshRuntimeUINextFrame() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
