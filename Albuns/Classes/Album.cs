using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albuns.Classes
{
    class Album
    {
        private string _titulo { get; set; }
        private string _artista { get; set; }
        private string _gravadora { get; set; }
        private string _genero { get; set; }
        private int _faixas { get; set; }
        private int _ano { get; set; }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Artista
        {
            get { return _artista; }
            set { _artista = value; }
        }

        public string Gravadora
        {
            get { return _gravadora; }
            set { _gravadora = value; }
        }
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        public int Faixas
        {
            get { return _faixas; }
            set { _faixas = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
    }
}
