using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libRnPunto1
{
    public class clsRnPunto1
    {
        #region "Atributos"
        private int intDia;
        private float fltValUniLib;
        private float fltCantNormal;
        private float fltCantQuinc;
        private float fltCantFest;
        private string strError;

        #endregion

        #region "Constructor"
        public clsRnPunto1()
        {
            intDia = 0;
            fltValUniLib = 0;
            fltCantNormal = 0;
            fltCantQuinc = 0;
            fltCantFest = 0;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public int Dia
        {
            set { intDia = value; }
        }

        public float valUniLib
        {
            get { return fltValUniLib; }
        }

        public float cantNormal
        {
            get { return fltCantNormal; }
        }

        public float cantQuinc
        {
            get { return fltCantQuinc; }
        }

        public float cantFest
        {
            get { return fltCantFest; }
        }

        public string Error
        {
            get { return strError; }
        }

        #endregion

        #region "Metodos Privados"
        private bool leerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"valoresLibras.txt";
                int intCant = 0;  // Para la cantidad de líneas que tiene el archivo
                string strLinea;  // Para la línea leída del archivo
                string[] vectorLinea;  // Vector para almacenar la línea del archivo
                string strCodigo;
                intCant = File.ReadAllLines(strPath).Length;  // Lee la cantidad de líneas que tiene el archivo
                if (intCant <= 0)
                {
                    strError = "Sin registros";
                    return false;
                }
                StreamReader Archivo = new StreamReader(@strPath); // Crear objeto para leer el archivo 
                while ((strLinea = Archivo.ReadLine()) != null)   // Leer línea * línea el archivo 
                {
                    vectorLinea = strLinea.Split('|');
                    strCodigo = vectorLinea[0]; //Nombre Dato 
                    if (strCodigo == intDia.ToString())
                    {
                        fltValUniLib = Convert.ToSingle(vectorLinea[1]); // Vr. Unitario libra
                        fltCantNormal = Convert.ToSingle(vectorLinea[2]); // Cant. Libras normal del dia
                        fltCantQuinc = Convert.ToSingle(vectorLinea[3]); // Cant. Libras Quincenal
                        fltCantFest = Convert.ToSingle(vectorLinea[4]); // Cant. Libras Festivo
                        break;
                    }
                }
                Archivo.Close();
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
        public bool Consultar()
        {
            return leerArchivo();
        }
        #endregion
    }
}
