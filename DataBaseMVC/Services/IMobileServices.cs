using DataBaseMVC.Models;

namespace DataBaseMVC.Services
{
    public interface IMobileServices
    {
        ResponseModel<MobileResponse> AddRecord(MobileRequest model);
        ResponseModel<MobileResponse> GetRecordById(int id);
        //(bool IsSuccess, string? ErrorCode, string? ErrorMessage) GetRecordById1(int id);
        ResponseModel<List<MobileResponse>> GetAllRecords();
        ResponseModel<List<MobileResponse>> GetDeletedRecords();
        ResponseModel<MobileResponse> UpdateRecord(MobileUpdateRequest model);
        ResponseModel DeleteRecord(int id);
        ResponseModel RestoreRecord(int id);
        //ResponseModel RestoreDeletedRecord(int id);
        ResponseModel EmptyTrash();
        //   
    }
}
