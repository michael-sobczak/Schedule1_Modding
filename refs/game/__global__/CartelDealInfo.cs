public class CartelDealInfo // TypeDefIndex: 2081
{
	// Fields
	public string RequestedProductID; // 0x10
	public int RequestedProductQuantity; // 0x18
	public int PaymentAmount; // 0x1C
	public GameDateTime DueTime; // 0x20
	public CartelDealInfo.EStatus Status; // 0x28

	// Methods

	// RVA: 0x8006A0 Offset: 0x7FF0A0 VA: 0x1808006A0
	public void .ctor(string requestedProductID, int requestedProductQuantity, int payment, GameDateTime dueTime, CartelDealInfo.EStatus status) { }

	// RVA: 0x800630 Offset: 0x7FF030 VA: 0x180800630
	public void .ctor() { }

	// RVA: 0x8005B0 Offset: 0x7FEFB0 VA: 0x1808005B0
	public bool IsValid() { }
}
