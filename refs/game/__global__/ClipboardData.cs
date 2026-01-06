internal class ClipboardData // TypeDefIndex: 5709
{
	// Fields
	private ListDictionary source_data; // 0x10
	private string plain_text_source; // 0x18
	private Image image_source; // 0x20
	internal object Item; // 0x28
	internal ArrayList Formats; // 0x30
	internal bool Retrieving; // 0x38
	internal bool Enumerating; // 0x39
	internal XplatUI.ObjectToClipboard Converter; // 0x40

	// Properties
	public bool IsSourceText { get; }
	public bool IsSourceImage { get; }

	// Methods

	// RVA: 0x2269AA0 Offset: 0x22684A0 VA: 0x182269AA0
	public void .ctor() { }

	// RVA: 0x22698F0 Offset: 0x22682F0 VA: 0x1822698F0
	public void ClearSources() { }

	// RVA: 0x2269710 Offset: 0x2268110 VA: 0x182269710
	public void AddSource(int type, object source) { }

	// RVA: 0x2269A30 Offset: 0x2268430 VA: 0x182269A30
	public object GetSource(int type) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string GetPlainText() { }

	// RVA: 0x2269940 Offset: 0x2268340 VA: 0x182269940
	public string GetRtfText() { }

	// RVA: 0x1E56BC0 Offset: 0x1E555C0 VA: 0x181E56BC0
	public bool get_IsSourceText() { }

	// RVA: 0x1E85E90 Offset: 0x1E84890 VA: 0x181E85E90
	public bool get_IsSourceImage() { }
}
