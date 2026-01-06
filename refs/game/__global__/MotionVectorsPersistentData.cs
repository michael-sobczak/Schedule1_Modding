internal sealed class MotionVectorsPersistentData // TypeDefIndex: 8905
{
	// Fields
	private const int k_EyeCount = 2;
	private readonly Matrix4x4[] m_ViewProjection; // 0x10
	private readonly Matrix4x4[] m_PreviousViewProjection; // 0x18
	private readonly int[] m_LastFrameIndex; // 0x20
	private readonly float[] m_PrevAspectRatio; // 0x28

	// Properties
	internal int lastFrameIndex { get; }
	internal Matrix4x4 viewProjection { get; }
	internal Matrix4x4 previousViewProjection { get; }
	internal Matrix4x4[] viewProjectionStereo { get; }
	internal Matrix4x4[] previousViewProjectionStereo { get; }

	// Methods

	// RVA: 0x2B08530 Offset: 0x2B06F30 VA: 0x182B08530
	internal void .ctor() { }

	// RVA: 0x2B08770 Offset: 0x2B07170 VA: 0x182B08770
	internal int get_lastFrameIndex() { }

	// RVA: 0x2B087F0 Offset: 0x2B071F0 VA: 0x182B087F0
	internal Matrix4x4 get_viewProjection() { }

	// RVA: 0x2B087A0 Offset: 0x2B071A0 VA: 0x182B087A0
	internal Matrix4x4 get_previousViewProjection() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal Matrix4x4[] get_viewProjectionStereo() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal Matrix4x4[] get_previousViewProjectionStereo() { }

	// RVA: 0x2B07DB0 Offset: 0x2B067B0 VA: 0x182B07DB0
	public void Reset() { }

	// RVA: 0x2B07D60 Offset: 0x2B06760 VA: 0x182B07D60
	internal int GetXRMultiPassId(ref CameraData cameraData) { }

	// RVA: 0x2B07F30 Offset: 0x2B06930 VA: 0x182B07F30
	public void Update(ref CameraData cameraData) { }
}
