using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class encriptarDocente : IEncriptar
    {

        public encriptarDocente()
        {


        }

        //Método encriptar docente

        Dictionary<string, string> Dictionary = new Dictionary<string, string>()
            {
                {"a","mFaq" }, {"b","33Dz" }, {"c","dX1" }, {"d","0x01" }, {"e","zupq" },
                {"f","mA1" }, {"g","l0v3" }, {"h","1Zz" }, {"i","s00o" }, {"j","kUt3" },
                {"k","vhH" }, {"l","s1d4" }, {"m","l0k0" }, {"n","vk" }, {"ñ","oña" },
                {"o","hhh1" },{"p","po8" }, {"q","dsX" }, {"r","1zD" }, {"s","lOl" },
                {"t","yy2" },{"u","2cV" }, {"v","mGhc" }, {"w","FFe" }, {"x","nNc" },
                {"y","5Mg" },{"z","tutq" },
                {"A","mFaq" }, {"B","33Dz" }, {"C","dX1" }, {"D","0x01" }, {"E","zupq" },
                {"F","mA1" }, {"G","l0v3" }, {"H","1Zz" }, {"I","s00o" }, {"J","kUt3" },
                {"K","vhH" }, {"L","s1d4" }, {"M","l0k0" }, {"N","vk" }, {"Ñ","oña" },
                {"O","hhh1" },{"P","po8" }, {"Q","dsX" }, {"R","1zD" }, {"S","lOl" },
                {"T","yy2" },{"U","2cV" }, {"V","mGhc" }, {"W","FFe" }, {"X","nNc" },
                {"Y","5Mg" },{"Z","tutq" },
                {" ","xAm5" },{"0","cV4" }, {"1","cW221" }, {"2","plL7" }, {"3","pc24" }, {"4","lo27" },
                {"5","mai5" }, {"6","qLopU" }, {"7","Qmdcd" }, {"8","h20" }, {"9","10" }
            };
        // string keyAdmin = EncriptarAdmin(Dictionary, encrip);
        string EncriptarDoc(Dictionary<string, string> Dictionary, string cad)
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

        public string encriptar(string cad)
        {
            string keyDoc = EncriptarDoc(Dictionary, cad);

            return keyDoc;
        }
        //Fin método encriptar

    }
}
