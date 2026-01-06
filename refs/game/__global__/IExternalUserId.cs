public interface IExternalUserId : IServiceComponent // TypeDefIndex: 17808
{
	// Properties
	public abstract string UserId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_UserId();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_UserIdChanged(Action<string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_UserIdChanged(Action<string> value);
}
