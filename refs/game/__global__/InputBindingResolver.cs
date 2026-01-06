internal struct InputBindingResolver : IDisposable // TypeDefIndex: 7324
{
	// Fields
	public int totalProcessorCount; // 0x0
	public int totalCompositeCount; // 0x4
	public int totalInteractionCount; // 0x8
	public InputActionMap[] maps; // 0x10
	public InputControl[] controls; // 0x18
	public InputActionState.UnmanagedMemory memory; // 0x20
	public IInputInteraction[] interactions; // 0xA0
	public InputProcessor[] processors; // 0xA8
	public InputBindingComposite[] composites; // 0xB0
	public Nullable<InputBinding> bindingMask; // 0xB8
	private bool m_IsControlOnlyResolve; // 0x118
	private List<NameAndParameters> m_Parameters; // 0x120

	// Properties
	public int totalMapCount { get; }
	public int totalActionCount { get; }
	public int totalBindingCount { get; }
	public int totalControlCount { get; }

	// Methods

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_totalMapCount() { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_totalActionCount() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_totalBindingCount() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int get_totalControlCount() { }

	// RVA: 0x279BE00 Offset: 0x279A800 VA: 0x18279BE00 Slot: 4
	public void Dispose() { }

	// RVA: 0x279C120 Offset: 0x279AB20 VA: 0x18279C120
	public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) { }

	// RVA: 0x2799B70 Offset: 0x2798570 VA: 0x182799B70
	public void AddActionMap(InputActionMap actionMap) { }

	// RVA: -1 Offset: -1
	private int InstantiateWithParameters<TType>(TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED19D0 Offset: 0xED03D0 VA: 0x180ED19D0
	|-InputBindingResolver.InstantiateWithParameters<object>
	|
	|-RVA: 0xED1330 Offset: 0xECFD30 VA: 0x180ED1330
	|-InputBindingResolver.InstantiateWithParameters<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x279BE10 Offset: 0x279A810 VA: 0x18279BE10
	private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap) { }

	// RVA: 0x279B5F0 Offset: 0x2799FF0 VA: 0x18279B5F0
	private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters) { }

	// RVA: 0x279BB70 Offset: 0x279A570 VA: 0x18279BB70
	private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount) { }
}
