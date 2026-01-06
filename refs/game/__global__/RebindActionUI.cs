public class RebindActionUI : MonoBehaviour // TypeDefIndex: 1962
{
	// Fields
	public Action onRebind; // 0x20
	[Tooltip("Reference to action that is to be rebound from the UI.")]
	[SerializeField]
	private InputActionReference m_Action; // 0x28
	[SerializeField]
	private string m_BindingId; // 0x30
	[SerializeField]
	private InputBinding.DisplayStringOptions m_DisplayStringOptions; // 0x38
	[Tooltip("Text label that will receive the name of the action. Optional. Set to None to have the rebind UI not show a label for the action.")]
	[SerializeField]
	private TextMeshProUGUI m_ActionLabel; // 0x40
	[SerializeField]
	[Tooltip("Text label that will receive the current, formatted binding string.")]
	private TextMeshProUGUI m_BindingText; // 0x48
	[SerializeField]
	[Tooltip("Optional UI that will be shown while a rebind is in progress.")]
	private GameObject m_RebindOverlay; // 0x50
	[Tooltip("Optional text label that will be updated with prompt for user input.")]
	[SerializeField]
	private TextMeshProUGUI m_RebindText; // 0x58
	[Tooltip("Event that is triggered when the way the binding is display should be updated. This allows displaying bindings in custom ways, e.g. using images instead of text.")]
	[SerializeField]
	private RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent; // 0x60
	[Tooltip("Event that is triggered when an interactive rebind is being initiated. This can be used, for example, to implement custom UI behavior while a rebind is in progress. It can also be used to further customize the rebind.")]
	[SerializeField]
	private RebindActionUI.InteractiveRebindEvent m_RebindStartEvent; // 0x68
	[SerializeField]
	[Tooltip("Event that is triggered when an interactive rebind is complete or has been aborted.")]
	private RebindActionUI.InteractiveRebindEvent m_RebindStopEvent; // 0x70
	private InputActionRebindingExtensions.RebindingOperation m_RebindOperation; // 0x78
	private static List<RebindActionUI> s_RebindActionUIs; // 0x0

	// Properties
	public InputActionReference actionReference { get; set; }
	public string bindingId { get; set; }
	public InputBinding.DisplayStringOptions displayStringOptions { get; set; }
	public TextMeshProUGUI actionLabel { get; set; }
	public TextMeshProUGUI bindingText { get; set; }
	public TextMeshProUGUI rebindPrompt { get; set; }
	public GameObject rebindOverlay { get; set; }
	public RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent { get; }
	public RebindActionUI.InteractiveRebindEvent startRebindEvent { get; }
	public RebindActionUI.InteractiveRebindEvent stopRebindEvent { get; }
	public InputActionRebindingExtensions.RebindingOperation ongoingRebind { get; }

	// Methods

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public InputActionReference get_actionReference() { }

	// RVA: 0x7A3D30 Offset: 0x7A2730 VA: 0x1807A3D30
	public void set_actionReference(InputActionReference value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_bindingId() { }

	// RVA: 0x7A3D60 Offset: 0x7A2760 VA: 0x1807A3D60
	public void set_bindingId(string value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public InputBinding.DisplayStringOptions get_displayStringOptions() { }

	// RVA: 0x7A3DC0 Offset: 0x7A27C0 VA: 0x1807A3DC0
	public void set_displayStringOptions(InputBinding.DisplayStringOptions value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public TextMeshProUGUI get_actionLabel() { }

	// RVA: 0x7A3D00 Offset: 0x7A2700 VA: 0x1807A3D00
	public void set_actionLabel(TextMeshProUGUI value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public TextMeshProUGUI get_bindingText() { }

	// RVA: 0x7A3D90 Offset: 0x7A2790 VA: 0x1807A3D90
	public void set_bindingText(TextMeshProUGUI value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public TextMeshProUGUI get_rebindPrompt() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_rebindPrompt(TextMeshProUGUI value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public GameObject get_rebindOverlay() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_rebindOverlay(GameObject value) { }

	// RVA: 0x7A3C70 Offset: 0x7A2670 VA: 0x1807A3C70
	public RebindActionUI.UpdateBindingUIEvent get_updateBindingUIEvent() { }

	// RVA: 0x7A3B50 Offset: 0x7A2550 VA: 0x1807A3B50
	public RebindActionUI.InteractiveRebindEvent get_startRebindEvent() { }

	// RVA: 0x7A3BE0 Offset: 0x7A25E0 VA: 0x1807A3BE0
	public RebindActionUI.InteractiveRebindEvent get_stopRebindEvent() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public InputActionRebindingExtensions.RebindingOperation get_ongoingRebind() { }

	// RVA: 0x7A3280 Offset: 0x7A1C80 VA: 0x1807A3280
	public bool ResolveActionAndBinding(out InputAction action, out int bindingIndex) { }

	// RVA: 0x7A3950 Offset: 0x7A2350 VA: 0x1807A3950
	public void UpdateBindingDisplay() { }

	// RVA: 0x7A2ED0 Offset: 0x7A18D0 VA: 0x1807A2ED0
	public void ResetToDefault() { }

	// RVA: 0x7A3480 Offset: 0x7A1E80 VA: 0x1807A3480
	public void StartInteractiveRebind() { }

	// RVA: 0x7A2A20 Offset: 0x7A1420 VA: 0x1807A2A20
	private void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = False) { }

	// RVA: 0x7A2850 Offset: 0x7A1250 VA: 0x1807A2850
	protected void OnEnable() { }

	// RVA: 0x7A2710 Offset: 0x7A1110 VA: 0x1807A2710
	protected void OnDisable() { }

	// RVA: 0x7A24D0 Offset: 0x7A0ED0 VA: 0x1807A24D0
	private static void OnActionChange(object obj, InputActionChange change) { }

	// RVA: 0x7A3890 Offset: 0x7A2290 VA: 0x1807A3890
	private void UpdateActionLabel() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7A3840 Offset: 0x7A2240 VA: 0x1807A3840
	private bool <UpdateBindingDisplay>b__31_0(InputBinding x) { }
}
