internal class PointerEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 6618
{
	// Methods

	// RVA: 0x2EB22C0 Offset: 0x2EB0CC0 VA: 0x182EB22C0 Slot: 4
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x2EB2300 Offset: 0x2EB0D00 VA: 0x182EB2300 Slot: 6
	public virtual void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x2EB23B0 Offset: 0x2EB0DB0 VA: 0x182EB23B0
	private static void SendEventToTarget(EventBase evt, IPanel panel) { }

	// RVA: 0x2EB2450 Offset: 0x2EB0E50 VA: 0x182EB2450
	private static void SetBestTargetForEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x2EB2640 Offset: 0x2EB1040 VA: 0x182EB2640
	private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
