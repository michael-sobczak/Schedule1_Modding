internal class CADMessageBase // TypeDefIndex: 4372
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x1B26ED0 Offset: 0x1B258D0 VA: 0x181B26ED0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x1B24F10 Offset: 0x1B23910 VA: 0x181B24F10
	internal MethodBase GetMethod() { }

	// RVA: 0x1B25080 Offset: 0x1B23A80 VA: 0x181B25080
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x1B25950 Offset: 0x1B24350 VA: 0x181B25950
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x1B26D50 Offset: 0x1B25750 VA: 0x181B26D50
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x1B252A0 Offset: 0x1B23CA0 VA: 0x181B252A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x1B25460 Offset: 0x1B23E60 VA: 0x181B25460
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x1B26000 Offset: 0x1B24A00 VA: 0x181B26000
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x1B25800 Offset: 0x1B24200 VA: 0x181B25800
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x1B26C00 Offset: 0x1B25600 VA: 0x181B26C00
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x1B25E30 Offset: 0x1B24830 VA: 0x181B25E30
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x1B24E80 Offset: 0x1B23880 VA: 0x181B24E80
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}
