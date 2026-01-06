public class CartelData : SaveData // TypeDefIndex: 991
{
	// Fields
	public ECartelStatus Status; // 0x28
	public int HoursSinceStatusChange; // 0x2C
	public CartelInfluence.RegionInfluenceData[] RegionInfluence; // 0x30
	public int HoursUntilNextGlobalActivity; // 0x38
	public CartelRegionalActivityData[] RegionalActivityData; // 0x40
	public CartelDealInfo ActiveCartelDeal; // 0x48
	public int HoursUntilNextDealRequest; // 0x50

	// Methods

	// RVA: 0x5D6020 Offset: 0x5D4A20 VA: 0x1805D6020
	public void .ctor(ECartelStatus status, int hoursSinceStatusChange, CartelInfluence.RegionInfluenceData[] regionInfluence, int hoursUntilNextGlobalActivity, CartelRegionalActivityData[] regionalActivityData, CartelDealInfo activeCartelDeal, int hoursUntilNextDealRequest) { }
}
