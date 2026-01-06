public class ContractReceipt // TypeDefIndex: 1479
{
	// Fields
	public int ReceiptId; // 0x10
	public EContractParty CompletedBy; // 0x14
	public string CustomerId; // 0x18
	public GameDateTime CompletionTime; // 0x20
	public StringIntPair[] Items; // 0x28
	public float AmountPaid; // 0x30

	// Methods

	// RVA: 0x6AA930 Offset: 0x6A9330 VA: 0x1806AA930
	public void .ctor(int receiptId, EContractParty completedBy, string customerID, GameDateTime completionTime, StringIntPair[] items, float amountPaid) { }

	// RVA: 0x6AA870 Offset: 0x6A9270 VA: 0x1806AA870
	public void .ctor() { }
}
