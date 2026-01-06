internal class DefaultBinder : Binder // TypeDefIndex: 3808
{
	// Fields
	private static DefaultBinder.Primitives[] _primitiveConversions; // 0x0

	// Methods

	// RVA: 0x1C9B7A0 Offset: 0x1C9A1A0 VA: 0x181C9B7A0 Slot: 5
	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	// RVA: 0x1C9B080 Offset: 0x1C99A80 VA: 0x181C9B080 Slot: 4
	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	// RVA: 0x1CA0D30 Offset: 0x1C9F730 VA: 0x181CA0D30 Slot: 9
	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: 0x1C9E3F0 Offset: 0x1C9CDF0 VA: 0x181C9E3F0 Slot: 6
	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	// RVA: 0x1C9FF30 Offset: 0x1C9E930 VA: 0x181C9FF30 Slot: 7
	public override void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0x1C9E9D0 Offset: 0x1C9D3D0 VA: 0x181C9E9D0
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1C9ECA0 Offset: 0x1C9D6A0 VA: 0x181C9ECA0
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1C9FA60 Offset: 0x1C9E460 VA: 0x181C9FA60
	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0x1C9F650 Offset: 0x1C9E050 VA: 0x181C9F650
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	// RVA: 0x1C9F240 Offset: 0x1C9DC40 VA: 0x181C9F240
	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0x1C9F120 Offset: 0x1C9DB20 VA: 0x181C9F120
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	// RVA: 0x1C9F530 Offset: 0x1C9DF30 VA: 0x181C9F530
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	// RVA: 0x1C9E450 Offset: 0x1C9CE50 VA: 0x181C9E450
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	// RVA: 0x1C9FEA0 Offset: 0x1C9E8A0 VA: 0x181C9FEA0
	internal static int GetHierarchyDepth(Type t) { }

	// RVA: 0x1C9EFD0 Offset: 0x1C9D9D0 VA: 0x181C9EFD0
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	// RVA: 0x1CA02C0 Offset: 0x1C9ECC0 VA: 0x181CA02C0
	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	// RVA: 0x1C9E790 Offset: 0x1C9D190 VA: 0x181C9E790
	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	// RVA: 0x1C9E0B0 Offset: 0x1C9CAB0 VA: 0x181C9E0B0
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	// RVA: 0x1C9DFA0 Offset: 0x1C9C9A0 VA: 0x181C9DFA0
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	// RVA: 0x1C9E5F0 Offset: 0x1C9CFF0 VA: 0x181C9E5F0
	internal static bool CompareMethodSig(MethodBase m1, MethodBase m2) { }

	// RVA: 0x1CA0470 Offset: 0x1C9EE70 VA: 0x181CA0470 Slot: 8
	public sealed override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1C9DEA0 Offset: 0x1C9C8A0 VA: 0x181C9DEA0
	private static bool CanChangePrimitive(Type source, Type target) { }

	// RVA: 0x1C9E320 Offset: 0x1C9CD20 VA: 0x181C9E320
	private static bool CanPrimitiveWiden(Type source, Type target) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x1CA18F0 Offset: 0x1CA02F0 VA: 0x181CA18F0
	private static void .cctor() { }
}
