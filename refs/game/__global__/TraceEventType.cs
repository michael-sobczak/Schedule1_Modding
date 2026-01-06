public enum TraceEventType // TypeDefIndex: 9581
{
	// Fields
	public int value__; // 0x0
	public const TraceEventType Critical = 1;
	public const TraceEventType Error = 2;
	public const TraceEventType Warning = 4;
	public const TraceEventType Information = 8;
	public const TraceEventType Verbose = 16;
	[EditorBrowsable(2)]
	public const TraceEventType Start = 256;
	[EditorBrowsable(2)]
	public const TraceEventType Stop = 512;
	[EditorBrowsable(2)]
	public const TraceEventType Suspend = 1024;
	[EditorBrowsable(2)]
	public const TraceEventType Resume = 2048;
	[EditorBrowsable(2)]
	public const TraceEventType Transfer = 4096;
}
