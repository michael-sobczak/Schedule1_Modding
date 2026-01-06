internal class MonoBtlsBioMemory : MonoBtlsBio // TypeDefIndex: 9421
{
	// Methods

	// RVA: 0x2013DE0 Offset: 0x20127E0 VA: 0x182013DE0
	private static extern IntPtr mono_btls_bio_mem_new() { }

	// RVA: 0x2013D50 Offset: 0x2012750 VA: 0x182013D50
	private static extern int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data) { }

	// RVA: 0x2013C70 Offset: 0x2012670 VA: 0x182013C70
	public void .ctor() { }

	// RVA: 0x2013A50 Offset: 0x2012450 VA: 0x182013A50
	public byte[] GetData() { }
}
