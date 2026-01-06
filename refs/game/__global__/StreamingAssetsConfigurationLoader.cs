internal class StreamingAssetsConfigurationLoader : IConfigurationLoader // TypeDefIndex: 19220
{
	// Fields
	private readonly IJsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IJsonSerializer serializer) { }

	[AsyncStateMachine(typeof(StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2))]
	// RVA: 0x2B97640 Offset: 0x2B96040 VA: 0x182B97640 Slot: 4
	public Task<SerializableProjectConfiguration> GetConfigAsync() { }
}
