internal static class ConfigurationCollectionHelper // TypeDefIndex: 19211
{
	// Methods

	[Extension]
	// RVA: 0x2B96750 Offset: 0x2B95150 VA: 0x182B96750
	public static void FillWith(IDictionary<string, ConfigurationEntry> self, SerializableProjectConfiguration config) { }

	[Extension]
	// RVA: 0x2B967E0 Offset: 0x2B951E0 VA: 0x182B967E0
	public static void FillWith(IDictionary<string, ConfigurationEntry> self, InitializationOptions options) { }

	[Extension]
	// RVA: 0x2B96B50 Offset: 0x2B95550 VA: 0x182B96B50
	private static void SetOrCreateEntry(IDictionary<string, ConfigurationEntry> self, string key, ConfigurationEntry entry) { }
}
