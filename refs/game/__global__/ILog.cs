internal interface ILog // TypeDefIndex: 18231
{
	// Properties
	public abstract long ElapsedMilliseconds { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_ElapsedMilliseconds();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartTimer();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract long StopTimer();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Indent();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Unindent();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Log(string message);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LogFormat(string message, object[] args);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LogWarning(string message);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void LogWarningFormat(string message, object[] args);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void LogError(string message);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LogErrorFormat(string message, object[] args);
}
