public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 16444
{
	// Fields
	[SerializeField]
	protected RectOffset m_Padding; // 0x20
	[SerializeField]
	protected TextAnchor m_ChildAlignment; // 0x28
	private RectTransform m_Rect; // 0x30
	protected DrivenRectTransformTracker m_Tracker; // 0x38
	private Vector2 m_TotalMinSize; // 0x3C
	private Vector2 m_TotalPreferredSize; // 0x44
	private Vector2 m_TotalFlexibleSize; // 0x4C
	private List<RectTransform> m_RectChildren; // 0x58

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public RectOffset get_padding() { }

	// RVA: 0x2F27B40 Offset: 0x2F26540 VA: 0x182F27B40
	public void set_padding(RectOffset value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public TextAnchor get_childAlignment() { }

	// RVA: 0x2F27AF0 Offset: 0x2F264F0 VA: 0x182F27AF0
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x2F27A60 Offset: 0x2F26460 VA: 0x182F27A60
	protected RectTransform get_rectTransform() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x2F267E0 Offset: 0x2F251E0 VA: 0x182F267E0 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x2BC30D0 Offset: 0x2BC1AD0 VA: 0x182BC30D0 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x2D47460 Offset: 0x2D45E60 VA: 0x182D47460 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x2D47490 Offset: 0x2D45E90 VA: 0x182D47490 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x2D2B180 Offset: 0x2D29B80 VA: 0x182D2B180 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x2D47470 Offset: 0x2D45E70 VA: 0x182D47470 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x2D474A0 Offset: 0x2D45EA0 VA: 0x182D474A0 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x2F27790 Offset: 0x2F26190 VA: 0x182F27790
	protected void .ctor() { }

	// RVA: 0x2F26E00 Offset: 0x2F25800 VA: 0x182F26E00 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F26D80 Offset: 0x2F25780 VA: 0x182F26D80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F26D70 Offset: 0x2F25770 VA: 0x182F26D70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2F26D50 Offset: 0x2F25750 VA: 0x182F26D50
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x2F26D60 Offset: 0x2F25760 VA: 0x182F26D60
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x2F26D40 Offset: 0x2F25740 VA: 0x182F26D40
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x2F26BE0 Offset: 0x2F255E0 VA: 0x182F26BE0
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x2F26B90 Offset: 0x2F25590 VA: 0x182F26B90
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x2F27700 Offset: 0x2F26100 VA: 0x182F27700
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x2F27480 Offset: 0x2F25E80 VA: 0x182F27480
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x2F27230 Offset: 0x2F25C30 VA: 0x182F27230
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x2F27520 Offset: 0x2F25F20 VA: 0x182F27520
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x2F26F60 Offset: 0x2F25960 VA: 0x182F26F60
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x2F27930 Offset: 0x2F26330 VA: 0x182F27930
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x2F26E20 Offset: 0x2F25820 VA: 0x182F26E20 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2F26D70 Offset: 0x2F25770 VA: 0x182F26D70 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9ED0 Offset: 0xEE88D0 VA: 0x180EE9ED0
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0xEEA260 Offset: 0xEE8C60 VA: 0x180EEA260
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0xEEA1B0 Offset: 0xEE8BB0 VA: 0x180EEA1B0
	|-LayoutGroup.SetProperty<Int32Enum>
	|
	|-RVA: 0xEEA2E0 Offset: 0xEE8CE0 VA: 0x180EEA2E0
	|-LayoutGroup.SetProperty<object>
	|
	|-RVA: 0xEEA350 Offset: 0xEE8D50 VA: 0x180EEA350
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0xEEA3E0 Offset: 0xEE8DE0 VA: 0x180EEA3E0
	|-LayoutGroup.SetProperty<Vector2>
	|
	|-RVA: 0xEE9F80 Offset: 0xEE8980 VA: 0x180EE9F80
	|-LayoutGroup.SetProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F275D0 Offset: 0x2F25FD0 VA: 0x182F275D0
	protected void SetDirty() { }

	[IteratorStateMachine(typeof(LayoutGroup.<DelayedSetDirty>d__56))]
	// RVA: 0x2F26B20 Offset: 0x2F25520 VA: 0x182F26B20
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }
}
