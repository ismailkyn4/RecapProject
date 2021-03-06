﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string CarNameInvalid = "Car name or daily price is invalid";
        public static string CarAdded = "Car successfully added";
        public static string CarDeleted = "Car successfully deleted";



        public static string CarUpdated = "Car successfully updated";

        public static string BrandNameInvalid = "Brand name is invalid";
        public static string BrandAdded = "Brand successfully added";
        public static string BrandDeleted = "Brand successfully deleted";
        public static string BrandUpdated = "Brand successfully updated";

        public static string ColorNameInvalid = "Color name is invalid";
        public static string ColorAdded = "Color successfully added";
        public static string ColorDeleted = "Color successfully deleted";
        public static string ColorUpdated = "Color successfully updated";

        public static string CustomerNameInvalid = "Customer name is invalid";
        public static string CustomerAdded = "Customer successfully added";
        public static string CustomerDeleted = "Customer successfully deleted";
        public static string CustomerUpdated = "Customer successfully updated";


        public static string FirstNameInvalid = "Firstname is invalid";
        public static string LastNameInvalid = "LastName is invalid";
        public static string UserAdded = "User successfully added";
        public static string UserDeleted = "User successfully deleted";
        public static string UserUpdated = "User successfully updated";

        public static string MaintenanceTime = "System is under maintenance !!";
        public static string CarsListed = "Cars listed";

        public static string ReturnedRental = "The Car you rented has been returned";
        public static string ErrorReturnRental = "The Car you rented was not returned ";

        public static string RentedCar = "Car successfully rented";
        public static string RentDeleted = "Rent is Deleted";
        public static string RentIdFalse = "Rent Id is false";
        public static string RentUpdated = "Rent Updated";
        public static string RentNotUpdated = "Rent not Updated";
        public static string ReturnedCar = "Car successfully returned";

        public static string EmailInvalid = "Email must contain '@' ";
        public static string PasswordInvalid = "Password must be at least 6 characters";

        public static string CarCountOfBrandError = "Can be a maximum of 10 car models";
        public static string BrandNameAlreadyExits = "There is already such a brand name";
        public static string ColorNameAlreadyExits = "There is already such a color name";
        public static string BrandLimitExceded = "Number of brands exceeded";
        public static string ImageLimitError = "There can be up to 5 images";

        public static string CarImageAdded="Car Image Added";
        public static string CarImageDeleted="Car Image Deleted";
        public static string CarImageUpdated = "Car Image Updated";


        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Registered";
        public static string UserNotFound="User not found";
        public static string PasswordError="Password error";
        public static string SuccessfulLogin="Successful login";
        public static string UserAlreadyExists= "This user already exists";
        public static string AccessTokenCreated="Token created";
    }
}
