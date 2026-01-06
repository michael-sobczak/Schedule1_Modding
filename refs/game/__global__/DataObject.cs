public class DataObject : IDataObject, IDataObject // TypeDefIndex: 5309
{
	// Fields
	private DataObject.Entry entries; // 0x10

	// Methods

	// RVA: 0x23153A0 Offset: 0x2313DA0 VA: 0x1823153A0
	public void .ctor() { }

	// RVA: 0x23153D0 Offset: 0x2313DD0 VA: 0x1823153D0
	public void .ctor(string format, object data) { }

	// RVA: 0x2315160 Offset: 0x2313B60 VA: 0x182315160 Slot: 4
	private int System.Runtime.InteropServices.ComTypes.IDataObject.DAdvise(ref FORMATETC pFormatetc, ADVF advf, IAdviseSink adviseSink, out int connection) { }

	// RVA: 0x23151A0 Offset: 0x2313BA0 VA: 0x1823151A0 Slot: 5
	private void System.Runtime.InteropServices.ComTypes.IDataObject.DUnadvise(int connection) { }

	// RVA: 0x23151E0 Offset: 0x2313BE0 VA: 0x1823151E0 Slot: 6
	private int System.Runtime.InteropServices.ComTypes.IDataObject.EnumDAdvise(out IEnumSTATDATA enumAdvise) { }

	// RVA: 0x2315220 Offset: 0x2313C20 VA: 0x182315220 Slot: 7
	private IEnumFORMATETC System.Runtime.InteropServices.ComTypes.IDataObject.EnumFormatEtc(DATADIR direction) { }

	// RVA: 0x2315260 Offset: 0x2313C60 VA: 0x182315260 Slot: 8
	private int System.Runtime.InteropServices.ComTypes.IDataObject.GetCanonicalFormatEtc(ref FORMATETC formatIn, out FORMATETC formatOut) { }

	// RVA: 0x23152E0 Offset: 0x2313CE0 VA: 0x1823152E0 Slot: 9
	private void System.Runtime.InteropServices.ComTypes.IDataObject.GetData(ref FORMATETC format, out STGMEDIUM medium) { }

	// RVA: 0x23152A0 Offset: 0x2313CA0 VA: 0x1823152A0 Slot: 10
	private void System.Runtime.InteropServices.ComTypes.IDataObject.GetDataHere(ref FORMATETC format, ref STGMEDIUM medium) { }

	// RVA: 0x2315320 Offset: 0x2313D20 VA: 0x182315320 Slot: 11
	private int System.Runtime.InteropServices.ComTypes.IDataObject.QueryGetData(ref FORMATETC format) { }

	// RVA: 0x2315360 Offset: 0x2313D60 VA: 0x182315360 Slot: 12
	private void System.Runtime.InteropServices.ComTypes.IDataObject.SetData(ref FORMATETC formatIn, ref STGMEDIUM medium, bool release) { }

	// RVA: 0x2314DD0 Offset: 0x23137D0 VA: 0x182314DD0 Slot: 19
	public virtual object GetData(string format) { }

	// RVA: 0x2314DF0 Offset: 0x23137F0 VA: 0x182314DF0 Slot: 20
	public virtual object GetData(string format, bool autoConvert) { }

	// RVA: 0x2314DB0 Offset: 0x23137B0 VA: 0x182314DB0 Slot: 21
	public virtual bool GetDataPresent(string format) { }

	// RVA: 0x2314D40 Offset: 0x2313740 VA: 0x182314D40 Slot: 22
	public virtual bool GetDataPresent(string format, bool autoConvert) { }

	// RVA: 0x2314E70 Offset: 0x2313870 VA: 0x182314E70 Slot: 23
	public virtual string[] GetFormats() { }

	// RVA: 0x2314E90 Offset: 0x2313890 VA: 0x182314E90 Slot: 24
	public virtual string[] GetFormats(bool autoConvert) { }

	// RVA: 0x2314EA0 Offset: 0x23138A0 VA: 0x182314EA0 Slot: 25
	public virtual void SetData(object data) { }

	// RVA: 0x2315000 Offset: 0x2313A00 VA: 0x182315000 Slot: 26
	public virtual void SetData(string format, bool autoConvert, object data) { }

	// RVA: 0x2314FD0 Offset: 0x23139D0 VA: 0x182314FD0 Slot: 27
	public virtual void SetData(string format, object data) { }

	// RVA: 0x2314EF0 Offset: 0x23138F0 VA: 0x182314EF0 Slot: 28
	public virtual void SetData(Type format, object data) { }

	// RVA: 0x2314CC0 Offset: 0x23136C0 VA: 0x182314CC0
	internal string EnsureFormat(string name) { }

	// RVA: 0x2314C20 Offset: 0x2313620 VA: 0x182314C20
	internal string EnsureFormat(Type type) { }
}
