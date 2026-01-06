public class RainSplashController : MonoBehaviour, ISkyModule // TypeDefIndex: 488
{
	// Fields
	private SkyProfile m_SkyProfile; // 0x20
	private float m_TimeOfDay; // 0x28
	private List<RainSplashRenderer> m_SplashRenderers; // 0x30

	// Methods

	// RVA: 0xA8B400 Offset: 0xA89E00 VA: 0x180A8B400
	private void Start() { }

	// RVA: 0xA87940 Offset: 0xA86340 VA: 0x180A87940 Slot: 4
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay) { }

	// RVA: 0xA8B480 Offset: 0xA89E80 VA: 0x180A8B480
	private void Update() { }

	// RVA: 0xA8B140 Offset: 0xA89B40 VA: 0x180A8B140
	public void ClearSplashRenderers() { }

	// RVA: 0xA8B250 Offset: 0xA89C50 VA: 0x180A8B250
	public void CreateSplashRenderers() { }

	// RVA: 0xA8B760 Offset: 0xA8A160 VA: 0x180A8B760
	public void .ctor() { }
}
