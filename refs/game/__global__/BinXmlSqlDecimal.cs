internal struct BinXmlSqlDecimal // TypeDefIndex: 7897
{
	// Fields
	internal byte m_bLen; // 0x0
	internal byte m_bPrec; // 0x1
	internal byte m_bScale; // 0x2
	internal byte m_bSign; // 0x3
	internal uint m_data1; // 0x4
	internal uint m_data2; // 0x8
	internal uint m_data3; // 0xC
	internal uint m_data4; // 0x10
	private static readonly byte NUMERIC_MAX_PRECISION; // 0x0
	private static readonly byte MaxPrecision; // 0x1
	private static readonly byte MaxScale; // 0x2
	private static readonly int x_cNumeMax; // 0x4
	private static readonly long x_lInt32Base; // 0x8
	private static readonly ulong x_ulInt32Base; // 0x10
	private static readonly ulong x_ulInt32BaseForMod; // 0x18
	internal static readonly ulong x_llMax; // 0x20
	private static readonly double DUINT_BASE; // 0x28
	private static readonly double DUINT_BASE2; // 0x30
	private static readonly double DUINT_BASE3; // 0x38
	private static readonly uint[] x_rgulShiftBase; // 0x40
	private static readonly byte[] rgCLenFromPrec; // 0x48

	// Properties
	public bool IsPositive { get; }

	// Methods

	// RVA: 0x23AECA0 Offset: 0x23AD6A0 VA: 0x1823AECA0
	public bool get_IsPositive() { }

	// RVA: 0x23AE920 Offset: 0x23AD320 VA: 0x1823AE920
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x1B566A0 Offset: 0x1B550A0 VA: 0x181B566A0
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x23ADF20 Offset: 0x23AC920 VA: 0x1823ADF20
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x20E8D70 Offset: 0x20E7770 VA: 0x1820E8D70
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x20E6CD0 Offset: 0x20E56D0 VA: 0x1820E6CD0
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x23AE020 Offset: 0x23ACA20 VA: 0x1823AE020
	public Decimal ToDecimal() { }

	// RVA: 0x23AE4C0 Offset: 0x23ACEC0 VA: 0x1823AE4C0
	private void TrimTrailingZeros() { }

	// RVA: 0x23AE130 Offset: 0x23ACB30 VA: 0x1823AE130 Slot: 3
	public override string ToString() { }

	// RVA: 0x23AE710 Offset: 0x23AD110 VA: 0x1823AE710
	private static void .cctor() { }
}
