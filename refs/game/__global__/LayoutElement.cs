public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 16442
{
	// Fields
	[SerializeField]
	private bool m_IgnoreLayout; // 0x20
	[SerializeField]
	private float m_MinWidth; // 0x24
	[SerializeField]
	private float m_MinHeight; // 0x28
	[SerializeField]
	private float m_PreferredWidth; // 0x2C
	[SerializeField]
	private float m_PreferredHeight; // 0x30
	[SerializeField]
	private float m_FlexibleWidth; // 0x34
	[SerializeField]
	private float m_FlexibleHeight; // 0x38
	[SerializeField]
	private int m_LayoutPriority; // 0x3C

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x2F265A0 Offset: 0x2F24FA0 VA: 0x182F265A0 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x2F266C0 Offset: 0x2F250C0 VA: 0x182F266C0 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x2F26660 Offset: 0x2F25060 VA: 0x182F26660 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x2F26780 Offset: 0x2F25180 VA: 0x182F26780 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x2F26720 Offset: 0x2F25120 VA: 0x182F26720 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x2F26540 Offset: 0x2F24F40 VA: 0x182F26540 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x2F264E0 Offset: 0x2F24EE0 VA: 0x182F264E0 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x2F26600 Offset: 0x2F25000 VA: 0x182F26600 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x2F264A0 Offset: 0x2F24EA0 VA: 0x182F264A0
	protected void .ctor() { }

	// RVA: 0x2F263E0 Offset: 0x2F24DE0 VA: 0x182F263E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F263B0 Offset: 0x2F24DB0 VA: 0x182F263B0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2F263C0 Offset: 0x2F24DC0 VA: 0x182F263C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F263B0 Offset: 0x2F24DB0 VA: 0x182F263B0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2F263B0 Offset: 0x2F24DB0 VA: 0x182F263B0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x2F26400 Offset: 0x2F24E00 VA: 0x182F26400
	protected void SetDirty() { }
}
