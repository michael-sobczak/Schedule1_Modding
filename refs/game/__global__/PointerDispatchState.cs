internal class PointerDispatchState // TypeDefIndex: 6735
{
	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0x2EDEAB0 Offset: 0x2EDD4B0 VA: 0x182EDEAB0
	public void .ctor() { }

	// RVA: 0x2EDE8C0 Offset: 0x2EDD2C0 VA: 0x182EDE8C0
	internal void Reset() { }

	// RVA: 0x21ACDF0 Offset: 0x21AB7F0 VA: 0x1821ACDF0
	public IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0x2EDE200 Offset: 0x2EDCC00 VA: 0x182EDE200
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0x2EDE0D0 Offset: 0x2EDCAD0 VA: 0x182EDE0D0
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x2EDE820 Offset: 0x2EDD220 VA: 0x182EDE820
	public void ReleasePointer(int pointerId) { }

	// RVA: 0x2EDE870 Offset: 0x2EDD270 VA: 0x182EDE870
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x2EDE260 Offset: 0x2EDCC60 VA: 0x182EDE260
	public void ProcessPointerCapture(int pointerId) { }

	// RVA: 0x2EDE0A0 Offset: 0x2EDCAA0 VA: 0x182EDE0A0
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x2EDE230 Offset: 0x2EDCC30 VA: 0x182EDE230
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x2EDE9B0 Offset: 0x2EDD3B0 VA: 0x182EDE9B0
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }
}
