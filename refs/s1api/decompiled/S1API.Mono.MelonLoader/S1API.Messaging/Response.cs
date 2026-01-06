using System;
using ScheduleOne.Messaging;

namespace S1API.Messaging;

public class Response
{
	internal readonly Response S1Response;

	public Action? OnTriggered
	{
		get
		{
			return (S1Response.callback == null) ? null : ((Action)delegate
			{
				S1Response.callback();
			});
		}
		set
		{
			S1Response.callback = value;
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
