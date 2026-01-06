public struct X509ChainStatus // TypeDefIndex: 9643
{
	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { set; }

	// Methods

	// RVA: 0x2656A20 Offset: 0x2655420 VA: 0x182656A20
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0xCC9B80 Offset: 0xCC8580 VA: 0x180CC9B80
	public void set_StatusInformation(string value) { }

	// RVA: 0x26568A0 Offset: 0x26552A0 VA: 0x1826568A0
	internal static string GetInformation(X509ChainStatusFlags flags) { }
}
