public class EffectorOffset : OffsetModifier // TypeDefIndex: 14245
{
	// Fields
	[Range(0, 1)]
	public float handsMaintainRelativePositionWeight; // 0x38
	public Vector3 bodyOffset; // 0x3C
	public Vector3 leftShoulderOffset; // 0x48
	public Vector3 rightShoulderOffset; // 0x54
	public Vector3 leftThighOffset; // 0x60
	public Vector3 rightThighOffset; // 0x6C
	public Vector3 leftHandOffset; // 0x78
	public Vector3 rightHandOffset; // 0x84
	public Vector3 leftFootOffset; // 0x90
	public Vector3 rightFootOffset; // 0x9C

	// Methods

	// RVA: 0x1F3C290 Offset: 0x1F3AC90 VA: 0x181F3C290 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x1F37C20 Offset: 0x1F36620 VA: 0x181F37C20
	public void .ctor() { }
}
