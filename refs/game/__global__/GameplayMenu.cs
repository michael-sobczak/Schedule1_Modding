public class GameplayMenu : Singleton<GameplayMenu> // TypeDefIndex: 2606
{
	// Fields
	public const float OpenVerticalOffset = 0.02;
	public const float ClosedVerticalOffset = -2;
	public const float OpenTime = 0.06;
	public const float SlideTime = 0.12;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private GameplayMenu.EGameplayScreen <CurrentScreen>k__BackingField; // 0x2C
	[Header("References")]
	public Camera OverlayCamera; // 0x30
	public Light OverlayLight; // 0x38
	[Header("Settings")]
	public float ContainerOffset_PhoneScreen; // 0x40
	private Coroutine openCloseRoutine; // 0x48
	private Coroutine screenChangeRoutine; // 0x50

	// Properties
	public bool IsOpen { get; set; }
	public bool CharacterScreenEnabled { get; }
	public GameplayMenu.EGameplayScreen CurrentScreen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsOpen(bool value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool get_CharacterScreenEnabled() { }

	[CompilerGenerated]
	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public GameplayMenu.EGameplayScreen get_CurrentScreen() { }

	[CompilerGenerated]
	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	protected void set_CurrentScreen(GameplayMenu.EGameplayScreen value) { }

	// RVA: 0x8E5C80 Offset: 0x8E4680 VA: 0x1808E5C80 Slot: 4
	protected override void Start() { }

	// RVA: 0x8E5080 Offset: 0x8E3A80 VA: 0x1808E5080
	public void Exit(ExitAction exit) { }

	// RVA: 0x8E5F80 Offset: 0x8E4980 VA: 0x1808E5F80 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x8E5A30 Offset: 0x8E4430 VA: 0x1808E5A30
	public void SetScreen(GameplayMenu.EGameplayScreen screen) { }

	// RVA: 0x8E5150 Offset: 0x8E3B50 VA: 0x1808E5150
	public void SetIsOpen(bool open) { }

	// RVA: 0x8E62C0 Offset: 0x8E4CC0 VA: 0x1808E62C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8E5E80 Offset: 0x8E4880 VA: 0x1808E5E80
	private void <Update>g__PrepAppOpen|22_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(GameplayMenu.<<SetIsOpen>g__SetIsOpenRoutine|24_0>d))]
	// RVA: 0x8E5E00 Offset: 0x8E4800 VA: 0x1808E5E00
	private IEnumerator <SetIsOpen>g__SetIsOpenRoutine|24_0(bool open) { }
}
