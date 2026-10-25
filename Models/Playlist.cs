using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verify.Models
{
    public class Playlist
    {

        public int IdPlaylist { get; set; }
        public string NomePlaylist { get; set; }
        public string DescPlaylist { get; set; }
        public DateTime CriacaoPlaylist { get; set; }
        public DateTime AtualizacaoPlaylist { get; set; }

        // Retorna string porem no sql ta como INT (0 e 1) antes de inserir no banco precisa tratar isso aqui >_<
        // ComboBox
        public string Privacidade {  get; set; }
        public int QtdLikes { get; set; }

        // Relações Usuário
        public Usuario IdUsuario { get; set; }
        public int UsuarioId
        {
            get { return IdUsuario != null ? IdUsuario.IdUsuario : 0; }
        }


    }

    public class PlaylistCollection : List<Playlist> { }

}
