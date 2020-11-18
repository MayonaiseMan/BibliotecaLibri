using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLibri
{
    class Biblioteca
    {
        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura, List<Libri> listaLibri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            ListaLibri = listaLibri;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
        }

        public string Nome
        {
            get;
            set;
        }
        public string Indirizzo
        {
            get;
            set;
        }

        public List<Libri> ListaLibri
        {
            get;
            set;
        }

        public string OrarioApertura
        {
            get;
            set;
        }

        public string OrarioChiusura
        {
            get;
            set;
        }
        public void AddLibro(Libri l)
        {
            ListaLibri.Add(l);
        }

        public Libri RicercaLibro(string titolo)
        {
            for (int i = 0; i < ListaLibri.Count; i++)
            {
                if (ListaLibri[i].titolo == titolo)
                {
                    return ListaLibri[i];
                }
            }

            throw new Exception("non c'è il libro cercato");

        }

        public List<Libri> ListaLibAutori(string autore)
        {
            List<Libri> Llibri = new List<Libri>();

            for(int i = 0; i < ListaLibri.Count; i++)
            {
                if (ListaLibri[i].autore == autore)
                {
                    Llibri.Add(ListaLibri[i]);
                }
            }

            return Llibri;
        }

        public int NumeroLibri()
        {
            return ListaLibri.Count;
        }
    }
}
