public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 16134
{
	// Fields
	[Tooltip("The array containing explicitly defined blends between two Virtual Cameras")]
	public CinemachineBlenderSettings.CustomBlend[] m_CustomBlends; // 0x18
	public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**";

	// Methods

	// RVA: 0xC16590 Offset: 0xC14F90 VA: 0x180C16590
	public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }
}
