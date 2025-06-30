using DataBaseMVC.Data;
using DataBaseMVC.Models;
using DataBaseMVC.Services;
using Microsoft.EntityFrameworkCore;

namespace DataBaseMVC.Repository
{
    public class MobileRepository(ApplicationDbContext dbContext) : IMobileServices
    {
        private readonly string errorCodePrefix = "Std-";

        public ResponseModel<MobileResponse> AddRecord(MobileRequest model)
        {
            ResponseModel<MobileResponse> responseModel = new ResponseModel<MobileResponse>();
            try
            {
                var mobile = new Mobile()
                {
                    Ram = model.Ram,
                    Name = model.Name,
                    Battery = model.Battery,
                };
               dbContext.Students.Add(mobile);
               dbContext.SaveChanges();
                var responseType = new MobileResponse()
                {
                    Id = mobile.Id,
                    Name = mobile.Name,
                    Ram = mobile.Ram,
                    Battery = mobile.Battery
                };
                responseModel.IsSuccess = true;
                responseModel.Result = responseType;
            }
            catch (Exception ex)
            {
                responseModel.ErrorCode = $"{errorCodePrefix}01";
                responseModel.ErrorMessage = $"Failed to add record. Detail: {ex.Message}. Stack trace : {ex.StackTrace}";
            }
            return responseModel;
        }

        public ResponseModel DeleteRecord(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseModel EmptyTrash()
        {
            throw new NotImplementedException();
        }

        public ResponseModel<List<MobileResponse>> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public ResponseModel<List<MobileResponse>> GetDeletedRecords()
        {
            throw new NotImplementedException();
        }

        public ResponseModel<MobileResponse> GetRecordById(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseModel RestoreRecord(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseModel<MobileResponse> UpdateRecord(MobileUpdateRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
