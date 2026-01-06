public struct InputBindingCompositeContext // TypeDefIndex: 7323
{
	// Fields
	internal InputActionState m_State; // 0x0
	internal int m_BindingIndex; // 0x8

	// Properties
	public IEnumerable<InputBindingCompositeContext.PartBinding> controls { get; }

	// Methods

	[IteratorStateMachine(typeof(InputBindingCompositeContext.<get_controls>d__2))]
	// RVA: 0x2799AF0 Offset: 0x27984F0 VA: 0x182799AF0
	public IEnumerable<InputBindingCompositeContext.PartBinding> get_controls() { }

	// RVA: 0x2799990 Offset: 0x2798390 VA: 0x182799990
	public float EvaluateMagnitude(int partNumber) { }

	// RVA: -1 Offset: -1
	public TValue ReadValue<TValue>(int partNumber) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED12A0 Offset: 0xECFCA0 VA: 0x180ED12A0
	|-InputBindingCompositeContext.ReadValue<float>
	|
	|-RVA: 0xED0EF0 Offset: 0xECF8F0 VA: 0x180ED0EF0
	|-InputBindingCompositeContext.ReadValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public TValue ReadValue<TValue>(int partNumber, out InputControl sourceControl) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED1040 Offset: 0xECFA40 VA: 0x180ED1040
	|-InputBindingCompositeContext.ReadValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public TValue ReadValue<TValue, TComparer>(int partNumber, TComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED0D30 Offset: 0xECF730 VA: 0x180ED0D30
	|-InputBindingCompositeContext.ReadValue<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public TValue ReadValue<TValue, TComparer>(int partNumber, out InputControl sourceControl, TComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED0A60 Offset: 0xECF460 VA: 0x180ED0A60
	|-InputBindingCompositeContext.ReadValue<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x27999F0 Offset: 0x27983F0 VA: 0x1827999F0
	public bool ReadValueAsButton(int partNumber) { }

	// RVA: 0x2799AC0 Offset: 0x27984C0 VA: 0x182799AC0
	public void ReadValue(int partNumber, void* buffer, int bufferSize) { }

	// RVA: 0x2799A90 Offset: 0x2798490 VA: 0x182799A90
	public object ReadValueAsObject(int partNumber) { }

	// RVA: 0x27999C0 Offset: 0x27983C0 VA: 0x1827999C0
	public double GetPressTime(int partNumber) { }
}
