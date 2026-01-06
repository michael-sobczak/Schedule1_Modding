internal class ForDeviceEventObservable : IObservable<InputEventPtr> // TypeDefIndex: 7828
{
	// Fields
	private IObservable<InputEventPtr> m_Source; // 0x10
	private InputDevice m_Device; // 0x18
	private Type m_DeviceType; // 0x20

	// Methods

	// RVA: 0x278D300 Offset: 0x278BD00 VA: 0x18278D300
	public void .ctor(IObservable<InputEventPtr> source, Type deviceType, InputDevice device) { }

	// RVA: 0x278D1C0 Offset: 0x278BBC0 VA: 0x18278D1C0 Slot: 4
	public IDisposable Subscribe(IObserver<InputEventPtr> observer) { }
}
