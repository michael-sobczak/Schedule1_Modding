internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver // TypeDefIndex: 7000
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30
	[SerializeField]
	private int m_RuleIndex; // 0x38
	[SerializeField]
	private string m_Text; // 0x40
	[SerializeField]
	private PickingMode m_PickingMode; // 0x48
	[SerializeField]
	private string[] m_Classes; // 0x50
	[SerializeField]
	private List<string> m_StylesheetPaths; // 0x58
	[SerializeField]
	private List<StyleSheet> m_Stylesheets; // 0x60
	[SerializeField]
	private bool m_SkipClone; // 0x68

	// Properties
	public int ruleIndex { get; }
	public string[] classes { get; }
	public List<string> stylesheetPaths { get; }
	public bool hasStylesheetPaths { get; }
	public List<StyleSheet> stylesheets { get; }
	public bool hasStylesheets { get; }
	internal bool skipClone { get; }

	// Methods

	// RVA: 0x2CE3430 Offset: 0x2CE1E30 VA: 0x182CE3430
	public int get_ruleIndex() { }

	// RVA: 0x2D0E270 Offset: 0x2D0CC70 VA: 0x182D0E270
	public string[] get_classes() { }

	// RVA: 0x2DEFBE0 Offset: 0x2DEE5E0 VA: 0x182DEFBE0
	public List<string> get_stylesheetPaths() { }

	// RVA: 0x2044CE0 Offset: 0x20436E0 VA: 0x182044CE0
	public bool get_hasStylesheetPaths() { }

	// RVA: 0x2DEFC60 Offset: 0x2DEE660 VA: 0x182DEFC60
	public List<StyleSheet> get_stylesheets() { }

	// RVA: 0xC0DCA0 Offset: 0xC0C6A0 VA: 0x180C0DCA0
	public bool get_hasStylesheets() { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	internal bool get_skipClone() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void OnBeforeSerialize() { }

	// RVA: 0x2DEFA50 Offset: 0x2DEE450 VA: 0x182DEFA50 Slot: 6
	public void OnAfterDeserialize() { }
}
