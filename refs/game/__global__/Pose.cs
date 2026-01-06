public struct Pose : IEquatable<Pose> // TypeDefIndex: 11882
{
	// Fields
	public Vector3 position; // 0x0
	public Quaternion rotation; // 0xC
	private static readonly Pose k_Identity; // 0x0

	// Methods

	// RVA: 0xD3EC80 Offset: 0xD3D680 VA: 0x180D3EC80
	public void .ctor(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2CC3AE0 Offset: 0x2CC24E0 VA: 0x182CC3AE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CC3960 Offset: 0x2CC2360 VA: 0x182CC3960 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CC3880 Offset: 0x2CC2280 VA: 0x182CC3880 Slot: 4
	public bool Equals(Pose other) { }

	// RVA: 0x2CC3A20 Offset: 0x2CC2420 VA: 0x182CC3A20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CC3C20 Offset: 0x2CC2620 VA: 0x182CC3C20
	private static void .cctor() { }
}
