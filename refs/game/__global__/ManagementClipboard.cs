public class ManagementClipboard : Singleton<ManagementClipboard> // TypeDefIndex: 2259
{
	// Fields
	public bool IsEquipped; // 0x28
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <StatePreserved>k__BackingField; // 0x2A
	public const float OpenTime = 0.06;
	[Header("References")]
	public Transform ClipboardTransform; // 0x30
	public Camera OverlayCamera; // 0x38
	public Light OverlayLight; // 0x40
	public SelectionInfoUI SelectionInfo; // 0x48
	[Header("Settings")]
	public float ClosedOffset; // 0x50
	public UnityEvent onClipboardEquipped; // 0x58
	public UnityEvent onClipboardUnequipped; // 0x60
	public UnityEvent onOpened; // 0x68
	public UnityEvent onClosed; // 0x70
	private Coroutine lerpRoutine; // 0x78
	private List<IConfigurable> CurrentConfigurables; // 0x80

	// Properties
	public bool IsOpen { get; set; }
	public bool StatePreserved { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	protected void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x844440 Offset: 0x842E40 VA: 0x180844440
	public bool get_StatePreserved() { }

	[CompilerGenerated]
	// RVA: 0x844450 Offset: 0x842E50 VA: 0x180844450
	protected void set_StatePreserved(bool value) { }

	// RVA: 0x842190 Offset: 0x840B90 VA: 0x180842190 Slot: 5
	protected override void Awake() { }

	// RVA: 0x844240 Offset: 0x842C40 VA: 0x180844240
	private void Update() { }

	// RVA: 0x843A90 Offset: 0x842490 VA: 0x180843A90
	private void Exit(ExitAction exitAction) { }

	// RVA: 0x843C90 Offset: 0x842690 VA: 0x180843C90
	public void Open(List<IConfigurable> selection, ManagementClipboard_Equippable equippable) { }

	// RVA: 0x8422F0 Offset: 0x840CF0 VA: 0x1808422F0
	public void Close(bool preserveState = False) { }

	// RVA: 0x843AE0 Offset: 0x8424E0 VA: 0x180843AE0
	private void LerpToVerticalPosition(bool open, Action callback) { }

	// RVA: 0x8443A0 Offset: 0x842DA0 VA: 0x1808443A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x844180 Offset: 0x842B80 VA: 0x180844180
	private void <Close>b__25_0() { }

	[CompilerGenerated]
	// RVA: 0x844180 Offset: 0x842B80 VA: 0x180844180
	private void <Close>g__Done|25_1() { }
}
