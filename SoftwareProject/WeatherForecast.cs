using System;

namespace SoftwareProject
{   
    //This is comment
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }


    }
}
