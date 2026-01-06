public class KeyboardNavigationManipulator : Manipulator // TypeDefIndex: 6701
{
	// Fields
	private readonly Action<KeyboardNavigationOperation, EventBase> m_Action; // 0x18

	// Methods

	// RVA: 0x7E2C80 Offset: 0x7E1680 VA: 0x1807E2C80
	public void .ctor(Action<KeyboardNavigationOperation, EventBase> action) { }

	// RVA: 0x2EA9D60 Offset: 0x2EA8760 VA: 0x182EA9D60 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x2EAA040 Offset: 0x2EA8A40 VA: 0x182EAA040 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x2EA9B10 Offset: 0x2EA8510 VA: 0x182EA9B10
	internal void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x2EA9C30 Offset: 0x2EA8630 VA: 0x182EA9C30
	private void OnNavigationCancel(NavigationCancelEvent evt) { }

	// RVA: 0x2EA9D30 Offset: 0x2EA8730 VA: 0x182EA9D30
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x2EA9C60 Offset: 0x2EA8660 VA: 0x182EA9C60
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	// RVA: 0x2E679C0 Offset: 0x2E663C0 VA: 0x182E679C0
	private void Invoke(KeyboardNavigationOperation operation, EventBase evt) { }

	[CompilerGenerated]
	// RVA: 0x2EA9F40 Offset: 0x2EA8940 VA: 0x182EA9F40
	internal static KeyboardNavigationOperation <OnKeyDown>g__GetOperation|4_0(ref KeyboardNavigationManipulator.<>c__DisplayClass4_0 ) { }
}
