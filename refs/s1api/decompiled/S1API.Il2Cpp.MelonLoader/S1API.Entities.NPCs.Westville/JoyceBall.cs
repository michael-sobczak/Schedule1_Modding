using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class JoyceBall : NPC
{
	public new static string NPCId => "joyce_ball";

	internal JoyceBall()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "joyce_ball"))
	{
	}
}
