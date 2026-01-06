public class CountdownText : MonoBehaviour // TypeDefIndex: 2281
{
	// Fields
	public TextMeshProUGUI TimeLabel; // 0x20
	[Header("Date Setting")]
	public int Year; // 0x28
	public int Month; // 0x2C
	public int Day; // 0x30
	public int Hour; // 0x34
	public int Minute; // 0x38
	public int Second; // 0x3C
	private DateTime targetPDTDate; // 0x40

	// Methods

	// RVA: 0x83FDF0 Offset: 0x83E7F0 VA: 0x18083FDF0
	private void Start() { }

	// RVA: 0x83FF10 Offset: 0x83E910 VA: 0x18083FF10
	private void Update() { }

	// RVA: 0x83FF10 Offset: 0x83E910 VA: 0x18083FF10
	private void UpdateCountdown() { }

	// RVA: 0x83FC50 Offset: 0x83E650 VA: 0x18083FC50
	private string FormatTime(TimeSpan timeSpan) { }

	// RVA: 0x840020 Offset: 0x83EA20 VA: 0x180840020
	public void .ctor() { }
}
