public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 19197
{
	// Fields
	private UnityWebRequest _uwr; // 0x10

	// Properties
	public string error { get; }
	public bool isDone { get; }
	public string text { get; }
	public Texture2D texture { get; }
	public string url { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x2F5D640 Offset: 0x2F5C040 VA: 0x182F5D640
	public void .ctor(string url) { }

	// RVA: 0x2F5D6A0 Offset: 0x2F5C0A0 VA: 0x182F5D6A0
	public string get_error() { }

	// RVA: 0x2F5D7C0 Offset: 0x2F5C1C0 VA: 0x182F5D7C0
	public bool get_isDone() { }

	// RVA: 0x2F5D810 Offset: 0x2F5C210 VA: 0x182F5D810
	public string get_text() { }

	// RVA: 0x2F5D3F0 Offset: 0x2F5BDF0 VA: 0x182F5D3F0
	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	// RVA: 0x2F5D890 Offset: 0x2F5C290 VA: 0x182F5D890
	public Texture2D get_texture() { }

	// RVA: 0x2F5D9A0 Offset: 0x2F5C3A0 VA: 0x182F5D9A0
	public string get_url() { }

	// RVA: 0x2F5D7E0 Offset: 0x2F5C1E0 VA: 0x182F5D7E0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x2F5D510 Offset: 0x2F5BF10 VA: 0x182F5D510 Slot: 9
	public void Dispose() { }

	// RVA: 0x2F5D550 Offset: 0x2F5BF50 VA: 0x182F5D550
	private bool WaitUntilDoneIfPossible() { }
}
