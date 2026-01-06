using System;

namespace S1API.Entities.Interfaces;

public interface IHealth
{
	float CurrentHealth { get; }

	float MaxHealth { get; set; }

	bool IsDead { get; }

	bool IsInvincible { get; set; }

	event Action OnDeath;

	void Revive();

	void Damage(int amount);

	void Heal(int amount);

	void Kill();
}
