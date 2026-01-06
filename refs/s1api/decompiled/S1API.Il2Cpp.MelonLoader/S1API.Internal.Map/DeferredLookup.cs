using System;

namespace S1API.Internal.Map;

internal sealed class DeferredLookup
{
	public Type IdentifierType { get; private set; }

	public string IdentifierName { get; private set; }

	public Action<object> Callback { get; }

	public bool IsResolved { get; private set; }

	public DeferredLookup(Type identifierType, Action<object> callback)
	{
		IdentifierType = identifierType ?? throw new ArgumentNullException("identifierType");
		Callback = callback ?? throw new ArgumentNullException("callback");
		IdentifierName = null;
		IsResolved = false;
	}

	public DeferredLookup(string identifierName, Action<object> callback)
	{
		IdentifierName = identifierName ?? throw new ArgumentNullException("identifierName");
		Callback = callback ?? throw new ArgumentNullException("callback");
		IdentifierType = null;
		IsResolved = false;
	}

	internal void MarkResolved()
	{
		IsResolved = true;
	}
}
