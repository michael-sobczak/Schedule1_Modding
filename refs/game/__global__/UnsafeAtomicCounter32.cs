public struct UnsafeAtomicCounter32 // TypeDefIndex: 15960
{
	// Fields
	public int* Counter; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(void* ptr) { }

	// RVA: 0x273E7D0 Offset: 0x273D1D0 VA: 0x18273E7D0
	public void Reset(int value = 0) { }

	// RVA: 0x273E780 Offset: 0x273D180 VA: 0x18273E780
	public int Add(int value) { }

	// RVA: 0x273E860 Offset: 0x273D260 VA: 0x18273E860
	public int Sub(int value) { }

	// RVA: 0x273E700 Offset: 0x273D100 VA: 0x18273E700
	public int AddSat(int value, int max = 2147483647) { }

	// RVA: 0x273E7E0 Offset: 0x273D1E0 VA: 0x18273E7E0
	public int SubSat(int value, int min = -2147483648) { }
}
