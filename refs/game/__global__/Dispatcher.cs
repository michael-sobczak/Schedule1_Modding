internal class Dispatcher : IDispatcher, IDispatcherDebug // TypeDefIndex: 17948
{
	// Fields
	private readonly IWebRequestHelper m_WebRequestHelper; // 0x10
	private readonly string m_CollectUrl; // 0x18
	internal const string k_PiplConsentHeaderKey = "PIPL_CONSENT";
	internal const string k_PiplExportHeaderKey = "PIPL_EXPORT";
	internal const string k_HeaderTrueValue = "true";
	private IBuffer m_DataBuffer; // 0x20
	private IWebRequest m_FlushRequest; // 0x28
	private byte[] m_LastFlushPayload; // 0x30
	private int m_FlushBufferIndex; // 0x38
	[CompilerGenerated]
	private int <ConsecutiveFailedUploadCount>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <FlushInProgress>k__BackingField; // 0x40
	[CompilerGenerated]
	private Action<byte[]> FlushStarted; // 0x48
	[CompilerGenerated]
	private Action<int, bool, bool, bool, bool, byte[]> FlushFinished; // 0x50

	// Properties
	public int ConsecutiveFailedUploadCount { get; set; }
	public bool FlushInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0 Slot: 4
	public int get_ConsecutiveFailedUploadCount() { }

	[CompilerGenerated]
	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	private void set_ConsecutiveFailedUploadCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0 Slot: 7
	public bool get_FlushInProgress() { }

	[CompilerGenerated]
	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	private void set_FlushInProgress(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2B90470 Offset: 0x2B8EE70 VA: 0x182B90470 Slot: 8
	public void add_FlushStarted(Action<byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x2B905D0 Offset: 0x2B8EFD0 VA: 0x182B905D0 Slot: 9
	public void remove_FlushStarted(Action<byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x2B903C0 Offset: 0x2B8EDC0 VA: 0x182B903C0 Slot: 10
	public void add_FlushFinished(Action<int, bool, bool, bool, bool, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x2B90520 Offset: 0x2B8EF20 VA: 0x182B90520 Slot: 11
	public void remove_FlushFinished(Action<int, bool, bool, bool, bool, byte[]> value) { }

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(IWebRequestHelper webRequestHelper, string collectUrl) { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0 Slot: 5
	public void SetBuffer(IBuffer buffer) { }

	// RVA: 0x2B900E0 Offset: 0x2B8EAE0 VA: 0x182B900E0 Slot: 6
	public void Flush() { }

	// RVA: 0x2B8FE30 Offset: 0x2B8E830 VA: 0x182B8FE30
	private void FlushBufferToService() { }

	// RVA: 0x2B90150 Offset: 0x2B8EB50 VA: 0x182B90150
	private void UploadCompleted(long responseCode) { }
}
