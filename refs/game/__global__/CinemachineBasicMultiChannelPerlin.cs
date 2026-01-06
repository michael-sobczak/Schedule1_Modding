public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 16096
{
	// Fields
	[Tooltip("The asset containing the Noise Profile.  Define the frequencies and amplitudes there to make a characteristic noise profile.  Make your own or just use one of the many presets.")]
	[FormerlySerializedAs("m_Definition")]
	[NoiseSettingsProperty]
	public NoiseSettings m_NoiseProfile; // 0x28
	[Tooltip("When rotating the camera, offset the camera's pivot position by this much (camera space)")]
	public Vector3 m_PivotOffset; // 0x30
	[Tooltip("Gain to apply to the amplitudes defined in the NoiseSettings asset.  1 is normal.  Setting this to 0 completely mutes the noise.")]
	public float m_AmplitudeGain; // 0x3C
	[Tooltip("Scale factor to apply to the frequencies defined in the NoiseSettings asset.  1 is normal.  Larger magnitudes will make the noise shake more rapidly.")]
	public float m_FrequencyGain; // 0x40
	private bool mInitialized; // 0x44
	private float mNoiseTime; // 0x48
	[HideInInspector]
	[SerializeField]
	private Vector3 mNoiseOffsets; // 0x4C

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0xBF71B0 Offset: 0xBF5BB0 VA: 0x180BF71B0 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0xBF67F0 Offset: 0xBF51F0 VA: 0x180BF67F0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBF7080 Offset: 0xBF5A80 VA: 0x180BF7080
	public void ReSeed() { }

	// RVA: 0xBF6690 Offset: 0xBF5090 VA: 0x180BF6690
	private void Initialize() { }

	// RVA: 0xBF7110 Offset: 0xBF5B10 VA: 0x180BF7110
	public void .ctor() { }
}
