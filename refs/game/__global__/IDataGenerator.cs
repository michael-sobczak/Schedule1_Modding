internal interface IDataGenerator // TypeDefIndex: 17927
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GameRunning(string callingMethodIdentifier);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SdkStartup(string callingMethodIdentifier);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void NewPlayer(string callingMethodIdentifier);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GameStarted(string callingMethodIdentifier);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void GameEnded(string callingMethodIdentifier, DataGenerator.SessionEndState quitState);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ClientDevice(string callingMethodIdentifier);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PushCommonParams(string callingMethodIdentifier);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PushEvent(string callingMethodIdentifier, Event e);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PushEmptyEvent(string name);
}
