internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 8039
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0x24F11E0 Offset: 0x24EFBE0 VA: 0x1824F11E0
	internal void .ctor(XmlNode container) { }

	// RVA: 0x24F1070 Offset: 0x24EFA70 VA: 0x1824F1070 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x24F1070 Offset: 0x24EFA70 VA: 0x1824F1070
	internal bool MoveNext() { }

	// RVA: 0x24F1100 Offset: 0x24EFB00 VA: 0x1824F1100 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x24F1150 Offset: 0x24EFB50 VA: 0x1824F1150 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x24F1150 Offset: 0x24EFB50 VA: 0x1824F1150
	internal XmlNode get_Current() { }
}
