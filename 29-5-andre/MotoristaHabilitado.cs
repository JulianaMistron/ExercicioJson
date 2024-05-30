using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_5_andre
{
    internal class MotoristaHabilitado
    {
        [JsonProperty("penalidades_aplicadas")]

            public List<PenalidadesAplicadas> PenalidadesAplicadas {  get; set; }
       
      
    }
}
