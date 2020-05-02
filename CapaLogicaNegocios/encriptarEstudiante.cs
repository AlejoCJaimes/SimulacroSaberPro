using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class encriptarEstudiante : IEncriptar
    {

        public encriptarEstudiante() { 
        
        
        }

        //Método encriptar estudiante


        Dictionary<string, string> Dictionary = new Dictionary<string, string>()
            {//yRdXc7Gdx01S
                {"a","f0rTN" }, {"b","1TeE" }, {"c","3ZL" }, {"d","0MeJ" }, {"e","0003X" },
                  {"f","Y4XoN" }, {"g","K4M1L" }, {"h","JH04N" }, {"i","Y0NnN" }, {"j","MvE5" },
                {"k","1xx1" }, {"l","PLzLm" }, {"m","4L3J0" }, {"n","V3GeT" }, {"ñ","777bb" },
                {"o","xqN6" },{"p","001" }, {"q","98yW" }, {"r","9c3D" }, {"s","0OMG0" },
                {"t","L1TT" },{"u","qkaPo" }, {"v","Dpd" }, {"w","Plr4" }, {"x","AlTf4" },
                {"y","Xp2" },{"z","JXp2x" },
                {"A","f0rTN" }, {"B","1TeE" }, {"C","3ZL" }, {"D","0MeJ" }, {"E","0003X" },
                  {"F","Y4XoN" }, {"G","K4M1L" }, {"H","JH04N" }, {"I","Y0NnN" }, {"J","MvE5" },
                {"K","1xx1" }, {"L","PLzLm" }, {"M","4L3J0" }, {"N","V3GeT" }, {"Ñ","777bb" },
                {"O","xqN6" },{"P","001" }, {"Q","98yW" }, {"R","9c3D" }, {"S","0OMG0" },
                {"T","L1TT" },{"U","qkaPo" }, {"V","Dpd" }, {"W","Plr4" }, {"X","AlTf4" },
                {"Y","Xp2" },{"Z","JXp2x" },
                 {" ","L0v33" },{"0","pU" }, {"1","bmWs" }, {"2","024U" }, {"3","ash4" }, {"4","4as2" },
                {"5","lm32" }, {"6","35l" }, {"7","1in3" }, {"8","cow" }, {"9","w8x" }
            };
        // string keyAdmin = EncriptarAdmin(Dictionary, encrip);
        string EncriptarAlum(Dictionary<string, string> Dictionary, string cad)
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
            string keyAlum = EncriptarAlum(Dictionary, cad);

            return keyAlum;
        }

        //Fin método encriptar estudiante

    }
}
