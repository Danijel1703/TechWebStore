﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _unitOfWork.Commit();
        }
    }
}