public interface IDataObject // TypeDefIndex: 9534
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int DAdvise(in FORMATETC pFormatetc, ADVF advf, IAdviseSink adviseSink, out int connection);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DUnadvise(int connection);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int EnumDAdvise(out IEnumSTATDATA enumAdvise);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumFORMATETC EnumFormatEtc(DATADIR direction);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetCanonicalFormatEtc(in FORMATETC formatIn, out FORMATETC formatOut);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetData(in FORMATETC format, out STGMEDIUM medium);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetDataHere(in FORMATETC format, ref STGMEDIUM medium);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int QueryGetData(in FORMATETC format);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetData(in FORMATETC formatIn, in STGMEDIUM medium, bool release);
}
