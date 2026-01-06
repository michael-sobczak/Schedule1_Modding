public abstract class RenderPipeline // TypeDefIndex: 12258
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }
	public virtual RenderPipelineGlobalSettings defaultSettings { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-RenderPipeline.ProcessRenderRequests<object>
	|-RenderPipeline.ProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected internal virtual bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF32510 Offset: 0xF30F10 VA: 0x180F32510
	|-RenderPipeline.IsRenderRequestSupported<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2CE67F0 Offset: 0x2CE51F0 VA: 0x182CE67F0
	protected static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x2CE6790 Offset: 0x2CE5190 VA: 0x182CE6790
	protected static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2CE6920 Offset: 0x2CE5320 VA: 0x182CE6920
	protected static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x2CE68C0 Offset: 0x2CE52C0 VA: 0x182CE68C0
	protected static void EndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2CE6A10 Offset: 0x2CE5410 VA: 0x182CE6A10 Slot: 7
	protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x2CE6980 Offset: 0x2CE5380 VA: 0x182CE6980
	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: -1 Offset: -1
	internal void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF32430 Offset: 0xF30E30 VA: 0x180F32430
	|-RenderPipeline.InternalProcessRenderRequests<object>
	|
	|-RVA: 0xF322D0 Offset: 0xF30CD0 VA: 0x180F322D0
	|-RenderPipeline.InternalProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	private void set_disposed(bool value) { }

	// RVA: 0x2CE6850 Offset: 0x2CE5250 VA: 0x182CE6850
	internal void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1102840 Offset: 0x1101240 VA: 0x181102840 Slot: 9
	public virtual RenderPipelineGlobalSettings get_defaultSettings() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
