public class Deployment // TypeDefIndex: 16799
{
	// Fields
	[CompilerGenerated]
	private string <RequestId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <PublicIp>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Status>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<bool> <Ready>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<bool> <WhitelistingActive>k__BackingField; // 0x2A
	[CompilerGenerated]
	private string <Fqdn>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<string, PortMapping> <Ports>k__BackingField; // 0x38
	[CompilerGenerated]
	private DeploymentLocation <Location>k__BackingField; // 0x40
	[CompilerGenerated]
	private List<string> <Tags>k__BackingField; // 0x48
	[CompilerGenerated]
	private Nullable<int> <Sockets>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <SocketsUsage>k__BackingField; // 0x58

	// Properties
	[JsonProperty(PropertyName = "request_id")]
	[DataMember(Name = "request_id", EmitDefaultValue = False)]
	public string RequestId { get; set; }
	[JsonProperty(PropertyName = "public_ip")]
	[DataMember(Name = "public_ip", EmitDefaultValue = False)]
	public string PublicIp { get; set; }
	[JsonProperty(PropertyName = "status")]
	[DataMember(Name = "status", EmitDefaultValue = False)]
	public string Status { get; set; }
	[JsonProperty(PropertyName = "ready")]
	[DataMember(Name = "ready", EmitDefaultValue = False)]
	public Nullable<bool> Ready { get; set; }
	[DataMember(Name = "whitelisting_active", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "whitelisting_active")]
	public Nullable<bool> WhitelistingActive { get; set; }
	[JsonProperty(PropertyName = "fqdn")]
	[DataMember(Name = "fqdn", EmitDefaultValue = False)]
	public string Fqdn { get; set; }
	[DataMember(Name = "ports", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "ports")]
	public Dictionary<string, PortMapping> Ports { get; set; }
	[DataMember(Name = "location", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "location")]
	public DeploymentLocation Location { get; set; }
	[DataMember(Name = "tags", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "tags")]
	public List<string> Tags { get; set; }
	[DataMember(Name = "sockets", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "sockets")]
	public Nullable<int> Sockets { get; set; }
	[JsonProperty(PropertyName = "sockets_usage")]
	[DataMember(Name = "sockets_usage", EmitDefaultValue = False)]
	public Nullable<int> SocketsUsage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_RequestId() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_RequestId(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_PublicIp() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_PublicIp(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Status() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Status(string value) { }

	[CompilerGenerated]
	// RVA: 0xCC6B00 Offset: 0xCC5500 VA: 0x180CC6B00
	public Nullable<bool> get_Ready() { }

	[CompilerGenerated]
	// RVA: 0xCC6B10 Offset: 0xCC5510 VA: 0x180CC6B10
	public void set_Ready(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCCA830 Offset: 0xCC9230 VA: 0x180CCA830
	public Nullable<bool> get_WhitelistingActive() { }

	[CompilerGenerated]
	// RVA: 0xCCA840 Offset: 0xCC9240 VA: 0x180CCA840
	public void set_WhitelistingActive(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Fqdn() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Fqdn(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Dictionary<string, PortMapping> get_Ports() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Ports(Dictionary<string, PortMapping> value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public DeploymentLocation get_Location() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Location(DeploymentLocation value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public List<string> get_Tags() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_Tags(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Nullable<int> get_Sockets() { }

	[CompilerGenerated]
	// RVA: 0xCC6420 Offset: 0xCC4E20 VA: 0x180CC6420
	public void set_Sockets(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Nullable<int> get_SocketsUsage() { }

	[CompilerGenerated]
	// RVA: 0xCC6430 Offset: 0xCC4E30 VA: 0x180CC6430
	public void set_SocketsUsage(Nullable<int> value) { }

	// RVA: 0xCCA360 Offset: 0xCC8D60 VA: 0x180CCA360 Slot: 3
	public override string ToString() { }

	// RVA: 0xCCA310 Offset: 0xCC8D10 VA: 0x180CCA310
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
