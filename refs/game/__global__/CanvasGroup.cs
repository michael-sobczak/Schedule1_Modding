public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 18970
{
	// Properties
	[NativeProperty("Alpha", False, 0)]
	public float alpha { get; set; }
	[NativeProperty("Interactable", False, 0)]
	public bool interactable { get; set; }
	[NativeProperty("BlocksRaycasts", False, 0)]
	public bool blocksRaycasts { get; set; }
	[NativeProperty("IgnoreParentGroups", False, 0)]
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x2F145E0 Offset: 0x2F12FE0 VA: 0x182F145E0
	public float get_alpha() { }

	// RVA: 0x2F146A0 Offset: 0x2F130A0 VA: 0x182F146A0
	public void set_alpha(float value) { }

	// RVA: 0x2F14660 Offset: 0x2F13060 VA: 0x182F14660
	public bool get_interactable() { }

	// RVA: 0x2F14790 Offset: 0x2F13190 VA: 0x182F14790
	public void set_interactable(bool value) { }

	// RVA: 0x2F145A0 Offset: 0x2F12FA0 VA: 0x182F145A0
	public bool get_blocksRaycasts() { }

	// RVA: 0x2F146F0 Offset: 0x2F130F0 VA: 0x182F146F0
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x2F14620 Offset: 0x2F13020 VA: 0x182F14620
	public bool get_ignoreParentGroups() { }

	// RVA: 0x2F14740 Offset: 0x2F13140 VA: 0x182F14740
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x2F145A0 Offset: 0x2F12FA0 VA: 0x182F145A0 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
