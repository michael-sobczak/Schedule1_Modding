internal class InstallationId : IInstallationId, IServiceComponent // TypeDefIndex: 19400
{
	// Fields
	internal string Identifier; // 0x10
	internal IUserIdentifierProvider UnityAdsIdentifierProvider; // 0x18
	internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider; // 0x20

	// Methods

	// RVA: 0x2B9A400 Offset: 0x2B98E00 VA: 0x182B9A400
	public void .ctor() { }

	// RVA: 0x2B9A340 Offset: 0x2B98D40 VA: 0x182B9A340 Slot: 4
	public string GetOrCreateIdentifier() { }

	// RVA: 0x2B9A170 Offset: 0x2B98B70 VA: 0x182B9A170
	public void CreateIdentifier() { }

	// RVA: 0x2B9A370 Offset: 0x2B98D70 VA: 0x182B9A370
	private static string ReadIdentifierFromFile() { }

	// RVA: 0x2B9A3B0 Offset: 0x2B98DB0 VA: 0x182B9A3B0
	private static void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x2B87E80 Offset: 0x2B86880 VA: 0x182B87E80
	private static string GenerateGuid() { }
}
