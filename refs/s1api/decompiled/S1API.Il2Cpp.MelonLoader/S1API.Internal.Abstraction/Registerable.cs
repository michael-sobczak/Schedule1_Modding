namespace S1API.Internal.Abstraction;

public abstract class Registerable : IRegisterable
{
	void IRegisterable.CreateInternal()
	{
		CreateInternal();
	}

	internal virtual void CreateInternal()
	{
		OnCreated();
	}

	void IRegisterable.DestroyInternal()
	{
		DestroyInternal();
	}

	internal virtual void DestroyInternal()
	{
		OnDestroyed();
	}

	void IRegisterable.OnCreated()
	{
		OnCreated();
	}

	protected virtual void OnCreated()
	{
	}

	void IRegisterable.OnDestroyed()
	{
		OnDestroyed();
	}

	protected virtual void OnDestroyed()
	{
	}
}
