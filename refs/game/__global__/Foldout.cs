public class Foldout : BindableElement, INotifyValueChanged<bool> // TypeDefIndex: 6299
{
	// Fields
	private Toggle m_Toggle; // 0x3D8
	private VisualElement m_Container; // 0x3E0
	[SerializeField]
	private bool m_Value; // 0x3E8
	public static readonly string ussClassName; // 0x0
	public static readonly string toggleUssClassName; // 0x8
	public static readonly string contentUssClassName; // 0x10
	public static readonly string inputUssClassName; // 0x18
	public static readonly string checkmarkUssClassName; // 0x20
	public static readonly string textUssClassName; // 0x28
	internal static readonly string toggleInspectorUssClassName; // 0x30
	internal static readonly string ussFoldoutDepthClassName; // 0x38
	internal static readonly int ussFoldoutMaxDepth; // 0x40
	private KeyboardNavigationManipulator m_NavigationManipulator; // 0x3F0

	// Properties
	internal Toggle toggle { get; }
	public override VisualElement contentContainer { get; }
	public string text { set; }
	public bool value { get; set; }

	// Methods

	// RVA: 0x67A290 Offset: 0x678C90 VA: 0x18067A290
	internal Toggle get_toggle() { }

	// RVA: 0x67A250 Offset: 0x678C50 VA: 0x18067A250 Slot: 99
	public override VisualElement get_contentContainer() { }

	// RVA: 0x2DCE6C0 Offset: 0x2DCD0C0 VA: 0x182DCE6C0
	public void set_text(string value) { }

	// RVA: 0x2DCE6B0 Offset: 0x2DCD0B0 VA: 0x182DCE6B0 Slot: 102
	public bool get_value() { }

	// RVA: 0x2DCE7F0 Offset: 0x2DCD1F0 VA: 0x182DCE7F0 Slot: 103
	public void set_value(bool value) { }

	// RVA: 0x2DCDDD0 Offset: 0x2DCC7D0 VA: 0x182DCDDD0 Slot: 104
	public void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x2DCDD80 Offset: 0x2DCC780 VA: 0x182DCDD80 Slot: 96
	internal override void OnViewDataReady() { }

	// RVA: 0x2DCDA70 Offset: 0x2DCC470 VA: 0x182DCDA70
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x2DCD960 Offset: 0x2DCC360 VA: 0x182DCD960
	private bool Apply(KeyboardNavigationOperation op) { }

	// RVA: 0x2DCE290 Offset: 0x2DCCC90 VA: 0x182DCE290
	public void .ctor() { }

	// RVA: 0x2DCDB80 Offset: 0x2DCC580 VA: 0x182DCDB80
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x2DCDFA0 Offset: 0x2DCC9A0 VA: 0x182DCDFA0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2DCDF40 Offset: 0x2DCC940 VA: 0x182DCDF40
	private void <.ctor>b__29_0(ChangeEvent<bool> evt) { }
}
