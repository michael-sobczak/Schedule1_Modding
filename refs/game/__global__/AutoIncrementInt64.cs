internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 12850
{
	// Fields
	private long _current; // 0x18
	private long _seed; // 0x20
	private long _step; // 0x28

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x2041470 Offset: 0x203FE70 VA: 0x182041470 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x2041520 Offset: 0x203FF20 VA: 0x182041520 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x20414C0 Offset: 0x203FEC0 VA: 0x1820414C0 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x2041590 Offset: 0x203FF90 VA: 0x182041590 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x2041620 Offset: 0x2040020 VA: 0x182041620 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x2041280 Offset: 0x203FC80 VA: 0x182041280 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x20413F0 Offset: 0x203FDF0 VA: 0x1820413F0 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x2041290 Offset: 0x203FC90 VA: 0x182041290 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x20411B0 Offset: 0x203FBB0 VA: 0x1820411B0
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x2041460 Offset: 0x203FE60 VA: 0x182041460
	public void .ctor() { }
}
