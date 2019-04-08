namespace CompositePattern
{
    class Todo : ITodoList
    {
        private string _title;

        public Todo(string title) {
            _title = title;
        }

        public string GetHtml()
        {
            return _title;
        }
    }
}
