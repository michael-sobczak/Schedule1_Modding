public interface IGraphInternals // TypeDefIndex: 13211
{
	// Properties
	public abstract string SerializedEditorSettings { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_SerializedEditorSettings();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_SerializedEditorSettings(string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDestroy();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void DestroyAllNodes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerable<Progress> ScanInternal();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SerializeExtraInfo(GraphSerializationContext ctx);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void DeserializeExtraInfo(GraphSerializationContext ctx);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PostDeserialization(GraphSerializationContext ctx);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void DeserializeSettingsCompatibility(GraphSerializationContext ctx);
}
