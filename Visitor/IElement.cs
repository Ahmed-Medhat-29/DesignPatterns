namespace Visitor;

interface IElement
{
    void Accept(IVisitor visitor);
}
