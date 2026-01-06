public interface IMovementPlane // TypeDefIndex: 13392
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 ToPlane(Vector3 p);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 ToPlane(Vector3 p, out float elevation);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 ToWorld(Vector2 p, float elevation = 0);
}
