public interface IArgumentProvider // TypeDefIndex: 15145
{
	// Properties
	public abstract int ArgumentCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Expression GetArgument(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ArgumentCount();
}
