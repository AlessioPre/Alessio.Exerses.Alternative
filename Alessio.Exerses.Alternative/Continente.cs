using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alessio.Exerses.Alternative
{
        #region Continente
        class Continente : Area_Geografica
        {
            
            #region //Var Continente
            Paese _paese;
        
            #endregion
            #region //Costruttore continente
            public Continente(string nomecontinente)
            {
                this.Nome = nomecontinente;
            }
            #endregion
            #region //Metodi Continente
            void AddPaese(Paese paese)
            {
                _paese = paese;
            }
            public void CreaPaese(string nomepaese)
            {
                 _paese = new Paese(nomepaese);

            }
            public void ChangePaese(Continente Continente)
            {
                Continente.AddPaese(_paese);
            }
            public void PaeseCreaRegione(string nomeregione)
            {
                _paese.CreaRegione(nomeregione);
            }
            public void RegioneCreaProvincia(string nomeprovincia)
            {
                _paese.RegioneCreaProvincia(nomeprovincia);
            }
            public void ProvinciaCreaComune(string nomecomune)
            {
                _paese.ProvinciaCreaComune(nomecomune);
            }

            internal void PaeseCambiaRegione(string v1, string v2, string v3)
        {
            if (_paese.Nome == v2 )
            {
                Paese paese = new Paese(v3);
                _paese.CreaRegione(v1);
                _paese.ChangeRegione(paese);
                paese.GetRegioneName();
                Console.WriteLine("Il Paese {0} , non ha più la regione {1} , Ora appartiene a {2}",_paese.Nome,paese.GetRegioneName(),paese.Nome);
            } 
        }
            internal void RegioneCambiaProvincia(string nomeProvincia, string nuovaregione, string vecchiaregione, string stato)
        {

            if (_paese.Nome== stato)
            {
                _paese.RegioneCreaProvincia(nomeProvincia, nuovaregione, vecchiaregione);

            }
        }
            internal void ProvinciaCambiaComune(string nomecomune, string vecchiaprovincia, string nuovaprovincia, string nomeregione, string nomepaese)
        {
            if (_paese.Nome == nomepaese)
            {
                _paese.ProvinciaCambiaComune( nomecomune,vecchiaprovincia,nuovaprovincia,nomeregione);

            }
        }
        #endregion

        #region Paese
        class Paese : Area_Geografica
            {
                #region // Var Paese
                Regione _regione;
                #endregion
                #region // Costruttore Paese
                public Paese(string nomepaese)
                {
                    this.Nome = nomepaese;
                }
                #endregion
                #region // Metodi Paese
                void AddRegion(Regione Regione)
                {
                    _regione = Regione;
                }
                public void CreaRegione(string nomeregione)
                {
                    _regione = new Regione(nomeregione);
                }
                //internal void ChangeContinente(string nomepaese ,string nuovocontinente)
                //{
                //   this.Nome = nomepaese;
                //   _nomecontinente = nuovocontinente;
                //}
                internal void ChangeRegione(Paese Paese)
                {
                    Paese.AddRegion(_regione);

                    this._regione = null;
                }
                internal void RegioneCreaProvincia(string nomeprovincia)
                {
                    _regione.CreateProvincia(nomeprovincia);
                }
                internal void ProvinciaCreaComune(string nomecomune)
                {
                    _regione.ProvinciaCreaComune(nomecomune);
                }

            internal string GetRegioneName()
            {
                return _regione.Nome;
            }

            internal void RegioneCreaProvincia(string nomeProvincia, string nuovaregione, string vecchiaregione)
            {
                if (_regione.Nome==vecchiaregione)
                {
                    Regione regione = new Regione(nuovaregione);
                    _regione.CreateProvincia(nomeProvincia);
                    _regione.ChangeProvincia(regione);
                    regione.GetProvinciaName();
                    Console.WriteLine("La regione {0} , non ha più la provincia {1} , Ora appartiene a {2}", _regione.Nome,regione.GetProvinciaName(), regione.Nome);
                }
            }

            internal void ProvinciaCambiaComune(string nomecomune, string vecchiaprovincia, string nuovaprovincia, string nomeregione)
            {
                if (_regione.Nome==nomeregione)
                {
                    _regione.ProvinciaCambiaComune(nomecomune,vecchiaprovincia,nuovaprovincia);
                };
            }
            #endregion

            #region Regione
            class Regione : Area_Geografica
                {
                    #region // Var Regione

                    Provincia _provincia;

                    #endregion
                    #region //Costruttore Regione
                    public Regione(string nomeregione)
                    {
                        this.Nome = nomeregione;
                    }
                    #endregion
                    #region // Metodi Regione
                    void AddProvincia(Provincia Provincia)
                    {
                        _provincia = Provincia;
                    }

                    public void CreateProvincia(string nomeprovincia)
                    {
                        _provincia = new Provincia(nomeprovincia);
                    }
                    public void ChangeProvincia(Regione Regione)
                    {
                        Regione.AddProvincia(_provincia);

                        this._provincia = null;
                    }

                    internal void ProvinciaCreaComune(string nomecomune)
                    {
                        _provincia.CreateComune(nomecomune);
                    }

                internal string GetProvinciaName()
                {
                    return this._provincia.Nome;
                }

                internal void ProvinciaCambiaComune(string nomecomune, string vecchiaprovincia, string nuovaprovincia)
                {
                    if (_provincia.Nome == vecchiaprovincia)
                    {
                        Provincia provincia = new Provincia(nuovaprovincia);
                        _provincia.CreateComune(nomecomune);
                        _provincia.ChangeComune(provincia);
                        provincia.GetComuneName();
                        Console.WriteLine("La regione {0} , non ha più la provincia {1} , Ora appartiene a {2}", _provincia.Nome, provincia.GetComuneName(), provincia.Nome);
                    }
                }

                //public void ChangeStato(string nomeregione ,string nuovostato)
                //{
                //    this.Nome= nomeregione;
                //    _nomestato = nuovostato;
                //}
                #endregion

                #region Provincia
                class Provincia : Area_Geografica
                    {
                        #region // Var Provincia
                        Comune _comune;
                        #endregion
                        #region //Costruttore Provincia
                        public Provincia(string nomeprovincia)
                        {
                            this.Nome = nomeprovincia;
                            //_comune = new Comune(nomecomune,provinciaAssociata);
                        }
                        #endregion
                        #region //Metodi Provincia
                        void AddComune(Comune comune)
                        {
                            _comune = comune;
                        }
                        public void CreateComune(string nomecomune)
                        {
                            _comune = new Comune(nomecomune);
                        }
                        public void ChangeComune(Provincia Provincia)
                        {
                            Provincia.AddComune(this._comune);

                            this._comune = null;
                        }

                    internal string GetComuneName()
                    {
                        return this._comune.Nome;
                    }

                    //public void ChangeRegione(string nomeprovincia , string nuovaregione)
                    //{
                    //    this.Nome       = nomeprovincia;
                    //    _nuovaregione   = nuovaregione;
                    //}
                    #endregion

                    #region Comune
                    class Comune : Area_Geografica
                        {
                            #region // Var Comune
                            //string _nomeProvincia;
                            #endregion
                            #region //Costruttore Comune
                            public Comune(string nomecomune)
                            {
                                this.Nome = nomecomune;
                                //_nomeProvincia = nomeprovincia;
                            }
                            #endregion
                            #region // Metodi Comune
                            //public void ChangeProvincia(string nomecomune, string nuovaprovinciaassociata)
                            //{
                            //    this.Nome = nomecomune;
                            //    this._nomeProvincia= nuovaprovinciaassociata;
                            //}
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                #endregion
            }
            #endregion
        }
        #endregion
}
