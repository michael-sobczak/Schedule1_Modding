public class RotationLimitAngle : RotationLimit // TypeDefIndex: 14170
{
	// Fields
	[Range(0, 180)]
	public float limit; // 0x40
	[Range(0, 180)]
	public float twistLimit; // 0x44

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1F2B0A0 Offset: 0x1F29AA0 VA: 0x181F2B0A0
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1F2B040 Offset: 0x1F29A40 VA: 0x181F2B040
	private void OpenScriptReference() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1F2B100 Offset: 0x1F29B00 VA: 0x181F2B100
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1F2AB30 Offset: 0x1F29530 VA: 0x181F2AB30
	private void ASThread() { }

	// RVA: 0x1F2AB90 Offset: 0x1F29590 VA: 0x181F2AB90 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x1F2AC40 Offset: 0x1F29640 VA: 0x181F2AC40
	private Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x1F2B160 Offset: 0x1F29B60 VA: 0x181F2B160
	public void .ctor() { }
}
