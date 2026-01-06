public struct GraphicsFence // TypeDefIndex: 12207
{
	// Fields
	internal IntPtr m_Ptr; // 0x0
	internal int m_Version; // 0x8
	internal GraphicsFenceType m_FenceType; // 0xC

	// Methods

	// RVA: 0x2CE0130 Offset: 0x2CDEB30 VA: 0x182CE0130
	internal static SynchronisationStageFlags TranslateSynchronizationStageToFlags(SynchronisationStage s) { }

	// RVA: 0x2CE0000 Offset: 0x2CDEA00 VA: 0x182CE0000
	internal void InitPostAllocation() { }

	// RVA: 0x2CE00C0 Offset: 0x2CDEAC0 VA: 0x182CE00C0
	internal bool IsFencePending() { }

	// RVA: 0x2CE0140 Offset: 0x2CDEB40 VA: 0x182CE0140
	internal void Validate() { }

	// RVA: 0x2CDFFB0 Offset: 0x2CDE9B0 VA: 0x182CDFFB0
	private int GetPlatformNotSupportedVersion() { }

	[FreeFunction("GPUFenceInternals::GetVersionNumber")]
	[NativeThrows]
	// RVA: 0x2CDFFC0 Offset: 0x2CDE9C0 VA: 0x182CDFFC0
	private static int GetVersionNumber(IntPtr fencePtr) { }
}
