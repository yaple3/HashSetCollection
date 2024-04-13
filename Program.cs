namespace HashSetCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HashSet<string> agenda = ["Mow Lawn", "Weed Garden", "Vacuum Rugs", "Clean Bathroom", "Make Bed"];

            HashSet<string> priorAgenda = ["Sweep Floors", "Wash Car", "Walk Dog", "Visit Grandma", "Run Errands"];

            HashSet<string> toDoList = ["Exercise", "Study", "Sleep", "Walk Dog", "Make Bed"];

            Console.WriteLine("Combined list of older and newer agenda");
            agenda.UnionWith(priorAgenda);
            foreach (string task in agenda)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();

            Console.WriteLine("tasks that are in both lists");
            HashSet<string> bothLists = [];
            bothLists = agenda;
            bothLists.IntersectWith(toDoList);
            foreach (string task in bothLists)
            {
                Console.WriteLine(task);
            }
        }
    }
}