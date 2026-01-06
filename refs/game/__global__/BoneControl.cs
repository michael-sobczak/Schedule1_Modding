public class BoneControl : InputControl<Bone> // TypeDefIndex: 7475
{
	// Fields
	[CompilerGenerated]
	private IntegerControl <parentBoneIndex>k__BackingField; // 0x140
	[CompilerGenerated]
	private Vector3Control <position>k__BackingField; // 0x148
	[CompilerGenerated]
	private QuaternionControl <rotation>k__BackingField; // 0x150

	// Properties
	[InputControl(offset = 0, displayName = "parentBoneIndex")]
	public IntegerControl parentBoneIndex { get; set; }
	[InputControl(offset = 4, displayName = "Position")]
	public Vector3Control position { get; set; }
	[InputControl(offset = 16, displayName = "Rotation")]
	public QuaternionControl rotation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public IntegerControl get_parentBoneIndex() { }

	[CompilerGenerated]
	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0
	public void set_parentBoneIndex(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80
	public Vector3Control get_position() { }

	[CompilerGenerated]
	// RVA: 0x79A930 Offset: 0x799330 VA: 0x18079A930
	public void set_position(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010
	public QuaternionControl get_rotation() { }

	[CompilerGenerated]
	// RVA: 0x71DC00 Offset: 0x71C600 VA: 0x18071DC00
	public void set_rotation(QuaternionControl value) { }

	// RVA: 0x281E3A0 Offset: 0x281CDA0 VA: 0x18281E3A0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x281E4B0 Offset: 0x281CEB0 VA: 0x18281E4B0 Slot: 17
	public override Bone ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x281E5A0 Offset: 0x281CFA0 VA: 0x18281E5A0 Slot: 18
	public override void WriteValueIntoState(Bone value, void* statePtr) { }

	// RVA: 0x281E660 Offset: 0x281D060 VA: 0x18281E660
	public void .ctor() { }
}
