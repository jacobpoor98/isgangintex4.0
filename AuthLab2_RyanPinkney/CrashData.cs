using System;
using Microsoft.ML.OnnxRuntime.Tensors;

namespace AuthLab2_RyanPinkney
{
    public class CrashData
    {
        public float crash_id { get; set; }
        public float route { get; set; }
        public float milepoint { get; set; }
        public float lat_utm_y { get; set; }
        public float long_utm_x { get; set; }
        public float county_name_SALT_LAKE { get; set; }
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
            crash_id, route, milepoint, lat_utm_y,
            long_utm_x, county_name_SALT_LAKE, single_vehicle_True, teenage_driver_involved_True,
            night_dark_condition_True, roadway_departure_True, intersection_related_True, city_Other
            };
            int[] dimensions = new int[] { 1, 12 };
            return new DenseTensor<float>(data, dimensions);
        }



    }
}
