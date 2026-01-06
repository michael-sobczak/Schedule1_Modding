public class RegionUnlockedCanvas : Singleton<RegionUnlockedCanvas>, IPostSleepEvent // TypeDefIndex: 2702
{
	// Fields
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Order>k__BackingField; // 0x2C
	public Animation OpenCloseAnim; // 0x30
	public TextMeshProUGUI RegionLabel; // 0x38
	public TextMeshProUGUI RegionDescription; // 0x40
	public Image RegionImage; // 0x48
	private EMapRegion region; // 0x50

	// Properties
	public bool IsRunning { get; set; }
	public int Order { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120 Slot: 7
	public bool get_IsRunning() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsRunning(bool value) { }

	[CompilerGenerated]
	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590 Slot: 8
	public int get_Order() { }

	[CompilerGenerated]
	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	private void set_Order(int value) { }

	// RVA: 0x917060 Offset: 0x915A60 VA: 0x180917060
	public void QueueUnlocked(EMapRegion _region) { }

	// RVA: 0x9170F0 Offset: 0x915AF0 VA: 0x1809170F0 Slot: 9
	public void StartEvent() { }

	// RVA: 0x917000 Offset: 0x915A00 VA: 0x180917000
	public void EndEvent() { }

	// RVA: 0x9177A0 Offset: 0x9161A0 VA: 0x1809177A0
	public void .ctor() { }
}
