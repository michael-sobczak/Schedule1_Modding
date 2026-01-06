public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable // TypeDefIndex: 7281
{
	// Fields
	private static readonly ProfilerMarker k_ResolveBindingsProfilerMarker; // 0x0
	[SerializeField]
	internal string m_Name; // 0x10
	[SerializeField]
	internal string m_Id; // 0x18
	[SerializeField]
	internal InputActionAsset m_Asset; // 0x20
	[SerializeField]
	internal InputAction[] m_Actions; // 0x28
	[SerializeField]
	internal InputBinding[] m_Bindings; // 0x30
	private InputBinding[] m_BindingsForEachAction; // 0x38
	private InputControl[] m_ControlsForEachAction; // 0x40
	internal int m_EnabledActionsCount; // 0x48
	internal InputAction m_SingletonAction; // 0x50
	internal int m_MapIndexInState; // 0x58
	internal InputActionState m_State; // 0x60
	internal Nullable<InputBinding> m_BindingMask; // 0x68
	private InputActionMap.Flags m_Flags; // 0xC8
	internal int m_ParameterOverridesCount; // 0xCC
	internal InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides; // 0xD0
	internal InputActionMap.DeviceArray m_Devices; // 0xD8
	internal CallbackArray<Action<InputAction.CallbackContext>> m_ActionCallbacks; // 0xE8
	internal Dictionary<string, int> m_ActionIndexByNameOrId; // 0x138
	internal static int s_DeferBindingResolution; // 0x8
	internal static bool s_NeedToResolveBindings; // 0xC

	// Properties
	public string name { get; }
	public InputActionAsset asset { get; }
	public Guid id { get; }
	internal Guid idDontGenerate { get; }
	public bool enabled { get; }
	public ReadOnlyArray<InputAction> actions { get; }
	public ReadOnlyArray<InputBinding> bindings { get; }
	private IEnumerable<InputBinding> UnityEngine.InputSystem.IInputActionCollection2.bindings { get; }
	public ReadOnlyArray<InputControlScheme> controlSchemes { get; }
	public Nullable<InputBinding> bindingMask { get; set; }
	public Nullable<ReadOnlyArray<InputDevice>> devices { get; set; }
	public InputAction Item { get; }
	private bool needToResolveBindings { get; set; }
	private bool bindingResolutionNeedsFullReResolve { get; set; }
	private bool controlsForEachActionInitialized { get; set; }
	private bool bindingsForEachActionInitialized { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_name() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public InputActionAsset get_asset() { }

	// RVA: 0x2750EB0 Offset: 0x274F8B0 VA: 0x182750EB0
	public Guid get_id() { }

	// RVA: 0x2750E60 Offset: 0x274F860 VA: 0x182750E60
	internal Guid get_idDontGenerate() { }

	// RVA: 0x2078150 Offset: 0x2076B50 VA: 0x182078150
	public bool get_enabled() { }

	// RVA: 0x2750B90 Offset: 0x274F590 VA: 0x182750B90
	public ReadOnlyArray<InputAction> get_actions() { }

	// RVA: 0x2750C50 Offset: 0x274F650 VA: 0x182750C50
	public ReadOnlyArray<InputBinding> get_bindings() { }

	// RVA: 0x2750890 Offset: 0x274F290 VA: 0x182750890 Slot: 7
	private IEnumerable<InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings() { }

	// RVA: 0x2750CB0 Offset: 0x274F6B0 VA: 0x182750CB0 Slot: 14
	public ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	// RVA: 0x2750BF0 Offset: 0x274F5F0 VA: 0x182750BF0 Slot: 10
	public Nullable<InputBinding> get_bindingMask() { }

	// RVA: 0x2750F90 Offset: 0x274F990 VA: 0x182750F90 Slot: 11
	public void set_bindingMask(Nullable<InputBinding> value) { }

	// RVA: 0x2750D90 Offset: 0x274F790 VA: 0x182750D90 Slot: 12
	public Nullable<ReadOnlyArray<InputDevice>> get_devices() { }

	// RVA: 0x27511B0 Offset: 0x274FBB0 VA: 0x1827511B0 Slot: 13
	public void set_devices(Nullable<ReadOnlyArray<InputDevice>> value) { }

	// RVA: 0x2750A80 Offset: 0x274F480 VA: 0x182750A80
	public InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x2750A30 Offset: 0x274F430 VA: 0x182750A30
	public void add_actionTriggered(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x2750F40 Offset: 0x274F940 VA: 0x182750F40
	public void remove_actionTriggered(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x2750970 Offset: 0x274F370 VA: 0x182750970
	public void .ctor() { }

	// RVA: 0x27509F0 Offset: 0x274F3F0 VA: 0x1827509F0
	public void .ctor(string name) { }

	// RVA: 0x274D3C0 Offset: 0x274BDC0 VA: 0x18274D3C0 Slot: 20
	public void Dispose() { }

	// RVA: 0x274D450 Offset: 0x274BE50 VA: 0x18274D450
	internal int FindActionIndex(string nameOrId) { }

	// RVA: 0x274F970 Offset: 0x274E370 VA: 0x18274F970
	private void SetUpActionLookupTable() { }

	// RVA: 0x274CFA0 Offset: 0x274B9A0 VA: 0x18274CFA0
	internal void ClearActionLookupTable() { }

	// RVA: 0x274D810 Offset: 0x274C210 VA: 0x18274D810
	private int FindActionIndex(Guid id) { }

	// RVA: 0x274DA60 Offset: 0x274C460 VA: 0x18274DA60 Slot: 8
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = False) { }

	// RVA: 0x274D930 Offset: 0x274C330 VA: 0x18274D930
	public InputAction FindAction(Guid id) { }

	// RVA: 0x274E1A0 Offset: 0x274CBA0 VA: 0x18274E1A0
	public bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x274D3E0 Offset: 0x274BDE0 VA: 0x18274D3E0 Slot: 16
	public void Enable() { }

	// RVA: 0x274D390 Offset: 0x274BD90 VA: 0x18274D390 Slot: 17
	public void Disable() { }

	// RVA: 0x274D050 Offset: 0x274BA50 VA: 0x18274D050
	public InputActionMap Clone() { }

	// RVA: 0x2750630 Offset: 0x274F030 VA: 0x182750630 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x274D360 Offset: 0x274BD60 VA: 0x18274D360 Slot: 15
	public bool Contains(InputAction action) { }

	// RVA: 0x27507D0 Offset: 0x274F1D0 VA: 0x1827507D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x274E0E0 Offset: 0x274CAE0 VA: 0x18274E0E0 Slot: 18
	public IEnumerator<InputAction> GetEnumerator() { }

	// RVA: 0x274E0E0 Offset: 0x274CAE0 VA: 0x18274E0E0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2750F30 Offset: 0x274F930 VA: 0x182750F30
	private bool get_needToResolveBindings() { }

	// RVA: 0x2751200 Offset: 0x274FC00 VA: 0x182751200
	private void set_needToResolveBindings(bool value) { }

	// RVA: 0x2750C30 Offset: 0x274F630 VA: 0x182750C30
	private bool get_bindingResolutionNeedsFullReResolve() { }

	// RVA: 0x2751150 Offset: 0x274FB50 VA: 0x182751150
	private void set_bindingResolutionNeedsFullReResolve(bool value) { }

	// RVA: 0x2750D80 Offset: 0x274F780 VA: 0x182750D80
	private bool get_controlsForEachActionInitialized() { }

	// RVA: 0x2751190 Offset: 0x274FB90 VA: 0x182751190
	private void set_controlsForEachActionInitialized(bool value) { }

	// RVA: 0x2750C40 Offset: 0x274F640 VA: 0x182750C40
	private bool get_bindingsForEachActionInitialized() { }

	// RVA: 0x2751170 Offset: 0x274FB70 VA: 0x182751170
	private void set_bindingsForEachActionInitialized(bool value) { }

	// RVA: 0x274DFA0 Offset: 0x274C9A0 VA: 0x18274DFA0
	internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action) { }

	// RVA: 0x274E040 Offset: 0x274CA40 VA: 0x18274E040
	internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action) { }

	// RVA: 0x274FB30 Offset: 0x274E530 VA: 0x18274FB30
	private void SetUpPerActionControlAndBindingArrays() { }

	// RVA: 0x274E920 Offset: 0x274D320 VA: 0x18274E920
	internal void OnWantToChangeSetup() { }

	// RVA: 0x274E610 Offset: 0x274D010 VA: 0x18274E610
	internal void OnSetupChanged() { }

	// RVA: 0x274E5A0 Offset: 0x274CFA0 VA: 0x18274E5A0
	internal void OnBindingModified() { }

	// RVA: 0x274CFF0 Offset: 0x274B9F0 VA: 0x18274CFF0
	internal void ClearCachedActionData(bool onlyControls = False) { }

	// RVA: 0x274DF50 Offset: 0x274C950 VA: 0x18274DF50
	internal void GenerateId() { }

	// RVA: 0x274E310 Offset: 0x274CD10 VA: 0x18274E310
	internal bool LazyResolveBindings(bool fullResolve) { }

	// RVA: 0x274EBB0 Offset: 0x274D5B0 VA: 0x18274EBB0
	internal bool ResolveBindingsIfNecessary() { }

	// RVA: 0x274EBF0 Offset: 0x274D5F0 VA: 0x18274EBF0
	internal void ResolveBindings() { }

	// RVA: 0x274DC40 Offset: 0x274C640 VA: 0x18274DC40 Slot: 9
	public int FindBinding(InputBinding mask, out InputAction action) { }

	// RVA: 0x274DB90 Offset: 0x274C590 VA: 0x18274DB90
	internal int FindBindingRelativeToMap(InputBinding mask) { }

	// RVA: 0x274DEA0 Offset: 0x274C8A0 VA: 0x18274DEA0
	public static InputActionMap[] FromJson(string json) { }

	// RVA: 0x2750640 Offset: 0x274F040 VA: 0x182750640
	public static string ToJson(IEnumerable<InputActionMap> maps) { }

	// RVA: 0x27506F0 Offset: 0x274F0F0 VA: 0x1827506F0
	public string ToJson() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void OnBeforeSerialize() { }

	// RVA: 0x274E410 Offset: 0x274CE10 VA: 0x18274E410 Slot: 6
	public void OnAfterDeserialize() { }

	// RVA: 0x2750910 Offset: 0x274F310 VA: 0x182750910
	private static void .cctor() { }
}
