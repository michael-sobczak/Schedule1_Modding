using ScheduleOne.Property;

namespace S1API.Property;

public class LaunderingOperation
{
	internal readonly LaunderingOperation InnerLaunderingOperation;

	public BusinessWrapper Business
	{
		get
		{
			return new BusinessWrapper(InnerLaunderingOperation.business);
		}
		set
		{
			InnerLaunderingOperation.business = value.InnerBusiness;
		}
	}

	public float Amount
	{
		get
		{
			return InnerLaunderingOperation.amount;
		}
		set
		{
			InnerLaunderingOperation.amount = value;
		}
	}

	public int MinutesSinceStarted
	{
		get
		{
			return InnerLaunderingOperation.minutesSinceStarted;
		}
		set
		{
			InnerLaunderingOperation.minutesSinceStarted = value;
		}
	}

	public int CompletionTimeInMinutes
	{
		get
		{
			return InnerLaunderingOperation.completionTime_Minutes;
		}
		set
		{
			InnerLaunderingOperation.completionTime_Minutes = value;
		}
	}

	public LaunderingOperation(LaunderingOperation launderingOperation)
	{
		InnerLaunderingOperation = launderingOperation;
	}

	public LaunderingOperation(BusinessWrapper business, float amount, int minutesSinceStarted, int completionTimeInMinutes = 1140)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		InnerLaunderingOperation = new LaunderingOperation(business.InnerBusiness, amount, minutesSinceStarted);
		InnerLaunderingOperation.completionTime_Minutes = completionTimeInMinutes;
	}
}
