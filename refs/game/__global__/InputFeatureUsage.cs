public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 18907
{
	// Fields
	internal string m_Name; // 0x0
	[NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public string get_name() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	internal InputFeatureType get_internalType() { }

	// RVA: 0x2F5FEA0 Offset: 0x2F5E8A0 VA: 0x182F5FEA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F5FF60 Offset: 0x2F5E960 VA: 0x182F5FF60 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x2F5FFB0 Offset: 0x2F5E9B0 VA: 0x182F5FFB0 Slot: 2
	public override int GetHashCode() { }
}
