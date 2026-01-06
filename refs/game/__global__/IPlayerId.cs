public interface IPlayerId : IServiceComponent // TypeDefIndex: 17790
{
	// Properties
	public abstract string PlayerId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_PlayerId();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_PlayerIdChanged(Action<string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_PlayerIdChanged(Action<string> value);
}
