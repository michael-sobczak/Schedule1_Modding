using UnityEngine;

namespace S1API.Entities.Interfaces;

public interface IEntity
{
	GameObject gameObject { get; }

	Vector3 Position { get; set; }

	float Scale { get; set; }
}
