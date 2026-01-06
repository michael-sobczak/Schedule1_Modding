internal class ExpandoClass // TypeDefIndex: 15628
{
	// Fields
	private readonly string[] _keys; // 0x10
	private readonly int _hashCode; // 0x18
	private Dictionary<int, List<WeakReference>> _transitions; // 0x20
	internal static readonly ExpandoClass Empty; // 0x0

	// Properties
	internal string[] Keys { get; }

	// Methods

	// RVA: 0x1FEA780 Offset: 0x1FE9180 VA: 0x181FEA780
	internal void .ctor() { }

	// RVA: 0x1FEA730 Offset: 0x1FE9130 VA: 0x181FEA730
	internal void .ctor(string[] keys, int hashCode) { }

	// RVA: 0x1FE9E50 Offset: 0x1FE8850 VA: 0x181FE9E50
	internal ExpandoClass FindNewClass(string newKey) { }

	// RVA: 0x1FEA320 Offset: 0x1FE8D20 VA: 0x181FEA320
	private List<WeakReference> GetTransitionList(int hashCode) { }

	// RVA: 0x1FEA660 Offset: 0x1FE9060 VA: 0x181FEA660
	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	// RVA: 0x1FEA5C0 Offset: 0x1FE8FC0 VA: 0x181FEA5C0
	internal int GetValueIndexCaseSensitive(string name) { }

	// RVA: 0x1FEA450 Offset: 0x1FE8E50 VA: 0x181FEA450
	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal string[] get_Keys() { }

	// RVA: 0x1FEA680 Offset: 0x1FE9080 VA: 0x181FEA680
	private static void .cctor() { }
}
