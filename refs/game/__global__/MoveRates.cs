internal struct MoveRates // TypeDefIndex: 12601
{
	// Fields
	public float Position; // 0x0
	public float Rotation; // 0x4
	public float Scale; // 0x8
	public const float UNSET_VALUE = -∞;
	public const float INSTANT_VALUE = ∞;

	// Properties
	public bool PositionSet { get; }
	public bool RotationSet { get; }
	public bool ScaleSet { get; }
	public bool AnySet { get; }
	public bool InstantPosition { get; }
	public bool InstantRotation { get; }
	public bool InstantScale { get; }

	// Methods

	// RVA: 0xD2D750 Offset: 0xD2C150 VA: 0x180D2D750
	public void .ctor(float value) { }

	// RVA: 0xD2D760 Offset: 0xD2C160 VA: 0x180D2D760
	public void .ctor(float position, float rotation) { }

	// RVA: 0x8272A0 Offset: 0x825CA0 VA: 0x1808272A0
	public void .ctor(float position, float rotation, float scale) { }

	// RVA: 0xD2D820 Offset: 0xD2C220 VA: 0x180D2D820
	public bool get_PositionSet() { }

	// RVA: 0xD2D840 Offset: 0xD2C240 VA: 0x180D2D840
	public bool get_RotationSet() { }

	// RVA: 0xD2D860 Offset: 0xD2C260 VA: 0x180D2D860
	public bool get_ScaleSet() { }

	// RVA: 0xD2D780 Offset: 0xD2C180 VA: 0x180D2D780
	public bool get_AnySet() { }

	// RVA: 0xD2D7C0 Offset: 0xD2C1C0 VA: 0x180D2D7C0
	public bool get_InstantPosition() { }

	// RVA: 0xD2D7E0 Offset: 0xD2C1E0 VA: 0x180D2D7E0
	public bool get_InstantRotation() { }

	// RVA: 0xD2D800 Offset: 0xD2C200 VA: 0x180D2D800
	public bool get_InstantScale() { }

	// RVA: 0xD2D730 Offset: 0xD2C130 VA: 0x180D2D730
	public void SetInstantRates() { }

	// RVA: 0xD2D750 Offset: 0xD2C150 VA: 0x180D2D750
	public void Update(float value) { }

	// RVA: 0x8272A0 Offset: 0x825CA0 VA: 0x1808272A0
	public void Update(float position, float rotation, float scale) { }
}
