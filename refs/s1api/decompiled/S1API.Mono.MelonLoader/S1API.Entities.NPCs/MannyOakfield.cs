using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class MannyOakfield : NPC
{
	public new static string NPCId => "manny_oakfield";

	internal MannyOakfield()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "manny_oakfield"))
	{
	}
}
