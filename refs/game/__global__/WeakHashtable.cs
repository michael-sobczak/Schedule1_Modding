internal sealed class WeakHashtable : Hashtable // TypeDefIndex: 9821
{
	// Fields
	private static IEqualityComparer _comparer; // 0x0
	private long _lastGlobalMem; // 0x50
	private int _lastHashCount; // 0x58

	// Methods

	// RVA: 0x2698D20 Offset: 0x2697720 VA: 0x182698D20
	internal void .ctor() { }

	// RVA: 0x2698780 Offset: 0x2697180 VA: 0x182698780 Slot: 24
	public override void Clear() { }

	// RVA: 0x2698790 Offset: 0x2697190 VA: 0x182698790 Slot: 39
	public override void Remove(object key) { }

	// RVA: 0x2698BE0 Offset: 0x26975E0 VA: 0x182698BE0
	public void SetWeak(object key, object value) { }

	// RVA: 0x26987A0 Offset: 0x26971A0 VA: 0x1826987A0
	private void ScavengeKeys() { }

	// RVA: 0x2698CA0 Offset: 0x26976A0 VA: 0x182698CA0
	private static void .cctor() { }
}
