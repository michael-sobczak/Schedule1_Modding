public class DeliveryInstance // TypeDefIndex: 1968
{
	// Fields
	public string DeliveryID; // 0x10
	public string StoreName; // 0x18
	public string DestinationCode; // 0x20
	public int LoadingDockIndex; // 0x28
	public StringIntPair[] Items; // 0x30
	public EDeliveryStatus Status; // 0x38
	public int TimeUntilArrival; // 0x3C
	[CompilerGenerated]
	private DeliveryVehicle <ActiveVehicle>k__BackingField; // 0x40
	[CodegenExclude]
	public UnityEvent onDeliveryCompleted; // 0x48

	// Properties
	[CodegenExclude]
	public DeliveryVehicle ActiveVehicle { get; set; }
	[CodegenExclude]
	public Property Destination { get; }
	[CodegenExclude]
	public LoadingDock LoadingDock { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public DeliveryVehicle get_ActiveVehicle() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_ActiveVehicle(DeliveryVehicle value) { }

	// RVA: 0x798990 Offset: 0x797390 VA: 0x180798990
	public Property get_Destination() { }

	// RVA: 0x798A20 Offset: 0x797420 VA: 0x180798A20
	public LoadingDock get_LoadingDock() { }

	// RVA: 0x7988F0 Offset: 0x7972F0 VA: 0x1807988F0
	public void .ctor(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, StringIntPair[] items, EDeliveryStatus status, int timeUntilArrival) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x798600 Offset: 0x797000 VA: 0x180798600
	public int GetTimeStatus() { }

	// RVA: 0x798630 Offset: 0x797030 VA: 0x180798630
	public void SetStatus(EDeliveryStatus status) { }

	// RVA: 0x798430 Offset: 0x796E30 VA: 0x180798430
	public void AddItemsToDeliveryVehicle() { }

	// RVA: 0x798620 Offset: 0x797020 VA: 0x180798620
	public void OnMinPass() { }
}
