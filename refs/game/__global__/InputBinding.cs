public struct InputBinding : IEquatable<InputBinding> // TypeDefIndex: 7316
{
	// Fields
	public const char Separator = '\x3b';
	internal const string kSeparatorString = ";";
	[SerializeField]
	private string m_Name; // 0x0
	[SerializeField]
	internal string m_Id; // 0x8
	[SerializeField]
	[Tooltip("Path of the control to bind to. Matched at runtime to controls from InputDevices present at the time.

Can either be graphically from the control picker dropdown UI or edited manually in text mode by clicking the 'T' button. Internally, both methods result in control path strings that look like, for example, "<Gamepad>/buttonSouth".")]
	private string m_Path; // 0x10
	[SerializeField]
	private string m_Interactions; // 0x18
	[SerializeField]
	private string m_Processors; // 0x20
	[SerializeField]
	internal string m_Groups; // 0x28
	[SerializeField]
	private string m_Action; // 0x30
	[SerializeField]
	internal InputBinding.Flags m_Flags; // 0x38
	private string m_OverridePath; // 0x40
	private string m_OverrideInteractions; // 0x48
	private string m_OverrideProcessors; // 0x50

	// Properties
	public string name { get; set; }
	public Guid id { get; set; }
	public string path { get; set; }
	public string overridePath { get; set; }
	public string interactions { get; set; }
	public string overrideInteractions { get; set; }
	public string processors { get; set; }
	public string overrideProcessors { get; set; }
	public string groups { get; set; }
	public string action { get; set; }
	public bool isComposite { get; set; }
	public bool isPartOfComposite { get; set; }
	public bool hasOverrides { get; }
	public string effectivePath { get; }
	public string effectiveInteractions { get; }
	public string effectiveProcessors { get; }
	internal bool isEmpty { get; }

	// Methods

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_name() { }

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void set_name(string value) { }

	// RVA: 0x27760C0 Offset: 0x2774AC0 VA: 0x1827760C0
	public Guid get_id() { }

	// RVA: 0x27762F0 Offset: 0x2774CF0 VA: 0x1827762F0
	public void set_id(Guid value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_path() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_path(string value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_overridePath() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_overridePath(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_interactions() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_interactions(string value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_overrideInteractions() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_overrideInteractions(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_processors() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_processors(string value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_overrideProcessors() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_overrideProcessors(string value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_groups() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_groups(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_action() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_action(string value) { }

	// RVA: 0x2776110 Offset: 0x2774B10 VA: 0x182776110
	public bool get_isComposite() { }

	// RVA: 0x2776320 Offset: 0x2774D20 VA: 0x182776320
	public void set_isComposite(bool value) { }

	// RVA: 0x2776170 Offset: 0x2774B70 VA: 0x182776170
	public bool get_isPartOfComposite() { }

	// RVA: 0x2776340 Offset: 0x2774D40 VA: 0x182776340
	public void set_isPartOfComposite(bool value) { }

	// RVA: 0x27760A0 Offset: 0x2774AA0 VA: 0x1827760A0
	public bool get_hasOverrides() { }

	// RVA: 0x2775FA0 Offset: 0x27749A0 VA: 0x182775FA0
	public void .ctor(string path, string action, string groups, string processors, string interactions, string name) { }

	// RVA: 0x2775570 Offset: 0x2773F70 VA: 0x182775570
	public string GetNameOfComposite() { }

	// RVA: 0x27753F0 Offset: 0x2773DF0 VA: 0x1827753F0
	internal void GenerateId() { }

	// RVA: 0x2775930 Offset: 0x2774330 VA: 0x182775930
	internal void RemoveOverrides() { }

	// RVA: 0x27755B0 Offset: 0x2773FB0 VA: 0x1827755B0
	public static InputBinding MaskByGroup(string group) { }

	// RVA: 0x27755F0 Offset: 0x2773FF0 VA: 0x1827755F0
	public static InputBinding MaskByGroups(string[] groups) { }

	// RVA: 0x2776080 Offset: 0x2774A80 VA: 0x182776080
	public string get_effectivePath() { }

	// RVA: 0x2776070 Offset: 0x2774A70 VA: 0x182776070
	public string get_effectiveInteractions() { }

	// RVA: 0x2776090 Offset: 0x2774A90 VA: 0x182776090
	public string get_effectiveProcessors() { }

	// RVA: 0x2776120 Offset: 0x2774B20 VA: 0x182776120
	internal bool get_isEmpty() { }

	// RVA: 0x2775310 Offset: 0x2773D10 VA: 0x182775310 Slot: 4
	public bool Equals(InputBinding other) { }

	// RVA: 0x2775230 Offset: 0x2773C30 VA: 0x182775230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2776180 Offset: 0x2774B80 VA: 0x182776180
	public static bool op_Equality(InputBinding left, InputBinding right) { }

	// RVA: 0x27761D0 Offset: 0x2774BD0 VA: 0x1827761D0
	public static bool op_Inequality(InputBinding left, InputBinding right) { }

	// RVA: 0x2775440 Offset: 0x2773E40 VA: 0x182775440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2775E10 Offset: 0x2774810 VA: 0x182775E10 Slot: 3
	public override string ToString() { }

	// RVA: 0x2775DD0 Offset: 0x27747D0 VA: 0x182775DD0
	public string ToDisplayString(InputBinding.DisplayStringOptions options = 0, InputControl control) { }

	// RVA: 0x2775980 Offset: 0x2774380 VA: 0x182775980
	public string ToDisplayString(out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options = 0, InputControl control) { }

	// RVA: 0x2775F40 Offset: 0x2774940 VA: 0x182775F40
	internal bool TriggersAction(InputAction action) { }

	// RVA: 0x2775770 Offset: 0x2774170 VA: 0x182775770
	public bool Matches(InputBinding binding) { }

	// RVA: 0x2775790 Offset: 0x2774190 VA: 0x182775790
	internal bool Matches(ref InputBinding binding, InputBinding.MatchOptions options = 0) { }
}
