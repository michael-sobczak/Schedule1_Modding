public class PingDisplay : MonoBehaviour // TypeDefIndex: 12670
{
	// Fields
	[SerializeField]
	[Tooltip("Color for text.")]
	private Color _color; // 0x20
	[Tooltip("Which corner to display ping in.")]
	[SerializeField]
	private PingDisplay.Corner _placement; // 0x30
	[Tooltip("True to show the real ping. False to include tick rate latency within the ping.")]
	[SerializeField]
	private bool _hideTickRate; // 0x34
	private GUIStyle _style; // 0x38

	// Methods

	// RVA: 0xD4B440 Offset: 0xD49E40 VA: 0x180D4B440
	private void OnGUI() { }

	// RVA: 0xD4B6C0 Offset: 0xD4A0C0 VA: 0x180D4B6C0
	public void .ctor() { }
}
