public interface IDamageable // TypeDefIndex: 1986
{
	// Properties
	public abstract GameObject gameObject { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendImpact(Impact impact);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ReceiveImpact(Impact impact);
}
