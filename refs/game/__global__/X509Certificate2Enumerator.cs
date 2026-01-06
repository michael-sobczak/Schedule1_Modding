public sealed class X509Certificate2Enumerator : IEnumerator // TypeDefIndex: 9629
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate2 Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x264BFA0 Offset: 0x264A9A0 VA: 0x18264BFA0
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x264C010 Offset: 0x264AA10 VA: 0x18264C010
	public X509Certificate2 get_Current() { }

	// RVA: 0x264BE60 Offset: 0x264A860 VA: 0x18264BE60
	public bool MoveNext() { }

	// RVA: 0x264BF50 Offset: 0x264A950 VA: 0x18264BF50 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x264BEB0 Offset: 0x264A8B0 VA: 0x18264BEB0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x264BF00 Offset: 0x264A900 VA: 0x18264BF00 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
}
