public class WeatherEnclosureDetector : MonoBehaviour // TypeDefIndex: 494
{
	// Fields
	[Tooltip("Default enclosure used when not inside the trigger of another enclosure area.")]
	public WeatherEnclosure mainEnclosure; // 0x20
	private List<WeatherEnclosure> triggeredEnclosures; // 0x28
	public RainDownfallController rainController; // 0x30
	public Action<WeatherEnclosure> enclosureChangedCallback; // 0x38

	// Methods

	// RVA: 0xA94530 Offset: 0xA92F30 VA: 0x180A94530
	private void Start() { }

	// RVA: 0xA94530 Offset: 0xA92F30 VA: 0x180A94530
	private void OnEnable() { }

	// RVA: 0xA94540 Offset: 0xA92F40 VA: 0x180A94540
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0xA946B0 Offset: 0xA930B0 VA: 0x180A946B0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0xA94430 Offset: 0xA92E30 VA: 0x180A94430
	public void ApplyEnclosure() { }

	// RVA: 0xA947A0 Offset: 0xA931A0 VA: 0x180A947A0
	public void .ctor() { }
}
