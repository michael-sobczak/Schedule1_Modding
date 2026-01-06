internal class UxmlObjectFactoryRegistry // TypeDefIndex: 6997
{
	// Fields
	private static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories; // 0x0

	// Properties
	internal static Dictionary<string, List<IBaseUxmlObjectFactory>> factories { get; }

	// Methods

	// RVA: 0x2DEE6C0 Offset: 0x2DED0C0 VA: 0x182DEE6C0
	internal static Dictionary<string, List<IBaseUxmlObjectFactory>> get_factories() { }

	// RVA: 0x2DEE000 Offset: 0x2DECA00 VA: 0x182DEE000
	protected static void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	// RVA: 0x2DEE660 Offset: 0x2DED060 VA: 0x182DEE660
	internal static bool TryGetFactories(string fullTypeName, out List<IBaseUxmlObjectFactory> factoryList) { }

	// RVA: 0x2DEDD80 Offset: 0x2DEC780 VA: 0x182DEDD80
	private static void RegisterEngineFactories() { }

	// RVA: 0x2DEE360 Offset: 0x2DECD60 VA: 0x182DEE360
	private static void RegisterUserFactories() { }
}
