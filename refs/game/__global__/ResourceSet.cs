public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 4670
{
	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0x1B90A70 Offset: 0x1B8F470 VA: 0x181B90A70
	protected void .ctor() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor(bool junk) { }

	// RVA: 0x1B8FE60 Offset: 0x1B8E860 VA: 0x181B8FE60
	private void CommonInit() { }

	// RVA: 0x1B8FEC0 Offset: 0x1B8E8C0 VA: 0x181B8FEC0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x10F5FF0 Offset: 0x10F49F0 VA: 0x1810F5FF0 Slot: 4
	public void Dispose() { }

	[ComVisible(False)]
	// RVA: 0x1B903C0 Offset: 0x1B8EDC0 VA: 0x181B903C0 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1B903C0 Offset: 0x1B8EDC0 VA: 0x181B903C0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1B90330 Offset: 0x1B8ED30 VA: 0x181B90330
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x1B905C0 Offset: 0x1B8EFC0 VA: 0x181B905C0 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0x1B907A0 Offset: 0x1B8F1A0 VA: 0x181B907A0 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0x1B903D0 Offset: 0x1B8EDD0 VA: 0x181B903D0 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0x1B904B0 Offset: 0x1B8EEB0 VA: 0x181B904B0 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0x1B903D0 Offset: 0x1B8EDD0 VA: 0x181B903D0
	private object GetObjectInternal(string name) { }

	// RVA: 0x1B8FFC0 Offset: 0x1B8E9C0 VA: 0x181B8FFC0
	private object GetCaseInsensitiveObjectInternal(string name) { }
}
