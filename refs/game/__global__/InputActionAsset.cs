public class InputActionAsset : ScriptableObject, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable // TypeDefIndex: 7268
{
	// Fields
	public const string Extension = "inputactions";
	internal const string kDefaultAssetLayoutJson = "{}";
	[SerializeField]
	internal InputActionMap[] m_ActionMaps; // 0x18
	[SerializeField]
	internal InputControlScheme[] m_ControlSchemes; // 0x20
	[SerializeField]
	internal bool m_IsProjectWide; // 0x28
	internal InputActionState m_SharedStateForAllMaps; // 0x30
	internal Nullable<InputBinding> m_BindingMask; // 0x38
	internal int m_ParameterOverridesCount; // 0x98
	internal InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides; // 0xA0
	internal InputActionMap.DeviceArray m_Devices; // 0xA8

	// Properties
	public bool enabled { get; }
	public ReadOnlyArray<InputActionMap> actionMaps { get; }
	public ReadOnlyArray<InputControlScheme> controlSchemes { get; }
	public IEnumerable<InputBinding> bindings { get; }
	public Nullable<InputBinding> bindingMask { get; set; }
	public Nullable<ReadOnlyArray<InputDevice>> devices { get; set; }
	public InputAction Item { get; }

	// Methods

	// RVA: 0x274CBF0 Offset: 0x274B5F0 VA: 0x18274CBF0
	public bool get_enabled() { }

	// RVA: 0x274CA30 Offset: 0x274B430 VA: 0x18274CA30
	public ReadOnlyArray<InputActionMap> get_actionMaps() { }

	// RVA: 0x274CB50 Offset: 0x274B550 VA: 0x18274CB50 Slot: 11
	public ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	[IteratorStateMachine(typeof(InputActionAsset.<get_bindings>d__9))]
	// RVA: 0x274CAD0 Offset: 0x274B4D0 VA: 0x18274CAD0 Slot: 4
	public IEnumerable<InputBinding> get_bindings() { }

	// RVA: 0x274CA90 Offset: 0x274B490 VA: 0x18274CA90 Slot: 7
	public Nullable<InputBinding> get_bindingMask() { }

	// RVA: 0x274CD50 Offset: 0x274B750 VA: 0x18274CD50 Slot: 8
	public void set_bindingMask(Nullable<InputBinding> value) { }

	// RVA: 0x274CBB0 Offset: 0x274B5B0 VA: 0x18274CBB0 Slot: 9
	public Nullable<ReadOnlyArray<InputDevice>> get_devices() { }

	// RVA: 0x274CF20 Offset: 0x274B920 VA: 0x18274CF20 Slot: 10
	public void set_devices(Nullable<ReadOnlyArray<InputDevice>> value) { }

	// RVA: 0x274C9A0 Offset: 0x274B3A0 VA: 0x18274C9A0
	public InputAction get_Item(string actionNameOrId) { }

	// RVA: 0x274C880 Offset: 0x274B280 VA: 0x18274C880
	public string ToJson() { }

	// RVA: 0x274B8B0 Offset: 0x274A2B0 VA: 0x18274B8B0
	public void LoadFromJson(string json) { }

	// RVA: 0x274B340 Offset: 0x2749D40 VA: 0x18274B340
	public static InputActionAsset FromJson(string json) { }

	// RVA: 0x274AAB0 Offset: 0x27494B0 VA: 0x18274AAB0 Slot: 5
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = False) { }

	// RVA: 0x274AED0 Offset: 0x27498D0 VA: 0x18274AED0 Slot: 6
	public int FindBinding(InputBinding mask, out InputAction action) { }

	// RVA: 0x274A560 Offset: 0x2748F60 VA: 0x18274A560
	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = False) { }

	// RVA: 0x274A800 Offset: 0x2749200 VA: 0x18274A800
	public InputActionMap FindActionMap(Guid id) { }

	// RVA: 0x274A910 Offset: 0x2749310 VA: 0x18274A910
	public InputAction FindAction(Guid guid) { }

	// RVA: 0x274B010 Offset: 0x2749A10 VA: 0x18274B010
	public int FindControlSchemeIndex(string name) { }

	// RVA: 0x274B120 Offset: 0x2749B20 VA: 0x18274B120
	public Nullable<InputControlScheme> FindControlScheme(string name) { }

	// RVA: 0x274B5F0 Offset: 0x2749FF0 VA: 0x18274B5F0
	public bool IsUsableWithDevice(InputDevice device) { }

	// RVA: 0x274A3B0 Offset: 0x2748DB0 VA: 0x18274A3B0 Slot: 13
	public void Enable() { }

	// RVA: 0x274A250 Offset: 0x2748C50 VA: 0x18274A250 Slot: 14
	public void Disable() { }

	// RVA: 0x274A1C0 Offset: 0x2748BC0 VA: 0x18274A1C0 Slot: 12
	public bool Contains(InputAction action) { }

	[IteratorStateMachine(typeof(InputActionAsset.<GetEnumerator>d__33))]
	// RVA: 0x274B4B0 Offset: 0x2749EB0 VA: 0x18274B4B0 Slot: 15
	public IEnumerator<InputAction> GetEnumerator() { }

	// RVA: 0x274B4B0 Offset: 0x2749EB0 VA: 0x18274B4B0 Slot: 16
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void MarkAsDirty() { }

	// RVA: 0x274B520 Offset: 0x2749F20 VA: 0x18274B520
	internal bool IsEmpty() { }

	// RVA: 0x274C720 Offset: 0x274B120 VA: 0x18274C720
	internal void OnWantToChangeSetup() { }

	// RVA: 0x274C690 Offset: 0x274B090 VA: 0x18274C690
	internal void OnSetupChanged() { }

	// RVA: 0x274C790 Offset: 0x274B190 VA: 0x18274C790
	private void ReResolveIfNecessary(bool fullResolve) { }

	// RVA: 0x274C7D0 Offset: 0x274B1D0 VA: 0x18274C7D0
	internal void ResolveBindingsIfNecessary() { }

	// RVA: 0x274C650 Offset: 0x274B050 VA: 0x18274C650
	private void OnDestroy() { }

	// RVA: 0x274B990 Offset: 0x274A390 VA: 0x18274B990
	internal void MigrateJson(ref InputActionAsset.ReadFileJson parsedJson) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }
}
