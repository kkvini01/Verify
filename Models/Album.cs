using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verify.Models
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string NomeAlbum { get; set; }
        public DateTime DataLancamentoAlbum { get; set; }
        public string Gravadora { get; set; }
        public string CapaUrl { get; set; }
        public string DuracaoTotalAlbum { get; set; }
        public string TipoAlbum { get; set; }
        public int NumeroFaixas { get; set; }

        // Relação Artista
        public Artista IdArtista{ get; set; }

    }

    public class AlbumCollection : List<Album> { }

}
