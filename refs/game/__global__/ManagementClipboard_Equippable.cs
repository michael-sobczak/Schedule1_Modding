public class ManagementClipboard_Equippable : Equippable_Viewmodel // TypeDefIndex: 2261
{
	// Fields
	[Header("References")]
	public Transform Clipboard; // 0x60
	public Transform LoweredPosition; // 0x68
	public Transform RaisedPosition; // 0x70
	public ToggleableLight Light; // 0x78
	public SelectionInfoUI SelectionInfo; // 0x80
	public TextMeshProUGUI OverrideText; // 0x88
	private static bool _heatmapToggledOn; // 0x0
	private Property _propertyWithHeatmapShown; // 0x90

	// Properties
	private static bool _canToggleHeatmap { get; }

	// Methods

	// RVA: 0x843210 Offset: 0x841C10 VA: 0x180843210
	public static bool ResetHeatmapToggle() { }

	// RVA: 0x843A80 Offset: 0x842480 VA: 0x180843A80
	private static bool get__canToggleHeatmap() { }

	// RVA: 0x842AB0 Offset: 0x8414B0 VA: 0x180842AB0 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x843250 Offset: 0x841C50 VA: 0x180843250
	private void ShowInputPrompts() { }

	// RVA: 0x843030 Offset: 0x841A30 VA: 0x180843030
	private void HideInputPrompts() { }

	// RVA: 0x843300 Offset: 0x841D00 VA: 0x180843300 Slot: 5
	public override void Unequip() { }

	// RVA: 0x843820 Offset: 0x842220 VA: 0x180843820 Slot: 6
	protected override void Update() { }

	// RVA: 0x8427F0 Offset: 0x8411F0 VA: 0x1808427F0
	private bool CanToggleClipboard() { }

	// RVA: 0x843550 Offset: 0x841F50 VA: 0x180843550
	private void UpdateHeatmap() { }

	// RVA: 0x842980 Offset: 0x841380 VA: 0x180842980
	private void ClearPropertyWithHeatmapShown() { }

	// RVA: 0x842E50 Offset: 0x841850 VA: 0x180842E50
	private void FullscreenEnter() { }

	// RVA: 0x842F00 Offset: 0x841900 VA: 0x180842F00
	private void FullscreenExit() { }

	// RVA: 0x843190 Offset: 0x841B90 VA: 0x180843190
	public void OverrideClipboardText(string overriddenText) { }

	// RVA: 0x842A50 Offset: 0x841450 VA: 0x180842A50
	public void EndOverride() { }

	// RVA: 0x840740 Offset: 0x83F140 VA: 0x180840740
	public void .ctor() { }
}
