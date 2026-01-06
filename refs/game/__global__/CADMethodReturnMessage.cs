internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 4374
{
	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x1B27E40 Offset: 0x1B26840 VA: 0x181B27E40
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x1B28150 Offset: 0x1B26B50 VA: 0x181B28150
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x1B27ED0 Offset: 0x1B268D0 VA: 0x181B27ED0
	internal ArrayList GetArguments() { }

	// RVA: 0x1B27010 Offset: 0x1B25A10 VA: 0x181B27010
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x1B28140 Offset: 0x1B26B40 VA: 0x181B28140
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x1B28090 Offset: 0x1B26A90 VA: 0x181B28090
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	internal int get_PropertiesCount() { }
}
