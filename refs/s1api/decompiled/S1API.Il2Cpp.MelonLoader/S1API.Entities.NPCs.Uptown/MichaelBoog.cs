using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class MichaelBoog : NPC
{
	public new static string NPCId => "michael_boog";

	internal MichaelBoog()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "michael_boog"))
	{
	}
}
