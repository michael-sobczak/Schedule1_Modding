public class LightningController : MonoBehaviour, ISkyModule // TypeDefIndex: 484
{
	// Fields
	private SkyProfile m_SkyProfile; // 0x20
	private float m_TimeOfDay; // 0x28
	private List<LightningRenderer> m_LightningRenderers; // 0x30

	// Methods

	// RVA: 0xA878C0 Offset: 0xA862C0 VA: 0x180A878C0
	private void Start() { }

	// RVA: 0xA87940 Offset: 0xA86340 VA: 0x180A87940 Slot: 4
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay) { }

	// RVA: 0xA87970 Offset: 0xA86370 VA: 0x180A87970
	public void Update() { }

	// RVA: 0xA87600 Offset: 0xA86000 VA: 0x180A87600
	public void ClearLightningRenderers() { }

	// RVA: 0xA87710 Offset: 0xA86110 VA: 0x180A87710
	public void CreateLightningRenderers() { }

	// RVA: 0xA87CE0 Offset: 0xA866E0 VA: 0x180A87CE0
	public void .ctor() { }
}
