internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 4306
{
	// Fields
	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x1B16650 Offset: 0x1B15050 VA: 0x181B16650
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x1B166E0 Offset: 0x1B150E0 VA: 0x181B166E0
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x1B15F10 Offset: 0x1B14910 VA: 0x181B15F10 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x1B158C0 Offset: 0x1B142C0 VA: 0x181B158C0
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x1B157E0 Offset: 0x1B141E0 VA: 0x181B157E0
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x1B16750 Offset: 0x1B15150 VA: 0x181B16750 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x1B15BB0 Offset: 0x1B145B0 VA: 0x181B15BB0 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x1B15E30 Offset: 0x1B14830 VA: 0x181B15E30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1B16530 Offset: 0x1B14F30 VA: 0x181B16530
	private static void .cctor() { }
}
