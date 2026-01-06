public class DeliveryStatusDisplay : MonoBehaviour // TypeDefIndex: 2827
{
	// Fields
	[CompilerGenerated]
	private DeliveryInstance <DeliveryInstance>k__BackingField; // 0x20
	public GameObject ItemEntryPrefab; // 0x28
	[Header("References")]
	public RectTransform Rect; // 0x30
	public Text DestinationLabel; // 0x38
	public Text ShopLabel; // 0x40
	public Image StatusImage; // 0x48
	public Text StatusLabel; // 0x50
	public Tooltip StatusTooltip; // 0x58
	public RectTransform ItemEntryContainer; // 0x60
	[Header("Settings")]
	public Color StatusColor_Transit; // 0x68
	public Color StatusColor_Waiting; // 0x78
	public Color StatusColor_Arrived; // 0x88

	// Properties
	public DeliveryInstance DeliveryInstance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public DeliveryInstance get_DeliveryInstance() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_DeliveryInstance(DeliveryInstance value) { }

	// RVA: 0x949320 Offset: 0x947D20 VA: 0x180949320
	public void AssignDelivery(DeliveryInstance instance) { }

	// RVA: 0x949690 Offset: 0x948090 VA: 0x180949690
	public void RefreshStatus() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
