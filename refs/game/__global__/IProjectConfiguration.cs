public interface IProjectConfiguration : IServiceComponent // TypeDefIndex: 17809
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool GetBool(string key, bool defaultValue = False);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetInt(string key, int defaultValue = 0);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float GetFloat(string key, float defaultValue = 0);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetString(string key, string defaultValue);
}
