using System.Collections.Generic;

namespace Aircompany.Models.Planes
{
    /// <summary>
    /// Abstract class which a base for creating types of Planes
    /// </summary>
    public abstract class Plane
    {
        #region Properties
        public string Model { get; set; }
        public int MaxSpeed { set; get; }
        public int MaxFlightDistance { get; set; }
        public int MaxLoadCapacity { get; set; }
        #endregion


        #region Methods
        public override bool Equals(object obj)
        {
            var plane = obj as Plane;

            return plane != null &&
                   Model == plane.Model &&
                   MaxSpeed == plane.MaxSpeed &&
                   MaxFlightDistance == plane.MaxFlightDistance &&
                   MaxLoadCapacity == plane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + MaxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxLoadCapacity.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $" Plane( model= {Model}'\', maxSpeed= {MaxSpeed}, maxFlightDistance= {MaxFlightDistance}, maxLoadCapacity= {MaxLoadCapacity} )";
        }
        #endregion
    }
}