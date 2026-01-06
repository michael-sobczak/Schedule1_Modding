public class Regex : ISerializable // TypeDefIndex: 9553
{
	// Fields
	private const int CacheDictionarySwitchLimit = 10;
	private static int s_cacheSize; // 0x0
	private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache; // 0x8
	private static int s_cacheCount; // 0x10
	private static Regex.CachedCodeEntry s_cacheFirst; // 0x18
	private static Regex.CachedCodeEntry s_cacheLast; // 0x20
	private static readonly TimeSpan s_maximumMatchTimeout; // 0x28
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
	internal static readonly TimeSpan s_defaultMatchTimeout; // 0x30
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x38
	protected internal TimeSpan internalMatchTimeout; // 0x10
	internal const int MaxOptionShift = 10;
	protected internal string pattern; // 0x18
	protected internal RegexOptions roptions; // 0x20
	protected internal RegexRunnerFactory factory; // 0x28
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference _runnerref; // 0x50
	internal WeakReference<RegexReplacement> _replref; // 0x58
	internal RegexCode _code; // 0x60
	internal bool _refsInitialized; // 0x68

	// Properties
	public RegexOptions Options { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x2626690 Offset: 0x2625090 VA: 0x182626690
	private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x2625FB0 Offset: 0x26249B0 VA: 0x182625FB0
	private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x2625EA0 Offset: 0x26248A0 VA: 0x182625EA0
	private void FillCacheDictionary() { }

	// RVA: 0x2628EC0 Offset: 0x26278C0 VA: 0x182628EC0
	private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry) { }

	// RVA: 0x2628D70 Offset: 0x2627770 VA: 0x182628D70
	private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry) { }

	// RVA: 0x2627010 Offset: 0x2625A10 VA: 0x182627010
	private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key) { }

	// RVA: 0x2626C50 Offset: 0x2625650 VA: 0x182626C50
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x2626EE0 Offset: 0x26258E0 VA: 0x182626EE0
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x2626DB0 Offset: 0x26257B0 VA: 0x182626DB0
	public bool IsMatch(string input) { }

	// RVA: 0x2626E50 Offset: 0x2625850 VA: 0x182626E50
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x2627730 Offset: 0x2626130 VA: 0x182627730
	public static Match Match(string input, string pattern) { }

	// RVA: 0x2627580 Offset: 0x2625F80 VA: 0x182627580
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x26274E0 Offset: 0x2625EE0 VA: 0x1826274E0
	public Match Match(string input) { }

	// RVA: 0x26276A0 Offset: 0x26260A0 VA: 0x1826276A0
	public Match Match(string input, int startat) { }

	// RVA: 0x2627890 Offset: 0x2626290 VA: 0x182627890
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x26285B0 Offset: 0x2626FB0 VA: 0x1826285B0
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x2627EF0 Offset: 0x26268F0 VA: 0x182627EF0
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x2628790 Offset: 0x2627190 VA: 0x182628790
	public string Replace(string input, string replacement) { }

	// RVA: 0x26288C0 Offset: 0x26272C0 VA: 0x1826288C0
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x2627BB0 Offset: 0x26265B0 VA: 0x182627BB0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x2627A60 Offset: 0x2626460 VA: 0x182627A60
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x2627D40 Offset: 0x2626740 VA: 0x182627D40
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x2627E20 Offset: 0x2626820 VA: 0x182627E20
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x2628090 Offset: 0x2626A90 VA: 0x182628090
	private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	// RVA: 0x2629150 Offset: 0x2627B50 VA: 0x182629150
	private static void .cctor() { }

	// RVA: 0x2628FE0 Offset: 0x26279E0 VA: 0x182628FE0
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x2626930 Offset: 0x2625330 VA: 0x182626930
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x2629890 Offset: 0x2628290 VA: 0x182629890
	protected void .ctor() { }

	// RVA: 0x26292C0 Offset: 0x2627CC0 VA: 0x1826292C0
	public void .ctor(string pattern) { }

	// RVA: 0x2629800 Offset: 0x2628200 VA: 0x182629800
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x2628D30 Offset: 0x2627730 VA: 0x182628D30 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x2629340 Offset: 0x2627D40 VA: 0x182629340
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x2625E00 Offset: 0x2624800 VA: 0x182625E00
	public static string Escape(string str) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public RegexOptions get_Options() { }

	// RVA: 0x2628FD0 Offset: 0x26279D0 VA: 0x182628FD0
	public bool get_RightToLeft() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2626800 Offset: 0x2625200 VA: 0x182626800
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x2626B50 Offset: 0x2625550 VA: 0x182626B50
	protected void InitializeReferences() { }

	// RVA: 0x26289E0 Offset: 0x26273E0 VA: 0x1826289E0
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x2628FD0 Offset: 0x26279D0 VA: 0x182628FD0
	protected internal bool UseOptionR() { }

	// RVA: 0x2628FC0 Offset: 0x26279C0 VA: 0x182628FC0
	internal bool UseOptionInvariant() { }
}
