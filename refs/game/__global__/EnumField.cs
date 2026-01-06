public class EnumField : BaseField<Enum> // TypeDefIndex: 6292
{
	// Fields
	private Type m_EnumType; // 0x448
	private bool m_IncludeObsoleteValues; // 0x450
	private TextElement m_TextElement; // 0x458
	private VisualElement m_ArrowElement; // 0x460
	private EnumData m_EnumData; // 0x468
	internal Func<IGenericMenu> createMenuCallback; // 0x4A8
	public static readonly string ussClassName; // 0x0
	public static readonly string textUssClassName; // 0x8
	public static readonly string arrowUssClassName; // 0x10
	public static readonly string labelUssClassName; // 0x18
	public static readonly string inputUssClassName; // 0x20

	// Properties
	internal bool includeObsoleteValues { get; }

	// Methods

	// RVA: 0x2DCCDA0 Offset: 0x2DCB7A0 VA: 0x182DCCDA0
	internal bool get_includeObsoleteValues() { }

	// RVA: 0x2DCBE10 Offset: 0x2DCA810 VA: 0x182DCBE10
	private void Initialize(Enum defaultValue) { }

	// RVA: 0x2DCCD90 Offset: 0x2DCB790 VA: 0x182DCCD90
	public void .ctor() { }

	// RVA: 0x2DCCA50 Offset: 0x2DCB450 VA: 0x182DCCA50
	public void .ctor(string label, Enum defaultValue) { }

	// RVA: 0x2DCBCF0 Offset: 0x2DCA6F0 VA: 0x182DCBCF0
	public void Init(Enum defaultValue) { }

	// RVA: 0x2DCBD00 Offset: 0x2DCA700 VA: 0x182DCBD00
	public void Init(Enum defaultValue, bool includeObsoleteValues) { }

	// RVA: 0x2DCC0E0 Offset: 0x2DCAAE0 VA: 0x182DCC0E0
	internal void PopulateDataFromType(Type enumType) { }

	// RVA: 0x2DCC1C0 Offset: 0x2DCABC0 VA: 0x182DCC1C0 Slot: 118
	public override void SetValueWithoutNotify(Enum newValue) { }

	// RVA: 0x2DCC780 Offset: 0x2DCB180 VA: 0x182DCC780
	private void UpdateValueLabel(Enum value) { }

	// RVA: 0x2DCC010 Offset: 0x2DCAA10 VA: 0x182DCC010
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x2DCC060 Offset: 0x2DCAA60 VA: 0x182DCC060
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x2DCBC60 Offset: 0x2DCA660 VA: 0x182DCBC60
	private bool ContainsPointer(int pointerId) { }

	// RVA: -1 Offset: -1
	private void ProcessPointerDown<T>(PointerEventBase<T> evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE832D0 Offset: 0xE81CD0 VA: 0x180E832D0
	|-EnumField.ProcessPointerDown<object>
	*/

	// RVA: 0x2DCBFE0 Offset: 0x2DCA9E0 VA: 0x182DCBFE0
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x2DCC290 Offset: 0x2DCAC90 VA: 0x182DCC290
	internal void ShowMenu() { }

	// RVA: 0x2DCBBD0 Offset: 0x2DCA5D0 VA: 0x182DCBBD0
	private void ChangeValueFromMenu(object menuItem) { }

	// RVA: 0x2DCC610 Offset: 0x2DCB010 VA: 0x182DCC610 Slot: 117
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x2DCC880 Offset: 0x2DCB280 VA: 0x182DCC880
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2DCBBD0 Offset: 0x2DCA5D0 VA: 0x182DCBBD0
	private void <ShowMenu>b__33_0(object contentView) { }
}
