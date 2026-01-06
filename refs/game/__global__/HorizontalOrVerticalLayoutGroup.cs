public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 16436
{
	// Fields
	[SerializeField]
	protected float m_Spacing; // 0x60
	[SerializeField]
	protected bool m_ChildForceExpandWidth; // 0x64
	[SerializeField]
	protected bool m_ChildForceExpandHeight; // 0x65
	[SerializeField]
	protected bool m_ChildControlWidth; // 0x66
	[SerializeField]
	protected bool m_ChildControlHeight; // 0x67
	[SerializeField]
	protected bool m_ChildScaleWidth; // 0x68
	[SerializeField]
	protected bool m_ChildScaleHeight; // 0x69
	[SerializeField]
	protected bool m_ReverseArrangement; // 0x6A

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }
	public bool reverseArrangement { get; set; }

	// Methods

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_spacing() { }

	// RVA: 0x2F1AE90 Offset: 0x2F19890 VA: 0x182F1AE90
	public void set_spacing(float value) { }

	// RVA: 0x4E21A0 Offset: 0x4E0BA0 VA: 0x1804E21A0
	public bool get_childForceExpandWidth() { }

	// RVA: 0x2F1AD50 Offset: 0x2F19750 VA: 0x182F1AD50
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x20902A0 Offset: 0x208ECA0 VA: 0x1820902A0
	public bool get_childForceExpandHeight() { }

	// RVA: 0x2F1AD00 Offset: 0x2F19700 VA: 0x182F1AD00
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x208F650 Offset: 0x208E050 VA: 0x18208F650
	public bool get_childControlWidth() { }

	// RVA: 0x2F1ACB0 Offset: 0x2F196B0 VA: 0x182F1ACB0
	public void set_childControlWidth(bool value) { }

	// RVA: 0x208F640 Offset: 0x208E040 VA: 0x18208F640
	public bool get_childControlHeight() { }

	// RVA: 0x2F1AC60 Offset: 0x2F19660 VA: 0x182F1AC60
	public void set_childControlHeight(bool value) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_childScaleWidth() { }

	// RVA: 0x2F1ADF0 Offset: 0x2F197F0 VA: 0x182F1ADF0
	public void set_childScaleWidth(bool value) { }

	// RVA: 0xCE3D90 Offset: 0xCE2790 VA: 0x180CE3D90
	public bool get_childScaleHeight() { }

	// RVA: 0x2F1ADA0 Offset: 0x2F197A0 VA: 0x182F1ADA0
	public void set_childScaleHeight(bool value) { }

	// RVA: 0xCE3DD0 Offset: 0xCE27D0 VA: 0x180CE3DD0
	public bool get_reverseArrangement() { }

	// RVA: 0x2F1AE40 Offset: 0x2F19840 VA: 0x182F1AE40
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x2F19E20 Offset: 0x2F18820 VA: 0x182F19E20
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x2F1A330 Offset: 0x2F18D30 VA: 0x182F1A330
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x2F1A220 Offset: 0x2F18C20 VA: 0x182F1A220
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x2F19E10 Offset: 0x2F18810 VA: 0x182F19E10
	protected void .ctor() { }
}
