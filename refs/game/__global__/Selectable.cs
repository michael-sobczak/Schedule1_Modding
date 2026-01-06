public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 16472
{
	// Fields
	protected static Selectable[] s_Selectables; // 0x0
	protected static int s_SelectableCount; // 0x8
	private bool m_EnableCalled; // 0x20
	[SerializeField]
	[FormerlySerializedAs("navigation")]
	private Navigation m_Navigation; // 0x28
	[SerializeField]
	[FormerlySerializedAs("transition")]
	private Selectable.Transition m_Transition; // 0x50
	[SerializeField]
	[FormerlySerializedAs("colors")]
	private ColorBlock m_Colors; // 0x54
	[FormerlySerializedAs("spriteState")]
	[SerializeField]
	private SpriteState m_SpriteState; // 0xB0
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	private AnimationTriggers m_AnimationTriggers; // 0xD0
	[Tooltip("Can the Selectable be interacted with?")]
	[SerializeField]
	private bool m_Interactable; // 0xD8
	[SerializeField]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[FormerlySerializedAs("highlightGraphic")]
	private Graphic m_TargetGraphic; // 0xE0
	private bool m_GroupsAllowInteraction; // 0xE8
	protected int m_CurrentIndex; // 0xEC
	[CompilerGenerated]
	private bool <isPointerInside>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <isPointerDown>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <hasSelection>k__BackingField; // 0xF2
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xF8

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x2F3BA10 Offset: 0x2F3A410 VA: 0x182F3BA10
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x2F3B9C0 Offset: 0x2F3A3C0 VA: 0x182F3B9C0
	public static int get_allSelectableCount() { }

	// RVA: 0x2F3BAA0 Offset: 0x2F3A4A0 VA: 0x182F3BAA0
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x2F392E0 Offset: 0x2F37CE0 VA: 0x182F392E0
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x2A294D0 Offset: 0x2A27ED0 VA: 0x182A294D0
	public Navigation get_navigation() { }

	// RVA: 0x2F3BFA0 Offset: 0x2F3A9A0 VA: 0x182F3BFA0
	public void set_navigation(Navigation value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public Selectable.Transition get_transition() { }

	// RVA: 0x2F3C0F0 Offset: 0x2F3AAF0 VA: 0x182F3C0F0
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x2F3BBE0 Offset: 0x2F3A5E0 VA: 0x182F3BBE0
	public ColorBlock get_colors() { }

	// RVA: 0x2F3BD90 Offset: 0x2F3A790 VA: 0x182F3BD90
	public void set_colors(ColorBlock value) { }

	// RVA: 0x2F3BD10 Offset: 0x2F3A710 VA: 0x182F3BD10
	public SpriteState get_spriteState() { }

	// RVA: 0x2F3C020 Offset: 0x2F3AA20 VA: 0x182F3C020
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x2F3BD30 Offset: 0x2F3A730 VA: 0x182F3BD30
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public Graphic get_targetGraphic() { }

	// RVA: 0x2F3C090 Offset: 0x2F3AA90 VA: 0x182F3C090
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x4B5E70 Offset: 0x4B4870 VA: 0x1804B5E70
	public bool get_interactable() { }

	// RVA: 0x2F3BE30 Offset: 0x2F3A830 VA: 0x182F3BE30
	public void set_interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8D1FE0 Offset: 0x8D09E0 VA: 0x1808D1FE0
	private bool get_isPointerInside() { }

	[CompilerGenerated]
	// RVA: 0xA63CC0 Offset: 0xA626C0 VA: 0x180A63CC0
	private void set_isPointerInside(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D817D0 Offset: 0x1D801D0 VA: 0x181D817D0
	private bool get_isPointerDown() { }

	[CompilerGenerated]
	// RVA: 0x1F56050 Offset: 0x1F54A50 VA: 0x181F56050
	private void set_isPointerDown(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D81670 Offset: 0x1D80070 VA: 0x181D81670
	private bool get_hasSelection() { }

	[CompilerGenerated]
	// RVA: 0x1D817E0 Offset: 0x1D801E0 VA: 0x181D817E0
	private void set_hasSelection(bool value) { }

	// RVA: 0x2F3B830 Offset: 0x2F3A230 VA: 0x182F3B830
	protected void .ctor() { }

	// RVA: 0x2F3BC90 Offset: 0x2F3A690 VA: 0x182F3BC90
	public Image get_image() { }

	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	public void set_image(Image value) { }

	// RVA: 0x2F3BBA0 Offset: 0x2F3A5A0 VA: 0x182F3BBA0
	public Animator get_animator() { }

	// RVA: 0x2F393B0 Offset: 0x2F37DB0 VA: 0x182F393B0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2F3A780 Offset: 0x2F39180 VA: 0x182F3A780 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x2F3B1E0 Offset: 0x2F39BE0 VA: 0x182F3B1E0
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x2F3A600 Offset: 0x2F39000 VA: 0x182F3A600 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x2F3A840 Offset: 0x2F39240 VA: 0x182F3A840 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2F3AA00 Offset: 0x2F39400 VA: 0x182F3AA00 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F3B1B0 Offset: 0x2F39BB0 VA: 0x182F3B1B0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2F3B130 Offset: 0x2F39B30 VA: 0x182F3B130
	private void OnSetProperty() { }

	// RVA: 0x2F3A850 Offset: 0x2F39250 VA: 0x182F3A850 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F3A710 Offset: 0x2F39110 VA: 0x182F3A710
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x2F3BC20 Offset: 0x2F3A620 VA: 0x182F3BC20
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x2F3A470 Offset: 0x2F38E70 VA: 0x182F3A470 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x2F394F0 Offset: 0x2F37EF0 VA: 0x182F394F0 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x2F39B80 Offset: 0x2F38580 VA: 0x182F39B80
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x2F3A240 Offset: 0x2F38C40 VA: 0x182F3A240
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x2F3A670 Offset: 0x2F39070 VA: 0x182F3A670
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x2F398E0 Offset: 0x2F382E0 VA: 0x182F398E0 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x2F399C0 Offset: 0x2F383C0 VA: 0x182F399C0 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x2F39AA0 Offset: 0x2F384A0 VA: 0x182F39AA0 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x2F39800 Offset: 0x2F38200 VA: 0x182F39800 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x2F3AD20 Offset: 0x2F39720 VA: 0x182F3AD20 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x2F3B460 Offset: 0x2F39E60 VA: 0x182F3B460
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x2F39450 Offset: 0x2F37E50 VA: 0x182F39450
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x2F3B560 Offset: 0x2F39F60 VA: 0x182F3B560
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x2F3A590 Offset: 0x2F38F90 VA: 0x182F3A590
	protected bool IsHighlighted() { }

	// RVA: 0x2F3A620 Offset: 0x2F39020 VA: 0x182F3A620
	protected bool IsPressed() { }

	// RVA: 0x2F39790 Offset: 0x2F38190 VA: 0x182F39790
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x2F3AE50 Offset: 0x2F39850 VA: 0x182F3AE50 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2F3B080 Offset: 0x2F39A80 VA: 0x182F3B080 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2F3AF80 Offset: 0x2F39980 VA: 0x182F3AF80 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2F3B000 Offset: 0x2F39A00 VA: 0x182F3B000 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2F3B0B0 Offset: 0x2F39AB0 VA: 0x182F3B0B0 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2F3A7C0 Offset: 0x2F391C0 VA: 0x182F3A7C0 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2F3B370 Offset: 0x2F39D70 VA: 0x182F3B370 Slot: 38
	public virtual void Select() { }

	// RVA: 0x2F3B7B0 Offset: 0x2F3A1B0 VA: 0x182F3B7B0
	private static void .cctor() { }
}
