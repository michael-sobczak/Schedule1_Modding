internal class MonoBtlsX509 : MonoBtlsObject // TypeDefIndex: 9454
{
	// Properties
	internal MonoBtlsX509.BoringX509Handle Handle { get; }

	// Methods

	// RVA: 0x2607B30 Offset: 0x2606530 VA: 0x182607B30
	internal MonoBtlsX509.BoringX509Handle get_Handle() { }

	// RVA: 0x22B0EA0 Offset: 0x22AF8A0 VA: 0x1822B0EA0
	internal void .ctor(MonoBtlsX509.BoringX509Handle handle) { }

	// RVA: 0x2607F10 Offset: 0x2606910 VA: 0x182607F10
	private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

	// RVA: 0x2607D50 Offset: 0x2606750 VA: 0x182607D50
	private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	// RVA: 0x2607E90 Offset: 0x2606890 VA: 0x182607E90
	private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	// RVA: 0x2607DF0 Offset: 0x26067F0 VA: 0x182607DF0
	private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	// RVA: 0x2607C40 Offset: 0x2606640 VA: 0x182607C40
	private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	// RVA: 0x2607CD0 Offset: 0x26066D0 VA: 0x182607CD0
	private static extern void mono_btls_x509_free(IntPtr handle) { }

	// RVA: 0x2607BB0 Offset: 0x26065B0 VA: 0x182607BB0
	private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	// RVA: 0x26071F0 Offset: 0x2605BF0 VA: 0x1826071F0
	internal MonoBtlsX509 Copy() { }

	// RVA: 0x2607870 Offset: 0x2606270 VA: 0x182607870
	public static MonoBtlsX509 LoadFromData(byte[] buffer, MonoBtlsX509Format format) { }

	// RVA: 0x2607730 Offset: 0x2606130 VA: 0x182607730
	public MonoBtlsX509Name GetSubjectName() { }

	// RVA: 0x2607520 Offset: 0x2605F20 VA: 0x182607520
	public long GetSubjectNameHash() { }

	// RVA: 0x2607330 Offset: 0x2605D30 VA: 0x182607330
	public byte[] GetRawData(MonoBtlsX509Format format) { }

	// RVA: 0x2607120 Offset: 0x2605B20 VA: 0x182607120
	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	// RVA: 0x2607030 Offset: 0x2605A30 VA: 0x182607030
	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }
}
