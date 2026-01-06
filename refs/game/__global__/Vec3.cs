public struct Vec3 // TypeDefIndex: 10786
{
	// Fields
	public static readonly Vec3 Zero; // 0x0
	public float X; // 0x0
	public float Y; // 0x4
	public float Z; // 0x8

	// Properties
	public float Item { get; set; }

	// Methods

	// RVA: 0x53CF50 Offset: 0x53B950 VA: 0x18053CF50
	public float get_Item(int index) { }

	// RVA: 0x53CFD0 Offset: 0x53B9D0 VA: 0x18053CFD0
	public void set_Item(int index, float value) { }

	// RVA: 0x53CE60 Offset: 0x53B860 VA: 0x18053CE60
	public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result) { }

	// RVA: 0x53CD70 Offset: 0x53B770 VA: 0x18053CD70
	public static void Neg(ref Vec3 v) { }

	// RVA: 0x53CC60 Offset: 0x53B660 VA: 0x18053CC60
	public static void Dot(ref Vec3 u, ref Vec3 v, out float dot) { }

	// RVA: 0x53CDA0 Offset: 0x53B7A0 VA: 0x18053CDA0
	public static void Normalize(ref Vec3 v) { }

	// RVA: 0x53CC90 Offset: 0x53B690 VA: 0x18053CC90
	public static int LongAxis(ref Vec3 v) { }

	// RVA: 0x53CE90 Offset: 0x53B890 VA: 0x18053CE90 Slot: 3
	public override string ToString() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void .cctor() { }
}
