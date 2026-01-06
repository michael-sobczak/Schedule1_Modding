internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 4397
{
	// Fields
	private RuntimeMethodInfo method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Identity identity; // 0x68
	private Type[] methodSignature; // 0x70

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x1B382B0 Offset: 0x1B36CB0 VA: 0x181B382B0
	internal void InitMessage(RuntimeMethodInfo method, object[] out_args) { }

	// RVA: 0x1B389D0 Offset: 0x1B373D0 VA: 0x181B389D0
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x1B38870 Offset: 0x1B37270 VA: 0x181B38870
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x1B381F0 Offset: 0x1B36BF0 VA: 0x181B381F0
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x1B38670 Offset: 0x1B37070 VA: 0x181B38670
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x1B38FB0 Offset: 0x1B379B0 VA: 0x181B38FB0 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x1B38AA0 Offset: 0x1B374A0 VA: 0x181B38AA0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1B38BA0 Offset: 0x1B375A0 VA: 0x181B38BA0 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x1B38C20 Offset: 0x1B37620 VA: 0x181B38C20 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1B39020 Offset: 0x1B37A20 VA: 0x181B39020 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 19
	public string get_Uri() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x1B381C0 Offset: 0x1B36BC0 VA: 0x181B381C0 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x1B38D80 Offset: 0x1B37780 VA: 0x181B38D80 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x1B38DE0 Offset: 0x1B377E0 VA: 0x181B38DE0 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x1B38B30 Offset: 0x1B37530 VA: 0x181B38B30
	internal CallType get_CallType() { }

	// RVA: 0x1B385F0 Offset: 0x1B36FF0 VA: 0x181B385F0
	public bool NeedsOutProcessing(out int outCount) { }
}
