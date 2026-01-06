internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable // TypeDefIndex: 7310
{
	// Fields
	public const int kInvalidIndex = -1;
	public InputActionMap[] maps; // 0x10
	public InputControl[] controls; // 0x18
	public IInputInteraction[] interactions; // 0x20
	public InputProcessor[] processors; // 0x28
	public InputBindingComposite[] composites; // 0x30
	public int totalProcessorCount; // 0x38
	public InputActionState.UnmanagedMemory memory; // 0x40
	private bool m_OnBeforeUpdateHooked; // 0xC0
	private bool m_OnAfterUpdateHooked; // 0xC1
	private bool m_InProcessControlStateChange; // 0xC2
	private InputEventPtr m_CurrentlyProcessingThisEvent; // 0xC8
	private Action m_OnBeforeUpdateDelegate; // 0xD0
	private Action m_OnAfterUpdateDelegate; // 0xD8
	private static readonly ProfilerMarker k_InputInitialActionStateCheckMarker; // 0x0
	private static readonly ProfilerMarker k_InputActionResolveConflictMarker; // 0x8
	private static readonly ProfilerMarker k_InputActionCallbackMarker; // 0x10
	private static readonly ProfilerMarker k_InputOnActionChangeMarker; // 0x18
	private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; // 0x20
	internal static InputActionState.GlobalState s_GlobalState; // 0x28

	// Properties
	public int totalCompositeCount { get; }
	public int totalMapCount { get; }
	public int totalActionCount { get; }
	public int totalBindingCount { get; }
	public int totalInteractionCount { get; }
	public int totalControlCount { get; }
	public InputActionState.ActionMapIndices* mapIndices { get; }
	public InputActionState.TriggerState* actionStates { get; }
	public InputActionState.BindingState* bindingStates { get; }
	public InputActionState.InteractionState* interactionStates { get; }
	public int* controlIndexToBindingIndex { get; }
	public ushort* controlGroupingAndComplexity { get; }
	public float* controlMagnitudes { get; }
	public uint* enabledControls { get; }
	public bool isProcessingControlStateChange { get; }

	// Methods

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public int get_totalCompositeCount() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_totalMapCount() { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public int get_totalActionCount() { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public int get_totalBindingCount() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_totalInteractionCount() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public int get_totalControlCount() { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public InputActionState.ActionMapIndices* get_mapIndices() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public InputActionState.TriggerState* get_actionStates() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public InputActionState.BindingState* get_bindingStates() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public InputActionState.InteractionState* get_interactionStates() { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public int* get_controlIndexToBindingIndex() { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public ushort* get_controlGroupingAndComplexity() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public float* get_controlMagnitudes() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public uint* get_enabledControls() { }

	// RVA: 0x4E8CD0 Offset: 0x4E76D0 VA: 0x1804E8CD0
	public bool get_isProcessingControlStateChange() { }

	// RVA: 0x276FAD0 Offset: 0x276E4D0 VA: 0x18276FAD0
	public void Initialize(InputBindingResolver resolver) { }

	// RVA: 0x276CEA0 Offset: 0x276B8A0 VA: 0x18276CEA0
	private void ComputeControlGroupingIfNecessary() { }

	// RVA: 0x276C9F0 Offset: 0x276B3F0 VA: 0x18276C9F0
	public void ClaimDataFrom(InputBindingResolver resolver) { }

	// RVA: 0x276EC10 Offset: 0x276D610 VA: 0x18276EC10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x276E2F0 Offset: 0x276CCF0 VA: 0x18276E2F0 Slot: 7
	public void Dispose() { }

	// RVA: 0x276D590 Offset: 0x276BF90 VA: 0x18276D590
	private void Destroy(bool isFinalizing = False) { }

	// RVA: 0x276CAD0 Offset: 0x276B4D0 VA: 0x18276CAD0
	public InputActionState Clone() { }

	// RVA: 0x276CAD0 Offset: 0x276B4D0 VA: 0x18276CAD0 Slot: 6
	private object System.ICloneable.Clone() { }

	// RVA: 0x2770800 Offset: 0x276F200 VA: 0x182770800
	private bool IsUsingDevice(InputDevice device) { }

	// RVA: 0x276BCB0 Offset: 0x276A6B0 VA: 0x18276BCB0
	private bool CanUseDevice(InputDevice device) { }

	// RVA: 0x276F960 Offset: 0x276E360 VA: 0x18276F960
	public bool HasEnabledActions() { }

	// RVA: 0x276F080 Offset: 0x276DA80 VA: 0x18276F080
	private void FinishBindingCompositeSetups() { }

	// RVA: 0x27712D0 Offset: 0x276FCD0 VA: 0x1827712D0
	internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl> activeControls, ref bool hasEnabledActions) { }

	// RVA: 0x276F160 Offset: 0x276DB60 VA: 0x18276F160
	public void FinishBindingResolution(bool hasEnabledActions, InputActionState.UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x2773B10 Offset: 0x2772510 VA: 0x182773B10
	private void RestoreActionStatesAfterReResolvingBindings(InputActionState.UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve) { }

	// RVA: 0x27700C0 Offset: 0x276EAC0 VA: 0x1827700C0
	private bool IsActiveControl(int bindingIndex, int controlIndex) { }

	// RVA: 0x276EFF0 Offset: 0x276D9F0 VA: 0x18276EFF0
	private int FindControlIndexOnBinding(int bindingIndex, InputControl control) { }

	// RVA: 0x2773650 Offset: 0x2772050 VA: 0x182773650
	private void ResetActionStatesDrivenBy(InputDevice device) { }

	// RVA: 0x276FFA0 Offset: 0x276E9A0 VA: 0x18276FFA0
	private bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex) { }

	// RVA: 0x27733C0 Offset: 0x2771DC0 VA: 0x1827733C0
	public void ResetActionState(int actionIndex, InputActionPhase toPhase = 1, bool hardReset = False) { }

	// RVA: 0x276EB90 Offset: 0x276D590 VA: 0x18276EB90
	public ref InputActionState.TriggerState FetchActionState(InputAction action) { }

	// RVA: 0x276EBC0 Offset: 0x276D5C0 VA: 0x18276EBC0
	public InputActionState.ActionMapIndices FetchMapIndices(InputActionMap map) { }

	// RVA: 0x276E300 Offset: 0x276CD00 VA: 0x18276E300
	public void EnableAllActions(InputActionMap map) { }

	// RVA: 0x276E8B0 Offset: 0x276D2B0 VA: 0x18276E8B0
	private void EnableControls(InputActionMap map) { }

	// RVA: 0x276E920 Offset: 0x276D320 VA: 0x18276E920
	public void EnableSingleAction(InputAction action) { }

	// RVA: 0x276E5A0 Offset: 0x276CFA0 VA: 0x18276E5A0
	private void EnableControls(InputAction action) { }

	// RVA: 0x276DA60 Offset: 0x276C460 VA: 0x18276DA60
	public void DisableAllActions(InputActionMap map) { }

	// RVA: 0x276E100 Offset: 0x276CB00 VA: 0x18276E100
	public void DisableControls(InputActionMap map) { }

	// RVA: 0x276E170 Offset: 0x276CB70 VA: 0x18276E170
	public void DisableSingleAction(InputAction action) { }

	// RVA: 0x276DDD0 Offset: 0x276C7D0 VA: 0x18276DDD0
	private void DisableControls(InputAction action) { }

	// RVA: 0x276E6C0 Offset: 0x276D0C0 VA: 0x18276E6C0
	private void EnableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x276DEF0 Offset: 0x276C8F0 VA: 0x18276DEF0
	private void DisableControls(int mapIndex, int controlStartIndex, int numControls) { }

	// RVA: 0x27746D0 Offset: 0x27730D0 VA: 0x1827746D0
	public void SetInitialStateCheckPending(int actionIndex, bool value = True) { }

	// RVA: 0x2774780 Offset: 0x2773180 VA: 0x182774780
	private void SetInitialStateCheckPending(InputActionState.BindingState* bindingStatePtr, bool value) { }

	// RVA: 0x27707C0 Offset: 0x276F1C0 VA: 0x1827707C0
	private bool IsControlEnabled(int controlIndex) { }

	// RVA: 0x2774690 Offset: 0x2773090 VA: 0x182774690
	private void SetControlEnabled(int controlIndex, bool state) { }

	// RVA: 0x276F9E0 Offset: 0x276E3E0 VA: 0x18276F9E0
	private void HookOnBeforeUpdate() { }

	// RVA: 0x2774B60 Offset: 0x2773560 VA: 0x182774B60
	private void UnhookOnBeforeUpdate() { }

	// RVA: 0x2770C00 Offset: 0x276F600 VA: 0x182770C00
	private void OnBeforeInitialUpdate() { }

	// RVA: 0x2774BE0 Offset: 0x27735E0 VA: 0x182774BE0 Slot: 4
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex) { }

	// RVA: 0x2774C30 Offset: 0x2773630 VA: 0x182774C30 Slot: 5
	private void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex) { }

	// RVA: 0x2774B20 Offset: 0x2773520 VA: 0x182774B20
	private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) { }

	// RVA: 0x2774840 Offset: 0x2773240 VA: 0x182774840
	private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex) { }

	// RVA: 0x276F6E0 Offset: 0x276E0E0 VA: 0x18276F6E0
	internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex) { }

	// RVA: 0x27719A0 Offset: 0x27703A0 VA: 0x1827719A0
	private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr) { }

	// RVA: 0x27717C0 Offset: 0x27701C0 VA: 0x1827717C0
	private void ProcessButtonState(ref InputActionState.TriggerState trigger, int actionIndex, InputActionState.BindingState* bindingStatePtr) { }

	// RVA: 0x2774800 Offset: 0x2773200 VA: 0x182774800
	private static bool ShouldIgnoreInputOnCompositeBinding(InputActionState.BindingState* binding, InputEvent* eventPtr) { }

	// RVA: 0x27701E0 Offset: 0x276EBE0 VA: 0x1827701E0
	private bool IsConflictingInput(ref InputActionState.TriggerState trigger, int actionIndex) { }

	// RVA: 0x276F320 Offset: 0x276DD20 VA: 0x18276F320
	private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount) { }

	// RVA: 0x2772110 Offset: 0x2770B10 VA: 0x182772110
	private void ProcessDefaultInteraction(ref InputActionState.TriggerState trigger, int actionIndex) { }

	// RVA: 0x27724A0 Offset: 0x2770EA0 VA: 0x1827724A0
	private void ProcessInteractions(ref InputActionState.TriggerState trigger, int interactionStartIndex, int interactionCount) { }

	// RVA: 0x2772700 Offset: 0x2771100 VA: 0x182772700
	private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) { }

	// RVA: 0x27747C0 Offset: 0x27731C0 VA: 0x1827747C0
	internal void SetTotalTimeoutCompletionTime(float seconds, ref InputActionState.TriggerState trigger) { }

	// RVA: 0x2774870 Offset: 0x2773270 VA: 0x182774870
	internal void StartTimeout(float seconds, ref InputActionState.TriggerState trigger) { }

	// RVA: 0x2774A30 Offset: 0x2773430 VA: 0x182774A30
	private void StopTimeout(int interactionIndex) { }

	// RVA: 0x276C440 Offset: 0x276AE40 VA: 0x18276C440
	internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref InputActionState.TriggerState trigger, InputActionPhase phaseAfterPerformed = 1, InputActionPhase phaseAfterCanceled = 1, bool processNextInteractionOnCancel = True) { }

	// RVA: 0x276C1D0 Offset: 0x276ABD0 VA: 0x18276C1D0
	private bool ChangePhaseOfAction(InputActionPhase newPhase, ref InputActionState.TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = 1) { }

	// RVA: 0x276BEE0 Offset: 0x276A8E0 VA: 0x18276BEE0
	private void ChangePhaseOfActionInternal(int actionIndex, InputActionState.TriggerState* actionState, InputActionPhase newPhase, ref InputActionState.TriggerState trigger, bool isDisablingAction = False) { }

	// RVA: 0x276BA00 Offset: 0x276A400 VA: 0x18276BA00
	private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action<InputAction.CallbackContext>> listeners, string callbackName) { }

	// RVA: 0x276F390 Offset: 0x276DD90 VA: 0x18276F390
	private object GetActionOrNoneString(ref InputActionState.TriggerState trigger) { }

	// RVA: 0x276F510 Offset: 0x276DF10 VA: 0x18276F510
	internal InputAction GetActionOrNull(int bindingIndex) { }

	// RVA: 0x276F470 Offset: 0x276DE70 VA: 0x18276F470
	internal InputAction GetActionOrNull(ref InputActionState.TriggerState trigger) { }

	// RVA: 0x276F770 Offset: 0x276E170 VA: 0x18276F770
	internal InputControl GetControl(ref InputActionState.TriggerState trigger) { }

	// RVA: 0x276F7C0 Offset: 0x276E1C0 VA: 0x18276F7C0
	private IInputInteraction GetInteractionOrNull(ref InputActionState.TriggerState trigger) { }

	// RVA: 0x276F5B0 Offset: 0x276DFB0 VA: 0x18276F5B0
	internal int GetBindingIndexInMap(int bindingIndex) { }

	// RVA: 0x276F600 Offset: 0x276E000 VA: 0x18276F600
	internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) { }

	// RVA: 0x276F640 Offset: 0x276E040 VA: 0x18276F640
	internal ref InputActionState.BindingState GetBindingState(int bindingIndex) { }

	// RVA: 0x276F650 Offset: 0x276E050 VA: 0x18276F650
	internal ref InputBinding GetBinding(int bindingIndex) { }

	// RVA: 0x276F350 Offset: 0x276DD50 VA: 0x18276F350
	internal InputActionMap GetActionMap(int bindingIndex) { }

	// RVA: 0x2773960 Offset: 0x2772360 VA: 0x182773960
	private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) { }

	// RVA: 0x2773A40 Offset: 0x2772440 VA: 0x182773A40
	private void ResetInteractionState(int interactionIndex) { }

	// RVA: 0x276F800 Offset: 0x276E200 VA: 0x18276F800
	internal int GetValueSizeInBytes(int bindingIndex, int controlIndex) { }

	// RVA: 0x276F8B0 Offset: 0x276E2B0 VA: 0x18276F8B0
	internal Type GetValueType(int bindingIndex, int controlIndex) { }

	// RVA: 0x2770180 Offset: 0x276EB80 VA: 0x182770180
	internal static bool IsActuated(ref InputActionState.TriggerState trigger, float threshold = 0) { }

	// RVA: 0x2773060 Offset: 0x2771A60 VA: 0x182773060
	internal void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = False) { }

	// RVA: -1 Offset: -1
	internal TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECDCF0 Offset: 0xECC6F0 VA: 0x180ECDCF0
	|-InputActionState.ReadValue<int>
	|
	|-RVA: 0xECE390 Offset: 0xECCD90 VA: 0x180ECE390
	|-InputActionState.ReadValue<Quaternion>
	|
	|-RVA: 0xECEA60 Offset: 0xECD460 VA: 0x180ECEA60
	|-InputActionState.ReadValue<float>
	|
	|-RVA: 0xECF100 Offset: 0xECDB00 VA: 0x180ECF100
	|-InputActionState.ReadValue<Vector2>
	|
	|-RVA: 0xECF7A0 Offset: 0xECE1A0 VA: 0x180ECF7A0
	|-InputActionState.ReadValue<Vector3>
	|
	|-RVA: 0xECD530 Offset: 0xECBF30 VA: 0x180ECD530
	|-InputActionState.ReadValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, InputControl<TValue> controlOfType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECC5D0 Offset: 0xECAFD0 VA: 0x180ECC5D0
	|-InputActionState.ApplyProcessors<int>
	|
	|-RVA: 0xECC740 Offset: 0xECB140 VA: 0x180ECC740
	|-InputActionState.ApplyProcessors<Quaternion>
	|
	|-RVA: 0xECC8E0 Offset: 0xECB2E0 VA: 0x180ECC8E0
	|-InputActionState.ApplyProcessors<float>
	|
	|-RVA: 0xECCA60 Offset: 0xECB460 VA: 0x180ECCA60
	|-InputActionState.ApplyProcessors<Vector2>
	|
	|-RVA: 0xECCBF0 Offset: 0xECB5F0 VA: 0x180ECCBF0
	|-InputActionState.ApplyProcessors<Vector3>
	|
	|-RVA: 0xECC3D0 Offset: 0xECADD0 VA: 0x180ECC3D0
	|-InputActionState.ApplyProcessors<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x276EAA0 Offset: 0x276D4A0 VA: 0x18276EAA0
	public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) { }

	// RVA: 0x276F6F0 Offset: 0x276E0F0 VA: 0x18276F6F0
	internal double GetCompositePartPressTime(int bindingIndex, int partNumber) { }

	// RVA: -1 Offset: -1
	internal TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, TComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECD280 Offset: 0xECBC80 VA: 0x180ECD280
	|-InputActionState.ReadCompositePartValue<float, InputBindingCompositeContext.DefaultComparer<float>>
	|
	|-RVA: 0xECCDB0 Offset: 0xECB7B0 VA: 0x180ECCDB0
	|-InputActionState.ReadCompositePartValue<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2772BF0 Offset: 0x27715F0 VA: 0x182772BF0
	internal bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize) { }

	// RVA: 0x2772AB0 Offset: 0x27714B0 VA: 0x182772AB0
	internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) { }

	// RVA: 0x2772E80 Offset: 0x2771880 VA: 0x182772E80
	internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = False) { }

	// RVA: 0x2772D50 Offset: 0x2771750 VA: 0x182772D50
	internal bool ReadValueAsButton(int bindingIndex, int controlIndex) { }

	// RVA: 0x2774430 Offset: 0x2772E30 VA: 0x182774430
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x276B970 Offset: 0x276A370 VA: 0x18276B970
	private void AddToGlobalList() { }

	// RVA: 0x2773270 Offset: 0x2771C70 VA: 0x182773270
	private void RemoveMapFromGlobalList() { }

	// RVA: 0x276CCA0 Offset: 0x276B6A0 VA: 0x18276CCA0
	private static void CompactGlobalList() { }

	// RVA: 0x27709B0 Offset: 0x276F3B0 VA: 0x1827709B0
	internal void NotifyListenersOfActionChange(InputActionChange change) { }

	// RVA: 0x2770AF0 Offset: 0x276F4F0 VA: 0x182770AF0
	internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) { }

	// RVA: 0x27737C0 Offset: 0x27721C0 VA: 0x1827737C0
	private static void ResetGlobals() { }

	// RVA: 0x276ECF0 Offset: 0x276D6F0 VA: 0x18276ECF0
	internal static int FindAllEnabledActions(List<InputAction> result) { }

	// RVA: 0x2770EE0 Offset: 0x276F8E0 VA: 0x182770EE0
	internal static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x276D0B0 Offset: 0x276BAB0 VA: 0x18276D0B0
	internal static void DeferredResolutionOfBindings() { }

	// RVA: 0x276D8C0 Offset: 0x276C2C0 VA: 0x18276D8C0
	internal static void DisableAllActions() { }

	// RVA: 0x276D3B0 Offset: 0x276BDB0 VA: 0x18276D3B0
	internal static void DestroyAllActionMapStates() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2774C80 Offset: 0x2773680 VA: 0x182774C80
	private static void .cctor() { }
}
