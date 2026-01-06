public class AbandonedMutexException : SystemException // TypeDefIndex: 3912
{
	// Fields
	private int _mutexIndex; // 0x90
	private Mutex _mutex; // 0x98

	// Methods

	// RVA: 0x1CD2960 Offset: 0x1CD1360 VA: 0x181CD2960
	public void .ctor() { }

	// RVA: 0x1CD29B0 Offset: 0x1CD13B0 VA: 0x181CD29B0
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x1CD2A70 Offset: 0x1CD1470 VA: 0x181CD2A70
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CD28D0 Offset: 0x1CD12D0 VA: 0x181CD28D0
	private void SetupException(int location, WaitHandle handle) { }
}
