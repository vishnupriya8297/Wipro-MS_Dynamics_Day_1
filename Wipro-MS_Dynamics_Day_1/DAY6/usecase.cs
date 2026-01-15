using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ETMS
{
    // Models
    class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    class EnrollmentRequest
    {
        public int LearnerId { get; set; }
        public string CourseCode { get; set; }
    }

    class AdminAction
    {
        public string ActionName { get; set; }
    }

    class Session
    {
        public string Title { get; set; }
    }

    class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int LearnerId { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // 1. Manage Course Catalog - List<T>
            List<Course> courses = new List<Course>()
            {
                new Course { Code = "C101", Name = "C# Basics" },
                new Course { Code = "C102", Name = "ASP.NET Core" }
            };

            Console.WriteLine("Course Catalog:");
            foreach (var c in courses)
                Console.WriteLine($"{c.Code} - {c.Name}");

            // 2. Fast Course Lookup - Dictionary<TKey, TValue>
            Dictionary<string, Course> courseLookup = new Dictionary<string, Course>();
            foreach (var c in courses)
                courseLookup[c.Code] = c;

            Console.WriteLine("\nFast Lookup:");
            Console.WriteLine(courseLookup["C101"].Name);

            // 3. Avoid Duplicate Enrollments - HashSet<T>
            HashSet<int> enrolledLearners = new HashSet<int>();
            enrolledLearners.Add(1);
            enrolledLearners.Add(2);
            enrolledLearners.Add(1); // duplicate not allowed

            Console.WriteLine("\nUnique Learner Enrollments:");
            foreach (var id in enrolledLearners)
                Console.WriteLine($"Learner ID: {id}");

            // 4. Process Enrollment Requests in Order - Queue<T>
            Queue<EnrollmentRequest> requests = new Queue<EnrollmentRequest>();
            requests.Enqueue(new EnrollmentRequest { LearnerId = 1, CourseCode = "C101" });
            requests.Enqueue(new EnrollmentRequest { LearnerId = 2, CourseCode = "C102" });

            Console.WriteLine("\nProcessing Enrollment Requests:");
            while (requests.Count > 0)
            {
                var req = requests.Dequeue();
                Console.WriteLine($"Processed Learner {req.LearnerId} for Course {req.CourseCode}");
            }

            // 5. Undo Admin Actions - Stack<T>
            Stack<AdminAction> adminActions = new Stack<AdminAction>();
            adminActions.Push(new AdminAction { ActionName = "Add Course" });
            adminActions.Push(new AdminAction { ActionName = "Delete Course" });

            Console.WriteLine("\nUndo Last Admin Action:");
            Console.WriteLine(adminActions.Pop().ActionName);

            // 6. Display Sessions Sorted by Start Time - SortedList<TKey, TValue>
            SortedList<DateTime, Session> sessions = new SortedList<DateTime, Session>();
            sessions.Add(new DateTime(2026, 1, 15, 10, 0, 0), new Session { Title = "Morning Session" });
            sessions.Add(new DateTime(2026, 1, 15, 14, 0, 0), new Session { Title = "Afternoon Session" });

            Console.WriteLine("\nSessions Sorted by Time:");
            foreach (var s in sessions)
                Console.WriteLine($"{s.Key}: {s.Value.Title}");

            // 7. Handle Concurrent Enrollments - ConcurrentDictionary<TKey, TValue>
            ConcurrentDictionary<int, Enrollment> enrollments = new ConcurrentDictionary<int, Enrollment>();
            enrollments.TryAdd(1, new Enrollment { EnrollmentId = 1, LearnerId = 1 });
            enrollments.TryAdd(2, new Enrollment { EnrollmentId = 2, LearnerId = 2 });

            Console.WriteLine("\nConcurrent Enrollments:");
            foreach (var e in enrollments)
                Console.WriteLine($"Enrollment ID: {e.Key}, Learner ID: {e.Value.LearnerId}");
        }
    }
}