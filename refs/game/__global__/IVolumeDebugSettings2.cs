public interface IVolumeDebugSettings2 : IVolumeDebugSettings // TypeDefIndex: 13694
{
	// Properties
	public abstract Type targetRenderPipeline { get; }
	public abstract List<ValueTuple<string, Type>> volumeComponentsPathAndType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_targetRenderPipeline();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract List<ValueTuple<string, Type>> get_volumeComponentsPathAndType();
}
