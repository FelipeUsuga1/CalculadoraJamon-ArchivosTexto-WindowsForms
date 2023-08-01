using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using libRnPunto1;

namespace libOpenPunto1
{
    public class clsOpenPunto1
    {
        #region "Atributos"
        private int intDiaSem;
        private bool blTipoQuinc;
        private bool blTipoFest;
        private float fltCantNorm;
        private float fltCantAdicional;
        private float fltTotalJamon;
        private float fltValTotalPag;
        private string strError;

        #endregion

        #region "Constructor"
        public clsOpenPunto1()
        {
            intDiaSem = 0;
            blTipoQuinc = false;
            blTipoFest = false;
            fltCantNorm = 0;
            fltCantAdicional = 0;
            fltTotalJamon = 0;
            fltValTotalPag = 0;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public int diaSem
        {
            set { intDiaSem = value; }
        }

        public bool tipoQuinc
        {
            set { blTipoQuinc = value; }
        }

        public bool tipoFest
        {
            set { blTipoFest = value; }
        }

        public float cantNorm
        {
            get { return fltCantNorm; }
        }


        public float cantAdicional
        {
            get { return fltCantAdicional; }
        }

        public float totalJamon
        {
            get { return fltTotalJamon; }
        }

        public float ValTotalPag
        {
            get { return fltValTotalPag; }
        }

        public string Error
        {
            get { return strError; }
        }

        #endregion

        #region "Metodos Privados"
        private bool Validar()
        {
            if (intDiaSem <= 0 || intDiaSem > 6)
            {
                strError = "Error, el dia de la semana no es valido";
                return false;
            }
            return true;
        }

        private bool procesarCalculo()
        {
            if (!Validar())
                return false;
            try
            {
                //Crear un objeto
                clsRnPunto1 cRn = new clsRnPunto1();

                cRn.Dia = intDiaSem;
                //Invocacion del metodo y tratamiento del error

                if (!cRn.Consultar())
                {
                    strError = cRn.Error;
                    cRn = null;
                    return false;
                }

                //Recuperacion de la info y el calcular

                if (blTipoQuinc == false && blTipoFest == false)
                {
                    fltCantNorm = cRn.cantNormal;
                    fltCantAdicional = 0;
                    fltTotalJamon = fltCantNorm + fltCantAdicional;
                }
                else
                {
                    if (blTipoQuinc == true && blTipoFest == false)
                    {
                        fltCantNorm = cRn.cantNormal;
                        fltCantAdicional = cRn.cantQuinc;
                        fltTotalJamon = fltCantNorm + fltCantAdicional;
                    }
                    else
                    {
                        if (blTipoFest == true && blTipoQuinc == false)
                        {
                            fltCantNorm = cRn.cantNormal;
                            fltCantAdicional = cRn.cantFest;
                            fltTotalJamon = fltCantNorm + fltCantAdicional;
                        }
                        else {
                            fltCantNorm = cRn.cantNormal;
                            fltCantAdicional = cRn.cantFest + cRn.cantQuinc;
                            fltTotalJamon = fltCantNorm + fltCantAdicional;
                        }
                    }
                    fltValTotalPag = (cRn.valUniLib) * fltTotalJamon;
                }
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        #endregion

        #region "Metodos Publicos"
        public bool Calcular()
        {
            return procesarCalculo();
        }
        #endregion
    }
}
