public abstract class InputBindingComposite // TypeDefIndex: 7318
{
	// Fields
	internal static TypeTable s_Composites; // 0x0

	// Properties
	public abstract Type valueType { get; }
	public abstract int valueSizeInBytes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_valueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_valueSizeInBytes();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract object ReadValueAsObject(ref InputBindingCompositeContext context);

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 8
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x2250F40 Offset: 0x224F940 VA: 0x182250F40
	internal void CallFinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x2775100 Offset: 0x2773B00 VA: 0x182775100
	internal static Type GetValueType(string composite) { }

	// RVA: 0x2774ED0 Offset: 0x27738D0 VA: 0x182774ED0
	public static string GetExpectedControlLayoutName(string composite, string part) { }

	[IteratorStateMachine(typeof(InputBindingComposite.<GetPartNames>d__12))]
	// RVA: 0x2775080 Offset: 0x2773A80 VA: 0x182775080
	internal static IEnumerable<string> GetPartNames(string composite) { }

	// RVA: 0x2774DD0 Offset: 0x27737D0 VA: 0x182774DD0
	internal static string GetDisplayFormatString(string composite) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
