using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelListing.IRepository;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;


namespace HotelListing.Repository
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotel> _hotels;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);
        IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        IGenericRepository<Hotel> IUnitOfWork.Hotels => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}