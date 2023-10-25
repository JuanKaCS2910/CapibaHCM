
using System.Collections.Generic;
using Capiba.HCM.Shared.DTOs;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;


namespace Capiba.HCM.Server.Models
{
    internal static class NavigationBuilder
    {
        private static JsonSerializerSettings DefaultSettings => SerializerSettings();

        private static JsonSerializerSettings SerializerSettings(bool indented = true) => new JsonSerializerSettings
        {
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            Formatting = indented ? Formatting.Indented : Formatting.None,
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = new List<JsonConverter> { new StringEnumConverter() }
        };

        public static SmartNavigationDTO FromJson(string json) => JsonConvert.DeserializeObject<SmartNavigationDTO>(json, DefaultSettings);
    }

    

    

}
