internal class Pasteboard // TypeDefIndex: 5883
{
	// Fields
	private static IntPtr primary_pbref; // 0x0
	private static IntPtr app_pbref; // 0x8
	private static IntPtr internal_format; // 0x10

	// Properties
	internal static IntPtr Primary { get; }
	internal static IntPtr Application { get; }

	// Methods

	// RVA: 0x22DF940 Offset: 0x22DE340 VA: 0x1822DF940
	private static void .cctor() { }

	// RVA: 0x22DF4C0 Offset: 0x22DDEC0 VA: 0x1822DF4C0
	internal static object Retrieve(IntPtr pbref, int key) { }

	// RVA: 0x22DF710 Offset: 0x22DE110 VA: 0x1822DF710
	internal static void Store(IntPtr pbref, object data, int key) { }

	// RVA: 0x22DFA60 Offset: 0x22DE460 VA: 0x1822DFA60
	internal static IntPtr get_Primary() { }

	// RVA: 0x22DFA10 Offset: 0x22DE410 VA: 0x1822DFA10
	internal static IntPtr get_Application() { }

	// RVA: 0x22DF010 Offset: 0x22DDA10 VA: 0x1822DF010
	private static extern IntPtr CFDataCreate(IntPtr allocator, ref IntPtr buf, int length) { }

	// RVA: 0x22DF0B0 Offset: 0x22DDAB0 VA: 0x1822DF0B0
	private static extern IntPtr CFDataGetBytePtr(IntPtr data) { }

	// RVA: 0x22DF130 Offset: 0x22DDB30 VA: 0x1822DF130
	private static extern int PasteboardClear(IntPtr pbref) { }

	// RVA: 0x22DF250 Offset: 0x22DDC50 VA: 0x1822DF250
	private static extern int PasteboardCreate(IntPtr str, ref IntPtr pbref) { }

	// RVA: 0x22DF1B0 Offset: 0x22DDBB0 VA: 0x1822DF1B0
	private static extern int PasteboardCopyItemFlavorData(IntPtr pbref, uint itemid, uint key, ref IntPtr data) { }

	// RVA: 0x22DF2E0 Offset: 0x22DDCE0 VA: 0x1822DF2E0
	private static extern int PasteboardGetItemCount(IntPtr pbref, ref uint count) { }

	// RVA: 0x22DF370 Offset: 0x22DDD70 VA: 0x1822DF370
	private static extern int PasteboardGetItemIdentifier(IntPtr pbref, uint itemindex, ref uint itemid) { }

	// RVA: 0x22DF410 Offset: 0x22DDE10 VA: 0x1822DF410
	private static extern int PasteboardPutItemFlavor(IntPtr pbref, uint itemid, uint key, IntPtr data, uint flags) { }
}
