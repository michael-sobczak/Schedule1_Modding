internal class MouseEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 6568
{
	// Methods

	// RVA: 0x2E99EF0 Offset: 0x2E988F0 VA: 0x182E99EF0 Slot: 4
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x2E99F30 Offset: 0x2E98930 VA: 0x182E99F30 Slot: 5
	public void DispatchEvent(EventBase evt, IPanel iPanel) { }

	// RVA: 0x2E9A5A0 Offset: 0x2E98FA0 VA: 0x182E9A5A0
	private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x2E9A4D0 Offset: 0x2E98ED0 VA: 0x182E9A4D0
	private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x2E9A310 Offset: 0x2E98D10 VA: 0x182E9A310
	private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x2E9A680 Offset: 0x2E99080 VA: 0x182E9A680
	private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x2E9A770 Offset: 0x2E99170 VA: 0x182E9A770
	private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse) { }

	// RVA: 0x2E9A2D0 Offset: 0x2E98CD0 VA: 0x182E9A2D0
	private static bool IsDone(EventBase evt) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
