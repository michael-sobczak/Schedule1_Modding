public class VOEmitter : MonoBehaviour // TypeDefIndex: 604
{
	// Fields
	public const float PitchVariation = 0.05;
	[SerializeField]
	private VODatabase Database; // 0x20
	[Range(0.5, 2)]
	public float PitchMultiplier; // 0x28
	private float runtimePitchMultiplier; // 0x2C
	protected AudioSourceController audioSourceController; // 0x30
	private VODatabase defaultVODatabase; // 0x38

	// Methods

	// RVA: 0xAAF580 Offset: 0xAADF80 VA: 0x180AAF580 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xAAF5D0 Offset: 0xAADFD0 VA: 0x180AAF5D0 Slot: 5
	public virtual void Play(EVOLineType lineType) { }

	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	public void SetRuntimePitchMultiplier(float pitchMultiplier) { }

	// RVA: 0xAAF9B0 Offset: 0xAAE3B0 VA: 0x180AAF9B0
	public void SetDatabase(VODatabase database, bool writeDefault = True) { }

	// RVA: 0xAAF990 Offset: 0xAAE390 VA: 0x180AAF990
	public void ResetDatabase() { }

	// RVA: 0xA9E220 Offset: 0xA9CC20 VA: 0x180A9E220
	public void .ctor() { }
}
