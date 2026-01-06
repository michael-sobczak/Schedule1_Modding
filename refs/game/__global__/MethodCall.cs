public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 4391
{
	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x1B2C920 Offset: 0x1B2B320 VA: 0x181B2C920
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B362B0 Offset: 0x1B34CB0 VA: 0x181B362B0
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1B35020 Offset: 0x1B33A20 VA: 0x181B35020
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x1B356A0 Offset: 0x1B340A0 VA: 0x181B356A0 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x1B35200 Offset: 0x1B33C00 VA: 0x181B35200 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B365F0 Offset: 0x1B34FF0 VA: 0x181B365F0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x1B36680 Offset: 0x1B35080 VA: 0x181B36680 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x1B366F0 Offset: 0x1B350F0 VA: 0x181B366F0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1B36720 Offset: 0x1B35120 VA: 0x181B36720 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x1B36770 Offset: 0x1B35170 VA: 0x181B36770 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1B2CBA0 Offset: 0x1B2B5A0 VA: 0x181B2CBA0 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x1B355F0 Offset: 0x1B33FF0 VA: 0x181B355F0 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x1B368E0 Offset: 0x1B352E0 VA: 0x181B368E0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Uri(string value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0xB25690 Offset: 0xB24090 VA: 0x180B25690 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 23
	public virtual void Init() { }

	// RVA: 0x1B35B90 Offset: 0x1B34590 VA: 0x181B35B90
	public void ResolveMethod() { }

	// RVA: 0x1B34E10 Offset: 0x1B33810 VA: 0x181B34E10
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x1B35560 Offset: 0x1B33F60 VA: 0x181B35560
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x1B36610 Offset: 0x1B35010 VA: 0x181B36610
	private Type[] get_GenericArguments() { }
}
