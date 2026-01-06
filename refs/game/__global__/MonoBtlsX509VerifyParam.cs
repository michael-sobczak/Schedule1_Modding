internal class MonoBtlsX509VerifyParam : MonoBtlsObject // TypeDefIndex: 9478
{
	// Properties
	internal MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle Handle { get; }
	public bool CanModify { get; }

	// Methods

	// RVA: 0x2606C80 Offset: 0x2605680 VA: 0x182606C80
	internal MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle get_Handle() { }

	// RVA: 0x2606D80 Offset: 0x2605780 VA: 0x182606D80
	private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	// RVA: 0x2606E80 Offset: 0x2605880 VA: 0x182606E80
	private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	// RVA: 0x2606D00 Offset: 0x2605700 VA: 0x182606D00
	private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	// RVA: 0x2606F00 Offset: 0x2605900 VA: 0x182606F00
	private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	// RVA: 0x2606FA0 Offset: 0x26059A0 VA: 0x182606FA0
	private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, long time) { }

	// RVA: 0x2606E00 Offset: 0x2605800 VA: 0x182606E00
	private static extern void mono_btls_x509_verify_param_free(IntPtr handle) { }

	// RVA: 0x22B0EA0 Offset: 0x22AF8A0 VA: 0x1822B0EA0
	internal void .ctor(MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle handle) { }

	// RVA: 0x2606310 Offset: 0x2604D10 VA: 0x182606310
	public MonoBtlsX509VerifyParam Copy() { }

	// RVA: 0x2606450 Offset: 0x2604E50 VA: 0x182606450
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	// RVA: 0x2606490 Offset: 0x2604E90 VA: 0x182606490
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	// RVA: 0x26064D0 Offset: 0x2604ED0 VA: 0x1826064D0
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = False) { }

	// RVA: 0x2606BE0 Offset: 0x26055E0 VA: 0x182606BE0
	public bool get_CanModify() { }

	// RVA: 0x2606AF0 Offset: 0x26054F0 VA: 0x182606AF0
	private void WantToModify() { }

	// RVA: 0x2606780 Offset: 0x2605180 VA: 0x182606780
	public void SetHost(string name) { }

	// RVA: 0x2606950 Offset: 0x2605350 VA: 0x182606950
	public void SetTime(DateTime time) { }
}
