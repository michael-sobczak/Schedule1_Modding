internal class MonoBtlsBio : MonoBtlsObject // TypeDefIndex: 9420
{
	// Properties
	protected internal MonoBtlsBio.BoringBioHandle Handle { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(MonoBtlsBio.BoringBioHandle handle) { }

	// RVA: 0x2014DD0 Offset: 0x20137D0 VA: 0x182014DD0
	protected internal MonoBtlsBio.BoringBioHandle get_Handle() { }

	// RVA: 0x2014E50 Offset: 0x2013850 VA: 0x182014E50
	private static extern void mono_btls_bio_free(IntPtr handle) { }
}
