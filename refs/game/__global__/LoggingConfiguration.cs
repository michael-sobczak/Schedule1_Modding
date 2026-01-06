public abstract class LoggingConfiguration : ScriptableObject // TypeDefIndex: 12802
{
	// Fields
	[Tooltip("True to use logging features. False to disable all logging.")]
	public bool LoggingEnabled; // 0x18

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public virtual void InitializeOnce() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool CanLog(LoggingType loggingType);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Log(string value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LogWarning(string value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void LogError(string value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract LoggingConfiguration Clone();

	// RVA: 0xD7C9F0 Offset: 0xD7B3F0 VA: 0x180D7C9F0
	protected void .ctor() { }
}
