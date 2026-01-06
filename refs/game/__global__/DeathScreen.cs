public class DeathScreen : Singleton<DeathScreen> // TypeDefIndex: 2668
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas canvas; // 0x30
	public RectTransform Container; // 0x38
	public CanvasGroup group; // 0x40
	public Button respawnButton; // 0x48
	public Button loadSaveButton; // 0x50
	public Animation Anim; // 0x58
	public AudioSourceController Sound; // 0x60
	private bool arrested; // 0x68

	// Properties
	public bool isOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	// RVA: 0x8F50D0 Offset: 0x8F3AD0 VA: 0x1808F50D0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8F5730 Offset: 0x8F4130 VA: 0x1808F5730
	private void RespawnClicked() { }

	// RVA: 0x8F53F0 Offset: 0x8F3DF0 VA: 0x1808F53F0
	private void LoadSaveClicked() { }

	// RVA: 0x8F54E0 Offset: 0x8F3EE0 VA: 0x1808F54E0
	public void Open() { }

	// RVA: 0x8F5240 Offset: 0x8F3C40 VA: 0x1808F5240
	private bool CanRespawn() { }

	// RVA: 0x8F52B0 Offset: 0x8F3CB0 VA: 0x1808F52B0
	public void Close() { }

	// RVA: 0x8F5890 Offset: 0x8F4290 VA: 0x1808F5890
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(DeathScreen.<<RespawnClicked>g__Routine|13_0>d))]
	// RVA: 0x8F5820 Offset: 0x8F4220 VA: 0x1808F5820
	private IEnumerator <RespawnClicked>g__Routine|13_0() { }

	[IteratorStateMachine(typeof(DeathScreen.<<Open>g__Routine|15_0>d))]
	[CompilerGenerated]
	// RVA: 0x8F57B0 Offset: 0x8F41B0 VA: 0x1808F57B0
	private IEnumerator <Open>g__Routine|15_0() { }
}
