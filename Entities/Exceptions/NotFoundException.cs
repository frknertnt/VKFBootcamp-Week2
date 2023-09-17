
namespace Entities.Exceptions
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message) : base(message) //abstract class olduğu için newlenemez o yüzden protected
        {

        }
    }
}
