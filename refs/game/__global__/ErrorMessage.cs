internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 4381
{
	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x1B2E8D0 Offset: 0x1B2D2D0 VA: 0x181B2E8D0
	public void .ctor() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1B2E920 Offset: 0x1B2D320 VA: 0x181B2E920 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x1B2E950 Offset: 0x1B2D350 VA: 0x181B2E950 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }
}
