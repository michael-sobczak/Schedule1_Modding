public enum ScheduleMode // TypeDefIndex: 11483
{
	// Fields
	public int value__; // 0x0
	public const ScheduleMode Run = 0;
	[Obsolete("Batched is obsolete, use Parallel or Single depending on job type. (UnityUpgradable) -> Parallel", False)]
	public const ScheduleMode Batched = 1;
	public const ScheduleMode Parallel = 1;
	public const ScheduleMode Single = 2;
}
