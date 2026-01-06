internal interface IAsyncOperation : IEnumerator // TypeDefIndex: 17828
{
	// Properties
	public abstract bool IsDone { get; }
	public abstract AsyncOperationStatus Status { get; }
	public abstract Exception Exception { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsDone();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationStatus get_Status();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_Completed(Action<IAsyncOperation> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_Completed(Action<IAsyncOperation> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Exception get_Exception();
}
