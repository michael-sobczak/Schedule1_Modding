internal static class TaskToApm // TypeDefIndex: 17679
{
	// Methods

	// RVA: 0x2171B40 Offset: 0x2170540 VA: 0x182171B40
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x2171D30 Offset: 0x2170730 VA: 0x182171D30
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5D4B0 Offset: 0xF5BEB0 VA: 0x180F5D4B0
	|-TaskToApm.End<int>
	|
	|-RVA: 0xF5D330 Offset: 0xF5BD30 VA: 0x180F5D330
	|-TaskToApm.End<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2171E20 Offset: 0x2170820 VA: 0x182171E20
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }
}
