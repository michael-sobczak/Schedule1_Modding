public interface ICurrencyManagerProvider // TypeDefIndex: 5395
{
	// Properties
	public abstract CurrencyManager CurrencyManager { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CurrencyManager get_CurrencyManager();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract CurrencyManager GetRelatedCurrencyManager(string dataMember);
}
