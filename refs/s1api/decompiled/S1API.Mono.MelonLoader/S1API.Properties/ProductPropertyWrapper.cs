using S1API.Properties.Interfaces;
using ScheduleOne.Effects;
using UnityEngine;

namespace S1API.Properties;

public class ProductPropertyWrapper : PropertyBase
{
	private readonly Effect _innerProperty;

	public override string ID => _innerProperty.ID;

	public override string Name => _innerProperty.Name;

	public override string name => ((Object)_innerProperty).name;

	public override string Description => _innerProperty.Description;

	public override int Tier => _innerProperty.Tier;

	public override float Addictiveness => _innerProperty.Addictiveness;

	internal Effect InnerProperty => _innerProperty;

	internal ProductPropertyWrapper(Effect property)
	{
		_innerProperty = property;
	}
}
