public interface IDebugDisplaySettings : IDebugDisplaySettingsQuery // TypeDefIndex: 13688
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ForEach(Action<IDebugDisplaySettingsData> onExecute);
}
