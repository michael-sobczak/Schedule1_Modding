public class WorldspacePopupCanvas : MonoBehaviour // TypeDefIndex: 2731
{
	// Fields
	public const float WORLDSPACE_ICON_SCALE_MULTIPLIER = 0.4;
	[Header("References")]
	public RectTransform WorldspaceContainer; // 0x20
	public RectTransform HudContainer; // 0x28
	[Header("Prefabs")]
	public GameObject HudIconContainerPrefab; // 0x30
	private List<WorldspacePopupUI> activeWorldspaceUIs; // 0x38
	private List<RectTransform> activeHUDUIs; // 0x40
	private List<WorldspacePopup> popupsWithUI; // 0x48

	// Methods

	// RVA: 0x922F70 Offset: 0x921970 VA: 0x180922F70
	private void Update() { }

	// RVA: 0x922230 Offset: 0x920C30 VA: 0x180922230
	private void LateUpdate() { }

	// RVA: 0x922DA0 Offset: 0x9217A0 VA: 0x180922DA0
	private bool ShouldCreateUI(WorldspacePopup popup) { }

	// RVA: 0x921DC0 Offset: 0x9207C0 VA: 0x180921DC0
	private WorldspacePopupUI CreateWorldspaceIcon(WorldspacePopup popup) { }

	// RVA: 0x921BD0 Offset: 0x9205D0 VA: 0x180921BD0
	private RectTransform CreateHUDIcon(WorldspacePopup popup) { }

	// RVA: 0x9220E0 Offset: 0x920AE0 VA: 0x1809220E0
	private void DestroyWorldspaceIcon(WorldspacePopup popup) { }

	// RVA: 0x921F20 Offset: 0x920920 VA: 0x180921F20
	private void DestroyHUDIcon(WorldspacePopup popup) { }

	// RVA: 0x923710 Offset: 0x922110 VA: 0x180923710
	public void .ctor() { }
}
