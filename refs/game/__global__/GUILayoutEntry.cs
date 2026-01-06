internal class GUILayoutEntry // TypeDefIndex: 17612
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x2D06A80 Offset: 0x2D05480 VA: 0x182D06A80
	public GUIStyle get_style() { }

	// RVA: 0x2D06A90 Offset: 0x2D05490 VA: 0x182D06A90
	public void set_style(GUIStyle value) { }

	// RVA: 0x2D069A0 Offset: 0x2D053A0 VA: 0x182D069A0 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x2D069D0 Offset: 0x2D053D0 VA: 0x182D069D0 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x2D06A00 Offset: 0x2D05400 VA: 0x182D06A00 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x2D06920 Offset: 0x2D05320 VA: 0x182D06920 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x2D06950 Offset: 0x2D05350 VA: 0x182D06950
	public int get_marginHorizontal() { }

	// RVA: 0x2D06A30 Offset: 0x2D05430 VA: 0x182D06A30
	public int get_marginVertical() { }

	// RVA: 0x2D066F0 Offset: 0x2D050F0 VA: 0x182D066F0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x2D06810 Offset: 0x2D05210 VA: 0x182D06810
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x2D060B0 Offset: 0x2D04AB0 VA: 0x182D060B0 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x2D060C0 Offset: 0x2D04AC0 VA: 0x182D060C0 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x2D05FA0 Offset: 0x2D049A0 VA: 0x182D05FA0 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x2D05BD0 Offset: 0x2D045D0 VA: 0x182D05BD0 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x2D060D0 Offset: 0x2D04AD0 VA: 0x182D060D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D06690 Offset: 0x2D05090 VA: 0x182D06690
	private static void .cctor() { }
}
