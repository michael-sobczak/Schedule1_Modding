public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 18910
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	internal ulong get_deviceId() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	internal uint get_featureIndex() { }

	// RVA: 0x2F5F9E0 Offset: 0x2F5E3E0 VA: 0x182F5F9E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F5F8C0 Offset: 0x2F5E2C0 VA: 0x182F5F8C0 Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x2F5F990 Offset: 0x2F5E390 VA: 0x182F5F990 Slot: 2
	public override int GetHashCode() { }
}
