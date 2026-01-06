public interface IInitializablePackageV2 : IInitializablePackage // TypeDefIndex: 17859
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register(CorePackageRegistry registry);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task InitializeInstanceAsync(CoreRegistry registry);
}
