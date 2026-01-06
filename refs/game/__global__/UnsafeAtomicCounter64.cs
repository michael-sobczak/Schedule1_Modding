public struct UnsafeAtomicCounter64 // TypeDefIndex: 15961
{
	// Fields
	public long* Counter; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(void* ptr) { }

	// RVA: 0x273E990 Offset: 0x273D390 VA: 0x18273E990
	public void Reset(long value = 0) { }

	// RVA: 0x273E940 Offset: 0x273D340 VA: 0x18273E940
	public long Add(long value) { }

	// RVA: 0x273EA30 Offset: 0x273D430 VA: 0x18273EA30
	public long Sub(long value) { }

	// RVA: 0x273E8B0 Offset: 0x273D2B0 VA: 0x18273E8B0
	public long AddSat(long value, long max = 9223372036854775807) { }

	// RVA: 0x273E9A0 Offset: 0x273D3A0 VA: 0x18273E9A0
	public long SubSat(long value, long min = -9223372036854775808) { }
}
