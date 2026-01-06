using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class JackieStevenson : NPC
{
	public new static string NPCId => "jackie_stevenson";

	internal JackieStevenson()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jackie_stevenson"))
	{
	}
}
