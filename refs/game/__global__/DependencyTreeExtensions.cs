internal static class DependencyTreeExtensions // TypeDefIndex: 17852
{
	// Methods

	[Extension]
	// RVA: 0x2B9D380 Offset: 0x2B9BD80 VA: 0x182B9D380
	internal static string ToJson(DependencyTree tree, ICollection<int> order) { }

	[Extension]
	// RVA: 0x2B9D2A0 Offset: 0x2B9BCA0 VA: 0x182B9D2A0
	internal static bool IsOptional(DependencyTree tree, int componentTypeHash) { }

	[Extension]
	// RVA: 0x2B9D320 Offset: 0x2B9BD20 VA: 0x182B9D320
	internal static bool IsProvided(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x2B9CA30 Offset: 0x2B9B430 VA: 0x182B9CA30
	private static JObject GetPackageJObject(DependencyTree tree, int packageHash) { }

	// RVA: 0x2B9C5B0 Offset: 0x2B9AFB0 VA: 0x182B9C5B0
	private static JObject GetComponentJObject(DependencyTree tree, int componentHash) { }

	// RVA: 0x2B9C4E0 Offset: 0x2B9AEE0 VA: 0x182B9C4E0
	private static string GetComponentIdentifier(IServiceComponent component) { }
}
