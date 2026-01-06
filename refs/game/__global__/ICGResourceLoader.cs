public interface ICGResourceLoader // TypeDefIndex: 10679
{
	// Methods

	[NotNull]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract Component Create(CGModule cgModule, string context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Destroy(CGModule cgModule, Component obj, string context, bool kill);
}
