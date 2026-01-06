public class IPHostEntry // TypeDefIndex: 9969
{
	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_HostName() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_HostName(string value) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Aliases(string[] value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IPAddress[] get_AddressList() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x7017B0 Offset: 0x7001B0 VA: 0x1807017B0
	public void .ctor() { }
}
