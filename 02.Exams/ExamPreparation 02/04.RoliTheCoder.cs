using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventIdToNames = new Dictionary<int, string>();
            var eventParticipants = new Dictionary<int, List<string>>();

            while(true)
            {
                var line = Console.ReadLine();
                if (line == "Time for Code")
                {
                    break;

                }

                var commandParts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var eventId = 0;

                if(int.TryParse(commandParts[0], out eventId) == false)
                {
                    continue;
                }
                var eventName = commandParts[1];
                if (eventName.StartsWith("#")==false)
                {
                    continue;
                }

                eventName = eventName.Trim('#');
                var invalidPartisipants = false;
                var participants = new List<string>();

                for (int i = 2; i < commandParts.Length; i++)
                {
                    if (commandParts[i].StartsWith("@") == false)
                    {
                        invalidPartisipants = true;
                        break;
                    }
                    participants.Add(commandParts[i]);
                }
                if (invalidPartisipants)
                {
                    continue;
                }

                if(eventIdToNames.ContainsKey(eventId))
                {
                    var existingEventName = eventIdToNames[eventId];

                    if (existingEventName == eventName)
                    {
                        eventParticipants[eventId].AddRange(participants);
                    }
                }
                else
                {
                    eventIdToNames[eventId] = eventName;
                    eventParticipants[eventId] = new List<string>(participants);
                }

            }

            var events = eventParticipants.Select(kvp => new
            {
                Id = kvp.Key,
                Name = eventIdToNames[kvp.Key],
                Participants = kvp.Value.Distinct().OrderBy(p => p).ToList()
            })
            .OrderByDescending(kvp => kvp.Participants.Count)
            .ThenBy(ev => ev.Name).ToList();

            foreach (var ev in events)
            {
                var evId = ev.Id;
                var evName = ev.Name;
                var participants = ev.Participants.ToList();


                Console.WriteLine($"{evName} - {participants.Count}");

                foreach (var participant in participants)
                {
                    Console.WriteLine(participant);
                }
            }
            
        }
    }
}
