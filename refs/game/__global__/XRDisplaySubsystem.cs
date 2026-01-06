public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 18918
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<bool> displayFocusChanged; // 0x20
	private HDROutputSettings m_HDROutputSettings; // 0x28

	// Properties
	public float scaleOfAllRenderTargets { set; }
	public float zNear { set; }
	public float zFar { set; }
	public bool sRGB { set; }
	public XRDisplaySubsystem.TextureLayout textureLayout { set; }
	public bool disableLegacyRenderer { set; }
	public HDROutputSettings hdrOutputSettings { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2C7AF20 Offset: 0x2C79920 VA: 0x182C7AF20
	private void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x2F61130 Offset: 0x2F5FB30 VA: 0x182F61130
	public void set_scaleOfAllRenderTargets(float value) { }

	// RVA: 0x2F61210 Offset: 0x2F5FC10 VA: 0x182F61210
	public void set_zNear(float value) { }

	// RVA: 0x2F611C0 Offset: 0x2F5FBC0 VA: 0x182F611C0
	public void set_zFar(float value) { }

	// RVA: 0x2F610E0 Offset: 0x2F5FAE0 VA: 0x182F610E0
	public void set_sRGB(bool value) { }

	// RVA: 0x2F61180 Offset: 0x2F5FB80 VA: 0x182F61180
	public void set_textureLayout(XRDisplaySubsystem.TextureLayout value) { }

	// RVA: 0x2F60FA0 Offset: 0x2F5F9A0 VA: 0x182F60FA0
	public void SetMSAALevel(int level) { }

	// RVA: 0x2F61090 Offset: 0x2F5FA90 VA: 0x182F61090
	public void set_disableLegacyRenderer(bool value) { }

	// RVA: 0x2F60D60 Offset: 0x2F5F760 VA: 0x182F60D60
	public int GetRenderPassCount() { }

	// RVA: 0x2F60DA0 Offset: 0x2F5F7A0 VA: 0x182F60DA0
	public void GetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass) { }

	[NativeMethod("TryGetRenderPass")]
	// RVA: 0x2F60F50 Offset: 0x2F5F950 VA: 0x182F60F50
	private bool Internal_TryGetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass) { }

	// RVA: 0x2F60AA0 Offset: 0x2F5F4A0 VA: 0x182F60AA0
	public void EndRecordingIfLateLatched(Camera camera) { }

	[NativeMethod("TryEndRecordingIfLateLatched")]
	// RVA: 0x2F60E90 Offset: 0x2F5F890 VA: 0x182F60E90
	private bool Internal_TryEndRecordingIfLateLatched(Camera camera) { }

	// RVA: 0x2F609C0 Offset: 0x2F5F3C0 VA: 0x182F609C0
	public void BeginRecordingIfLateLatched(Camera camera) { }

	[NativeMethod("TryBeginRecordingIfLateLatched")]
	// RVA: 0x2F60E40 Offset: 0x2F5F840 VA: 0x182F60E40
	private bool Internal_TryBeginRecordingIfLateLatched(Camera camera) { }

	// RVA: 0x2F60B80 Offset: 0x2F5F580 VA: 0x182F60B80
	public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
	[NativeMethod("TryGetCullingParams")]
	// RVA: 0x2F60EE0 Offset: 0x2F5F8E0 VA: 0x182F60EE0
	private bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "GetPreferredMirrorViewBlitMode", IsThreadSafe = False)]
	// RVA: 0x2F60D20 Offset: 0x2F5F720 VA: 0x182F60D20
	public int GetPreferredMirrorBlitMode() { }

	[NativeMethod(Name = "QueryMirrorViewBlitDesc", IsThreadSafe = False)]
	[NativeConditional("ENABLE_XR")]
	// RVA: 0x2F60CB0 Offset: 0x2F5F6B0 VA: 0x182F60CB0
	public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode) { }

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeMethod(Name = "AddGraphicsThreadMirrorViewBlit", IsThreadSafe = False)]
	// RVA: 0x2F60950 Offset: 0x2F5F350 VA: 0x182F60950
	public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode) { }

	// RVA: 0x2F61020 Offset: 0x2F5FA20 VA: 0x182F61020
	public HDROutputSettings get_hdrOutputSettings() { }

	// RVA: 0x2F60FE0 Offset: 0x2F5F9E0 VA: 0x182F60FE0
	public void .ctor() { }
}
