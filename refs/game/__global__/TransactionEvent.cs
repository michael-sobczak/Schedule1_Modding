public class TransactionEvent : Event // TypeDefIndex: 17912
{
	// Fields
	private static readonly string[] k_TransactionTypeValues; // 0x0
	private static readonly string[] k_TransactionServerValues; // 0x8
	[CompilerGenerated]
	private TransactionRealCurrency <SpentRealCurrency>k__BackingField; // 0x40
	[CompilerGenerated]
	private List<TransactionVirtualCurrency> <SpentVirtualCurrencies>k__BackingField; // 0x48
	[CompilerGenerated]
	private List<TransactionItem> <SpentItems>k__BackingField; // 0x50
	[CompilerGenerated]
	private TransactionRealCurrency <ReceivedRealCurrency>k__BackingField; // 0x58
	[CompilerGenerated]
	private List<TransactionVirtualCurrency> <ReceivedVirtualCurrencies>k__BackingField; // 0x60
	[CompilerGenerated]
	private List<TransactionItem> <ReceivedItems>k__BackingField; // 0x68

	// Properties
	public string TransactionName { set; }
	public string TransactionId { set; }
	public TransactionType TransactionType { set; }
	public string PaymentCountry { set; }
	public string ProductId { set; }
	public string StoreItemSkuId { set; }
	public string StoreItemId { set; }
	public string StoreId { set; }
	public string StoreSourceId { set; }
	public string TransactionReceipt { set; }
	public string TransactionReceiptSignature { set; }
	public TransactionServer TransactionServer { set; }
	public string TransactorID { set; }
	public TransactionRealCurrency SpentRealCurrency { get; set; }
	public List<TransactionVirtualCurrency> SpentVirtualCurrencies { get; set; }
	public List<TransactionItem> SpentItems { get; set; }
	public TransactionRealCurrency ReceivedRealCurrency { get; set; }
	public List<TransactionVirtualCurrency> ReceivedVirtualCurrencies { get; set; }
	public List<TransactionItem> ReceivedItems { get; set; }

	// Methods

	// RVA: 0x2B94330 Offset: 0x2B92D30 VA: 0x182B94330
	public void .ctor() { }

	// RVA: 0x2B94370 Offset: 0x2B92D70 VA: 0x182B94370
	protected internal void .ctor(string name) { }

	// RVA: 0x2B94890 Offset: 0x2B93290 VA: 0x182B94890
	public void set_TransactionName(string value) { }

	// RVA: 0x2B94800 Offset: 0x2B93200 VA: 0x182B94800
	public void set_TransactionId(string value) { }

	// RVA: 0x2B94B10 Offset: 0x2B93510 VA: 0x182B94B10
	public void set_TransactionType(TransactionType value) { }

	// RVA: 0x2B944A0 Offset: 0x2B92EA0 VA: 0x182B944A0
	public void set_PaymentCountry(string value) { }

	// RVA: 0x2B94530 Offset: 0x2B92F30 VA: 0x182B94530
	public void set_ProductId(string value) { }

	// RVA: 0x2B946E0 Offset: 0x2B930E0 VA: 0x182B946E0
	public void set_StoreItemSkuId(string value) { }

	// RVA: 0x2B94650 Offset: 0x2B93050 VA: 0x182B94650
	public void set_StoreItemId(string value) { }

	// RVA: 0x2B945C0 Offset: 0x2B92FC0 VA: 0x182B945C0
	public void set_StoreId(string value) { }

	// RVA: 0x2B94770 Offset: 0x2B93170 VA: 0x182B94770
	public void set_StoreSourceId(string value) { }

	// RVA: 0x2B949B0 Offset: 0x2B933B0 VA: 0x182B949B0
	public void set_TransactionReceipt(string value) { }

	// RVA: 0x2B94920 Offset: 0x2B93320 VA: 0x182B94920
	public void set_TransactionReceiptSignature(string value) { }

	// RVA: 0x2B94A40 Offset: 0x2B93440 VA: 0x182B94A40
	public void set_TransactionServer(TransactionServer value) { }

	// RVA: 0x2B94BE0 Offset: 0x2B935E0 VA: 0x182B94BE0
	public void set_TransactorID(string value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public TransactionRealCurrency get_SpentRealCurrency() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_SpentRealCurrency(TransactionRealCurrency value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public List<TransactionVirtualCurrency> get_SpentVirtualCurrencies() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_SpentVirtualCurrencies(List<TransactionVirtualCurrency> value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public List<TransactionItem> get_SpentItems() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_SpentItems(List<TransactionItem> value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public TransactionRealCurrency get_ReceivedRealCurrency() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_ReceivedRealCurrency(TransactionRealCurrency value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public List<TransactionVirtualCurrency> get_ReceivedVirtualCurrencies() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_ReceivedVirtualCurrencies(List<TransactionVirtualCurrency> value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public List<TransactionItem> get_ReceivedItems() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_ReceivedItems(List<TransactionItem> value) { }

	// RVA: 0x2B94060 Offset: 0x2B92A60 VA: 0x182B94060 Slot: 4
	internal override void Serialize(IBuffer buffer) { }

	// RVA: 0x2B941A0 Offset: 0x2B92BA0 VA: 0x182B941A0 Slot: 5
	public override void Validate() { }

	// RVA: 0x2B93EB0 Offset: 0x2B928B0 VA: 0x182B93EB0 Slot: 6
	public override void Reset() { }

	// RVA: 0x2B94280 Offset: 0x2B92C80 VA: 0x182B94280
	private static void .cctor() { }
}
