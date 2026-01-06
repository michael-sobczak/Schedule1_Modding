internal class MonoBtlsX509Name : MonoBtlsObject // TypeDefIndex: 9468
{
	// Properties
	internal MonoBtlsX509Name.BoringX509NameHandle Handle { get; }

	// Methods

	// RVA: 0x2603E10 Offset: 0x2602810 VA: 0x182603E10
	private static extern long mono_btls_x509_name_hash(IntPtr handle) { }

	// RVA: 0x2603B20 Offset: 0x2602520 VA: 0x182603B20
	private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	// RVA: 0x2603CE0 Offset: 0x26026E0 VA: 0x182603CE0
	private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	// RVA: 0x2603C40 Offset: 0x2602640 VA: 0x182603C40
	private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	// RVA: 0x2603BA0 Offset: 0x26025A0 VA: 0x182603BA0
	private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data) { }

	// RVA: 0x2603D70 Offset: 0x2602770 VA: 0x182603D70
	private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str) { }

	// RVA: 0x2603A80 Offset: 0x2602480 VA: 0x182603A80
	private static extern IntPtr mono_btls_x509_name_from_data(void* data, int len, int use_canon_enc) { }

	// RVA: 0x2603A00 Offset: 0x2602400 VA: 0x182603A00
	private static extern void mono_btls_x509_name_free(IntPtr handle) { }

	// RVA: 0x2603980 Offset: 0x2602380 VA: 0x182603980
	internal MonoBtlsX509Name.BoringX509NameHandle get_Handle() { }

	// RVA: 0x22B0EA0 Offset: 0x22AF8A0 VA: 0x1822B0EA0
	internal void .ctor(MonoBtlsX509Name.BoringX509NameHandle handle) { }

	// RVA: 0x26038E0 Offset: 0x26022E0 VA: 0x1826038E0
	public long GetHash() { }

	// RVA: 0x26031A0 Offset: 0x2601BA0 VA: 0x1826031A0
	public int GetEntryCount() { }

	// RVA: 0x26035E0 Offset: 0x2601FE0 VA: 0x1826035E0
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	// RVA: 0x26033A0 Offset: 0x2601DA0 VA: 0x1826033A0
	public string GetEntryOid(int index) { }

	// RVA: 0x2603240 Offset: 0x2601C40 VA: 0x182603240
	public byte[] GetEntryOidData(int index) { }

	// RVA: 0x26036D0 Offset: 0x26020D0 VA: 0x1826036D0
	public string GetEntryValue(int index, out int tag) { }

	// RVA: 0x2603010 Offset: 0x2601A10 VA: 0x182603010
	public static MonoBtlsX509Name CreateFromData(byte[] data, bool use_canon_enc) { }
}
