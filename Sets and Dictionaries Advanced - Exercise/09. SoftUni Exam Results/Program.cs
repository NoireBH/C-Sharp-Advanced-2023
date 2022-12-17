using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var examResults = new Dictionary<string, int>();
            var totalSubmissions = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] parts = input.Split("-");
                string username = parts[0];
                string language = parts[1];
                

                if (language == "banned")
                {
                    examResults.Remove(username);          
                }

                else
                {
                    int points = int.Parse(parts[2]);

                    if (!totalSubmissions.ContainsKey(language))
                    {
                        totalSubmissions.Add(language, 1);
                    }

                    else
                    {
                        totalSubmissions[language]++;
                    }

                    if (!examResults.ContainsKey(username))
                    {
                       examResults.Add(username, points);
                    }

                    else
                    {
                        if (examResults[username] < points)
                        {
                            examResults[username] = points;
                        }
                        
                    }
                }
            }

            Console.WriteLine("Results:");

            foreach (var user in examResults.OrderByDescending(p => p.Value).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var submission in totalSubmissions
                .OrderByDescending(count => count.Value)
                .ThenBy(name => name.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
