//create a program to show the usage of static constuctor
using System;
namespace Constructor {
    class Test {
        
        private static int id = 5;
        public static int Id {
            get {
                return id;
            }
        }
        public static void print() {
            Console.WriteLine("Test.id = " + id);
        }
        static void Main(string[] args) {
            
            Test.print();
        }
    }
}
