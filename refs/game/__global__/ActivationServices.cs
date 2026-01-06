internal class ActivationServices // TypeDefIndex: 4346
{
	// Fields
	private static IActivator _constructionActivator; // 0x0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0x1B24360 Offset: 0x1B22D60 VA: 0x181B24360
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0x1B233A0 Offset: 0x1B21DA0 VA: 0x181B233A0
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0x1B242A0 Offset: 0x1B22CA0 VA: 0x181B242A0
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0x1B23570 Offset: 0x1B21F70 VA: 0x181B23570
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x1B23E20 Offset: 0x1B22820 VA: 0x181B23E20
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0x1B24150 Offset: 0x1B22B50 VA: 0x181B24150
	public static object CreateProxyForType(Type type) { }

	// RVA: 0x1B23560 Offset: 0x1B21F60 VA: 0x181B23560
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0x1B24290 Offset: 0x1B22C90 VA: 0x181B24290
	public static void EnableProxyActivation(Type type, bool enable) { }
}
