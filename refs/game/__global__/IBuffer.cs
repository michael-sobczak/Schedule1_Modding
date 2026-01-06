internal interface IBuffer // TypeDefIndex: 17938
{
	// Properties
	public abstract int Length { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PushStandardEventStart(string name, int version);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PushCustomEventStart(string name);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PushEndEvent();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void PushDouble(string name, double value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PushFloat(string name, float value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PushString(string name, string value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PushInt64(string name, long value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PushInt(string name, int value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PushBool(string name, bool value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void PushObject(string name, object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void PushProduct(string name, TransactionRealCurrency realCurrency, List<TransactionVirtualCurrency> virtualCurrencies, List<TransactionItem> items);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void FlushToDisk();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ClearDiskCache();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void LoadFromDisk();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int get_Length();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract byte[] Serialize();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ClearBuffer();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ClearBuffer(long upTo);
}
