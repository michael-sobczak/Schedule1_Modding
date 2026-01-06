public enum ProfilerRecorderOptions // TypeDefIndex: 11495
{
	// Fields
	public int value__; // 0x0
	public const ProfilerRecorderOptions None = 0;
	public const ProfilerRecorderOptions StartImmediately = 1;
	public const ProfilerRecorderOptions KeepAliveDuringDomainReload = 2;
	public const ProfilerRecorderOptions CollectOnlyOnCurrentThread = 4;
	public const ProfilerRecorderOptions WrapAroundWhenCapacityReached = 8;
	public const ProfilerRecorderOptions SumAllSamplesInFrame = 16;
	public const ProfilerRecorderOptions GpuRecorder = 64;
	public const ProfilerRecorderOptions Default = 24;
}
