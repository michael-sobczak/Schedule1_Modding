public sealed class InputAction : ICloneable, IDisposable // TypeDefIndex: 7260
{
	// Fields
	private static readonly ProfilerMarker k_InputActionEnableProfilerMarker; // 0x0
	private static readonly ProfilerMarker k_InputActionDisableProfilerMarker; // 0x8
	[Tooltip("Human readable name of the action. Must be unique within its action map (case is ignored). Can be changed without breaking references to the action.")]
	[SerializeField]
	internal string m_Name; // 0x10
	[SerializeField]
	[Tooltip("Determines how the action triggers.

A Value action will start and perform when a control moves from its default value and then perform on every value change. It will cancel when controls go back to default value. Also, when enabled, a Value action will respond right away to a control's current value.

A Button action will start when a button is pressed and perform when the press threshold (see 'Default Button Press Point' in settings) is reached. It will cancel when the button is going below the release threshold (see 'Button Release Threshold' in settings). Also, if a button is already pressed when the action is enabled, the button has to be released first.

A Pass-Through action will not explicitly start and will never cancel. Instead, for every value change on any bound control, the action will perform.")]
	internal InputActionType m_Type; // 0x18
	[FormerlySerializedAs("m_ExpectedControlLayout")]
	[Tooltip("The type of control expected by the action (e.g. "Button" or "Stick"). This will limit the controls shown when setting up bindings in the UI and will also limit which controls can be bound interactively to the action.")]
	[SerializeField]
	internal string m_ExpectedControlType; // 0x20
	[Tooltip("Unique ID of the action (GUID). Used to reference the action from bindings such that actions can be renamed without breaking references.")]
	[SerializeField]
	internal string m_Id; // 0x28
	[SerializeField]
	internal string m_Processors; // 0x30
	[SerializeField]
	internal string m_Interactions; // 0x38
	[SerializeField]
	internal InputBinding[] m_SingletonActionBindings; // 0x40
	[SerializeField]
	internal InputAction.ActionFlags m_Flags; // 0x48
	internal Nullable<InputBinding> m_BindingMask; // 0x50
	internal int m_BindingsStartIndex; // 0xB0
	internal int m_BindingsCount; // 0xB4
	internal int m_ControlStartIndex; // 0xB8
	internal int m_ControlCount; // 0xBC
	internal int m_ActionIndexInState; // 0xC0
	internal InputActionMap m_ActionMap; // 0xC8
	internal CallbackArray<Action<InputAction.CallbackContext>> m_OnStarted; // 0xD0
	internal CallbackArray<Action<InputAction.CallbackContext>> m_OnCanceled; // 0x120
	internal CallbackArray<Action<InputAction.CallbackContext>> m_OnPerformed; // 0x170

	// Properties
	public string name { get; }
	public InputActionType type { get; }
	public Guid id { get; }
	internal Guid idDontGenerate { get; }
	public string expectedControlType { get; set; }
	public string processors { get; }
	public string interactions { get; }
	public InputActionMap actionMap { get; }
	public Nullable<InputBinding> bindingMask { get; set; }
	public ReadOnlyArray<InputBinding> bindings { get; }
	public ReadOnlyArray<InputControl> controls { get; }
	public InputActionPhase phase { get; }
	public bool inProgress { get; }
	public bool enabled { get; }
	public bool triggered { get; }
	public InputControl activeControl { get; }
	public Type activeValueType { get; }
	public bool wantsInitialStateCheck { get; set; }
	internal bool isSingletonAction { get; }
	private InputActionState.TriggerState currentState { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_name() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public InputActionType get_type() { }

	// RVA: 0x2759D90 Offset: 0x2758790 VA: 0x182759D90
	public Guid get_id() { }

	// RVA: 0x2759D40 Offset: 0x2758740 VA: 0x182759D40
	internal Guid get_idDontGenerate() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_expectedControlType() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_expectedControlType(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_processors() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_interactions() { }

	// RVA: 0x2759950 Offset: 0x2758350 VA: 0x182759950
	public InputActionMap get_actionMap() { }

	// RVA: 0x2759A70 Offset: 0x2758470 VA: 0x182759A70
	public Nullable<InputBinding> get_bindingMask() { }

	// RVA: 0x2759FF0 Offset: 0x27589F0 VA: 0x182759FF0
	public void set_bindingMask(Nullable<InputBinding> value) { }

	// RVA: 0x2759AB0 Offset: 0x27584B0 VA: 0x182759AB0
	public ReadOnlyArray<InputBinding> get_bindings() { }

	// RVA: 0x2759B70 Offset: 0x2758570 VA: 0x182759B70
	public ReadOnlyArray<InputControl> get_controls() { }

	// RVA: 0x2759E90 Offset: 0x2758890 VA: 0x182759E90
	public InputActionPhase get_phase() { }

	// RVA: 0x2759E10 Offset: 0x2758810 VA: 0x182759E10
	public bool get_inProgress() { }

	// RVA: 0x2759CE0 Offset: 0x27586E0 VA: 0x182759CE0
	public bool get_enabled() { }

	// RVA: 0x2759900 Offset: 0x2758300 VA: 0x182759900
	public void add_started(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x2759FA0 Offset: 0x27589A0 VA: 0x182759FA0
	public void remove_started(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x2759860 Offset: 0x2758260 VA: 0x182759860
	public void add_canceled(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x2759F00 Offset: 0x2758900 VA: 0x182759F00
	public void remove_canceled(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x27598B0 Offset: 0x27582B0 VA: 0x1827598B0
	public void add_performed(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x2759F50 Offset: 0x2758950 VA: 0x182759F50
	public void remove_performed(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x27592B0 Offset: 0x2757CB0 VA: 0x1827592B0
	public bool get_triggered() { }

	// RVA: 0x2759970 Offset: 0x2758370 VA: 0x182759970
	public InputControl get_activeControl() { }

	// RVA: 0x27599F0 Offset: 0x27583F0 VA: 0x1827599F0
	public Type get_activeValueType() { }

	// RVA: 0x2759EF0 Offset: 0x27588F0 VA: 0x182759EF0
	public bool get_wantsInitialStateCheck() { }

	// RVA: 0x275A2C0 Offset: 0x2758CC0 VA: 0x18275A2C0
	public void set_wantsInitialStateCheck(bool value) { }

	// RVA: 0x27595E0 Offset: 0x2757FE0 VA: 0x1827595E0
	public void .ctor() { }

	// RVA: 0x2759640 Offset: 0x2758040 VA: 0x182759640
	public void .ctor(string name, InputActionType type = 0, string binding, string interactions, string processors, string expectedControlType) { }

	// RVA: 0x27584C0 Offset: 0x2756EC0 VA: 0x1827584C0 Slot: 5
	public void Dispose() { }

	// RVA: 0x2758E10 Offset: 0x2757810 VA: 0x182758E10 Slot: 3
	public override string ToString() { }

	// RVA: 0x27584E0 Offset: 0x2756EE0 VA: 0x1827584E0
	public void Enable() { }

	// RVA: 0x2758310 Offset: 0x2756D10 VA: 0x182758310
	public void Disable() { }

	// RVA: 0x2758090 Offset: 0x2756A90 VA: 0x182758090
	public InputAction Clone() { }

	// RVA: 0x2758090 Offset: 0x2756A90 VA: 0x182758090 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1
	public TValue ReadValue<TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED00A0 Offset: 0xECEAA0 VA: 0x180ED00A0
	|-InputAction.ReadValue<int>
	|
	|-RVA: 0xED0190 Offset: 0xECEB90 VA: 0x180ED0190
	|-InputAction.ReadValue<Quaternion>
	|
	|-RVA: 0xED02B0 Offset: 0xECECB0 VA: 0x180ED02B0
	|-InputAction.ReadValue<float>
	|
	|-RVA: 0xED03A0 Offset: 0xECEDA0 VA: 0x180ED03A0
	|-InputAction.ReadValue<Vector2>
	|
	|-RVA: 0xED04A0 Offset: 0xECEEA0 VA: 0x180ED04A0
	|-InputAction.ReadValue<Vector3>
	|
	|-RVA: 0xECFE70 Offset: 0xECE870 VA: 0x180ECFE70
	|-InputAction.ReadValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2758C90 Offset: 0x2757690 VA: 0x182758C90
	public object ReadValueAsObject() { }

	// RVA: 0x27588A0 Offset: 0x27572A0 VA: 0x1827588A0
	public float GetControlMagnitude() { }

	// RVA: 0x2758D70 Offset: 0x2757770 VA: 0x182758D70
	public void Reset() { }

	// RVA: 0x2758BE0 Offset: 0x27575E0 VA: 0x182758BE0
	public bool IsPressed() { }

	// RVA: 0x2758B90 Offset: 0x2757590 VA: 0x182758B90
	public bool IsInProgress() { }

	// RVA: 0x27586B0 Offset: 0x27570B0 VA: 0x1827586B0
	private int ExpectedFrame() { }

	// RVA: 0x27593B0 Offset: 0x2757DB0 VA: 0x1827593B0
	public bool WasPressedThisFrame() { }

	// RVA: 0x2759340 Offset: 0x2757D40 VA: 0x182759340
	public bool WasPressedThisDynamicUpdate() { }

	// RVA: 0x27594B0 Offset: 0x2757EB0 VA: 0x1827594B0
	public bool WasReleasedThisFrame() { }

	// RVA: 0x2759440 Offset: 0x2757E40 VA: 0x182759440
	public bool WasReleasedThisDynamicUpdate() { }

	// RVA: 0x27592B0 Offset: 0x2757CB0 VA: 0x1827592B0
	public bool WasPerformedThisFrame() { }

	// RVA: 0x2759240 Offset: 0x2757C40 VA: 0x182759240
	public bool WasPerformedThisDynamicUpdate() { }

	// RVA: 0x27591B0 Offset: 0x2757BB0 VA: 0x1827591B0
	public bool WasCompletedThisFrame() { }

	// RVA: 0x2759140 Offset: 0x2757B40 VA: 0x182759140
	public bool WasCompletedThisDynamicUpdate() { }

	// RVA: 0x2758A00 Offset: 0x2757400 VA: 0x182758A00
	public float GetTimeoutCompletionPercentage() { }

	// RVA: 0x2759E70 Offset: 0x2758870 VA: 0x182759E70
	internal bool get_isSingletonAction() { }

	// RVA: 0x2759C50 Offset: 0x2758650 VA: 0x182759C50
	private InputActionState.TriggerState get_currentState() { }

	// RVA: 0x2758C30 Offset: 0x2757630 VA: 0x182758C30
	internal string MakeSureIdIsInPlace() { }

	// RVA: 0x2758850 Offset: 0x2757250 VA: 0x182758850
	internal void GenerateId() { }

	// RVA: 0x2758900 Offset: 0x2757300 VA: 0x182758900
	internal InputActionMap GetOrCreateActionMap() { }

	// RVA: 0x2758220 Offset: 0x2756C20 VA: 0x182758220
	private void CreateInternalActionMapForSingletonAction() { }

	// RVA: 0x2758D30 Offset: 0x2757730 VA: 0x182758D30
	internal void RequestInitialStateCheckOnEnabledAction() { }

	// RVA: 0x2757CA0 Offset: 0x27566A0 VA: 0x182757CA0
	internal bool ActiveControlIsValid(InputControl control) { }

	// RVA: 0x2758720 Offset: 0x2757120 VA: 0x182758720
	internal Nullable<InputBinding> FindEffectiveBindingMask() { }

	// RVA: 0x2757E20 Offset: 0x2756820 VA: 0x182757E20
	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	// RVA: 0x2757FC0 Offset: 0x27569C0 VA: 0x182757FC0
	internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) { }

	// RVA: 0x2759540 Offset: 0x2757F40 VA: 0x182759540
	private static void .cctor() { }
}
