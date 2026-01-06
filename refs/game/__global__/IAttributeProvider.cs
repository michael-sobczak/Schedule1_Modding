public interface IAttributeProvider // TypeDefIndex: 11230
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IList<Attribute> GetAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList<Attribute> GetAttributes(Type attributeType, bool inherit);
}
