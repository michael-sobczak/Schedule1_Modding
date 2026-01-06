public class BandwidthDisplay : MonoBehaviour // TypeDefIndex: 12668
{
	// Fields
	[SerializeField]
	[Tooltip("Color for text.")]
	private Color _color; // 0x20
	[SerializeField]
	[Tooltip("Which corner to display network statistics in.")]
	private BandwidthDisplay.Corner _placement; // 0x30
	[Tooltip("True to show outgoing data bytes.")]
	[SerializeField]
	private bool _showOutgoing; // 0x34
	[SerializeField]
	[Tooltip("True to show incoming data bytes.")]
	private bool _showIncoming; // 0x35
	private GUIStyle _style; // 0x38
	private string _clientText; // 0x40
	private string _serverText; // 0x48
	private NetworkTraficStatistics _networkTrafficStatistics; // 0x50
	private ulong peakBytesSentByServer; // 0x58

	// Methods

	// RVA: 0x66B030 Offset: 0x669A30 VA: 0x18066B030
	public void SetShowOutgoing(bool value) { }

	// RVA: 0x6604D0 Offset: 0x65EED0 VA: 0x1806604D0
	public void SetShowIncoming(bool value) { }

	// RVA: 0xD43380 Offset: 0xD41D80 VA: 0x180D43380
	public void .ctor() { }
}
