using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Todo("Hacer A I");
            var t2 = new Todo("Hacer A II");
            var tc1 = new TodoComposite("Hacer Composite A");

            var tc2 = new TodoComposite("Hacer Sub Composite B");
            tc2.Add(new Todo("Hacer B I"));
            tc2.Add(new Todo("Hacer B II"));
            tc2.Add(new Todo("Hacer B III"));
            tc1.Add(t1);
            tc1.Add(t2);
            tc1.Add(tc2);

            var project = tc1;

            Console.Write(project.GetHtml());
            Console.ReadKey(true);
        }
    }
}
