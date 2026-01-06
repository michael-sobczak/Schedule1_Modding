namespace S1API.Internal.Abstraction;

internal interface IRegisterable
{
	void CreateInternal();

	void DestroyInternal();

	void OnCreated();

	void OnDestroyed();
}
