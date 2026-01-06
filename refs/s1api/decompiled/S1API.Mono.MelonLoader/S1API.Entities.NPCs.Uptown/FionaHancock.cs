using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class FionaHancock : NPC
{
	public new static string NPCId => "fiona_hancock";

	internal FionaHancock()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "fiona_hancock"))
	{
	}
}
