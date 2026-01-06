public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 4403
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x1B3F770 Offset: 0x1B3E170 VA: 0x181B3F770
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x1B3F690 Offset: 0x1B3E090 VA: 0x181B3F690
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x11AE000 Offset: 0x11ACA00 VA: 0x1811AE000 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x1B3F880 Offset: 0x1B3E280 VA: 0x181B3F880 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x1B3F8F0 Offset: 0x1B3E2F0 VA: 0x181B3F8F0 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x1B3F950 Offset: 0x1B3E350 VA: 0x181B3F950 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x1B3FB80 Offset: 0x1B3E580 VA: 0x181B3FB80 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x1B3FBF0 Offset: 0x1B3E5F0 VA: 0x181B3FBF0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Uri(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1B3F660 Offset: 0x1B3E060 VA: 0x181B3F660 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x1B3FAC0 Offset: 0x1B3E4C0 VA: 0x181B3FAC0 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}
