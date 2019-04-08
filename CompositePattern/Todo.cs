using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Todo : ITodoList
    {
        private string _title;

        public Todo(string title) {
            this._title = title;
        }

        public string GetHtml()
        {
            return this._title;
        }
    }
}
