using System;
using Microsoft.ML.OnnxRuntime.Tensors;

namespace AuthLab2_RyanPinkney
{
    public class CrashData
    {

        public float county_name_SALT_LAKE { get; set; }
        public float county_name_UTAH { get; set; }
        public float single_vehicle_True { get; set; }
        public float teenage_driver_involved_True { get; set; }
        public float night_dark_condition_True { get; set; }
        public float roadway_departure_True { get; set; }
        public float intersection_related_True { get; set; }
        public float city_Other { get; set; }

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
           county_name_SALT_LAKE, county_name_UTAH, single_vehicle_True, teenage_driver_involved_True,
            night_dark_condition_True, roadway_departure_True, intersection_related_True, city_Other
            };
            int[] dimensions = new int[] { 1, 8};
            return new DenseTensor<float>(data, dimensions);
        }



    }
}
