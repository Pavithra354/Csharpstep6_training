using System;

namespace InterviewDelegatesDemo
{
    class Program
    {
        static void Main()
        {
            // Predicate to check candidate skill eligibility
            Predicate<string> isEligible = (string skill) =>
            {
                string[] requiredSkills = { "C#", "Java", "Python" };
                return Array.Exists(requiredSkills, s => s == skill);
            };

            // Func to schedule interview and return slot details
            Func<string, int, string> scheduleInterview = (candidateName, dayOffset) =>
            {
                DateTime slot = DateTime.Now.AddDays(dayOffset).AddHours(10);
                return $"Interview scheduled for {candidateName} on {slot:dddd, dd MMMM yyyy hh:mm tt}";
            };

            // Action to confirm to the candidate
            Action<string> sendConfirmation = (string message) =>
            {
                Console.WriteLine("📢 Confirmation:");
                Console.WriteLine(message);
            };

            // Candidate Details
            string candidateName = "Pavithra";
            string candidateSkill = "C#";

            // Flow
            if (isEligible(candidateSkill))
            {
                string slotMessage = scheduleInterview(candidateName, 2);
                sendConfirmation(slotMessage);
            }
            else
            {
                Console.WriteLine($"❌ Sorry {candidateName}, your skill '{candidateSkill}' does not match our current openings.");
            }
        }
    }
}