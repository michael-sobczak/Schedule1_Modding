public class RotationLimitHinge : RotationLimit // TypeDefIndex: 14171
{
	// Fields
	public bool useLimits; // 0x40
	public float min; // 0x44
	public float max; // 0x48
	[HideInInspector]
	public float zeroAxisDisplayOffset; // 0x4C
	private float lastAngle; // 0x50

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1F2B740 Offset: 0x1F2A140 VA: 0x181F2B740
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1F2B6E0 Offset: 0x1F2A0E0 VA: 0x181F2B6E0
	private void OpenScriptReference() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1F2B7A0 Offset: 0x1F2A1A0 VA: 0x181F2B7A0
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1F2B1C0 Offset: 0x1F29BC0 VA: 0x181F2B1C0
	private void ASThread() { }

	// RVA: 0x1F2B6A0 Offset: 0x1F2A0A0 VA: 0x181F2B6A0 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x1F2B220 Offset: 0x1F29C20 VA: 0x181F2B220
	private Quaternion LimitHinge(Quaternion rotation) { }

	// RVA: 0x1F2B800 Offset: 0x1F2A200 VA: 0x181F2B800
	public void .ctor() { }
}
