internal class MonoBtlsKey : MonoBtlsObject // TypeDefIndex: 9432
{
	// Properties
	internal MonoBtlsKey.BoringKeyHandle Handle { get; }

	// Methods

	// RVA: 0x2018160 Offset: 0x2016B60 VA: 0x182018160
	private static extern IntPtr mono_btls_key_new() { }

	// RVA: 0x2018030 Offset: 0x2016A30 VA: 0x182018030
	private static extern void mono_btls_key_free(IntPtr handle) { }

	// RVA: 0x20181D0 Offset: 0x2016BD0 VA: 0x1820181D0
	private static extern IntPtr mono_btls_key_up_ref(IntPtr handle) { }

	// RVA: 0x20180B0 Offset: 0x2016AB0 VA: 0x1820180B0
	private static extern int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits) { }

	// RVA: 0x2017F80 Offset: 0x2016980 VA: 0x182017F80
	private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, byte[] der, int der_length) { }

	// RVA: 0x2017F00 Offset: 0x2016900 VA: 0x182017F00
	internal MonoBtlsKey.BoringKeyHandle get_Handle() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(MonoBtlsKey.BoringKeyHandle handle) { }

	// RVA: 0x2017D30 Offset: 0x2016730 VA: 0x182017D30
	public byte[] GetBytes(bool include_private_bits) { }

	// RVA: 0x20179E0 Offset: 0x20163E0 VA: 0x1820179E0
	public MonoBtlsKey Copy() { }

	// RVA: 0x2017B30 Offset: 0x2016530 VA: 0x182017B30
	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }
}
