internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent // TypeDefIndex: 19217
{
	// Fields
	private string m_JsonCache; // 0x10
	private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues; // 0x18
	[CompilerGenerated]
	private readonly IJsonSerializer <Serializer>k__BackingField; // 0x20

	// Properties
	internal IJsonSerializer Serializer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal IJsonSerializer get_Serializer() { }

	// RVA: 0x2B97570 Offset: 0x2B95F70 VA: 0x182B97570
	public void .ctor(IReadOnlyDictionary<string, ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	// RVA: 0x2B97020 Offset: 0x2B95A20 VA: 0x182B97020 Slot: 4
	public bool GetBool(string key, bool defaultValue = False) { }

	// RVA: 0x2B97180 Offset: 0x2B95B80 VA: 0x182B97180 Slot: 5
	public int GetInt(string key, int defaultValue = 0) { }

	// RVA: 0x2B970C0 Offset: 0x2B95AC0 VA: 0x182B970C0 Slot: 6
	public float GetFloat(string key, float defaultValue = 0) { }

	// RVA: 0x2B971C0 Offset: 0x2B95BC0 VA: 0x182B971C0 Slot: 7
	public string GetString(string key, string defaultValue) { }

	// RVA: 0x2B972D0 Offset: 0x2B95CD0 VA: 0x182B972D0
	public string ToJson() { }
}
