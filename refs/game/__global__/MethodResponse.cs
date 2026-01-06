public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 4395
{
	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x1B37300 Offset: 0x1B35D00 VA: 0x181B37300
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x1B37400 Offset: 0x1B35E00 VA: 0x181B37400
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x1B374D0 Offset: 0x1B35ED0 VA: 0x181B374D0
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x1B2CD60 Offset: 0x1B2B760 VA: 0x181B2CD60
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B36D10 Offset: 0x1B35710 VA: 0x181B36D10
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x1B37910 Offset: 0x1B36310 VA: 0x181B37910 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x1B37930 Offset: 0x1B36330 VA: 0x181B37930 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x1B379A0 Offset: 0x1B363A0 VA: 0x181B379A0 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x1B37B00 Offset: 0x1B36500 VA: 0x181B37B00 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x1B37B70 Offset: 0x1B36570 VA: 0x181B37B70 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x1B37C50 Offset: 0x1B36650 VA: 0x181B37C50 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x1B2CE00 Offset: 0x1B2B800 VA: 0x181B2CE00 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x1B37E60 Offset: 0x1B36860 VA: 0x181B37E60 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x1B37290 Offset: 0x1B35C90 VA: 0x181B37290 Slot: 14
	public string get_Uri() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Uri(string value) { }

	// RVA: 0x1B37290 Offset: 0x1B35C90 VA: 0x181B37290 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1B36950 Offset: 0x1B35350 VA: 0x181B36950 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x1B36980 Offset: 0x1B35380 VA: 0x181B36980 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}
