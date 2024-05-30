using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _29_5_andre
{
    internal class ReadFile
    {
        public static List<PenalidadesAplicadas> GetData(string path)
        {
             StreamReader r = new StreamReader(path);
             string jsonString = r.ReadToEnd();

             var lst = JsonConvert.DeserializeObject<MotoristaHabilitado>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            if(lst !=null) return lst.PenalidadesAplicadas;
            return null;
        }

    }
}

