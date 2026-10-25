using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verify.Models
{
    public class Musica
    {

        public int IdMusica { get; set; }
        public string TituloMusica { get; set; }
        public string DuracaoSegundos { get; set; }
        public DateTime DataLancamentoMusica { get; set; }
        public string GeneroMusical { get; set; }
        public string NomeCompositor { get; set; }
        public int NumReprod { get; set; }

        // Relação com artista
        public Artista IdArtista { get; set; }

        // Relação Album
        public Album IdAlbum { get; set; }

        // Tapa buraco pq eu não agueto mais resolver erro :)
        // IDs numéricos para exibição
        public int ArtistaId
        {
            get { return IdArtista != null ? IdArtista.IdArtista : 0; }
        }

        public int AlbumId
        {
            get { return IdAlbum != null ? IdAlbum.IdAlbum : 0; }
        }


    }

    public class MusicaCollection : List<Musica> { }

}
