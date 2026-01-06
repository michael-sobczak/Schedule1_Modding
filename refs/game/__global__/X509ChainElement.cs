public class X509ChainElement // TypeDefIndex: 9637
{
	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private string info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Properties
	public X509Certificate2 Certificate { get; }
	public X509ChainStatus[] ChainElementStatus { get; }
	internal X509ChainStatusFlags StatusFlags { get; set; }

	// Methods

	// RVA: 0x26524C0 Offset: 0x2650EC0 VA: 0x1826524C0
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x2651520 Offset: 0x264FF20 VA: 0x182651520
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x2651550 Offset: 0x264FF50 VA: 0x182651550
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x26515D0 Offset: 0x264FFD0 VA: 0x1826515D0
	internal void UncompressFlags() { }
}
