internal static class JobProcessor // TypeDefIndex: 7070
{
	// Methods

	// RVA: 0x2DFD1D0 Offset: 0x2DFBBD0 VA: 0x182DFD1D0
	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x2DFD070 Offset: 0x2DFBA70 VA: 0x182DFD070
	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x2DFD120 Offset: 0x2DFBB20 VA: 0x182DFD120
	internal static JobHandle ScheduleCopyClosingMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x2DFD180 Offset: 0x2DFBB80 VA: 0x182DFD180
	private static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	// RVA: 0x2DFD020 Offset: 0x2DFBA20 VA: 0x182DFD020
	private static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	// RVA: 0x2DFD0D0 Offset: 0x2DFBAD0 VA: 0x182DFD0D0
	private static void ScheduleCopyClosingMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }
}
