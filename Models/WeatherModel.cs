using System.Text.Json.Serialization;

namespace SuperBasicWeatherApi.Models
{
    public class WeatherModel
    {
        public class Root
        {
            public Weather[] Weather { get; set; }

            public Main Main { get; set; }

            public int Visibility { get; set; }

            public Sys Sys { get; set; }

            public int Timezone { get; set; }

            public int Id { get; set; }

            public string Name { get; set; }

            public int Cod { get; set; }
        }

        public class Main
        {
            public float Temp { get; set; }

            public float FeelsLike { get; set; }

            public float TempMin { get; set; }

            public float TempMax { get; set; }

            public int Pressure { get; set; }

            public int Humidity { get; set; }

            public int SeaLevel { get; set; }

            public int GrndLevel { get; set; }
        }

        public class Sys
        {
            public int Type { get; set; }

            public int Id { get; set; }

            public string Country { get; set; }

            public int Sunrise { get; set; }

            public int Sunset { get; set; }
        }

        public class Weather
        {
            public string Main { get; set; }

            public string Description { get; set; }
        }
    }
}
