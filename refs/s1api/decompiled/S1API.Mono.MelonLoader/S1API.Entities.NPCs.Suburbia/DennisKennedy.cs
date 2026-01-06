using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class DennisKennedy : NPC
{
	public new static string NPCId => "dennis_kennedy";

	internal DennisKennedy()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "dennis_kennedy"))
	{
	}
}
