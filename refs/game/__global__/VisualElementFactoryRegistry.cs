internal class VisualElementFactoryRegistry // TypeDefIndex: 7001
{
	// Fields
	private static Dictionary<string, List<IUxmlFactory>> s_Factories; // 0x0
	private static Dictionary<string, List<IUxmlFactory>> s_MovedTypesFactories; // 0x8

	// Properties
	internal static Dictionary<string, List<IUxmlFactory>> factories { get; }

	// Methods

	// RVA: 0x2DF05E0 Offset: 0x2DEEFE0 VA: 0x182DF05E0
	private static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr) { }

	// RVA: 0x2DF2900 Offset: 0x2DF1300 VA: 0x182DF2900
	internal static Dictionary<string, List<IUxmlFactory>> get_factories() { }

	// RVA: 0x2DF1F70 Offset: 0x2DF0970 VA: 0x182DF1F70
	protected static void RegisterFactory(IUxmlFactory factory) { }

	// RVA: 0x2DF2860 Offset: 0x2DF1260 VA: 0x182DF2860
	internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList) { }

	// RVA: 0x2DF0750 Offset: 0x2DEF150 VA: 0x182DF0750
	private static void RegisterEngineFactories() { }

	// RVA: 0x2DF2560 Offset: 0x2DF0F60 VA: 0x182DF2560
	internal static void RegisterUserFactories() { }
}
