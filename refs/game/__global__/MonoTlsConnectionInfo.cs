public class MonoTlsConnectionInfo // TypeDefIndex: 17536
{
	// Fields
	[CompilerGenerated]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliant(False)]
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xB25AF0 Offset: 0xB244F0 VA: 0x180B25AF0
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGenerated]
	// RVA: 0xCC4B30 Offset: 0xCC3530 VA: 0x180CC4B30
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGenerated]
	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_PeerDomainName(string value) { }

	// RVA: 0x1A7AB30 Offset: 0x1A79530 VA: 0x181A7AB30 Slot: 3
	public override string ToString() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
