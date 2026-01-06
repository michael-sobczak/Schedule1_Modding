public class BatchRendererGroup // TypeDefIndex: 12230
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CD5660 Offset: 0x2CD4060 VA: 0x182CD5660
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }
}
