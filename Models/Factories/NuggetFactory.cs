using System.Collections.Generic;
using PennyPacker.Models.Workers;

namespace PennyPacker.Models.Factories {
    public class NuggetFactory {
        public List<FoodProcessor> employees { get; set; } = new List<FoodProcessor> ();

        public void HireEmployee (FoodProcessor employee) {
            employees.Add (employee);
        }
    }
}