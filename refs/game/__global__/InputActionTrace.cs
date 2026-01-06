public sealed class InputActionTrace : IEnumerable<InputActionTrace.ActionEventPtr>, IEnumerable, IDisposable // TypeDefIndex: 7797
{
	// Fields
	private bool m_SubscribedToAll; // 0x10
	private bool m_OnActionChangeHooked; // 0x11
	private InlinedArray<InputAction> m_SubscribedActions; // 0x18
	private InlinedArray<InputActionMap> m_SubscribedActionMaps; // 0x30
	private InputEventBuffer m_EventBuffer; // 0x48
	private InlinedArray<InputActionState> m_ActionMapStates; // 0x68
	private InlinedArray<InputActionState> m_ActionMapStateClones; // 0x80
	private Action<InputAction.CallbackContext> m_CallbackDelegate; // 0x98
	private Action<object, InputActionChange> m_ActionChangeDelegate; // 0xA0

	// Properties
	public InputEventBuffer buffer { get; }
	public int count { get; }

	// Methods

	// RVA: 0x277C950 Offset: 0x277B350 VA: 0x18277C950
	public InputEventBuffer get_buffer() { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int get_count() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x277C6E0 Offset: 0x277B0E0 VA: 0x18277C6E0
	public void .ctor(InputAction action) { }

	// RVA: 0x277C830 Offset: 0x277B230 VA: 0x18277C830
	public void .ctor(InputActionMap actionMap) { }

	// RVA: 0x277B9B0 Offset: 0x277A3B0 VA: 0x18277B9B0
	public void SubscribeToAll() { }

	// RVA: 0x277C200 Offset: 0x277AC00 VA: 0x18277C200
	public void UnsubscribeFromAll() { }

	// RVA: 0x277BD60 Offset: 0x277A760 VA: 0x18277BD60
	public void SubscribeTo(InputAction action) { }

	// RVA: 0x277BC40 Offset: 0x277A640 VA: 0x18277BC40
	public void SubscribeTo(InputActionMap actionMap) { }

	// RVA: 0x277C4D0 Offset: 0x277AED0 VA: 0x18277C4D0
	public void UnsubscribeFrom(InputAction action) { }

	// RVA: 0x277C5F0 Offset: 0x277AFF0 VA: 0x18277C5F0
	public void UnsubscribeFrom(InputActionMap actionMap) { }

	// RVA: 0x277B7F0 Offset: 0x277A1F0 VA: 0x18277B7F0
	public void RecordAction(InputAction.CallbackContext context) { }

	// RVA: 0x277B130 Offset: 0x2779B30 VA: 0x18277B130
	public void Clear() { }

	// RVA: 0x277B390 Offset: 0x2779D90 VA: 0x18277B390 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x277BEB0 Offset: 0x277A8B0 VA: 0x18277BEB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x277B370 Offset: 0x2779D70 VA: 0x18277B370 Slot: 6
	public void Dispose() { }

	// RVA: 0x277B260 Offset: 0x2779C60 VA: 0x18277B260
	private void DisposeInternal() { }

	// RVA: 0x277B3F0 Offset: 0x2779DF0 VA: 0x18277B3F0 Slot: 4
	public IEnumerator<InputActionTrace.ActionEventPtr> GetEnumerator() { }

	// RVA: 0x277BEA0 Offset: 0x277A8A0 VA: 0x18277BEA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x277B4A0 Offset: 0x2779EA0 VA: 0x18277B4A0
	private void HookOnActionChange() { }

	// RVA: 0x277C190 Offset: 0x277AB90 VA: 0x18277C190
	private void UnhookOnActionChange() { }

	// RVA: 0x277B570 Offset: 0x2779F70 VA: 0x18277B570
	private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) { }

	// RVA: 0x277B180 Offset: 0x2779B80 VA: 0x18277B180
	private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) { }
}
