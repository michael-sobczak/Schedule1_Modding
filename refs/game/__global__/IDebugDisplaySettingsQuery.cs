public interface IDebugDisplaySettingsQuery // TypeDefIndex: 13692
{
	// Properties
	public abstract bool AreAnySettingsActive { get; }
	public abstract bool IsPostProcessingAllowed { get; }
	public abstract bool IsLightingActive { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_AreAnySettingsActive();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsPostProcessingAllowed();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsLightingActive();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TryGetScreenClearColor(ref Color color);
}
