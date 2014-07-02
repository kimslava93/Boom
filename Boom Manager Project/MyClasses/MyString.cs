namespace Boom_Manager_Project.MyClasses
{
    public class MyString
    {

        public MyString(string s)
        {
            Value = s;
        }

        public string Value { get; set; }
        
        public bool Equals(string obj)
        {
            return Value == obj;
        }
    }
}
