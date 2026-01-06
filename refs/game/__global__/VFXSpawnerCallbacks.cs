public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 19118
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}
