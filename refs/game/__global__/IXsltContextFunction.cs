public interface IXsltContextFunction // TypeDefIndex: 8229
{
	// Properties
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XPathResultType get_ReturnType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Invoke(XsltContext xsltContext, object[] args, XPathNavigator docContext);
}
