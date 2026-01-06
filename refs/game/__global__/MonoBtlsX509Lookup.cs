internal class MonoBtlsX509Lookup : MonoBtlsObject // TypeDefIndex: 9461
{
	// Fields
	private MonoBtlsX509Store store; // 0x20
	private MonoBtlsX509LookupType type; // 0x28
	private List<MonoBtlsX509LookupMono> monoLookups; // 0x30

	// Properties
	internal MonoBtlsX509Lookup.BoringX509LookupHandle Handle { get; }

	// Methods

	// RVA: 0x2602CD0 Offset: 0x26016D0 VA: 0x182602CD0
	internal MonoBtlsX509Lookup.BoringX509LookupHandle get_Handle() { }

	// RVA: 0x2602F00 Offset: 0x2601900 VA: 0x182602F00
	private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	// RVA: 0x2602D50 Offset: 0x2601750 VA: 0x182602D50
	private static extern int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	// RVA: 0x2602DF0 Offset: 0x26017F0 VA: 0x182602DF0
	private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	// RVA: 0x2602E80 Offset: 0x2601880 VA: 0x182602E80
	private static extern void mono_btls_x509_lookup_free(IntPtr handle) { }

	// RVA: 0x2602F90 Offset: 0x2601990 VA: 0x182602F90
	private static extern IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

	// RVA: 0x2602970 Offset: 0x2601370 VA: 0x182602970
	private static MonoBtlsX509Lookup.BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x2602B50 Offset: 0x2601550 VA: 0x182602B50
	internal void .ctor(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x2602AB0 Offset: 0x26014B0 VA: 0x182602AB0
	internal IntPtr GetNativeLookup() { }

	// RVA: 0x26023B0 Offset: 0x2600DB0 VA: 0x1826023B0
	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x2602560 Offset: 0x2600F60 VA: 0x182602560
	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	// RVA: 0x26022A0 Offset: 0x2600CA0 VA: 0x1826022A0
	internal void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: 0x26027E0 Offset: 0x26011E0 VA: 0x1826027E0 Slot: 5
	protected override void Close() { }
}
