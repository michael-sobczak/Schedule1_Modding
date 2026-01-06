public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 16179
{
	// Fields
	[FormerlySerializedAs("m_Position")]
	[Tooltip("These are the noise channels for the virtual camera's position. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
	public NoiseSettings.TransformNoiseParams[] PositionNoise; // 0x18
	[Tooltip("These are the noise channels for the virtual camera's orientation. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
	[FormerlySerializedAs("m_Orientation")]
	public NoiseSettings.TransformNoiseParams[] OrientationNoise; // 0x20

	// Properties
	public override float SignalDuration { get; }

	// Methods

	// RVA: 0xC24290 Offset: 0xC22C90 VA: 0x180C24290
	public static Vector3 GetCombinedFilterResults(NoiseSettings.TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets) { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 6
	public override float get_SignalDuration() { }

	// RVA: 0xC243E0 Offset: 0xC22DE0 VA: 0x180C243E0 Slot: 7
	public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0xC24540 Offset: 0xC22F40 VA: 0x180C24540
	public void .ctor() { }
}
