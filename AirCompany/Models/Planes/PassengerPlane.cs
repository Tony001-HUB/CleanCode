using System;

namespace Aircompany.Models.Planes.PlaneTypes
{
    /// <summary>
    /// Represents a passenger plane.
    /// </summary>
    public class PassengerPlane : Plane
    {
        #region Properties
        public int PassengersCapacity { get; set; }
        #endregion
        

        #region Methods
        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   PassengersCapacity == plane.PassengersCapacity;
        }

        public override int GetHashCode()
        {
            int hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PassengersCapacity.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, passengersCapacity={PassengersCapacity}"; //вместо base.ToString().Replace("}", ", passengersCapacity=" + _passengersCapacity + '}');
        }
        #endregion
    }
}