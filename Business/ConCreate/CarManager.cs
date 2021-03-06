﻿using Business.Abstract;
using Core.Entities;
using Core.Utilities;
using DataAccess.Abstract;
using Entity.ConCreate;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCreate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal entity)
        {
            _carDal = entity;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult();
        }

        public IResult delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {            
            return new SuccessDataResult<List<Car>>(_carDal.GetALL());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail());
        }

        public IDataResult<CarDetailDto> GetCarsById(int carId)
        {
            return new SuccessDataResult<CarDetailDto>(_carDal.GetCarDetailID(carId));
        }

        public IResult update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
