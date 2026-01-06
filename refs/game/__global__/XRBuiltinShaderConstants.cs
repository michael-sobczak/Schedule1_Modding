public static class XRBuiltinShaderConstants // TypeDefIndex: 13492
{
	// Fields
	public static readonly int unity_StereoCameraProjection; // 0x0
	public static readonly int unity_StereoCameraInvProjection; // 0x4
	public static readonly int unity_StereoMatrixV; // 0x8
	public static readonly int unity_StereoMatrixInvV; // 0xC
	public static readonly int unity_StereoMatrixP; // 0x10
	public static readonly int unity_StereoMatrixInvP; // 0x14
	public static readonly int unity_StereoMatrixVP; // 0x18
	public static readonly int unity_StereoMatrixInvVP; // 0x1C
	public static readonly int unity_StereoWorldSpaceCameraPos; // 0x20
	private static Matrix4x4[] s_cameraProjMatrix; // 0x28
	private static Matrix4x4[] s_invCameraProjMatrix; // 0x30
	private static Matrix4x4[] s_viewMatrix; // 0x38
	private static Matrix4x4[] s_invViewMatrix; // 0x40
	private static Matrix4x4[] s_projMatrix; // 0x48
	private static Matrix4x4[] s_invProjMatrix; // 0x50
	private static Matrix4x4[] s_viewProjMatrix; // 0x58
	private static Matrix4x4[] s_invViewProjMatrix; // 0x60
	private static Vector4[] s_worldSpaceCameraPos; // 0x68

	// Methods

	// RVA: 0x29DBF40 Offset: 0x29DA940 VA: 0x1829DBF40
	public static void UpdateBuiltinShaderConstants(Matrix4x4 viewMatrix, Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex) { }

	// RVA: 0x29DBDC0 Offset: 0x29DA7C0 VA: 0x1829DBDC0
	public static void SetBuiltinShaderConstants(CommandBuffer cmd) { }

	// RVA: 0x29DC4E0 Offset: 0x29DAEE0 VA: 0x1829DC4E0
	public static void Update(XRPass xrPass, CommandBuffer cmd, bool renderIntoTexture) { }

	// RVA: 0x29DCDA0 Offset: 0x29DB7A0 VA: 0x1829DCDA0
	private static void .cctor() { }
}
