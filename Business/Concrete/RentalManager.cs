using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentedCar);
        }

        public IResult Delete(Rental rental)
        {
            if (_rentalDal.GetAll(r=>r.RentalId ==rental.RentalId).Count >0)
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.RentDeleted);
                
            }
            return new ErrorResult(Messages.RentIdFalse);

        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetByRentalId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.RentalId==id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(filter), Messages.ReturnedRental);
        }

        public IResult Update(Rental rental)
        {

            _rentalDal.Update(rental);

            return new SuccessResult(Messages.RentUpdated);
        }
    }
}
