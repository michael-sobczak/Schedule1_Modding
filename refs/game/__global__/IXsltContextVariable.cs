public interface IXsltContextVariable // TypeDefIndex: 8230
{
	// Properties
	public abstract XPathResultType VariableType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XPathResultType get_VariableType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Evaluate(XsltContext xsltContext);
}
