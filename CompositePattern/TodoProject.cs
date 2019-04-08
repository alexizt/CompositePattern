using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class TodoComposite : ITodoList
    {
        private string _title;
        public List<ITodoList> SubTodos=new List<ITodoList>();

        public TodoComposite(string title)
        {
            this._title = title;            
        }

        public void add(ITodoList todo) {
            this.SubTodos.Add(todo);
        }

        public string GetHtml()
        {
            string html= System.Environment.NewLine+"<h1>";
            html += this._title;
            html += "</h1>"+ System.Environment.NewLine + "<ul>" + System.Environment.NewLine;
            foreach (ITodoList tl in this.SubTodos)
            {
                html += "<li>";
                html += tl.GetHtml();
                html += "</li>" + System.Environment.NewLine;
            }
            html += "</ul>" + System.Environment.NewLine;

            return html;
        }
    }
}
