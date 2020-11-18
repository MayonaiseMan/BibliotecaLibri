using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaLibri
{
    public class Libri
    {
        private string _autore;
        private string _titolo;
        private int _annoPub;
        private string _editore;
        private int _nPag;

        public Libri(string a, string t, int ap, string e, int np) 
        {
            Autore = a;
            Titolo = t;
            AnnoPubblicazione = ap;
            Editore=e;
            NPag = np;

        }

        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("errore nome autore");
                }
                _autore = value;
            }
        }

        public string Titolo
        {
            get 
            {
                return _titolo;
            }
            set
            {
                if (value == null) 
                {
                    throw new Exception("errore nome autore");
                }
                _titolo = value;
            }
        }

        public int AnnoPubblicazione
        {
            get
            {
                return _annoPub;
            }
            set 
            {
                if ( value < 0)
                {
                    throw new Exception("errore data");
                }
                _annoPub=value;  
            }
        }

        public string Editore
        {

            get
            {
                return _editore;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("errore nome dell'editore");
                }
                _editore = value;
            }
        }

        public int NPag
        {
            get
            {
                return _nPag;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("errore numero pagine");
                }
                _nPag = value;
            }
        }
    }
}