namespace Entities.Exceptions;

public class UserDeviceNotFoundException : NotFoundException
{
    public UserDeviceNotFoundException(Guid id) : base($"UserDevice: {id} was not found")
    {
        
    }
}