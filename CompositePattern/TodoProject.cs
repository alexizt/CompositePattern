using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class TodoComposite : ITodoList
    {
        private string _title;
        public List<ITodoList> SubTodos=new List<ITodoList>();

        public TodoComposite(string title)
        {
            _title = title;            
        }

        public void Add(ITodoList todo) {
            SubTodos.Add(todo);
        }

        public string GetHtml()
        {
            string html= Environment.NewLine+"<h1>";
            html += _title;
            html += "</h1>"+ Environment.NewLine + "<ul>" + Environment.NewLine;
            foreach (ITodoList tl in SubTodos)
            {
                html += "<li>";
                html += tl.GetHtml();
                html += "</li>" + Environment.NewLine;
            }
            html += "</ul>" + Environment.NewLine;

            return html;
        }
    }
}
