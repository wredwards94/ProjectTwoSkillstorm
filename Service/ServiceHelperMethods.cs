using Contracts;
using Entities;
using Entities.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace Service;

internal class ServiceHelperMethods
{
    private readonly IRepositoryManager _repositoryManager;

    public ServiceHelperMethods(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

    public async Task<UserPlan> CheckUserPlanExists(Guid userPlanId, bool trackChanges)
    {
        var userPlan = await _repositoryManager.UserPlan.GetUserPlanById(userPlanId, trackChanges);
        if (userPlan == null) throw new UserPlanNotFoundException(userPlanId);
        return userPlan;
    }
    
    public async Task<PhonePlan> CheckPhonePlanExists(Guid planId, bool trackChanges)
    {
        var plan = await _repositoryManager.PhonePlan.GetPhonePlan(planId, trackChanges);
        if (plan == null) throw new PhonePlanNotFoundException(planId);
        return plan;
    }
    
    public async Task<UserDevice> CheckUserDeviceExists(Guid userDeviceId, bool trackChanges)
    {
        var userDevice = await _repositoryManager.UserDevice.GetUserDevice(userDeviceId, trackChanges);
        if (userDevice == null) throw new UserDeviceNotFoundException(userDeviceId);
        return userDevice;
    }
    
    public async Task<Device> CheckDeviceExists(Guid deviceId, bool trackChanges)
    {
        var device = await _repositoryManager.Device.GetDevice(deviceId, trackChanges);
        if (device == null) throw new DeviceNotFoundException(deviceId);
        return device;
    }
}