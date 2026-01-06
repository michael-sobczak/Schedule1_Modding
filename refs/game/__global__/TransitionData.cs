internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData> // TypeDefIndex: 6801
{
	// Fields
	public List<TimeValue> transitionDelay; // 0x0
	public List<TimeValue> transitionDuration; // 0x8
	public List<StylePropertyName> transitionProperty; // 0x10
	public List<EasingFunction> transitionTimingFunction; // 0x18

	// Methods

	// RVA: 0x2F0BB10 Offset: 0x2F0A510 VA: 0x182F0BB10 Slot: 4
	public TransitionData Copy() { }

	// RVA: 0x2F0B9A0 Offset: 0x2F0A3A0 VA: 0x182F0B9A0 Slot: 5
	public void CopyFrom(ref TransitionData other) { }

	// RVA: 0x2F0BE70 Offset: 0x2F0A870 VA: 0x182F0BE70
	public static bool op_Equality(TransitionData lhs, TransitionData rhs) { }

	// RVA: 0x2F0BCB0 Offset: 0x2F0A6B0 VA: 0x182F0BCB0 Slot: 6
	public bool Equals(TransitionData other) { }

	// RVA: 0x2F0BCF0 Offset: 0x2F0A6F0 VA: 0x182F0BCF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F0BDB0 Offset: 0x2F0A7B0 VA: 0x182F0BDB0 Slot: 2
	public override int GetHashCode() { }
}
