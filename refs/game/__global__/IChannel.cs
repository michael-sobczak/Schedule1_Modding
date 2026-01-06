public interface IChannel : IDisposable // TypeDefIndex: 17777
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_MessageReceived(Action<string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_MessageReceived(Action<string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_BinaryMessageReceived(Action<byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_BinaryMessageReceived(Action<byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_KickReceived(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_KickReceived(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_NewStateReceived(Action<SubscriptionState> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_NewStateReceived(Action<SubscriptionState> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void add_ErrorReceived(Action<string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void remove_ErrorReceived(Action<string> value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Task SubscribeAsync();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Task UnsubscribeAsync();
}
