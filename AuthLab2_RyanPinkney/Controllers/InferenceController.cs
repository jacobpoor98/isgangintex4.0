//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.ML.OnnxRuntime;
//using Microsoft.ML.OnnxRuntime.Tensors;

//// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace AuthLab2_RyanPinkney.Controllers
//{
//    public class InferenceController : Controller
//    {
//        private InferenceSession _session;

//        public InferenceController(InferenceSession session)
//        {
//            _session = session;
//        }

//        [HttpPost]
//        public ActionResult Score(HousingData data)
//        {
//            var result = _session.Run(new List<NamedOnnxValue>
//            {
//                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
//            });
//            Tensor<float> score = result.First().AsTensor<float>();
//            var prediction = new Prediction { PredictedValue = score.First() * 100000 };
//            result.Dispose();

//            return View("SeverityModel", prediction);
//        }

//        public class HousingData
//        {
//            public float MedianIncome { get; set; }
//            public float MedianHouseAge { get; set; }
//            public float AverageNumberOfRooms { get; set; }
//            public float AverageNumberOfBedrooms { get; set; }
//            public float Population { get; set; }
//            public float AverageOccupancy { get; set; }
//            public float Latitude { get; set; }
//            public float Longitude { get; set; }

//            public Tensor<float> AsTensor()
//            {
//                float[] data = new float[]
//                {
//            MedianIncome, MedianHouseAge, AverageNumberOfRooms, AverageNumberOfBedrooms,
//            Population, AverageOccupancy, Latitude, Longitude
//                };
//                int[] dimensions = new int[] { 1, 8 };
//                return new DenseTensor<float>(data, dimensions);
//            }
//        }

//        public class Prediction
//        {
//            public float PredictedValue { get; set; }
//        }
//    }
//}
