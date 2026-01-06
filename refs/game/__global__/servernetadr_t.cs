public struct servernetadr_t // TypeDefIndex: 14754
{
	// Fields
	private ushort m_usConnectionPort; // 0x0
	private ushort m_usQueryPort; // 0x2
	private uint m_unIP; // 0x4

	// Methods

	// RVA: 0xCBDFD0 Offset: 0xCBC9D0 VA: 0x180CBDFD0
	public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort) { }

	// RVA: 0xCBDFC0 Offset: 0xCBC9C0 VA: 0x180CBDFC0
	public ushort GetQueryPort() { }

	// RVA: 0xCBDFE0 Offset: 0xCBC9E0 VA: 0x180CBDFE0
	public void SetQueryPort(ushort usPort) { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50
	public ushort GetConnectionPort() { }

	// RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	public void SetConnectionPort(ushort usPort) { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public uint GetIP() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void SetIP(uint unIP) { }

	// RVA: 0xCBDF40 Offset: 0xCBC940 VA: 0x180CBDF40
	public string GetConnectionAddressString() { }

	// RVA: 0xCBDFB0 Offset: 0xCBC9B0 VA: 0x180CBDFB0
	public string GetQueryAddressString() { }

	// RVA: 0xCBDFF0 Offset: 0xCBC9F0 VA: 0x180CBDFF0
	public static string ToString(uint unIP, ushort usPort) { }

	// RVA: 0xCBE350 Offset: 0xCBCD50 VA: 0x180CBE350
	public static bool op_LessThan(servernetadr_t x, servernetadr_t y) { }

	// RVA: 0xCBE2D0 Offset: 0xCBCCD0 VA: 0x180CBE2D0
	public static bool op_GreaterThan(servernetadr_t x, servernetadr_t y) { }

	// RVA: 0xCBDE90 Offset: 0xCBC890 VA: 0x180CBDE90 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCBDF60 Offset: 0xCBC960 VA: 0x180CBDF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xCBE290 Offset: 0xCBCC90 VA: 0x180CBE290
	public static bool op_Equality(servernetadr_t x, servernetadr_t y) { }

	// RVA: 0xCBE310 Offset: 0xCBCD10 VA: 0x180CBE310
	public static bool op_Inequality(servernetadr_t x, servernetadr_t y) { }

	// RVA: 0xCBDE60 Offset: 0xCBC860 VA: 0x180CBDE60
	public bool Equals(servernetadr_t other) { }

	// RVA: 0xCBDDF0 Offset: 0xCBC7F0 VA: 0x180CBDDF0
	public int CompareTo(servernetadr_t other) { }
}
