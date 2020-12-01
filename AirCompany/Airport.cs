using Aircompany.Models;
using Aircompany.Models.Planes;
using Aircompany.Models.Planes.PlaneTypes;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        #region Constructors
        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }
        #endregion


        #region Properties
        public List<Plane> Planes { get; private set; }
        #endregion


        #region Methods
        public IEnumerable<PassengerPlane> GetPassengerPlanes()
        {
            return Planes
                .Where(plane => plane is PassengerPlane)
                .Cast<PassengerPlane>();
        }

        public IEnumerable<MilitaryPlane> GetMilitaryPlanes()
        {
            return Planes
                .Where(plane => plane is MilitaryPlane)
                .Cast<MilitaryPlane>();
        }

        public PassengerPlane GetPlaneWithMaxCapacity()
        {
            return GetPassengerPlanes()
                .Aggregate((w, x) => w.PassengersCapacity > x.PassengersCapacity ? w : x);
        }

        public IEnumerable<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return GetMilitaryPlanes()
                .Where(militaryPlane => militaryPlane.TypeOfPlane == MilitaryPlaneType.Transport);
        }


        public Airport SortByMaxDistance()
        {
            Planes = Planes
                .OrderBy(w => w.MaxFlightDistance)
                .ToList();

            return this;
        }

        public Airport SortByMaxSpeed()
        {
            Planes = Planes
                .OrderBy(w => w.MaxSpeed)
                .ToList();

            return this;
        }

        public Airport SortByMaxLoadCapacity()
        {
            Planes = Planes
                .OrderBy(w => w.MaxLoadCapacity)
                .ToList();

            return this;
        }


        public override string ToString()
        {
            var models = Planes.Select(x => x.Model);
            var modelsString = string.Join(", ", models);

            return $"Airport. Planes: {modelsString}";
        }
        #endregion
    }
}