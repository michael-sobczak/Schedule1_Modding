public class Toast : MonoBehaviour // TypeDefIndex: 18010
{
	// Fields
	[FormerlySerializedAs("text")]
	[SerializeField]
	protected GameObject Text; // 0x20
	private IText textComponent; // 0x28

	// Properties
	public string Message { get; set; }
	public RectTransform RectTransform { get; }

	// Methods

	// RVA: 0x443B20 Offset: 0x442520 VA: 0x180443B20
	public string get_Message() { }

	// RVA: 0x443BD0 Offset: 0x4425D0 VA: 0x180443BD0
	public void set_Message(string value) { }

	// RVA: 0x443B70 Offset: 0x442570 VA: 0x180443B70
	public RectTransform get_RectTransform() { }

	// RVA: 0x443AF0 Offset: 0x4424F0 VA: 0x180443AF0
	private void Awake() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
