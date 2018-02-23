using Newtonsoft.Json;

namespace OpenInvoicePeru.Comun.Dto.Modelos
{
    public class GrupoResumenNuevo : GrupoResumen
    {
        [JsonProperty(Required = Required.Always)]
        public string IdDocumento { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string TipoDocumentoReceptor { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string NroDocumentoReceptor { get; set; }

        [JsonProperty(Required = Required.Always)]
        public int CodigoEstadoItem { get; set; }

        public string DocumentoRelacionado { get; set; }

        public string TipoDocumentoRelacionado { get; set; }

        public string RegimenPercepcion { get; set; }
        public decimal MontoPercepcion { get; set; }        
        public decimal PorcentajePercepcion { get; set; }
        //public decimal MontoIncluidaPercepcion { get; set; }
        //public decimal BaseImponiblePercepcion { get; set; } --> TotalVenta
    }
}