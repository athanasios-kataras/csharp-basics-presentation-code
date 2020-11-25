namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks
{
    public class AnonymousTypes
    {
        public int TestInt {get; set;}
        public void TestAnonymousTypes() {
            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            System.Console.WriteLine(student.FirstName);
        }

        public void TestNestedAnonymousType() {
            var student = new { 
                    Id = 1, 
                    FirstName = "James", 
                    LastName = "Bond",
                    Address = new { Id = 1, City = "London", Country = "UK" }
                };
        }

        public void TestAnonymousTypeEquality() {
            var student = new { 
                    Id = 1, 
                    FirstName = "James", 
                    LastName = "Bond",
                    Address = new { Id = 1, City = "London", Country = "UK" }
                };

            var student2 = new { 
                    Id = 1, 
                    FirstName = "James", 
                    LastName = "Bond",
                    Address = new { Id = 1, City = "London", Country = "UK" }
                };

            var student3 = new { 
                    Id = 1, 
                    FirstName = "James1", 
                    LastName = "Bond1",
                    Address = new { Id = 1, City = "London", Country = "UK" }
                };

            var student4 = new { 
                    Id = 1, 
                    FirstName = "James", 
                    LastName = "Bond",
                    Address = new { Id = 2, City = "London", Country = "UK" }
                };

            System.Console.WriteLine("Student 1 equals student 2: " + (student.Equals(student2)));
            System.Console.WriteLine("Student 1 equals student 3: " + (student.Equals(student3)));
            System.Console.WriteLine("Student 1 equals student 4: " + (student.Equals(student4)));
        }

        public void TestNonAnonymousTypeEquality() {
            var anon = new AnonymousTypes() {
                TestInt = 1
            };

            var anon2 = new AnonymousTypes() {
                TestInt = 2
            };

            System.Console.WriteLine("Anonymous 1 equals ananymous 2: " + (anon.Equals(anon2)));
        }
    }
}