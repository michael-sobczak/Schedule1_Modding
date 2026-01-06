internal sealed class RegexReplacement // TypeDefIndex: 9569
{
	// Fields
	private const int Specials = 4;
	public const int LeftPortion = -1;
	public const int RightPortion = -2;
	public const int LastGroup = -3;
	public const int WholeString = -4;
	private readonly List<string> _strings; // 0x10
	private readonly List<int> _rules; // 0x18
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; // 0x20

	// Properties
	public string Pattern { get; }

	// Methods

	// RVA: 0x2639510 Offset: 0x2637F10 VA: 0x182639510
	public void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x2638830 Offset: 0x2637230 VA: 0x182638830
	public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Pattern() { }

	// RVA: 0x2639350 Offset: 0x2637D50 VA: 0x182639350
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x2639170 Offset: 0x2637B70 VA: 0x182639170
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x2638A90 Offset: 0x2637490 VA: 0x182638A90
	public string Replace(Regex regex, string input, int count, int startat) { }
}
