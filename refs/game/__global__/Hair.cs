public class Hair : Accessory // TypeDefIndex: 3117
{
	// Fields
	[CompilerGenerated]
	private bool <BlockedByHat>k__BackingField; // 0x60
	[SerializeField]
	private GameObject[] hairToHide; // 0x68

	// Properties
	public bool BlockedByHat { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_BlockedByHat() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	protected void set_BlockedByHat(bool value) { }

	// RVA: 0x9BB9D0 Offset: 0x9BA3D0 VA: 0x1809BB9D0
	public void SetBlockedByHat(bool blocked) { }

	// RVA: 0x9BB960 Offset: 0x9BA360 VA: 0x1809BB960 Slot: 4
	protected virtual void BlockHair() { }

	// RVA: 0x9BBA00 Offset: 0x9BA400 VA: 0x1809BBA00 Slot: 5
	protected virtual void UnBlockHair() { }

	// RVA: 0x9BBA70 Offset: 0x9BA470 VA: 0x1809BBA70
	public void .ctor() { }
}
