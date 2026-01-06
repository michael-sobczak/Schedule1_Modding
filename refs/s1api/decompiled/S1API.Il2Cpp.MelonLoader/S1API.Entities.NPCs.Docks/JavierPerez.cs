using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class JavierPerez : NPC
{
	public new static string NPCId => "javier_perez";

	internal JavierPerez()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "javier_perez"))
	{
	}
}
