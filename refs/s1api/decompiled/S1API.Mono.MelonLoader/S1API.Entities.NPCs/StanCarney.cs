using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class StanCarney : NPC
{
	public new static string NPCId => "stan_carney";

	internal StanCarney()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "stan_carney"))
	{
	}
}
