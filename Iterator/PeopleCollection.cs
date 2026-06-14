using System.Collections.Generic;

namespace Iterator;

class PeopleCollection : List<Person>, IPeopleCollection
{
    public IPeopleIterator CreateIterator()
    {
        return new PeopleIterator(this);
    }
}
