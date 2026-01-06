public struct ProfilingSample : IDisposable // TypeDefIndex: 13699
{
	// Fields
	private readonly CommandBuffer m_Cmd; // 0x0
	private readonly string m_Name; // 0x8
	private bool m_Disposed; // 0x10
	private CustomSampler m_Sampler; // 0x18

	// Methods

	// RVA: 0x2A12C70 Offset: 0x2A11670 VA: 0x182A12C70
	public void .ctor(CommandBuffer cmd, string name, CustomSampler sampler) { }

	// RVA: 0x2A12D20 Offset: 0x2A11720 VA: 0x182A12D20
	public void .ctor(CommandBuffer cmd, string format, object arg) { }

	// RVA: 0x2A12DE0 Offset: 0x2A117E0 VA: 0x182A12DE0
	public void .ctor(CommandBuffer cmd, string format, object[] args) { }

	// RVA: 0x2A12C00 Offset: 0x2A11600 VA: 0x182A12C00 Slot: 4
	public void Dispose() { }

	// RVA: 0x2A12B80 Offset: 0x2A11580 VA: 0x182A12B80
	private void Dispose(bool disposing) { }
}
