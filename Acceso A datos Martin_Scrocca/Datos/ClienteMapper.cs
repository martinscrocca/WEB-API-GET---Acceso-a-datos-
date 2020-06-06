using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entindades;
using Newtonsoft.Json;

namespace Datos
{
    public class ClienteMapper // paso 2 
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("/api/v1/cliente");// trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);

            return resultado;
        } 

        private List<Cliente> MapList (string json)
        {
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }
    }
}
