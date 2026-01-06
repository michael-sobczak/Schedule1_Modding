public class CanvasGroupFader : MonoBehaviour // TypeDefIndex: 18194
{
	// Fields
	[CompilerGenerated]
	private CanvasGroupFader.FadeGoalType <FadeGoal>k__BackingField; // 0x20
	[Group("Components", False)]
	[SerializeField]
	[Tooltip("CanvasGroup to fade in and out.")]
	protected CanvasGroup CanvasGroup; // 0x28
	[Group("Effects", False)]
	[SerializeField]
	[Tooltip("True to update the CanvasGroup blocking settings when showing and hiding.")]
	protected bool UpdateCanvasBlocking; // 0x30
	[Group("Effects", False)]
	[SerializeField]
	protected float FadeInDuration; // 0x34
	[Group("Effects", False)]
	[SerializeField]
	protected float FadeOutDuration; // 0x38
	private bool _completedOnce; // 0x3C

	// Properties
	public CanvasGroupFader.FadeGoalType FadeGoal { get; set; }
	public bool IsHiding { get; }
	public bool IsVisible { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public CanvasGroupFader.FadeGoalType get_FadeGoal() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	private void set_FadeGoal(CanvasGroupFader.FadeGoalType value) { }

	// RVA: 0xABCB70 Offset: 0xABB570 VA: 0x180ABCB70
	public bool get_IsHiding() { }

	// RVA: 0xDA3700 Offset: 0xDA2100 VA: 0x180DA3700
	public bool get_IsVisible() { }

	// RVA: 0xDA3580 Offset: 0xDA1F80 VA: 0x180DA3580 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0xDA3550 Offset: 0xDA1F50 VA: 0x180DA3550 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0xDA36D0 Offset: 0xDA20D0 VA: 0x180DA36D0 Slot: 6
	protected virtual void Update() { }

	// RVA: 0xDA3640 Offset: 0xDA2040 VA: 0x180DA3640 Slot: 7
	public virtual void ShowImmediately() { }

	// RVA: 0xDA3490 Offset: 0xDA1E90 VA: 0x180DA3490 Slot: 8
	public virtual void HideImmediately() { }

	// RVA: 0xDA3690 Offset: 0xDA2090 VA: 0x180DA3690 Slot: 9
	public virtual void Show() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	protected virtual void OnShow() { }

	// RVA: 0xDA34E0 Offset: 0xDA1EE0 VA: 0x180DA34E0 Slot: 11
	public virtual void Hide() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	protected virtual void OnHide() { }

	// RVA: 0xDA3620 Offset: 0xDA2020 VA: 0x180DA3620
	private void SetFadeGoal(bool fadeIn) { }

	// RVA: 0xDA3290 Offset: 0xDA1C90 VA: 0x180DA3290
	private void Fade() { }

	// RVA: 0xDA3230 Offset: 0xDA1C30 VA: 0x180DA3230 Slot: 13
	protected virtual void CompleteFade(bool fadingIn) { }

	// RVA: 0xDA35C0 Offset: 0xDA1FC0 VA: 0x180DA35C0 Slot: 14
	protected virtual void SetCanvasGroupBlockingType(CanvasGroupBlockingType blockingType) { }

	// RVA: 0xDA36E0 Offset: 0xDA20E0 VA: 0x180DA36E0
	public void .ctor() { }
}
