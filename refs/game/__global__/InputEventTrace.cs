public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr>, IEnumerable // TypeDefIndex: 7686
{
	// Fields
	private const int kDefaultBufferSize = 1048576;
	private static readonly ProfilerMarker k_InputEvenTraceMarker; // 0x0
	private int m_ChangeCounter; // 0x10
	private bool m_Enabled; // 0x14
	private Func<InputEventPtr, InputDevice, bool> m_OnFilterEvent; // 0x18
	[SerializeField]
	private int m_DeviceId; // 0x20
	private CallbackArray<Action<InputEventPtr>> m_EventListeners; // 0x28
	[SerializeField]
	private long m_EventBufferSize; // 0x78
	[SerializeField]
	private long m_MaxEventBufferSize; // 0x80
	[SerializeField]
	private long m_GrowIncrementSize; // 0x88
	[SerializeField]
	private long m_EventCount; // 0x90
	[SerializeField]
	private long m_EventSizeInBytes; // 0x98
	[SerializeField]
	private ulong m_EventBufferStorage; // 0xA0
	[SerializeField]
	private ulong m_EventBufferHeadStorage; // 0xA8
	[SerializeField]
	private ulong m_EventBufferTailStorage; // 0xB0
	[SerializeField]
	private bool m_HasWrapped; // 0xB8
	[SerializeField]
	private bool m_RecordFrameMarkers; // 0xB9
	[SerializeField]
	private InputEventTrace.DeviceInfo[] m_DeviceInfos; // 0xC0
	private static int kFileVersion; // 0x8

	// Properties
	public static FourCC FrameMarkerEvent { get; }
	public int deviceId { get; set; }
	public bool enabled { get; }
	public bool recordFrameMarkers { get; set; }
	public long eventCount { get; }
	public long totalEventSizeInBytes { get; }
	public long allocatedSizeInBytes { get; }
	public long maxSizeInBytes { get; }
	public ReadOnlyArray<InputEventTrace.DeviceInfo> deviceInfos { get; }
	public Func<InputEventPtr, InputDevice, bool> onFilterEvent { get; set; }
	private byte* m_EventBuffer { get; set; }
	private byte* m_EventBufferHead { get; set; }
	private byte* m_EventBufferTail { get; set; }
	private static FourCC kFileFormat { get; }

	// Methods

	// RVA: 0x2864220 Offset: 0x2862C20 VA: 0x182864220
	public static FourCC get_FrameMarkerEvent() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_deviceId() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_deviceId(int value) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_enabled() { }

	// RVA: 0x5012B0 Offset: 0x4FFCB0 VA: 0x1805012B0
	public bool get_recordFrameMarkers() { }

	// RVA: 0x2864370 Offset: 0x2862D70 VA: 0x182864370
	public void set_recordFrameMarkers(bool value) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public long get_eventCount() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public long get_totalEventSizeInBytes() { }

	// RVA: 0x2864260 Offset: 0x2862C60 VA: 0x182864260
	public long get_allocatedSizeInBytes() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public long get_maxSizeInBytes() { }

	// RVA: 0x2864280 Offset: 0x2862C80 VA: 0x182864280
	public ReadOnlyArray<InputEventTrace.DeviceInfo> get_deviceInfos() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Func<InputEventPtr, InputDevice, bool> get_onFilterEvent() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_onFilterEvent(Func<InputEventPtr, InputDevice, bool> value) { }

	// RVA: 0x28641D0 Offset: 0x2862BD0 VA: 0x1828641D0
	public void add_onEvent(Action<InputEventPtr> value) { }

	// RVA: 0x2864320 Offset: 0x2862D20 VA: 0x182864320
	public void remove_onEvent(Action<InputEventPtr> value) { }

	// RVA: 0x28640F0 Offset: 0x2862AF0 VA: 0x1828640F0
	public void .ctor(InputDevice device, long bufferSizeInBytes = 1048576, bool growBuffer = False, long maxBufferSizeInBytes = -1, long growIncrementSizeInBytes = -1) { }

	// RVA: 0x2864070 Offset: 0x2862A70 VA: 0x182864070
	public void .ctor(long bufferSizeInBytes = 1048576, bool growBuffer = False, long maxBufferSizeInBytes = -1, long growIncrementSizeInBytes = -1) { }

	// RVA: 0x2863EE0 Offset: 0x28628E0 VA: 0x182863EE0
	public void WriteTo(string filePath) { }

	// RVA: 0x28637E0 Offset: 0x28621E0 VA: 0x1828637E0
	public void WriteTo(Stream stream) { }

	// RVA: 0x2862B40 Offset: 0x2861540 VA: 0x182862B40
	public void ReadFrom(string filePath) { }

	// RVA: 0x2862C50 Offset: 0x2861650 VA: 0x182862C50
	public void ReadFrom(Stream stream) { }

	// RVA: 0x2862240 Offset: 0x2860C40 VA: 0x182862240
	public static InputEventTrace LoadFrom(string filePath) { }

	// RVA: 0x28620F0 Offset: 0x2860AF0 VA: 0x1828620F0
	public static InputEventTrace LoadFrom(Stream stream) { }

	// RVA: 0x28634D0 Offset: 0x2861ED0 VA: 0x1828634D0
	public InputEventTrace.ReplayController Replay() { }

	// RVA: 0x2863530 Offset: 0x2861F30 VA: 0x182863530
	public bool Resize(long newBufferSize, long newMaxBufferSize = -1) { }

	// RVA: 0x2861CF0 Offset: 0x28606F0 VA: 0x182861CF0
	public void Clear() { }

	// RVA: 0x2861EC0 Offset: 0x28608C0 VA: 0x182861EC0
	public void Enable() { }

	// RVA: 0x2861D30 Offset: 0x2860730 VA: 0x182861D30
	public void Disable() { }

	// RVA: 0x2862070 Offset: 0x2860A70 VA: 0x182862070
	public bool GetNextEvent(ref InputEventPtr current) { }

	// RVA: 0x2862010 Offset: 0x2860A10 VA: 0x182862010 Slot: 5
	public IEnumerator<InputEventPtr> GetEnumerator() { }

	// RVA: 0x2862010 Offset: 0x2860A10 VA: 0x182862010 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2861E40 Offset: 0x2860840 VA: 0x182861E40 Slot: 4
	public void Dispose() { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	private byte* get_m_EventBuffer() { }

	// RVA: 0xAA7280 Offset: 0xAA5C80 VA: 0x180AA7280
	private void set_m_EventBuffer(byte* value) { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	private byte* get_m_EventBufferHead() { }

	// RVA: 0xAA7260 Offset: 0xAA5C60 VA: 0x180AA7260
	private void set_m_EventBufferHead(byte* value) { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	private byte* get_m_EventBufferTail() { }

	// RVA: 0xAA72A0 Offset: 0xAA5CA0 VA: 0x180AA72A0
	private void set_m_EventBufferTail(byte* value) { }

	// RVA: 0x2861CC0 Offset: 0x28606C0 VA: 0x182861CC0
	private void Allocate() { }

	// RVA: 0x2863450 Offset: 0x2861E50 VA: 0x182863450
	private void Release() { }

	// RVA: 0x28624A0 Offset: 0x2860EA0 VA: 0x1828624A0
	private void OnBeforeUpdate() { }

	// RVA: 0x28625B0 Offset: 0x2860FB0 VA: 0x1828625B0
	private void OnInputEvent(InputEventPtr inputEvent, InputDevice device) { }

	// RVA: 0x28642E0 Offset: 0x2862CE0 VA: 0x1828642E0
	private static FourCC get_kFileFormat() { }

	// RVA: 0x2863FF0 Offset: 0x28629F0 VA: 0x182863FF0
	private static void .cctor() { }
}
