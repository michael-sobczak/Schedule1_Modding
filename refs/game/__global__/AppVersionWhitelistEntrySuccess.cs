public class AppVersionWhitelistEntrySuccess // TypeDefIndex: 16786
{
	// Fields
	[CompilerGenerated]
	private Nullable<bool> <Success>k__BackingField; // 0x10
	[CompilerGenerated]
	private AppVersionWhitelistEntry <WhitelistEntry>k__BackingField; // 0x18

	// Properties
	[DataMember(Name = "success", EmitDefaultValue = False)]
	[JsonProperty(PropertyName = "success")]
	public Nullable<bool> Success { get; set; }
	[JsonProperty(PropertyName = "whitelist_entry")]
	[DataMember(Name = "whitelist_entry", EmitDefaultValue = False)]
	public AppVersionWhitelistEntry WhitelistEntry { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xB25AF0 Offset: 0xB244F0 VA: 0x180B25AF0
	public Nullable<bool> get_Success() { }

	[CompilerGenerated]
	// RVA: 0xCC4B30 Offset: 0xCC3530 VA: 0x180CC4B30
	public void set_Success(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public AppVersionWhitelistEntry get_WhitelistEntry() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_WhitelistEntry(AppVersionWhitelistEntry value) { }

	// RVA: 0xCC66F0 Offset: 0xCC50F0 VA: 0x180CC66F0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC66A0 Offset: 0xCC50A0 VA: 0x180CC66A0
	public string ToJson() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
