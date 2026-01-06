internal struct HashFNV1A32 // TypeDefIndex: 13864
{
	// Fields
	private const uint k_Prime = 16777619;
	private const uint k_OffsetBasis = 2166136261;
	private uint m_Hash; // 0x0

	// Properties
	public int value { get; }

	// Methods

	// RVA: 0x2A40D90 Offset: 0x2A3F790 VA: 0x182A40D90
	public static HashFNV1A32 Create() { }

	// RVA: 0x2A40B90 Offset: 0x2A3F590 VA: 0x182A40B90
	public void Append(in int input) { }

	// RVA: 0x2A40B90 Offset: 0x2A3F590 VA: 0x182A40B90
	public void Append(in uint input) { }

	// RVA: 0x2A40CD0 Offset: 0x2A3F6D0 VA: 0x182A40CD0
	public void Append(in bool input) { }

	// RVA: 0x2A40B50 Offset: 0x2A3F550 VA: 0x182A40B50
	public void Append(in float input) { }

	// RVA: 0x2A40CF0 Offset: 0x2A3F6F0 VA: 0x182A40CF0
	public void Append(in double input) { }

	// RVA: 0x2A40D30 Offset: 0x2A3F730 VA: 0x182A40D30
	public void Append(in Vector2 input) { }

	// RVA: 0x2A40BA0 Offset: 0x2A3F5A0 VA: 0x182A40BA0
	public void Append(in Vector3 input) { }

	// RVA: 0x2A40C30 Offset: 0x2A3F630 VA: 0x182A40C30
	public void Append(in Vector4 input) { }

	// RVA: -1 Offset: -1
	public void Append<T>(T input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC0E50 Offset: 0xEBF850 VA: 0x180EC0E50
	|-HashFNV1A32.Append<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2A40AC0 Offset: 0x2A3F4C0 VA: 0x182A40AC0
	public void Append(Delegate del) { }

	// RVA: 0x2A40DA0 Offset: 0x2A3F7A0 VA: 0x182A40DA0
	internal static int GetFuncHashCode(Delegate del) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_value() { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }
}
