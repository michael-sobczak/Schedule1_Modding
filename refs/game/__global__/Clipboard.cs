public sealed class Clipboard // TypeDefIndex: 5262
{
	// Methods

	// RVA: 0x21C9F30 Offset: 0x21C8930 VA: 0x1821C9F30
	private static bool ConvertToClipboardData(ref int type, object obj, out byte[] data) { }

	// RVA: 0x21C9F00 Offset: 0x21C8900 VA: 0x1821C9F00
	private static bool ConvertFromClipboardData(int type, IntPtr data, out object obj) { }

	// RVA: 0x21CA1D0 Offset: 0x21C8BD0 VA: 0x1821CA1D0
	public static IDataObject GetDataObject() { }

	// RVA: 0x21CA6B0 Offset: 0x21C90B0 VA: 0x1821CA6B0
	public static void SetDataObject(object data) { }

	// RVA: 0x21CA680 Offset: 0x21C9080 VA: 0x1821CA680
	public static void SetDataObject(object data, bool copy) { }

	// RVA: 0x21CA2D0 Offset: 0x21C8CD0 VA: 0x1821CA2D0
	internal static void SetDataObjectImpl(object data, bool copy) { }

	// RVA: 0x21CA1E0 Offset: 0x21C8BE0 VA: 0x1821CA1E0
	private static bool IsDataSerializable(object obj) { }

	// RVA: 0x21CA6E0 Offset: 0x21C90E0 VA: 0x1821CA6E0
	public static void SetDataObject(object data, bool copy, int retryTimes, int retryDelay) { }

	// RVA: 0x21C9F50 Offset: 0x21C8950 VA: 0x1821C9F50
	internal static IDataObject GetDataObject(bool primary_selection) { }
}
