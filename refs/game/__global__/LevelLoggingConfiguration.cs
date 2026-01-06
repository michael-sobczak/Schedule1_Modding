public class LevelLoggingConfiguration : LoggingConfiguration // TypeDefIndex: 12801
{
	// Fields
	[SerializeField]
	[Tooltip("Type of logging to use for development builds and editor.")]
	private LoggingType _developmentLogging; // 0x20
	[SerializeField]
	[Tooltip("Type of logging to use for GUI builds.")]
	private LoggingType _guiLogging; // 0x21
	[SerializeField]
	[Tooltip("Type of logging to use for headless builds.")]
	private LoggingType _headlessLogging; // 0x22
	private bool _initialized; // 0x23
	private LoggingType _highestLoggingType; // 0x24

	// Methods

	[APIExclude]
	// RVA: 0xD7C7C0 Offset: 0xD7B1C0 VA: 0x180D7C7C0
	public void LoggingConstructor(bool loggingEnabled, LoggingType development, LoggingType gui, LoggingType headless) { }

	// RVA: 0xD7C5D0 Offset: 0xD7AFD0 VA: 0x180D7C5D0 Slot: 4
	public override void InitializeOnce() { }

	// RVA: 0xD7C540 Offset: 0xD7AF40 VA: 0x180D7C540 Slot: 5
	public override bool CanLog(LoggingType loggingType) { }

	// RVA: 0xD7C740 Offset: 0xD7B140 VA: 0x180D7C740 Slot: 6
	public override void Log(string value) { }

	// RVA: 0xD7C6C0 Offset: 0xD7B0C0 VA: 0x180D7C6C0 Slot: 7
	public override void LogWarning(string value) { }

	// RVA: 0xD7C640 Offset: 0xD7B040 VA: 0x180D7C640 Slot: 8
	public override void LogError(string value) { }

	// RVA: 0xD7C560 Offset: 0xD7AF60 VA: 0x180D7C560 Slot: 9
	public override LoggingConfiguration Clone() { }

	// RVA: 0xD7C7E0 Offset: 0xD7B1E0 VA: 0x180D7C7E0
	public void .ctor() { }
}
