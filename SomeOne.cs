public class SomeOne
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsDone { get; private set; }
    private bool _isLoyal;
    public bool IsLoyal
    {
        get => _isLoyal;
        private set
        {
            _isLoyal = value;
            IsDone = !_isLoyal; // If not loyal, then done
        }
    }
    public SomeOne(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public override string ToString()
    {
        return $"{Name}, {Age} years old";
    }
}
public class Me
{
    public SomeOne MyCurrentOne { get; set; }
    public LinkedList<SomeOne> MyLinkedList { get; set; }

    public void AddPerson(SomeOne person)
    {
        if (MyLinkedList == null)
        {
            MyLinkedList = new LinkedList<SomeOne>();
        }
        MyLinkedList.AddLast(person);
    }
    public void MoveIntoTheNext()
    {
        if (MyLinkedList != null && MyCurrentOne != null)
        {
            var currentNode = MyLinkedList.Find(MyCurrentOne);
            if (currentNode != null && currentNode.Next != null)
            {
                MyCurrentOne = currentNode.Next.Value;
            }
        }
    }
}