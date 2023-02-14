using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1ClassLibrary.Models
{
    public class Car
    {
        #region props
        public int Id { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string? LicensePlate { get; set; }
        #endregion
        public override string ToString()
        {
            return $"{Id}, {Model}, {Price}, {LicensePlate}";
        }

        #region validations
        public void ValidateID()
        {
            if (Id <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void ValidateModel()
        {
            if (Model == null)
            {
                throw new ArgumentNullException();
            }
            if (Model.Length < 4)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void ValidatePrice() 
        {
            if (Price < 0) 
            { 
                throw new ArgumentOutOfRangeException(); 
            }
        }
        public void ValidateLicensePlate()
        {
            if (LicensePlate == null)
            {
                throw new ArgumentNullException();
            }
            if (LicensePlate.Length <= 2 || LicensePlate.Length >= 7) 
            { 
                throw new ArgumentOutOfRangeException(); 
            }
        }
        public void Validate()
        {
            ValidateID();
            ValidateModel();
            ValidatePrice();
            ValidateLicensePlate();
        }
        #endregion
    }

}
