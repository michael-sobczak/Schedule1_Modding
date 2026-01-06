internal class RenderGraphLogger // TypeDefIndex: 13521
{
	// Fields
	private Dictionary<string, StringBuilder> m_LogMap; // 0x10
	private StringBuilder m_CurrentBuilder; // 0x18
	private int m_CurrentIndentation; // 0x20

	// Methods

	// RVA: 0x29CB840 Offset: 0x29CA240 VA: 0x1829CB840
	public void Initialize(string logName) { }

	// RVA: 0x29CB7D0 Offset: 0x29CA1D0 VA: 0x1829CB7D0
	public void IncrementIndentation(int value) { }

	// RVA: 0x29CB520 Offset: 0x29C9F20 VA: 0x1829CB520
	public void DecrementIndentation(int value) { }

	// RVA: 0x29CB930 Offset: 0x29CA330 VA: 0x1829CB930
	public void LogLine(string format, object[] args) { }

	// RVA: 0x29CB720 Offset: 0x29CA120 VA: 0x1829CB720
	public string GetLog(string logName) { }

	// RVA: 0x29CB590 Offset: 0x29C9F90 VA: 0x1829CB590
	public string GetAllLogs() { }

	// RVA: 0x29CB9C0 Offset: 0x29CA3C0 VA: 0x1829CB9C0
	public void .ctor() { }
}
