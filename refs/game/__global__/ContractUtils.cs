internal static class ContractUtils // TypeDefIndex: 15652
{
	// Properties
	[ExcludeFromCodeCoverage]
	public static Exception Unreachable { get; }

	// Methods

	// RVA: 0x2001520 Offset: 0x1FFFF20 VA: 0x182001520
	public static Exception get_Unreachable() { }

	// RVA: 0x20014E0 Offset: 0x1FFFEE0 VA: 0x1820014E0
	public static void Requires(bool precondition, string paramName) { }

	// RVA: 0x2001480 Offset: 0x1FFFE80 VA: 0x182001480
	public static void RequiresNotNull(object value, string paramName) { }

	// RVA: 0x2001400 Offset: 0x1FFFE00 VA: 0x182001400
	public static void RequiresNotNull(object value, string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresNotNullItems<T>(IList<T> array, string arrayName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6A970 Offset: 0xE69370 VA: 0x180E6A970
	|-ContractUtils.RequiresNotNullItems<object>
	|
	|-RVA: 0xE6A790 Offset: 0xE69190 VA: 0x180E6A790
	|-ContractUtils.RequiresNotNullItems<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2001380 Offset: 0x1FFFD80 VA: 0x182001380
	private static string GetParamName(string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6A690 Offset: 0xE69090 VA: 0x180E6A690
	|-ContractUtils.RequiresArrayRange<KeyValuePair<object, object>>
	|-ContractUtils.RequiresArrayRange<object>
	|-ContractUtils.RequiresArrayRange<__Il2CppFullySharedGenericType>
	*/
}
