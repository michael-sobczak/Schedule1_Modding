public class InputControlLayout // TypeDefIndex: 7757
{
	// Fields
	private static InternedString s_DefaultVariant; // 0x0
	public const string VariantSeparator = ";";
	private InternedString m_Name; // 0x10
	private Type m_Type; // 0x20
	private InternedString m_Variants; // 0x28
	private FourCC m_StateFormat; // 0x38
	internal int m_StateSizeInBytes; // 0x3C
	internal Nullable<bool> m_UpdateBeforeRender; // 0x40
	internal InlinedArray<InternedString> m_BaseLayouts; // 0x48
	private InlinedArray<InternedString> m_AppliedOverrides; // 0x68
	private InternedString[] m_CommonUsages; // 0x88
	internal InputControlLayout.ControlItem[] m_Controls; // 0x90
	internal string m_DisplayName; // 0x98
	private string m_Description; // 0xA0
	private InputControlLayout.Flags m_Flags; // 0xA8
	internal static InputControlLayout.Collection s_Layouts; // 0x10
	internal static InputControlLayout.Cache s_CacheInstance; // 0x50
	internal static int s_CacheInstanceRef; // 0x58

	// Properties
	public static InternedString DefaultVariant { get; }
	public InternedString name { get; }
	public string displayName { get; }
	public Type type { get; }
	public InternedString variants { get; }
	public FourCC stateFormat { get; }
	public int stateSizeInBytes { get; }
	public IEnumerable<InternedString> baseLayouts { get; }
	public IEnumerable<InternedString> appliedOverrides { get; }
	public ReadOnlyArray<InternedString> commonUsages { get; }
	public ReadOnlyArray<InputControlLayout.ControlItem> controls { get; }
	public bool updateBeforeRender { get; }
	public bool isDeviceLayout { get; }
	public bool isControlLayout { get; }
	public bool isOverride { get; set; }
	public bool isGenericTypeOfDevice { get; set; }
	public bool hideInUI { get; set; }
	public bool isNoisy { get; set; }
	public Nullable<bool> canRunInBackground { get; set; }
	public InputControlLayout.ControlItem Item { get; }
	internal static InputControlLayout.Cache cache { get; }

	// Methods

	// RVA: 0x2873E30 Offset: 0x2872830 VA: 0x182873E30
	public static InternedString get_DefaultVariant() { }

	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public InternedString get_name() { }

	// RVA: 0x2874260 Offset: 0x2872C60 VA: 0x182874260
	public string get_displayName() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Type get_type() { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public InternedString get_variants() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public FourCC get_stateFormat() { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public int get_stateSizeInBytes() { }

	// RVA: 0x28740A0 Offset: 0x2872AA0 VA: 0x1828740A0
	public IEnumerable<InternedString> get_baseLayouts() { }

	// RVA: 0x2874050 Offset: 0x2872A50 VA: 0x182874050
	public IEnumerable<InternedString> get_appliedOverrides() { }

	// RVA: 0x28741A0 Offset: 0x2872BA0 VA: 0x1828741A0
	public ReadOnlyArray<InternedString> get_commonUsages() { }

	// RVA: 0x2874200 Offset: 0x2872C00 VA: 0x182874200
	public ReadOnlyArray<InputControlLayout.ControlItem> get_controls() { }

	// RVA: 0x2874400 Offset: 0x2872E00 VA: 0x182874400
	public bool get_updateBeforeRender() { }

	// RVA: 0x2874340 Offset: 0x2872D40 VA: 0x182874340
	public bool get_isDeviceLayout() { }

	// RVA: 0x28742A0 Offset: 0x2872CA0 VA: 0x1828742A0
	public bool get_isControlLayout() { }

	// RVA: 0x28743F0 Offset: 0x2872DF0 VA: 0x1828743F0
	public bool get_isOverride() { }

	// RVA: 0x2874540 Offset: 0x2872F40 VA: 0x182874540
	internal void set_isOverride(bool value) { }

	// RVA: 0x28743D0 Offset: 0x2872DD0 VA: 0x1828743D0
	public bool get_isGenericTypeOfDevice() { }

	// RVA: 0x2874500 Offset: 0x2872F00 VA: 0x182874500
	internal void set_isGenericTypeOfDevice(bool value) { }

	// RVA: 0x2874290 Offset: 0x2872C90 VA: 0x182874290
	public bool get_hideInUI() { }

	// RVA: 0x28744E0 Offset: 0x2872EE0 VA: 0x1828744E0
	internal void set_hideInUI(bool value) { }

	// RVA: 0x28743E0 Offset: 0x2872DE0 VA: 0x1828743E0
	public bool get_isNoisy() { }

	// RVA: 0x2874520 Offset: 0x2872F20 VA: 0x182874520
	internal void set_isNoisy(bool value) { }

	// RVA: 0x2874140 Offset: 0x2872B40 VA: 0x182874140
	public Nullable<bool> get_canRunInBackground() { }

	// RVA: 0x2874440 Offset: 0x2872E40 VA: 0x182874440
	internal void set_canRunInBackground(Nullable<bool> value) { }

	// RVA: 0x2873E90 Offset: 0x2872890 VA: 0x182873E90
	public InputControlLayout.ControlItem get_Item(string path) { }

	// RVA: 0x28714B0 Offset: 0x286FEB0 VA: 0x1828714B0
	public Nullable<InputControlLayout.ControlItem> FindControl(InternedString path) { }

	// RVA: 0x2870F70 Offset: 0x286F970 VA: 0x182870F70
	public Nullable<InputControlLayout.ControlItem> FindControlIncludingArrayElements(string path, out int arrayIndex) { }

	// RVA: 0x2871F00 Offset: 0x2870900 VA: 0x182871F00
	public Type GetValueType() { }

	// RVA: 0x2871970 Offset: 0x2870370 VA: 0x182871970
	public static InputControlLayout FromType(string name, Type type) { }

	// RVA: 0x2873A50 Offset: 0x2872450 VA: 0x182873A50
	public string ToJson() { }

	// RVA: 0x28718B0 Offset: 0x28702B0 VA: 0x1828718B0
	public static InputControlLayout FromJson(string json) { }

	// RVA: 0x2873DC0 Offset: 0x28727C0 VA: 0x182873DC0
	private void .ctor(string name, Type type) { }

	// RVA: 0x286FFA0 Offset: 0x286E9A0 VA: 0x18286FFA0
	private static void AddControlItems(Type type, List<InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x286F4A0 Offset: 0x286DEA0 VA: 0x18286F4A0
	private static void AddControlItemsFromFields(Type type, List<InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x286FF00 Offset: 0x286E900 VA: 0x18286FF00
	private static void AddControlItemsFromProperties(Type type, List<InputControlLayout.ControlItem> controlLayouts, string layoutName) { }

	// RVA: 0x286F910 Offset: 0x286E310 VA: 0x18286F910
	private static void AddControlItemsFromMembers(MemberInfo[] members, List<InputControlLayout.ControlItem> controlItems, string layoutName) { }

	// RVA: 0x286F540 Offset: 0x286DF40 VA: 0x18286F540
	private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<InputControlLayout.ControlItem> controlItems) { }

	// RVA: 0x2870140 Offset: 0x286EB40 VA: 0x182870140
	private static InputControlLayout.ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) { }

	// RVA: 0x2871F80 Offset: 0x2870980 VA: 0x182871F80
	private static string InferLayoutFromValueType(Type type) { }

	// RVA: 0x28721C0 Offset: 0x2870BC0 VA: 0x1828721C0
	public void MergeLayout(InputControlLayout other) { }

	// RVA: 0x2870AC0 Offset: 0x286F4C0 VA: 0x182870AC0
	private static Dictionary<string, InputControlLayout.ControlItem> CreateLookupTableForControls(InputControlLayout.ControlItem[] controlItems, List<string> variants) { }

	// RVA: 0x2873BA0 Offset: 0x28725A0 VA: 0x182873BA0
	internal static bool VariantsMatch(InternedString expected, InternedString actual) { }

	// RVA: 0x2873C00 Offset: 0x2872600 VA: 0x182873C00
	internal static bool VariantsMatch(string expected, string actual) { }

	// RVA: 0x2873870 Offset: 0x2872270 VA: 0x182873870
	internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString> baseLayouts, out InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x28740F0 Offset: 0x2872AF0 VA: 0x1828740F0
	internal static ref InputControlLayout.Cache get_cache() { }

	// RVA: 0x28700E0 Offset: 0x286EAE0 VA: 0x1828700E0
	internal static InputControlLayout.CacheRefInstance CacheRef() { }

	// RVA: 0x2873D40 Offset: 0x2872740 VA: 0x182873D40
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2873B00 Offset: 0x2872500 VA: 0x182873B00
	private bool <MergeLayout>b__77_0(InputControlLayout.ControlItem x) { }
}
