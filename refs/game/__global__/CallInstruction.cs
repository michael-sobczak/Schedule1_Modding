internal abstract class CallInstruction : Instruction // TypeDefIndex: 15246
{
	// Properties
	public abstract int ArgumentCount { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ArgumentCount();

	// RVA: 0x1FA6780 Offset: 0x1FA5180 VA: 0x181FA6780 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FA5E90 Offset: 0x1FA4890 VA: 0x181FA5E90
	public static CallInstruction Create(MethodInfo info) { }

	// RVA: 0x1FA5EF0 Offset: 0x1FA48F0 VA: 0x181FA5EF0
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	// RVA: 0x1FA60A0 Offset: 0x1FA4AA0 VA: 0x181FA60A0
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	// RVA: 0x1FA5DF0 Offset: 0x1FA47F0 VA: 0x181FA5DF0
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	// RVA: 0x1FA5E20 Offset: 0x1FA4820 VA: 0x181FA5E20
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	// RVA: 0x1FA5E50 Offset: 0x1FA4850 VA: 0x181FA5E50
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	// RVA: 0x1F82CD0 Offset: 0x1F816D0 VA: 0x181F82CD0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FA6620 Offset: 0x1FA5020 VA: 0x181FA6620
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

	// RVA: 0x1FA65C0 Offset: 0x1FA4FC0 VA: 0x181FA65C0
	protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	protected void .ctor() { }
}
