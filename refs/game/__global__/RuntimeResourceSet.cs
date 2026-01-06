internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 4657
{
	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0x1B74640 Offset: 0x1B73040 VA: 0x181B74640
	internal void .ctor(string fileName) { }

	// RVA: 0x1B74520 Offset: 0x1B72F20 VA: 0x181B74520
	internal void .ctor(Stream stream) { }

	// RVA: 0x1B73700 Offset: 0x1B72100 VA: 0x181B73700 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B738E0 Offset: 0x1B722E0 VA: 0x181B738E0 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1B738E0 Offset: 0x1B722E0 VA: 0x181B738E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1B73840 Offset: 0x1B72240 VA: 0x181B73840
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x1B742C0 Offset: 0x1B72CC0 VA: 0x181B742C0 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0x1B74230 Offset: 0x1B72C30 VA: 0x181B74230 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0x1B738F0 Offset: 0x1B722F0 VA: 0x181B738F0 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0x1B74210 Offset: 0x1B72C10 VA: 0x181B74210 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0x1B73910 Offset: 0x1B72310 VA: 0x181B73910
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0x1B74340 Offset: 0x1B72D40 VA: 0x181B74340
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }
}
