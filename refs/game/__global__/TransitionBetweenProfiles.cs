public class TransitionBetweenProfiles : MonoBehaviour // TypeDefIndex: 495
{
	// Fields
	public SkyProfile daySkyProfile; // 0x20
	public SkyProfile nightSkyProfile; // 0x28
	[Tooltip("How long the transition animation will last.")]
	[Range(0.1, 30)]
	public float transitionDuration; // 0x30
	public TimeOfDayController timeOfDayController; // 0x38
	private SkyProfile m_CurrentSkyProfile; // 0x40

	// Methods

	// RVA: 0xA923B0 Offset: 0xA90DB0 VA: 0x180A923B0
	private void Start() { }

	// RVA: 0xA92480 Offset: 0xA90E80 VA: 0x180A92480
	public void ToggleSkyProfiles() { }

	// RVA: 0xA78910 Offset: 0xA77310 VA: 0x180A78910
	public void .ctor() { }
}
