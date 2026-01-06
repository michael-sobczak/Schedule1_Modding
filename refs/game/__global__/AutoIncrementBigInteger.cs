internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 12851
{
	// Fields
	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x2040D40 Offset: 0x203F740 VA: 0x182040D40 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x2040E50 Offset: 0x203F850 VA: 0x182040E50 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x2040D90 Offset: 0x203F790 VA: 0x182040D90 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x2040ED0 Offset: 0x203F8D0 VA: 0x182040ED0 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x2040DF0 Offset: 0x203F7F0 VA: 0x182040DF0 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x2040FD0 Offset: 0x203F9D0 VA: 0x182040FD0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x2040B20 Offset: 0x203F520 VA: 0x182040B20 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x2040CA0 Offset: 0x203F6A0 VA: 0x182040CA0 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x2040BB0 Offset: 0x203F5B0 VA: 0x182040BB0 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x20409E0 Offset: 0x203F3E0 VA: 0x1820409E0
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x2040CD0 Offset: 0x203F6D0 VA: 0x182040CD0
	public void .ctor() { }
}
