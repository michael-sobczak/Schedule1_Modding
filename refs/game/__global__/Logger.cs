internal class Logger : ILog // TypeDefIndex: 18234
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <Debug>k__BackingField; // 0x10
	private readonly string _prefix; // 0x18
	private int _indent; // 0x20
	private Stack<Stopwatch> _timers; // 0x28

	// Properties
	public long ElapsedMilliseconds { get; }
	public bool Debug { get; set; }

	// Methods

	// RVA: 0x2F635B0 Offset: 0x2F61FB0 VA: 0x182F635B0 Slot: 4
	public long get_ElapsedMilliseconds() { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_Debug() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	public void set_Debug(bool value) { }

	// RVA: 0x2F63510 Offset: 0x2F61F10 VA: 0x182F63510
	public void .ctor(string prefix) { }

	// RVA: 0x2F63400 Offset: 0x2F61E00 VA: 0x182F63400 Slot: 5
	public void StartTimer() { }

	// RVA: 0x2F63490 Offset: 0x2F61E90 VA: 0x182F63490 Slot: 6
	public long StopTimer() { }

	// RVA: 0x2F62E80 Offset: 0x2F61880 VA: 0x182F62E80 Slot: 7
	public void Indent() { }

	// RVA: 0x2F63500 Offset: 0x2F61F00 VA: 0x182F63500 Slot: 8
	public void Unindent() { }

	// RVA: 0x2F63320 Offset: 0x2F61D20 VA: 0x182F63320 Slot: 9
	public void Log(string message) { }

	// RVA: 0x2F63060 Offset: 0x2F61A60 VA: 0x182F63060 Slot: 10
	public void LogFormat(string message, object[] args) { }

	// RVA: 0x2F63240 Offset: 0x2F61C40 VA: 0x182F63240 Slot: 11
	public void LogWarning(string message) { }

	// RVA: 0x2F63150 Offset: 0x2F61B50 VA: 0x182F63150 Slot: 12
	public void LogWarningFormat(string message, object[] args) { }

	// RVA: 0x2F62F80 Offset: 0x2F61980 VA: 0x182F62F80 Slot: 13
	public void LogError(string message) { }

	// RVA: 0x2F62E90 Offset: 0x2F61890 VA: 0x182F62E90 Slot: 14
	public void LogErrorFormat(string message, object[] args) { }

	// RVA: 0x2F62E10 Offset: 0x2F61810 VA: 0x182F62E10
	private string GetIndent() { }
}
