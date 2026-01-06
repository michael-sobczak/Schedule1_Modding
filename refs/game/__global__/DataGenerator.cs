internal class DataGenerator : IDataGenerator // TypeDefIndex: 17929
{
	// Fields
	private readonly IBuffer m_Buffer; // 0x10
	private readonly ICommonData m_CommonData; // 0x18
	private readonly IDeviceData m_DeviceData; // 0x20

	// Methods

	// RVA: 0x43EE90 Offset: 0x43D890 VA: 0x18043EE90
	public void .ctor(IBuffer buffer, ICommonData staticData, IDeviceData deviceData) { }

	// RVA: 0x2B8EDA0 Offset: 0x2B8D7A0 VA: 0x182B8EDA0 Slot: 5
	public void SdkStartup(string callingMethodIdentifier) { }

	// RVA: 0x2B8E2E0 Offset: 0x2B8CCE0 VA: 0x182B8E2E0 Slot: 4
	public void GameRunning(string callingMethodIdentifier) { }

	// RVA: 0x2B8E610 Offset: 0x2B8D010 VA: 0x182B8E610 Slot: 6
	public void NewPlayer(string callingMethodIdentifier) { }

	// RVA: 0x2B8E380 Offset: 0x2B8CD80 VA: 0x182B8E380 Slot: 7
	public void GameStarted(string callingMethodIdentifier) { }

	// RVA: 0x2B8E1D0 Offset: 0x2B8CBD0 VA: 0x182B8E1D0 Slot: 8
	public void GameEnded(string callingMethodIdentifier, DataGenerator.SessionEndState quitState) { }

	// RVA: 0x2B8DEC0 Offset: 0x2B8C8C0 VA: 0x182B8DEC0 Slot: 9
	public void ClientDevice(string callingMethodIdentifier) { }

	// RVA: 0x2B8E710 Offset: 0x2B8D110 VA: 0x182B8E710 Slot: 10
	public void PushCommonParams(string callingMethodIdentifier) { }

	// RVA: 0x2B8EC90 Offset: 0x2B8D690 VA: 0x182B8EC90 Slot: 11
	public void PushEvent(string callingMethodIdentifier, Event e) { }

	// RVA: 0x2B8EC10 Offset: 0x2B8D610 VA: 0x182B8EC10 Slot: 12
	public void PushEmptyEvent(string name) { }
}
