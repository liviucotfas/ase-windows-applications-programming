using System;

namespace SerializableCustomCollectionEvents
{
    [Serializable]
    public class Comanda
    {
        #region Proprietati
        String _nume;
        public String Nume
        {
            get { return _nume; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Numele nu poate fi vid.");
                }

                _nume = value;
                //Declansare eveniment
                OnModificareComanda(new EventArgs());
            }
        }

        String _prenume;
        public String Prenume
        {
            get { return _prenume; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Prenumele nu poate fi vid.");
                }
                _prenume = value;
                //Declansare eveniment
                OnModificareComanda(new EventArgs());
            }
        }

        String _masina;
        public String Masina
        {
            get { return _masina; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Masina nu poate fi vida.");
                }
                _masina = value; 
            }
        }
        
        DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        #endregion

        #region Constructor
        public Comanda(String nume, String prenume, String masina)
        {
            _nume = nume; _prenume = prenume; _masina = masina; _data = DateTime.Now;
        }
        #endregion

        [field: NonSerialized] 
        #region Eveniment: ModificareComanda
        public event EventHandler ModificareComanda;
        protected virtual void OnModificareComanda(EventArgs e)
        {
            if (ModificareComanda != null)
            {
                ModificareComanda(this, e);
            }
        }
        #endregion
    }
}
