using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.Model;
using TWS.Model.Common;
using TWS.Repository.Common;
using TWS.Service.Common;

namespace TWS.Service
{
    public class ManufacturerService : IManufacturerService
    {
        IManufacturerRepository _repository;
        IUnitOfWork _unitOfWork;
        public ManufacturerService(IUnitOfWork  unitOfWork, IManufacturerRepository manufacturerRepository) 
        {
            _repository = manufacturerRepository;
            _unitOfWork= unitOfWork;
        }

        public async Task<IEnumerable<IManufacturer>> GetAllManufacturers()
        {
            return await _repository.GetAll();
        }

        public async Task AddManufacturer(IManufacturer manufacturer)
        {
            await _unitOfWork.ManufacturerRepository.Create(manufacturer);
            await _unitOfWork.Commit();
        }
        
        public async Task DeleteManufacturer(Guid id)
        {
            await _unitOfWork.ManufacturerRepository.Delete(id);
            await _unitOfWork.Commit();
        }

        public async Task UpdateManufacturer(Guid id, IManufacturer manufacturer)
        {
            await _unitOfWork.ManufacturerRepository.Update(id, manufacturer);
            await _unitOfWork.Commit();
        }

        public async Task<IEnumerable<IManufacturer>> GetPagedManufacturers(IPaging paging)
        {
            return await _repository.GetPagedEntries(paging);
        }

        public async Task<IEnumerable<IManufacturer>> GetSortedManufacturers(ISort sort)
        {
            return await _repository.GetSortedEntries(sort);
        }

        public async Task<IManufacturer> GetManufacturerById(Guid id)
        {
            return await _repository.GetById(id);
        }
    }
}
