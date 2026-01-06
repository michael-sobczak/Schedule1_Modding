public class HumanPoseHandler : IDisposable // TypeDefIndex: 18307
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[FreeFunction("AnimationBindings::CreateHumanPoseHandler")]
	// RVA: 0x2C79CB0 Offset: 0x2C786B0 VA: 0x182C79CB0
	private static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root) { }

	[FreeFunction("AnimationBindings::DestroyHumanPoseHandler")]
	// RVA: 0x2C79D00 Offset: 0x2C78700 VA: 0x182C79D00
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2C79B80 Offset: 0x2C78580 VA: 0x182C79B80
	private void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] float[] muscles) { }

	// RVA: 0x2C79AE0 Offset: 0x2C784E0 VA: 0x182C79AE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2C79D40 Offset: 0x2C78740 VA: 0x182C79D40
	public void .ctor(Avatar avatar, Transform root) { }

	// RVA: 0x2C79BF0 Offset: 0x2C785F0 VA: 0x182C79BF0
	public void GetHumanPose(ref HumanPose humanPose) { }
}
