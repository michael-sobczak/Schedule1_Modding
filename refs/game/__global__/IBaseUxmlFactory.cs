public interface IBaseUxmlFactory // TypeDefIndex: 6987
{
	// Properties
	public abstract string uxmlQualifiedName { get; }
	public abstract Type uxmlType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_uxmlQualifiedName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_uxmlType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
}
