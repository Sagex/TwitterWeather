using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterWeather
{
    class GaroaWeather
    {
        public int temp { get; set; }
        public string city { get; set; }
        public string description { get; set; }
        public string humidity { get; set; }
        public string wind_speedy { get; set; }

        // The command or chars: "\x0A" is to jump line. Is ASCII command
        public override string ToString()
        {
            return $"Previsão do tempo da nossa querida Terra da Garoa:\x0A{city}\x0ATemperatura: {temp}°C\x0A" + $"Condição do céu: {description}\x0AUmidade: {humidity}%\x0AVelocidade do vento: {wind_speedy}";
        }
    }
}
