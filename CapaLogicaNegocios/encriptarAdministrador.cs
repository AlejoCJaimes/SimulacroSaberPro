using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class encriptarAdministrador : IEncriptar
    {

        public encriptarAdministrador()
        {

        }

        //Método encriptar administrador


        Dictionary<string, string> Dictionary = new Dictionary<string, string>()
            {
                {"a","x01" }, {"b","3W" }, {"c","p01" }, {"d","F" }, {"e","lPq" },
                {"f","mF" }, {"g","7R" }, {"h","7Gd" }, {"i","1Q" }, {"j","yRd" },
                {"k","2b5" }, {"l","Px" }, {"m","32" }, {"n","S" }, {"ñ","24" },
                {"o","Xc" },{"p","uNa" }, {"q","5T" }, {"r","1D" }, {"s","woW" },
                {"t","li" },{"u","4k" }, {"v","X03" }, {"w","xD" }, {"x","2B" },
                {"y","1Tb" },{"z","uWu" },
                {"A","x01" }, {"B","3W" }, {"C","p01" }, {"D","F" }, {"E","lPq" },
                {"F","mF" }, {"G","7R" }, {"H","7Gd" }, {"I","1Q" }, {"J","yRd" },
                {"K","2b5" }, {"L","Px" }, {"M","gG" }, {"N","S" }, {"Ñ","24" },
                {"O","Xc" },{"P","uNa" }, {"Q","5T" }, {"R","1D" }, {"S","woW" },
                {"T","li" },{"U","4k" }, {"V","X03" }, {"W","xD" }, {"X","2B" },
                {"Y","1Tb" },{"Z","uWu" },
                {"0","cV" }, {"1","cW1" }, {"2","cL7" }, {"3","pB4" }, {"4","b27" },
                {"5","m5" }, {"6","qLo" }, {"7","cd" }, {"8","h" }, {"9","002" },
                {" ","7u7" }
            };

        //metodo de cifrado
        string EncriptarAdmin(Dictionary<string, string> Dictionary, string cad)
        {
            string res = "";
            for (int i = 0; i < cad.Length; i++)
            {

                if (Dictionary.ContainsKey(Convert.ToString(cad[i])))
                {
                    string value_For_Key = Dictionary[Convert.ToString(cad[i])];
                    Console.Write(value_For_Key);
                    res = res + value_For_Key;
                }
            }
            return res;
        }

        //devolucion de la clave cifrada
        public string encriptar(string cad)
        {
            string keyAdmin = EncriptarAdmin(Dictionary, cad);

            return keyAdmin;
        }

        //Fin método encriptar



    }
}
