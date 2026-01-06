internal class BitStack // TypeDefIndex: 7908
{
	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x23AF070 Offset: 0x23ADA70 VA: 0x1823AF070
	public void .ctor() { }

	// RVA: 0x23AEE90 Offset: 0x23AD890 VA: 0x1823AEE90
	public void PushBit(bool bit) { }

	// RVA: 0x23AEDF0 Offset: 0x23AD7F0 VA: 0x1823AEDF0
	public bool PopBit() { }

	// RVA: 0x23AEDE0 Offset: 0x23AD7E0 VA: 0x1823AEDE0
	public bool PeekBit() { }

	// RVA: 0x23AEF90 Offset: 0x23AD990 VA: 0x1823AEF90
	private void PushCurr() { }

	// RVA: 0x23AEE50 Offset: 0x23AD850 VA: 0x1823AEE50
	private void PopCurr() { }
}
