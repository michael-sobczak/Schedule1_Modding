public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 16061
{
	// Fields
	[VcamTargetProperty]
	[NoSaveDuringPlay]
	[Tooltip("The object that the camera is looking at.  Setting this will improve the quality of the blends to and from this camera")]
	public Transform m_LookAt; // 0xA8
	private Camera m_Camera; // 0xB0
	private CameraState m_State; // 0xB8
	[CompilerGenerated]
	private Transform <Follow>k__BackingField; // 0x1A0
	[Tooltip("Hint for blending positions to and from this virtual camera")]
	[FormerlySerializedAs("m_PositionBlending")]
	public CinemachineVirtualCameraBase.BlendHint m_BlendHint; // 0x1A8

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0xBEB000 Offset: 0xBE9A00 VA: 0x180BEB000 Slot: 27
	public override CameraState get_State() { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0 Slot: 29
	public override Transform get_LookAt() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20 Slot: 30
	public override void set_LookAt(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0 Slot: 31
	public override Transform get_Follow() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800 Slot: 32
	public override void set_Follow(Transform value) { }

	// RVA: 0xBEA700 Offset: 0xBE9100 VA: 0x180BEA700 Slot: 35
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBEAE80 Offset: 0xBE9880 VA: 0x180BEAE80
	public void .ctor() { }
}
