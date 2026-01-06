public class AdImpressionEvent : Event // TypeDefIndex: 17902
{
	// Fields
	private static readonly string[] k_AdPlacementTypeValues; // 0x0
	private static readonly string[] k_AdProviderValues; // 0x8
	private static readonly string[] k_AdCompletionStatusValues; // 0x10

	// Properties
	public AdCompletionStatus AdCompletionStatus { set; }
	public AdProvider AdProvider { set; }
	public string PlacementId { set; }
	public string PlacementName { set; }
	public AdPlacementType PlacementType { set; }
	public double AdEcpmUsd { set; }
	public string AdStoreDestinationId { set; }
	public string AdSdkVersion { set; }
	public string AdImpressionId { set; }
	public string AdMediaType { set; }
	public long AdTimeWatchedMs { set; }
	public long AdTimeCloseButtonShownMs { set; }
	public long AdLengthMs { set; }
	public bool AdHasClicked { set; }
	public string AdSource { set; }
	public string AdStatusCallback { set; }

	// Methods

	// RVA: 0x2B837A0 Offset: 0x2B821A0 VA: 0x182B837A0
	public void .ctor() { }

	// RVA: 0x2B837F0 Offset: 0x2B821F0 VA: 0x182B837F0
	public void set_AdCompletionStatus(AdCompletionStatus value) { }

	// RVA: 0x2B83B90 Offset: 0x2B82590 VA: 0x182B83B90
	public void set_AdProvider(AdProvider value) { }

	// RVA: 0x2B83FC0 Offset: 0x2B829C0 VA: 0x182B83FC0
	public void set_PlacementId(string value) { }

	// RVA: 0x2B84050 Offset: 0x2B82A50 VA: 0x182B84050
	public void set_PlacementName(string value) { }

	// RVA: 0x2B840E0 Offset: 0x2B82AE0 VA: 0x182B840E0
	public void set_PlacementType(AdPlacementType value) { }

	// RVA: 0x2B838C0 Offset: 0x2B822C0 VA: 0x182B838C0
	public void set_AdEcpmUsd(double value) { }

	// RVA: 0x2B83E10 Offset: 0x2B82810 VA: 0x182B83E10
	public void set_AdStoreDestinationId(string value) { }

	// RVA: 0x2B83C60 Offset: 0x2B82660 VA: 0x182B83C60
	public void set_AdSdkVersion(string value) { }

	// RVA: 0x2B839E0 Offset: 0x2B823E0 VA: 0x182B839E0
	public void set_AdImpressionId(string value) { }

	// RVA: 0x2B83B00 Offset: 0x2B82500 VA: 0x182B83B00
	public void set_AdMediaType(string value) { }

	// RVA: 0x2B83F30 Offset: 0x2B82930 VA: 0x182B83F30
	public void set_AdTimeWatchedMs(long value) { }

	// RVA: 0x2B83EA0 Offset: 0x2B828A0 VA: 0x182B83EA0
	public void set_AdTimeCloseButtonShownMs(long value) { }

	// RVA: 0x2B83A70 Offset: 0x2B82470 VA: 0x182B83A70
	public void set_AdLengthMs(long value) { }

	// RVA: 0x2B83950 Offset: 0x2B82350 VA: 0x182B83950
	public void set_AdHasClicked(bool value) { }

	// RVA: 0x2B83CF0 Offset: 0x2B826F0 VA: 0x182B83CF0
	public void set_AdSource(string value) { }

	// RVA: 0x2B83D80 Offset: 0x2B82780 VA: 0x182B83D80
	public void set_AdStatusCallback(string value) { }

	// RVA: 0x2B835C0 Offset: 0x2B81FC0 VA: 0x182B835C0 Slot: 5
	public override void Validate() { }

	// RVA: 0x2B836A0 Offset: 0x2B820A0 VA: 0x182B836A0
	private static void .cctor() { }
}
