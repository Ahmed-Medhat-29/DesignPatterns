namespace Prototype;

interface ICloneable<T> where T : ICloneable<T>
{
	T Clone(bool deepClone = false);
}
