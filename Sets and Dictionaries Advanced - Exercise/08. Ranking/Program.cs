using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();

            var usersParticipating = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] parts = input.Split(":");
                string contest = parts[0];
                string passwordForContest = parts[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, passwordForContest);

                }
            }

            string input2;
            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] parts = input2.Split("=>");
                string contest = parts[0];
                string passwordForContest = parts[1];
                string username = parts[2];
                int points = int.Parse(parts[3]);

                if (contests.ContainsKey(contest)
                    && contests[contest] == passwordForContest)
                {


                    if (!usersParticipating.ContainsKey(username))
                    {

                        usersParticipating.Add(username, new Dictionary<string, int>());
                    }

                    if (usersParticipating[username].ContainsKey(contest))
                    {
                        if (usersParticipating[username][contest] < points)
                        {
                            usersParticipating[username][contest] = points;
                        }
                    }

                    else
                    {
                        usersParticipating[username].Add(contest, points);
                    }
                }
            }

            int topPoints = 0;
            string topPointsParticipant = String.Empty;

            foreach (var user in usersParticipating)
            {
                if (user.Value.Sum(x => x.Value) > topPoints)
                {
                    topPoints = user.Value.Sum(x => x.Value);
                    topPointsParticipant = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {topPointsParticipant} with total {topPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in usersParticipating.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }


        }
    }
}
