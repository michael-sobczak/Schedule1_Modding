internal class UIRenderDevice : IDisposable // TypeDefIndex: 7084
{
	// Fields
	private readonly bool m_MockDevice; // 0x10
	private IntPtr m_DefaultStencilState; // 0x18
	private IntPtr m_VertexDecl; // 0x20
	private Page m_FirstPage; // 0x28
	private uint m_NextPageVertexCount; // 0x30
	private uint m_LargeMeshVertexCount; // 0x34
	private float m_IndexToVertexCountRatio; // 0x38
	private List<List<UIRenderDevice.AllocToFree>> m_DeferredFrees; // 0x40
	private List<List<UIRenderDevice.AllocToUpdate>> m_Updates; // 0x48
	private uint[] m_Fences; // 0x50
	private MaterialPropertyBlock m_StandardMatProps; // 0x58
	private uint m_FrameIndex; // 0x60
	private uint m_NextUpdateID; // 0x64
	private UIRenderDevice.DrawStatistics m_DrawStats; // 0x68
	private readonly LinkedPool<MeshHandle> m_MeshHandles; // 0x90
	private readonly DrawParams m_DrawParams; // 0x98
	private readonly TextureSlotManager m_TextureSlotManager; // 0xA0
	private static LinkedList<UIRenderDevice.DeviceToFree> m_DeviceFreeQueue; // 0x0
	private static int m_ActiveDeviceCount; // 0x8
	private static bool m_SubscribedToNotifications; // 0xC
	private static bool m_SynchronousFree; // 0xD
	private static readonly int s_GradientSettingsTexID; // 0x10
	private static readonly int s_ShaderInfoTexID; // 0x14
	private static readonly int s_TransformsPropID; // 0x18
	private static readonly int s_ClipRectsPropID; // 0x1C
	private static ProfilerMarker s_MarkerAllocate; // 0x20
	private static ProfilerMarker s_MarkerFree; // 0x28
	private static ProfilerMarker s_MarkerAdvanceFrame; // 0x30
	private static ProfilerMarker s_MarkerFence; // 0x38
	private static ProfilerMarker s_MarkerBeforeDraw; // 0x40
	private static Nullable<bool> s_VertexTexturingIsAvailable; // 0x48
	private static Nullable<bool> s_ShaderModelIs35; // 0x4A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly uint <maxVerticesPerPage>k__BackingField; // 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <breakBatches>k__BackingField; // 0xAC
	private static Texture2D s_DefaultShaderInfoTexFloat; // 0x50
	private static Texture2D s_DefaultShaderInfoTexARGB8; // 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0xAD

	// Properties
	internal uint maxVerticesPerPage { get; }
	internal bool breakBatches { get; set; }
	internal static Texture2D defaultShaderInfoTexFloat { get; }
	internal static Texture2D defaultShaderInfoTexARGB8 { get; }
	internal static bool vertexTexturingIsAvailable { get; }
	internal static bool shaderModelIs35 { get; }
	private bool fullyCreated { get; }
	protected bool disposed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	internal uint get_maxVerticesPerPage() { }

	[CompilerGenerated]
	// RVA: 0x4E2700 Offset: 0x4E1100 VA: 0x1804E2700
	internal bool get_breakBatches() { }

	[CompilerGenerated]
	// RVA: 0x4E2B90 Offset: 0x4E1590 VA: 0x1804E2B90
	internal void set_breakBatches(bool value) { }

	// RVA: 0x2E0A750 Offset: 0x2E09150 VA: 0x182E0A750
	private static void .cctor() { }

	// RVA: 0x2E0B3B0 Offset: 0x2E09DB0 VA: 0x182E0B3B0
	public void .ctor(uint initialVertexCapacity = 0, uint initialIndexCapacity = 0) { }

	// RVA: 0x2E0AC00 Offset: 0x2E09600 VA: 0x182E0AC00
	protected void .ctor(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice) { }

	// RVA: 0x2E0B7A0 Offset: 0x2E0A1A0 VA: 0x182E0B7A0
	internal static Texture2D get_defaultShaderInfoTexFloat() { }

	// RVA: 0x2E0B3D0 Offset: 0x2E09DD0 VA: 0x182E0B3D0
	internal static Texture2D get_defaultShaderInfoTexARGB8() { }

	// RVA: 0x2E0BF70 Offset: 0x2E0A970 VA: 0x182E0BF70
	internal static bool get_vertexTexturingIsAvailable() { }

	// RVA: 0x2E0BD90 Offset: 0x2E0A790 VA: 0x182E0BD90
	internal static bool get_shaderModelIs35() { }

	// RVA: 0x2E08640 Offset: 0x2E07040 VA: 0x182E08640
	private void InitVertexDeclaration() { }

	// RVA: 0x2E06C50 Offset: 0x2E05650 VA: 0x182E06C50
	private void CompleteCreation() { }

	// RVA: 0x2E0BD80 Offset: 0x2E0A780 VA: 0x182E0BD80
	private bool get_fullyCreated() { }

	[CompilerGenerated]
	// RVA: 0x2E0BD70 Offset: 0x2E0A770 VA: 0x182E0BD70
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x2E0C150 Offset: 0x2E0AB50 VA: 0x182E0C150
	private void set_disposed(bool value) { }

	// RVA: 0x2E07000 Offset: 0x2E05A00 VA: 0x182E07000 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E06E60 Offset: 0x2E05860 VA: 0x182E06E60 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2E05F60 Offset: 0x2E04960 VA: 0x182E05F60
	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) { }

	// RVA: 0x2E0A120 Offset: 0x2E08B20 VA: 0x182E0A120
	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData) { }

	// RVA: 0x2E0A360 Offset: 0x2E08D60 VA: 0x182E0A360
	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) { }

	// RVA: 0x2E09EF0 Offset: 0x2E088F0 VA: 0x182E09EF0
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	// RVA: 0x2E05460 Offset: 0x2E03E60 VA: 0x182E05460
	internal List<UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	// RVA: 0x2E09610 Offset: 0x2E08010 VA: 0x182E09610
	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) { }

	// RVA: 0x2E06030 Offset: 0x2E04A30 VA: 0x182E06030
	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived) { }

	// RVA: 0x2E097B0 Offset: 0x2E081B0 VA: 0x182E097B0
	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out UIRenderDevice.AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	// RVA: 0x2E07F10 Offset: 0x2E06910 VA: 0x182E07F10
	public void Free(MeshHandle mesh) { }

	// RVA: 0x2E08CD0 Offset: 0x2E076D0 VA: 0x182E08CD0
	public void OnFrameRenderingBegin() { }

	// RVA: -1 Offset: -1
	internal static NativeSlice<T> PtrToSlice<T>(void* p, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF65830 Offset: 0xF64230 VA: 0x180F65830
	|-UIRenderDevice.PtrToSlice<DrawBufferRange>
	|
	|-RVA: 0xF65940 Offset: 0xF64340 VA: 0x180F65940
	|-UIRenderDevice.PtrToSlice<ushort>
	|
	|-RVA: 0xF659C0 Offset: 0xF643C0 VA: 0x180F659C0
	|-UIRenderDevice.PtrToSlice<Vertex>
	|
	|-RVA: 0xF658B0 Offset: 0xF642B0 VA: 0x180F658B0
	|-UIRenderDevice.PtrToSlice<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2E06A90 Offset: 0x2E05490 VA: 0x182E06A90
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref UIRenderDevice.EvaluationState st) { }

	// RVA: 0x2E068C0 Offset: 0x2E052C0 VA: 0x182E068C0
	private void ApplyBatchState(ref UIRenderDevice.EvaluationState st, bool allowMaterialChange) { }

	// RVA: 0x2E07070 Offset: 0x2E05A70 VA: 0x182E07070
	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException) { }

	// RVA: 0x2E0A040 Offset: 0x2E08A40 VA: 0x182E0A040
	private void UpdateFenceValue() { }

	// RVA: 0x2E08960 Offset: 0x2E07360 VA: 0x182E08960
	private void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage) { }

	// RVA: -1 Offset: -1
	private void DrawRanges<I, T>(Utility.GPUBuffer<I> ib, Utility.GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF656E0 Offset: 0xF640E0 VA: 0x180F656E0
	|-UIRenderDevice.DrawRanges<ushort, Vertex>
	|
	|-RVA: 0xF65590 Offset: 0xF63F90 VA: 0x180F65590
	|-UIRenderDevice.DrawRanges<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2E0A640 Offset: 0x2E09040 VA: 0x182E0A640
	private void WaitOnCpuFence(uint fence) { }

	// RVA: 0x2E054D0 Offset: 0x2E03ED0 VA: 0x182E054D0
	public void AdvanceFrame() { }

	// RVA: 0x2E09410 Offset: 0x2E07E10 VA: 0x182E09410
	private void PruneUnusedPages() { }

	// RVA: 0x2E08D70 Offset: 0x2E07770 VA: 0x182E08D70
	internal static void PrepareForGfxDeviceRecreate() { }

	// RVA: 0x2E0A6F0 Offset: 0x2E090F0 VA: 0x182E0A6F0
	internal static void WrapUpGfxDeviceRecreate() { }

	// RVA: 0x2E07E80 Offset: 0x2E06880 VA: 0x182E07E80
	internal static void FlushAllPendingDeviceDisposes() { }

	// RVA: 0x2E08620 Offset: 0x2E07020 VA: 0x182E08620
	internal UIRenderDevice.DrawStatistics GatherDrawStatistics() { }

	// RVA: 0x2E08F60 Offset: 0x2E07960 VA: 0x182E08F60
	public static void ProcessDeviceFreeQueue() { }

	// RVA: 0x2E08C30 Offset: 0x2E07630 VA: 0x182E08C30
	private static void OnEngineUpdateGlobal() { }

	// RVA: 0x2E08C70 Offset: 0x2E07670 VA: 0x182E08C70
	private static void OnFlushPendingResources() { }
}
