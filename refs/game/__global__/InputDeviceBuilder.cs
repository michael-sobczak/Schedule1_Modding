internal struct InputDeviceBuilder : IDisposable // TypeDefIndex: 7760
{
	// Fields
	private InputDevice m_Device; // 0x0
	private InputControlLayout.CacheRefInstance m_LayoutCacheRef; // 0x8
	private Dictionary<string, InputControlLayout.ControlItem> m_ChildControlOverrides; // 0x10
	private List<uint> m_StateOffsetToControlMap; // 0x18
	private StringBuilder m_StringBuilder; // 0x20
	private const uint kSizeForControlUsingStateFromOtherControl = 4294967295;
	private static InputDeviceBuilder s_Instance; // 0x0
	private static int s_InstanceRef; // 0x28

	// Properties
	internal static InputDeviceBuilder instance { get; }

	// Methods

	// RVA: 0x2781F80 Offset: 0x2780980 VA: 0x182781F80
	public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription) { }

	// RVA: 0x277FC20 Offset: 0x277E620 VA: 0x18277FC20
	public InputDevice Finish() { }

	// RVA: 0x277F370 Offset: 0x277DD70 VA: 0x18277F370 Slot: 4
	public void Dispose() { }

	// RVA: 0x2781AD0 Offset: 0x27804D0 VA: 0x182781AD0
	private void Reset() { }

	// RVA: 0x2781990 Offset: 0x2780390 VA: 0x182781990
	private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x2781180 Offset: 0x277FB80 VA: 0x182781180
	private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) { }

	// RVA: 0x277D7D0 Offset: 0x277C1D0 VA: 0x18277D7D0
	private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls) { }

	// RVA: 0x277CBB0 Offset: 0x277B5B0 VA: 0x18277CBB0
	private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride) { }

	// RVA: 0x2780540 Offset: 0x277EF40 VA: 0x182780540
	private void InsertChildControlOverride(InputControl parent, ref InputControlLayout.ControlItem controlItem) { }

	// RVA: 0x277EA60 Offset: 0x277D460 VA: 0x18277EA60
	private string ChildControlOverridePath(InputControl parent, InternedString controlName) { }

	// RVA: 0x277CAB0 Offset: 0x277B4B0 VA: 0x18277CAB0
	private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem) { }

	// RVA: 0x2780910 Offset: 0x277F310 VA: 0x182780910
	private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem) { }

	// RVA: 0x277E810 Offset: 0x277D210 VA: 0x18277E810
	private static void ApplyUseStateFrom(InputControl parent, ref InputControlLayout.ControlItem controlItem, InputControlLayout layout) { }

	// RVA: 0x2782190 Offset: 0x2780B90 VA: 0x182782190
	private static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl) { }

	// RVA: 0x2781B40 Offset: 0x2780540 VA: 0x182781B40
	private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) { }

	// RVA: 0x277E500 Offset: 0x277CF00 VA: 0x18277E500
	private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) { }

	// RVA: 0x277E5B0 Offset: 0x277CFB0 VA: 0x18277E5B0
	private static void AddProcessors(InputControl control, ref InputControlLayout.ControlItem controlItem, string layoutName) { }

	// RVA: 0x2781ED0 Offset: 0x27808D0 VA: 0x182781ED0
	private static void SetFormat(InputControl control, InputControlLayout.ControlItem controlItem) { }

	// RVA: 0x277FBC0 Offset: 0x277E5C0 VA: 0x18277FBC0
	private static InputControlLayout FindOrLoadLayout(string name) { }

	// RVA: 0x277EAE0 Offset: 0x277D4E0 VA: 0x18277EAE0
	private static void ComputeStateLayout(InputControl control) { }

	// RVA: 0x277F8F0 Offset: 0x277E2F0 VA: 0x18277F8F0
	private void FinalizeControlHierarchy() { }

	// RVA: 0x277F380 Offset: 0x277DD80 VA: 0x18277F380
	private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex) { }

	// RVA: 0x2780DE0 Offset: 0x277F7E0 VA: 0x182780DE0
	private void InsertControlBitRangeNode(ref InputDevice.ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset) { }

	// RVA: 0x277FED0 Offset: 0x277E8D0 VA: 0x18277FED0
	private ushort GetBestMidPoint(InputDevice.ControlBitRangeNode parent, ushort startOffset) { }

	// RVA: 0x277E380 Offset: 0x277CD80 VA: 0x18277E380
	private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex) { }

	// RVA: 0x277E250 Offset: 0x277CC50 VA: 0x18277E250
	private void AddChildren(ref InputDevice.ControlBitRangeNode parent, InputDevice.ControlBitRangeNode left, InputDevice.ControlBitRangeNode right) { }

	// RVA: 0x2780470 Offset: 0x277EE70 VA: 0x182780470
	private ushort GetControlIndex(InputControl control) { }

	// RVA: 0x2782210 Offset: 0x2780C10 VA: 0x182782210
	internal static ref InputDeviceBuilder get_instance() { }

	// RVA: 0x2781A90 Offset: 0x2780490 VA: 0x182781A90
	internal static InputDeviceBuilder.RefInstance Ref() { }
}
