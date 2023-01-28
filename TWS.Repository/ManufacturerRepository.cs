using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DAL;
using TWS.DAL.Entities;
using TWS.Model;
using TWS.Model.Common;
using TWS.Repository.Common;

namespace TWS.Repository
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly TWSContext _dbContext;
        private readonly IMapper _mapper;
        public ManufacturerRepository(TWSContext dbContext, IMapper mapper) 
        { 
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IManufacturer>> GetAll()
        {
            var entities = await _dbContext.Set<ManufacturerEntity>().ToListAsync();
            IEnumerable<IManufacturer> manufacturers = _mapper.Map<IEnumerable<Manufacturer>>(entities);
            return manufacturers;
        }

        public async Task<IManufacturer> GetById(Guid id)
        {
            var entity = await _dbContext.Set<ManufacturerEntity>().FindAsync(id);
            IManufacturer manufacturer = _mapper.Map<Manufacturer>(entity);
            return manufacturer;
        }

        public async Task Create(IManufacturer manufacturer)
        {
            ManufacturerEntity entity = _mapper.Map<ManufacturerEntity>(manufacturer);
            _dbContext.Set<ManufacturerEntity>().Add(entity);
            await Task.FromResult(entity);
        }

        public async Task Update(Guid id, IManufacturer manufacturer)
        {
            ManufacturerEntity newEntity = _mapper.Map<ManufacturerEntity>(manufacturer);
            ManufacturerEntity existingEntity = _dbContext.Set<ManufacturerEntity>().Where(entity => entity.Id == id).FirstOrDefault();
            existingEntity.Name = newEntity.Name;
            await Task.FromResult(existingEntity);
        }

        public async Task Delete(Guid id)
        {
            ManufacturerEntity entity = _dbContext.Set<ManufacturerEntity>().Find(id);
            _dbContext.Set<ManufacturerEntity>().Remove(entity);
            await Task.FromResult(entity);
        }

        public async Task <IEnumerable<IManufacturer>> GetPagedEntries(IPaging paging)
        {
            int skip = paging.PageSize * (paging.PageNumber - 1);
            IEnumerable<ManufacturerEntity> entities = await _dbContext.Set<ManufacturerEntity>().Skip(skip).Take(paging.PageSize).ToListAsync();
            IEnumerable<Manufacturer> result = _mapper.Map<IEnumerable<Manufacturer>>(entities);
            return result;
        }
    }
}
