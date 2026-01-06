public interface IUnityServices // TypeDefIndex: 19101
{
	// Properties
	public abstract ServicesInitializationState State { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_Initialized(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_Initialized(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_InitializeFailed(Action<Exception> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_InitializeFailed(Action<Exception> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ServicesInitializationState get_State();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Task InitializeAsync(InitializationOptions options);

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public virtual string GetIdentifier() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract T GetService<T>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUnityServices.GetService<__Il2CppFullySharedGenericType>
	*/
}
