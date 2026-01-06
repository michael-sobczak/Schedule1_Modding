internal class DebugUIHandlerPersistentCanvas : MonoBehaviour // TypeDefIndex: 13971
{
	// Fields
	public RectTransform panel; // 0x20
	public RectTransform valuePrefab; // 0x28
	private List<DebugUIHandlerValue> m_Items; // 0x30
	private List<DebugUI.ValueTuple> m_ValueTupleWidgets; // 0x38

	// Methods

	// RVA: 0x2A4E800 Offset: 0x2A4D200 VA: 0x182A4E800
	internal void Toggle(DebugUI.Value widget, string displayName) { }

	// RVA: 0x2A4EB00 Offset: 0x2A4D500 VA: 0x182A4EB00
	internal void Toggle(DebugUI.ValueTuple widget, Nullable<int> forceTupleIndex) { }

	// RVA: 0x2A4E7B0 Offset: 0x2A4D1B0 VA: 0x182A4E7B0
	internal bool IsEmpty() { }

	// RVA: 0x2A4E620 Offset: 0x2A4D020 VA: 0x182A4E620
	internal void Clear() { }

	// RVA: 0x2A4EEE0 Offset: 0x2A4D8E0 VA: 0x182A4EEE0
	public void .ctor() { }
}
