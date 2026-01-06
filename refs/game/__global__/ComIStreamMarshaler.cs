internal sealed class ComIStreamMarshaler : ICustomMarshaler // TypeDefIndex: 17137
{
	// Fields
	private static readonly ComIStreamMarshaler defaultInstance; // 0x0

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x2136D00 Offset: 0x2135700 VA: 0x182136D00
	private static ICustomMarshaler GetInstance(string cookie) { }

	// RVA: 0x2136D50 Offset: 0x2135750 VA: 0x182136D50 Slot: 5
	public IntPtr MarshalManagedToNative(object managedObj) { }

	// RVA: 0x2136CB0 Offset: 0x21356B0 VA: 0x182136CB0 Slot: 6
	public void CleanUpNativeData(IntPtr pNativeData) { }

	// RVA: 0x2136DE0 Offset: 0x21357E0 VA: 0x182136DE0 Slot: 4
	public object MarshalNativeToManaged(IntPtr pNativeData) { }

	// RVA: 0x2136B50 Offset: 0x2135550 VA: 0x182136B50 Slot: 7
	public void CleanUpManagedData(object managedObj) { }

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490 Slot: 8
	public int GetNativeDataSize() { }

	// RVA: 0x2136DF0 Offset: 0x21357F0 VA: 0x182136DF0
	private static void .cctor() { }
}
