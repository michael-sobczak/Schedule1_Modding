public static class InputControlPath // TypeDefIndex: 7363
{
	// Fields
	public const string Wildcard = "*";
	public const string DoubleWildcard = "**";
	public const char Separator = '\x2f';
	internal const char SeparatorReplacement = '\x20';

	// Methods

	[Extension]
	// RVA: 0x279ED70 Offset: 0x279D770 VA: 0x18279ED70
	internal static string CleanSlashes(string pathComponent) { }

	// RVA: 0x279EDA0 Offset: 0x279D7A0 VA: 0x18279EDA0
	public static string Combine(InputControl parent, string path) { }

	// RVA: 0x27A0210 Offset: 0x279EC10 VA: 0x1827A0210
	public static string ToHumanReadableString(string path, InputControlPath.HumanReadableStringOptions options = 0, InputControl control) { }

	// RVA: 0x27A0250 Offset: 0x279EC50 VA: 0x1827A0250
	public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, InputControlPath.HumanReadableStringOptions options = 0, InputControl control) { }

	// RVA: 0x27A0EA0 Offset: 0x279F8A0 VA: 0x1827A0EA0
	public static string[] TryGetDeviceUsages(string path) { }

	// RVA: 0x27A0D40 Offset: 0x279F740 VA: 0x1827A0D40
	public static string TryGetDeviceLayout(string path) { }

	// RVA: 0x27A0AE0 Offset: 0x279F4E0 VA: 0x1827A0AE0
	public static string TryGetControlLayout(string path) { }

	// RVA: 0x279F450 Offset: 0x279DE50 VA: 0x18279F450
	private static string FindControlLayoutRecursive(ref InputControlPath.PathParser parser, string layoutName) { }

	// RVA: 0x279F060 Offset: 0x279DA60 VA: 0x18279F060
	private static string FindControlLayoutRecursive(ref InputControlPath.PathParser parser, InputControlLayout layout) { }

	// RVA: 0x279EE90 Offset: 0x279D890 VA: 0x18279EE90
	private static bool ControlLayoutMatchesPathComponent(ref InputControlLayout.ControlItem controlItem, ref InputControlPath.PathParser parser) { }

	// RVA: 0x27A0080 Offset: 0x279EA80 VA: 0x1827A0080
	private static bool StringMatches(Substring str, InternedString matchTo) { }

	// RVA: 0x27A08E0 Offset: 0x279F2E0 VA: 0x1827A08E0
	public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0) { }

	// RVA: 0x27A09B0 Offset: 0x279F3B0 VA: 0x1827A09B0
	public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0) { }

	// RVA: 0x27A0940 Offset: 0x279F340 VA: 0x1827A0940
	public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl> matches, int indexInPath = 0) { }

	// RVA: -1 Offset: -1
	public static TControl TryFindControl<TControl>(InputControl control, string path, int indexInPath = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED5440 Offset: 0xED3E40 VA: 0x180ED5440
	|-InputControlPath.TryFindControl<object>
	*/

	// RVA: -1 Offset: -1
	public static int TryFindControls<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED5540 Offset: 0xED3F40 VA: 0x180ED5540
	|-InputControlPath.TryFindControls<object>
	*/

	// RVA: 0x27A0880 Offset: 0x279F280 VA: 0x1827A0880
	public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0) { }

	// RVA: -1 Offset: -1
	public static TControl TryFindChild<TControl>(InputControl control, string path, int indexInPath = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED51F0 Offset: 0xED3BF0 VA: 0x180ED51F0
	|-InputControlPath.TryFindChild<object>
	*/

	// RVA: 0x279FDA0 Offset: 0x279E7A0 VA: 0x18279FDA0
	public static bool Matches(string expected, InputControl control) { }

	// RVA: 0x279F5B0 Offset: 0x279DFB0 VA: 0x18279F5B0
	internal static bool MatchControlComponent(ref InputControlPath.ParsedPathComponent expectedControlComponent, ref InputControlLayout.ControlItem controlItem, bool matchAlias = False) { }

	// RVA: 0x279FB70 Offset: 0x279E570 VA: 0x18279FB70
	public static bool MatchesPrefix(string expected, InputControl control) { }

	// RVA: 0x279FD10 Offset: 0x279E710 VA: 0x18279FD10
	private static bool MatchesRecursive(ref InputControlPath.PathParser parser, InputControl currentControl, bool prefixOnly = False) { }

	// RVA: -1 Offset: -1
	private static TControl MatchControlsRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4BE0 Offset: 0xED35E0 VA: 0x180ED4BE0
	|-InputControlPath.MatchControlsRecursive<object>
	*/

	// RVA: -1 Offset: -1
	private static TControl MatchByUsageAtDeviceRootRecursive<TControl>(InputDevice device, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4700 Offset: 0xED3100 VA: 0x180ED4700
	|-InputControlPath.MatchByUsageAtDeviceRootRecursive<object>
	*/

	// RVA: -1 Offset: -1
	private static TControl MatchChildrenRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4A80 Offset: 0xED3480 VA: 0x180ED4A80
	|-InputControlPath.MatchChildrenRecursive<object>
	*/

	// RVA: 0x279F960 Offset: 0x279E360 VA: 0x18279F960
	private static bool MatchPathComponent(string component, string path, ref int indexInPath, InputControlPath.PathComponentType componentType, int startIndexInComponent = 0) { }

	// RVA: 0x279FFB0 Offset: 0x279E9B0 VA: 0x18279FFB0
	private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath) { }

	[IteratorStateMachine(typeof(InputControlPath.<Parse>d__34))]
	// RVA: 0x279FF30 Offset: 0x279E930 VA: 0x18279FF30
	public static IEnumerable<InputControlPath.ParsedPathComponent> Parse(string path) { }
}
