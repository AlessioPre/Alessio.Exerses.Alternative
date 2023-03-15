using System;
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
                                Nome = nomecomune;
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
