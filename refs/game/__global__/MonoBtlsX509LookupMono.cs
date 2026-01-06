internal abstract class MonoBtlsX509LookupMono : MonoBtlsObject // TypeDefIndex: 9464
{
	// Fields
	private GCHandle gch; // 0x20
	private IntPtr instance; // 0x28
	private MonoBtlsX509LookupMono.BySubjectFunc bySubjectFunc; // 0x30
	private IntPtr bySubjectFuncPtr; // 0x38
	private MonoBtlsX509Lookup lookup; // 0x40

	// Properties
	internal MonoBtlsX509LookupMono.BoringX509LookupMonoHandle Handle { get; }

	// Methods

	// RVA: 0x2602090 Offset: 0x2600A90 VA: 0x182602090
	internal MonoBtlsX509LookupMono.BoringX509LookupMonoHandle get_Handle() { }

	// RVA: 0x2602230 Offset: 0x2600C30 VA: 0x182602230
	private static extern IntPtr mono_btls_x509_lookup_mono_new() { }

	// RVA: 0x2602190 Offset: 0x2600B90 VA: 0x182602190
	private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	// RVA: 0x2602110 Offset: 0x2600B10 VA: 0x182602110
	private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	// RVA: 0x2601E00 Offset: 0x2600800 VA: 0x182601E00
	internal void .ctor() { }

	// RVA: 0x2601B60 Offset: 0x2600560 VA: 0x182601B60
	internal void Install(MonoBtlsX509Lookup lookup) { }

	// RVA: 0x26019A0 Offset: 0x26003A0 VA: 0x1826019A0
	protected void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name);

	[MonoPInvokeCallback(typeof(MonoBtlsX509LookupMono.BySubjectFunc))]
	// RVA: 0x2601BC0 Offset: 0x26005C0 VA: 0x182601BC0
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr) { }

	// RVA: 0x2601AC0 Offset: 0x26004C0 VA: 0x182601AC0 Slot: 5
	protected override void Close() { }
}
