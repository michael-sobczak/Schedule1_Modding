internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData> // TypeDefIndex: 6800
{
	// Fields
	public Rotate rotate; // 0x0
	public Scale scale; // 0x18
	public TransformOrigin transformOrigin; // 0x28
	public Translate translate; // 0x3C

	// Methods

	// RVA: 0x2F0ADC0 Offset: 0x2F097C0 VA: 0x182F0ADC0 Slot: 4
	public TransformData Copy() { }

	// RVA: 0x2F0AD90 Offset: 0x2F09790 VA: 0x182F0AD90 Slot: 5
	public void CopyFrom(ref TransformData other) { }

	// RVA: 0x2F0B0F0 Offset: 0x2F09AF0 VA: 0x182F0B0F0
	public static bool op_Equality(TransformData lhs, TransformData rhs) { }

	// RVA: 0x2F0ADF0 Offset: 0x2F097F0 VA: 0x182F0ADF0 Slot: 6
	public bool Equals(TransformData other) { }

	// RVA: 0x2F0AE80 Offset: 0x2F09880 VA: 0x182F0AE80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F0AFB0 Offset: 0x2F099B0 VA: 0x182F0AFB0 Slot: 2
	public override int GetHashCode() { }
}
