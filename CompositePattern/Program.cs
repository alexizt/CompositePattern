using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<ITodoList>() {
                new Todo("Hacer A I") ,
                new Todo("Hacer A II"),
                new TodoComposite("Sub Project") { SubTodos=new List<ITodoList>(){ new Todo("Sub Todo I")  } }
            };
            var t1 = new Todo("Hacer A I");
            var t2 = new Todo("Hacer A II");
            var tc1 = new TodoComposite("Hacer Composite A");

            var tc2 = new TodoComposite("Hacer Sub Composite B");
            tc2.add(new Todo("Hacer B I"));
            tc2.add(new Todo("Hacer B II"));
            tc2.add(new Todo("Hacer B III"));
            tc1.add(t1);
            tc1.add(t2);
            tc1.add(tc2);

            var project = tc1;

            Console.Write(project.GetHtml());
            Console.ReadKey(true);
        }
    }
}
