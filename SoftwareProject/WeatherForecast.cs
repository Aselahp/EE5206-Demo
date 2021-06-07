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

<<<<<<< HEAD
        public string Description { get; set; }
=======
        public int Id { get; set; }

>>>>>>> 4e8521d887478af293fa513d182e5bf2579a1c6c
    }
}
