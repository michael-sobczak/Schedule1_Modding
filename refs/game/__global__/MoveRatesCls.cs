internal class MoveRatesCls : IResettable // TypeDefIndex: 12602
{
	// Fields
	public float Position; // 0x10
	public float Rotation; // 0x14
	public float Scale; // 0x18
	[CompilerGenerated]
	private float <LastMultiplier>k__BackingField; // 0x1C
	public const float UNSET_VALUE = -∞;
	public const float INSTANT_VALUE = ∞;

	// Properties
	public float LastMultiplier { get; set; }
	public bool PositionSet { get; }
	public bool RotationSet { get; }
	public bool ScaleSet { get; }
	public bool AnySet { get; }
	public bool InstantPosition { get; }
	public bool InstantRotation { get; }
	public bool InstantScale { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A60 Offset: 0x497460 VA: 0x180498A60
	public float get_LastMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x49D820 Offset: 0x49C220 VA: 0x18049D820
	private void set_LastMultiplier(float value) { }

	// RVA: 0xD2D550 Offset: 0xD2BF50 VA: 0x180D2D550
	public void .ctor(float value) { }

	// RVA: 0xD2D500 Offset: 0xD2BF00 VA: 0x180D2D500
	public void .ctor(float position, float rotation) { }

	// RVA: 0xD2D5D0 Offset: 0xD2BFD0 VA: 0x180D2D5D0
	public void .ctor(float position, float rotation, float scale) { }

	// RVA: 0xD2D6D0 Offset: 0xD2C0D0 VA: 0x180D2D6D0
	public bool get_PositionSet() { }

	// RVA: 0xD2D6F0 Offset: 0xD2C0F0 VA: 0x180D2D6F0
	public bool get_RotationSet() { }

	// RVA: 0xD2D710 Offset: 0xD2C110 VA: 0x180D2D710
	public bool get_ScaleSet() { }

	// RVA: 0xD2D630 Offset: 0xD2C030 VA: 0x180D2D630
	public bool get_AnySet() { }

	// RVA: 0xD2D670 Offset: 0xD2C070 VA: 0x180D2D670
	public bool get_InstantPosition() { }

	// RVA: 0xD2D690 Offset: 0xD2C090 VA: 0x180D2D690
	public bool get_InstantRotation() { }

	// RVA: 0xD2D6B0 Offset: 0xD2C0B0 VA: 0x180D2D6B0
	public bool get_InstantScale() { }

	// RVA: 0xD2D590 Offset: 0xD2BF90 VA: 0x180D2D590
	public void .ctor() { }

	// RVA: 0xD2D440 Offset: 0xD2BE40 VA: 0x180D2D440
	public void Multiply(float value) { }

	// RVA: 0xD2D490 Offset: 0xD2BE90 VA: 0x180D2D490
	public void SetInstantRates() { }

	// RVA: 0xD2D4B0 Offset: 0xD2BEB0 VA: 0x180D2D4B0
	public void Update(float value) { }

	// RVA: 0xD2D4C0 Offset: 0xD2BEC0 VA: 0x180D2D4C0
	public void Update(float position, float rotation, float scale) { }

	// RVA: 0xD2D4D0 Offset: 0xD2BED0 VA: 0x180D2D4D0
	public void Update(MoveRatesCls mr) { }

	// RVA: 0xD2D470 Offset: 0xD2BE70 VA: 0x180D2D470 Slot: 4
	public void ResetState() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void InitializeState() { }
}
