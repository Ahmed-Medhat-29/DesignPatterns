using System.Linq;

namespace Iterator;

class PeopleIterator : IPeopleIterator
{
    private PeopleCollection _peopleCollection;
    private int _current = 0;

    public PeopleIterator(PeopleCollection collection)
    {
        _peopleCollection = collection;
    }

    public bool IsDone
    {
        get { return _current >= _peopleCollection.Count; }
    }


    public Person CurrentItem
    {
        get
        {
            return _peopleCollection
              .OrderBy(p => p.Name).ToList()[_current];
        }
    }

    public Person First()
    {
        _current = 0;
        return _peopleCollection
            .OrderBy(p => p.Name).ToList()[_current];
    }

    public Person Next()
    {
        _current++;
        if (!IsDone)
        {
            return _peopleCollection
                .OrderBy(p => p.Name).ToList()[_current];
        }
        else
        {
            return null;
        }
    }
}
