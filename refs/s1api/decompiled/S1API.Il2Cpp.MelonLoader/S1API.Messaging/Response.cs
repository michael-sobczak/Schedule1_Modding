using System;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;

namespace S1API.Messaging;

public class Response
{
	internal readonly Response S1Response;

	public Action? OnTriggered
	{
		get
		{
			return ((Delegate)(object)S1Response.callback == (Delegate)null) ? null : ((Action)delegate
			{
				S1Response.callback.Invoke();
			});
		}
		set
		{
			S1Response.callback = Action.op_Implicit(value);
		}
	}

	public string Label
	{
		get
		{
			return S1Response.label;
		}
		set
		{
			S1Response.label = value;
		}
	}

	public string Text
	{
		get
		{
			return S1Response.text;
		}
		set
		{
			S1Response.text = value;
		}
	}

	public Response()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		S1Response = new Response();
	}

	internal Response(Response response)
	{
		S1Response = response;
	}
}
