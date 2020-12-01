using Aircompany.Models;

namespace Aircompany.Models.Planes.PlaneTypes
{
    /// <summary>
    /// Represents a military planes.
    /// </summary>
    public class MilitaryPlane : Plane
    {
        #region Properties
        public MilitaryPlaneType TypeOfPlane { get; set; }
        #endregion


        #region Methods
        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   TypeOfPlane == plane.TypeOfPlane;
        }

        public override int GetHashCode()
        {
            int hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + TypeOfPlane.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, type={TypeOfPlane}";
        }
        #endregion
    }
}