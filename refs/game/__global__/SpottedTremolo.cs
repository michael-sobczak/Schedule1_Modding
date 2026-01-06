public class SpottedTremolo : MonoBehaviour // TypeDefIndex: 2550
{
	// Fields
	[Range(0, 1)]
	public float Intensity; // 0x20
	public AudioSourceController Loop; // 0x28
	public EntityVisibility PlayerVisibility; // 0x30
	[Header("Settings")]
	public float MinVolume; // 0x38
	public float MaxVolume; // 0x3C
	public float MinPitch; // 0x40
	public float MaxPitch; // 0x44
	public float SmoothTime; // 0x48
	[SerializeField]
	[Range(0, 1)]
	private float smoothedIntensity; // 0x4C

	// Methods

	// RVA: 0x8BD3B0 Offset: 0x8BBDB0 VA: 0x1808BD3B0
	public void Update() { }

	// RVA: 0x8BD690 Offset: 0x8BC090 VA: 0x1808BD690
	public void .ctor() { }
}
