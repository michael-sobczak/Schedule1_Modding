internal class ChannelData // TypeDefIndex: 4283
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0x1B04140 Offset: 0x1B02B40 VA: 0x181B04140
	internal ArrayList get_ServerProviders() { }

	// RVA: 0x1B04060 Offset: 0x1B02A60 VA: 0x181B04060
	public ArrayList get_ClientProviders() { }

	// RVA: 0x1B040D0 Offset: 0x1B02AD0 VA: 0x181B040D0
	public Hashtable get_CustomProperties() { }

	// RVA: 0x1B03650 Offset: 0x1B02050 VA: 0x181B03650
	public void CopyFrom(ChannelData other) { }

	// RVA: 0x1B03F90 Offset: 0x1B02990 VA: 0x181B03F90
	public void .ctor() { }
}
