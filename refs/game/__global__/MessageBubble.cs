public class MessageBubble : MonoBehaviour // TypeDefIndex: 2837
{
	// Fields
	[Header("Settings")]
	public string text; // 0x20
	public MessageBubble.Alignment alignment; // 0x28
	public bool showTriangle; // 0x2C
	public float bubble_MinWidth; // 0x30
	public float bubble_MaxWidth; // 0x34
	public bool alignTextCenter; // 0x38
	public bool autosetPosition; // 0x39
	private string displayedText; // 0x40
	private bool triangleShown; // 0x48
	[Header("References")]
	public RectTransform container; // 0x50
	[SerializeField]
	protected Image bubble; // 0x58
	[SerializeField]
	protected Text content; // 0x60
	[SerializeField]
	protected Image triangle_Left; // 0x68
	[SerializeField]
	protected Image triangle_Right; // 0x70
	public Button button; // 0x78
	public float height; // 0x80
	public float spacingAbove; // 0x84
	public static Color32 backgroundColor_Left; // 0x0
	public static Color32 textColor_Left; // 0x4
	public static Color32 backgroundColor_Right; // 0x8
	public static Color32 textColor_Right; // 0xC
	public static float baseBubbleSpacing; // 0x10

	// Methods

	// RVA: 0x94C5C0 Offset: 0x94AFC0 VA: 0x18094C5C0
	public void SetupBubble(string _text, MessageBubble.Alignment _alignment, bool alignCenter = False) { }

	// RVA: 0x94CB40 Offset: 0x94B540 VA: 0x18094CB40 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x94C230 Offset: 0x94AC30 VA: 0x18094C230 Slot: 5
	public virtual void RefreshDisplayedText() { }

	// RVA: 0x94C440 Offset: 0x94AE40 VA: 0x18094C440 Slot: 6
	protected virtual void RefreshTriangle() { }

	// RVA: 0x94CC50 Offset: 0x94B650 VA: 0x18094CC50
	public void .ctor() { }

	// RVA: 0x94CBA0 Offset: 0x94B5A0 VA: 0x18094CBA0
	private static void .cctor() { }
}
