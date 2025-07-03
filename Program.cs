LinkedList<SomeOne> people = new LinkedList<SomeOne>();

var me = new Me();
me.AddPerson(new SomeOne("Alice", 30));
me.AddPerson(new SomeOne("Bob", 25));
me.AddPerson(new SomeOne("Charlie", 35));

me.MyCurrentOne = me.MyLinkedList.First.Value;

bool areYouDoneWithYourEx(SomeOne someOne)
{
    return someOne.IsDone;
}

if(areYouDoneWithYourEx(me.MyCurrentOne))
{
    me.MoveIntoTheNext();
}
if(areYouDoneWithYourEx(me.MyCurrentOne))
{
    me.MoveIntoTheNext();
}
