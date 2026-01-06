public interface IButtonControl // TypeDefIndex: 5392
{
	// Properties
	public abstract DialogResult DialogResult { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DialogResult get_DialogResult();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_DialogResult(DialogResult value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void NotifyDefault(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void PerformClick();
}
