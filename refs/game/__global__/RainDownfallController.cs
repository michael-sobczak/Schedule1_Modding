public class RainDownfallController : MonoBehaviour, ISkyModule // TypeDefIndex: 487
{
	// Fields
	public MeshRenderer rainMeshRenderer; // 0x20
	public Material rainMaterial; // 0x28
	private MaterialPropertyBlock m_PropertyBlock; // 0x30
	private AudioSource m_RainAudioSource; // 0x38
	private float m_TimeOfDay; // 0x40
	private SkyProfile m_SkyProfile; // 0x48

	// Methods

	// RVA: 0xA8A640 Offset: 0xA89040 VA: 0x180A8A640
	public void SetWeatherEnclosure(WeatherEnclosure enclosure) { }

	// RVA: 0xA8B0C0 Offset: 0xA89AC0 VA: 0x180A8B0C0
	private void Update() { }

	// RVA: 0xA8A850 Offset: 0xA89250 VA: 0x180A8A850 Slot: 4
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
