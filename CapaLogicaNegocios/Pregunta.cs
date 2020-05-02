using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogicaNegocios
{
    public class Pregunta
    {
        int numeroPregunta;
        string descripcion;
        string fotografia;
        string idCompetencia;
        string idEnunciado;

        public Pregunta()
        {

        }
        //SETTERS
        public void setNumeroPregunta(int numeroPregunta)
        {
            this.numeroPregunta = numeroPregunta;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public void setFotografia(string fotografia)
        {
            this.fotografia = fotografia;
        }
        public void setIdCompetencia(string idCompetencia)
        {
            this.idCompetencia = idCompetencia;
        }
        public void setIdEnunciado(string idEnunciado)
        {
            this.idEnunciado = idEnunciado;
        }
        //GETTERS
        public int getNumeroPregunta()
        {
            return numeroPregunta;
        }
        public string getDescripcion()
        {
            return descripcion;
        }

        public string getFotografia()
        {
            return fotografia;
        }
        public string getIdCompetencia()
        {
            return idCompetencia;
        }
        public string getIdEnunciado()
        {
            return idEnunciado;
        }

        //UTILIDADES BASE DE DATOS
        static CD_Conexion conexion = CD_Conexion.getInstancia();

        public static int agregarPreguntas(string titulo, string descripcionEnunciado, string descripcionPregunta, string opcion1, string opcion2, string opcion3, string opcion4, string descripcionCompetencia, int respuestaCorrecta)
        {
            int retorno = 0, retornoEnunciado = 0, retornoPregunta = 0, retornoRespuesta1 = 0, retornoRespuesta2 = 0, retornoRespuesta3 = 0, retornoRespuesta4 = 0, retornoPreguntaRespuesta1 = 0, retornoPreguntaRespuesta2 = 0, retornoPreguntaRespuesta3 = 0, retornoPreguntaRespuesta4 = 0;
            Enunciado enunciado = new Enunciado();
            enunciado.setTitulo(titulo);
            enunciado.setDescripcion(descripcionEnunciado);

            Pregunta pregunta = new Pregunta();
            pregunta.setDescripcion(descripcionPregunta);
            try
            {
                MySqlCommand insertarEnunciado = new MySqlCommand("INSERT INTO `enunciado` (`Id`, `Titulo`, `Descripcion`, `Grafica`) VALUES (NULL, '" + titulo + "', '" + descripcionEnunciado + "', NULL);", conexion.getConnection());
                retornoEnunciado = insertarEnunciado.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarRespuesta1 = new MySqlCommand("INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES (NULL, '" + opcion1 + "');", conexion.getConnection());
                retornoRespuesta1 = insertarRespuesta1.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarRespuesta2 = new MySqlCommand("INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES (NULL, '" + opcion2 + "');", conexion.getConnection());
                retornoRespuesta2 = insertarRespuesta2.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarRespuesta3 = new MySqlCommand("INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES (NULL, '" + opcion3 + "');", conexion.getConnection());
                retornoRespuesta3 = insertarRespuesta3.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarRespuesta4 = new MySqlCommand("INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES (NULL, '" + opcion4 + "');", conexion.getConnection());
                retornoRespuesta4 = insertarRespuesta4.ExecuteNonQuery();
                conexion.offConnection();
                //LLAVES FORANEAS
                string buscadorIdOpcion1 = "";
                MySqlCommand buscarIdOpcion1 = new MySqlCommand("SELECT Id FROM `opciones` WHERE UPPER(Descripcion) = '" + opcion1 + "';", conexion.getConnection());
                MySqlDataReader idOpcion1 = buscarIdOpcion1.ExecuteReader();
                if (idOpcion1.Read())
                {
                    buscadorIdOpcion1 = idOpcion1["Id"].ToString();
                }
                string buscadorIdOpcion2 = "";
                conexion.offConnection();
                MySqlCommand buscarIdOpcion2 = new MySqlCommand("SELECT Id FROM `opciones` WHERE UPPER(Descripcion) = '" + opcion2 + "';", conexion.getConnection());
                MySqlDataReader idOpcion2 = buscarIdOpcion2.ExecuteReader();
                if (idOpcion2.Read())
                {
                    buscadorIdOpcion2 = idOpcion2["Id"].ToString();
                }
                string buscadorIdOpcion3 = "";
                conexion.offConnection();
                MySqlCommand buscarIdOpcion3 = new MySqlCommand("SELECT Id FROM `opciones` WHERE UPPER(Descripcion) = '" + opcion3 + "';", conexion.getConnection());
                MySqlDataReader idOpcion3 = buscarIdOpcion3.ExecuteReader();
                if (idOpcion3.Read())
                {
                    buscadorIdOpcion3 = idOpcion3["Id"].ToString();
                }
                string buscadorIdOpcion4 = "";
                conexion.offConnection();
                MySqlCommand buscarIdOpcion4 = new MySqlCommand("SELECT Id FROM `opciones` WHERE UPPER(Descripcion) = '" + opcion4 + "';", conexion.getConnection());
                MySqlDataReader idOpcion4 = buscarIdOpcion4.ExecuteReader();
                if (idOpcion4.Read())
                {
                    buscadorIdOpcion4 = idOpcion4["Id"].ToString();
                }
                string buscadorIdPregunta = "";
                conexion.offConnection();
                string buscadorIdCompetencia = "";
                conexion.offConnection();
                MySqlCommand buscarIdCompetencia = new MySqlCommand("SELECT Id FROM `competencias` WHERE UPPER(Nombre) = '" + descripcionCompetencia + "';", conexion.getConnection());
                MySqlDataReader idCompetencia = buscarIdCompetencia.ExecuteReader();
                if (idCompetencia.Read())
                {
                    buscadorIdCompetencia = idCompetencia["Id"].ToString();
                }
                string buscadorIdEnunciado = "";
                conexion.offConnection();
                MySqlCommand buscarIdEnunciado = new MySqlCommand("SELECT Id FROM `enunciado` WHERE UPPER(Titulo) = '" + titulo + "';", conexion.getConnection());
                MySqlDataReader idEnunciado = buscarIdEnunciado.ExecuteReader();
                if (idEnunciado.Read())
                {
                    buscadorIdEnunciado = idEnunciado["Id"].ToString();
                }
                //INSERTAR PREGUNTA
                conexion.offConnection();
                MySqlCommand insertarPregunta = new MySqlCommand("INSERT INTO `pregunta` (`Id`,  `Descripcion`, `Fotografia`, `idCompetencia`, `Id_Enunciado`) VALUES (NULL, '" + descripcionPregunta + "', NULL, '" + Convert.ToInt32(buscadorIdCompetencia) + "', '" + Convert.ToInt32(buscadorIdEnunciado) + "');", conexion.getConnection());
                retornoPregunta = insertarPregunta.ExecuteNonQuery();
                MySqlCommand buscarIdPregunta = new MySqlCommand("SELECT Id FROM `pregunta` WHERE UPPER(Descripcion) = '" + descripcionPregunta + "';", conexion.getConnection());
                MySqlDataReader idPregunta = buscarIdPregunta.ExecuteReader();
                if (idPregunta.Read())
                {
                    buscadorIdPregunta = idPregunta["Id"].ToString();
                }
                conexion.offConnection();
                if (respuestaCorrecta == 1)
                {
                    MySqlCommand insertarPreguntaRespuesta1 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,1," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion1) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta1 = insertarPreguntaRespuesta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta2 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion2) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta2 = insertarPreguntaRespuesta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta3 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion3) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta3 = insertarPreguntaRespuesta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta4 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion4) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta4 = insertarPreguntaRespuesta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else if (respuestaCorrecta == 2)
                {
                    MySqlCommand insertarPreguntaRespuesta1 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion1) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta1 = insertarPreguntaRespuesta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta2 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,1," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion2) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta2 = insertarPreguntaRespuesta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta3 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion3) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta3 = insertarPreguntaRespuesta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta4 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion4) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta4 = insertarPreguntaRespuesta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else if (respuestaCorrecta == 3)
                {
                    MySqlCommand insertarPreguntaRespuesta1 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion1) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta1 = insertarPreguntaRespuesta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta2 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion2) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta2 = insertarPreguntaRespuesta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta3 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,1," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion3) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta3 = insertarPreguntaRespuesta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta4 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion4) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta4 = insertarPreguntaRespuesta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else
                {
                    MySqlCommand insertarPreguntaRespuesta1 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion1) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta1 = insertarPreguntaRespuesta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta2 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion2) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta2 = insertarPreguntaRespuesta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta3 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion3) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta3 = insertarPreguntaRespuesta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta4 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,1," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion4) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta4 = insertarPreguntaRespuesta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (retornoEnunciado > 0 && retornoPregunta > 0 && retornoRespuesta1 > 0 && retornoRespuesta2 > 0 && retornoRespuesta3 > 0 && retornoRespuesta4 > 0 && retornoPreguntaRespuesta1 > 0 && retornoPreguntaRespuesta2 > 0 && retornoPreguntaRespuesta3 > 0 && retornoPreguntaRespuesta4 > 0)
            {
                retorno = 1;
            }
            return retorno;
        }

        public static int agregarPreguntas_1(string descripcionPregunta, string opcion1, string opcion2, string opcion3, string opcion4,string titulo, string descripcionCompetencia, int respuestaCorrecta)
        {
            int retorno = 0, retornoEnunciado = 0, retornoPregunta = 0, retornoRespuesta1 = 0, retornoRespuesta2 = 0, retornoRespuesta3 = 0, retornoRespuesta4 = 0, retornoPreguntaRespuesta1 = 0, retornoPreguntaRespuesta2 = 0, retornoPreguntaRespuesta3 = 0, retornoPreguntaRespuesta4 = 0;
            Enunciado enunciado = new Enunciado();
            enunciado.setTitulo(titulo);
            

            Pregunta pregunta = new Pregunta();
            pregunta.setDescripcion(descripcionPregunta);
            try
            {
                
                MySqlCommand insertarRespuesta1 = new MySqlCommand("INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES (NULL, '" + opcion1 + "');", conexion.getConnection());
                retornoRespuesta1 = insertarRespuesta1.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarRespuesta2 = new MySqlCommand("INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES (NULL, '" + opcion2 + "');", conexion.getConnection());
                retornoRespuesta2 = insertarRespuesta2.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarRespuesta3 = new MySqlCommand("INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES (NULL, '" + opcion3 + "');", conexion.getConnection());
                retornoRespuesta3 = insertarRespuesta3.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarRespuesta4 = new MySqlCommand("INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES (NULL, '" + opcion4 + "');", conexion.getConnection());
                retornoRespuesta4 = insertarRespuesta4.ExecuteNonQuery();
                conexion.offConnection();
                //LLAVES FORANEAS
                string buscadorIdOpcion1 = "";
                MySqlCommand buscarIdOpcion1 = new MySqlCommand("SELECT Id FROM `opciones` WHERE UPPER(Descripcion) = '" + opcion1 + "';", conexion.getConnection());
                MySqlDataReader idOpcion1 = buscarIdOpcion1.ExecuteReader();
                if (idOpcion1.Read())
                {
                    buscadorIdOpcion1 = idOpcion1["Id"].ToString();
                }
                string buscadorIdOpcion2 = "";
                conexion.offConnection();
                MySqlCommand buscarIdOpcion2 = new MySqlCommand("SELECT Id FROM `opciones` WHERE UPPER(Descripcion) = '" + opcion2 + "';", conexion.getConnection());
                MySqlDataReader idOpcion2 = buscarIdOpcion2.ExecuteReader();
                if (idOpcion2.Read())
                {
                    buscadorIdOpcion2 = idOpcion2["Id"].ToString();
                }
                string buscadorIdOpcion3 = "";
                conexion.offConnection();
                MySqlCommand buscarIdOpcion3 = new MySqlCommand("SELECT Id FROM `opciones` WHERE UPPER(Descripcion) = '" + opcion3 + "';", conexion.getConnection());
                MySqlDataReader idOpcion3 = buscarIdOpcion3.ExecuteReader();
                if (idOpcion3.Read())
                {
                    buscadorIdOpcion3 = idOpcion3["Id"].ToString();
                }
                string buscadorIdOpcion4 = "";
                conexion.offConnection();
                MySqlCommand buscarIdOpcion4 = new MySqlCommand("SELECT Id FROM `opciones` WHERE UPPER(Descripcion) = '" + opcion4 + "';", conexion.getConnection());
                MySqlDataReader idOpcion4 = buscarIdOpcion4.ExecuteReader();
                if (idOpcion4.Read())
                {
                    buscadorIdOpcion4 = idOpcion4["Id"].ToString();
                }
                string buscadorIdPregunta = "";
                conexion.offConnection();
                string buscadorIdCompetencia = "";
                conexion.offConnection();
                MySqlCommand buscarIdCompetencia = new MySqlCommand("SELECT Id FROM `competencias` WHERE UPPER(Nombre) = '" + descripcionCompetencia + "';", conexion.getConnection());
                MySqlDataReader idCompetencia = buscarIdCompetencia.ExecuteReader();
                if (idCompetencia.Read())
                {
                    buscadorIdCompetencia = idCompetencia["Id"].ToString();
                }
                string buscadorIdEnunciado = "";
                conexion.offConnection();
                MySqlCommand buscarIdEnunciado = new MySqlCommand("SELECT Id FROM `enunciado` WHERE UPPER(Titulo) = '" + titulo + "';", conexion.getConnection());
                MySqlDataReader idEnunciado = buscarIdEnunciado.ExecuteReader();
                if (idEnunciado.Read())
                {
                    buscadorIdEnunciado = idEnunciado["Id"].ToString();
                }
                //INSERTAR PREGUNTA
                conexion.offConnection();
                MySqlCommand insertarPregunta = new MySqlCommand("INSERT INTO `pregunta` (`Id`,  `Descripcion`, `Fotografia`, `idCompetencia`, `Id_Enunciado`) VALUES (NULL, '" + descripcionPregunta + "', NULL, '" + Convert.ToInt32(buscadorIdCompetencia) + "', '" + Convert.ToInt32(buscadorIdEnunciado) + "');", conexion.getConnection());
                retornoPregunta = insertarPregunta.ExecuteNonQuery();
                MySqlCommand buscarIdPregunta = new MySqlCommand("SELECT Id FROM `pregunta` WHERE UPPER(Descripcion) = '" + descripcionPregunta + "';", conexion.getConnection());
                MySqlDataReader idPregunta = buscarIdPregunta.ExecuteReader();
                if (idPregunta.Read())
                {
                    buscadorIdPregunta = idPregunta["Id"].ToString();
                }
                conexion.offConnection();
                if (respuestaCorrecta == 1)
                {
                    MySqlCommand insertarPreguntaRespuesta1 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,1," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion1) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta1 = insertarPreguntaRespuesta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta2 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion2) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta2 = insertarPreguntaRespuesta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta3 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion3) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta3 = insertarPreguntaRespuesta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta4 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion4) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta4 = insertarPreguntaRespuesta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else if (respuestaCorrecta == 2)
                {
                    MySqlCommand insertarPreguntaRespuesta1 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion1) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta1 = insertarPreguntaRespuesta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta2 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,1," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion2) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta2 = insertarPreguntaRespuesta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta3 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion3) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta3 = insertarPreguntaRespuesta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta4 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion4) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta4 = insertarPreguntaRespuesta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else if (respuestaCorrecta == 3)
                {
                    MySqlCommand insertarPreguntaRespuesta1 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion1) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta1 = insertarPreguntaRespuesta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta2 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion2) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta2 = insertarPreguntaRespuesta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta3 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,1," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion3) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta3 = insertarPreguntaRespuesta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta4 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion4) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta4 = insertarPreguntaRespuesta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else
                {
                    MySqlCommand insertarPreguntaRespuesta1 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion1) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta1 = insertarPreguntaRespuesta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta2 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion2) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta2 = insertarPreguntaRespuesta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta3 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,0," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion3) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta3 = insertarPreguntaRespuesta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarPreguntaRespuesta4 = new MySqlCommand("INSERT INTO `preguntaopciones`(`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES (NULL,1," + Convert.ToInt32(buscadorIdPregunta) + "," + Convert.ToInt32(buscadorIdOpcion4) + ");", conexion.getConnection());
                    retornoPreguntaRespuesta4 = insertarPreguntaRespuesta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (retornoEnunciado > 0 && retornoPregunta > 0 && retornoRespuesta1 > 0 && retornoRespuesta2 > 0 && retornoRespuesta3 > 0 && retornoRespuesta4 > 0 && retornoPreguntaRespuesta1 > 0 && retornoPreguntaRespuesta2 > 0 && retornoPreguntaRespuesta3 > 0 && retornoPreguntaRespuesta4 > 0)
            {
                retorno = 1;
            }
            return retorno;
        }

        public static int contarpreguntas()
        {
            int retorno=0, retorno_enunciado = 0;

            try
            {
                MySqlCommand countPreguntas = new MySqlCommand("SELECT COUNT(*) FROM pregunta;", conexion.getConnection());
                retorno_enunciado = countPreguntas.ExecuteNonQuery();
                conexion.offConnection();
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            if (retorno_enunciado >= 1)
            {
                retorno = 1;
            }
            return retorno;
        }
        public static int ingresarPruebaPregunta(string numeroPrueba, string descripcion)
        {
            int retorno = 0;
            //LLAVES FORANEAS
            string buscadorIdPregunta = "";
            try
            {
                MySqlCommand buscarIdPregunta = new MySqlCommand("SELECT Id FROM `pregunta` WHERE UPPER(Descripcion) = '" + descripcion + "';", conexion.getConnection());
                MySqlDataReader idPregunta = buscarIdPregunta.ExecuteReader();
                if (idPregunta.Read())
                {
                    buscadorIdPregunta = idPregunta["Id"].ToString();
                }
                conexion.offConnection();
                MySqlCommand insertarPruebaPregunta = new MySqlCommand("INSERT INTO `pruebapreguntas`(`Id`, `num_prueba`, `IdPregunta`) VALUES (NULL," + Convert.ToInt32(numeroPrueba) + "," + Convert.ToInt32(buscadorIdPregunta) + ");", conexion.getConnection());
                retorno = insertarPruebaPregunta.ExecuteNonQuery();
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return retorno;
        }


        public static int actualizarPregunta(string descripcionPregunta, string titulo, string enunciado, string pregunta, string competenciaNombre, string opcion1, string opcion2, string opcion3, string opcion4, int respuestaCorrecta)
        {
            int retorno = 0, retornoEnunciado = 0, retornoPregunta = 0, retornoRespuestaCorrecta1 = 0, retornoRespuestaCorrecta2 = 0, retornoRespuestaCorrecta3 = 0, retornoRespuestaCorrecta4 = 0, retornoRespuesta1 = 0, retornoRespuesta2 = 0, retornoRespuesta3 = 0, retornoRespuesta4 = 0;
            string buscadorIdEnunciado = "", buscadorIdCompetencia = "", buscadorIdPregunta = "", buscadorIdOpcion1 = "", buscadorIdOpcion2 = "", buscadorIdOpcion3 = "", buscadorIdOpcion4 = "";
            try
            {
                MySqlCommand buscarId = new MySqlCommand("select e.Id as \"idEnunciado\", p.Id as \"idPregunta\" from enunciado e JOIN pregunta p ON p.Id_Enunciado = e.Id WHERE p.Descripcion = '" + descripcionPregunta + "';", conexion.getConnection());
                MySqlDataReader id = buscarId.ExecuteReader();
                if (id.Read())
                {
                    buscadorIdEnunciado = id["idEnunciado"].ToString();
                    buscadorIdPregunta = id["idPregunta"].ToString();
                }
                conexion.offConnection();
                MySqlCommand buscarIdEnunciado = new MySqlCommand("select Id  from competencias WHERE nombre = '" + competenciaNombre + "';", conexion.getConnection());

                MySqlDataReader idCompetencia = buscarIdEnunciado.ExecuteReader();
                if (idCompetencia.Read())
                {
                    buscadorIdCompetencia = idCompetencia["Id"].ToString();
                }
                conexion.offConnection();
                MySqlCommand actualizarEnunciado = new MySqlCommand("UPDATE `enunciado` SET `Titulo`='" + titulo + "',`Descripcion`='" + enunciado + "' WHERE Id = " + Convert.ToInt16(buscadorIdEnunciado) + ";", conexion.getConnection());
                retornoEnunciado = actualizarEnunciado.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand consultaOpcion1 = new MySqlCommand("select o.id from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "');", conexion.getConnection());
                MySqlDataReader leerOpcion1 = consultaOpcion1.ExecuteReader();
                if (leerOpcion1.Read())
                {
                    buscadorIdOpcion1 = leerOpcion1[0].ToString();
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion2 = new MySqlCommand("select o.id from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and o.id != " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                MySqlDataReader leerOpcion2 = consultaOpcion2.ExecuteReader();
                if (leerOpcion2.Read())
                {
                    buscadorIdOpcion2 = leerOpcion2[0].ToString();
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion3 = new MySqlCommand("select o.id from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and o.id != " + Convert.ToInt16(buscadorIdOpcion1) + " and o.id != " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                MySqlDataReader leerOpcion3 = consultaOpcion3.ExecuteReader();
                if (leerOpcion3.Read())
                {
                    buscadorIdOpcion3 = leerOpcion3[0].ToString();
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion4 = new MySqlCommand("select o.id from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and o.id != " + Convert.ToInt16(buscadorIdOpcion1) + " and o.id != " + Convert.ToInt16(buscadorIdOpcion2) + " and o.id != " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                MySqlDataReader leerOpcion4 = consultaOpcion4.ExecuteReader();
                if (leerOpcion4.Read())
                {
                    buscadorIdOpcion4 = leerOpcion4[0].ToString();
                }
                conexion.offConnection();
                if (respuestaCorrecta == 1)
                {
                    MySqlCommand insertarOpcionCorrecta1 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 1 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta1 = insertarOpcionCorrecta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta2 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta2 = insertarOpcionCorrecta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta3 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta3 = insertarOpcionCorrecta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta4 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion4) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta4 = insertarOpcionCorrecta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else if (respuestaCorrecta == 2)
                {
                    MySqlCommand insertarOpcionCorrecta1 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta1 = insertarOpcionCorrecta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta2 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 1 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta2 = insertarOpcionCorrecta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta3 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta3 = insertarOpcionCorrecta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta4 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion4) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta4 = insertarOpcionCorrecta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else if (respuestaCorrecta == 3)
                {
                    MySqlCommand insertarOpcionCorrecta1 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta1 = insertarOpcionCorrecta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta2 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta2 = insertarOpcionCorrecta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta3 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 1 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta3 = insertarOpcionCorrecta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta4 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion4) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta4 = insertarOpcionCorrecta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                else
                {
                    MySqlCommand insertarOpcionCorrecta1 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta1 = insertarOpcionCorrecta1.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta2 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta2 = insertarOpcionCorrecta2.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta3 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 0 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta3 = insertarOpcionCorrecta3.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand insertarOpcionCorrecta4 = new MySqlCommand("UPDATE `preguntaopciones` SET `Opc_correcta`= 1 WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion4) + ";", conexion.getConnection());
                    retornoRespuestaCorrecta4 = insertarOpcionCorrecta4.ExecuteNonQuery();
                    conexion.offConnection();
                }
                MySqlCommand insertarOpcion1 = new MySqlCommand("UPDATE `opciones` SET `descripcion`= '" + opcion1 + "' WHERE Id = " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                retornoRespuesta1 = insertarOpcion1.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarOpcion2 = new MySqlCommand("UPDATE `opciones` SET `descripcion`= '" + opcion2 + "' WHERE Id = " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                retornoRespuesta2 = insertarOpcion2.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarOpcion3 = new MySqlCommand("UPDATE `opciones` SET `descripcion`= '" + opcion3 + "' WHERE Id = " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                retornoRespuesta3 = insertarOpcion3.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand insertarOpcion4 = new MySqlCommand("UPDATE `opciones` SET `descripcion`= '" + opcion4 + "' WHERE Id = " + Convert.ToInt16(buscadorIdOpcion4) + ";", conexion.getConnection());
                retornoRespuesta4 = insertarOpcion4.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand actualizarPregunta = new MySqlCommand("UPDATE `pregunta` SET `Descripcion`='" + pregunta + "',`idCompetencia`=" + Convert.ToInt16(buscadorIdCompetencia) + ",`Id_Enunciado`=" + Convert.ToInt16(buscadorIdEnunciado) + " WHERE Descripcion = '" + descripcionPregunta + "';", conexion.getConnection());
                retornoPregunta = actualizarPregunta.ExecuteNonQuery();
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            if (retornoEnunciado > 0 && retornoPregunta > 0 && retornoRespuestaCorrecta1 > 0 && retornoRespuestaCorrecta2 > 0 && retornoRespuestaCorrecta3 > 0 && retornoRespuestaCorrecta4 > 0 && retornoRespuesta1 > 0 && retornoRespuesta2 > 0 && retornoRespuesta3 > 0 && retornoRespuesta4 > 0)
            {
                retorno = 1;
            }

            return retorno;
        }


        public static void eliminarPregunta(string descripcionPregunta)
        {
            int retornoPruebaPregunta = 0, retornoPregunta = 0, retornoEnunciado = 0, retornoRespuestaCorrecta1 = 0, retornoRespuestaCorrecta2 = 0, retornoRespuestaCorrecta3 = 0, retornoRespuestaCorrecta4 = 0, retornoRespuesta1 = 0, retornoRespuesta2 = 0, retornoRespuesta3 = 0, retornoRespuesta4 = 0;
            string buscadorIdPregunta = "", buscadorIdEnunciado = "", buscadorIdOpcion1 = "", buscadorIdOpcion2 = "", buscadorIdOpcion3 = "", buscadorIdOpcion4 = "";
            try
            {
                MySqlCommand buscarIdPregunta = new MySqlCommand("select p.Id as \"IdPregunta\",e.Id as \"IdEnunciado\"  from pregunta p JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN enunciado e ON e.Id = p.Id_Enunciado WHERE p.Descripcion = '" + descripcionPregunta + "';", conexion.getConnection());
                MySqlDataReader idPregunta = buscarIdPregunta.ExecuteReader();
                if (idPregunta.Read())
                {
                    buscadorIdPregunta = idPregunta["IdPregunta"].ToString();
                    buscadorIdEnunciado = idPregunta["IdEnunciado"].ToString();
                }
                conexion.offConnection();
                MySqlCommand eliminarPruebaPreguntas = new MySqlCommand("DELETE FROM `pruebapreguntas` WHERE IdPregunta = '" + Convert.ToInt32(buscadorIdPregunta) + "';", conexion.getConnection());
                retornoPruebaPregunta = eliminarPruebaPreguntas.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand consultaOpcion1 = new MySqlCommand("select o.id from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "');", conexion.getConnection());
                MySqlDataReader leerOpcion1 = consultaOpcion1.ExecuteReader();
                if (leerOpcion1.Read())
                {
                    buscadorIdOpcion1 = leerOpcion1[0].ToString();
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion2 = new MySqlCommand("select o.id from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and o.id != " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                MySqlDataReader leerOpcion2 = consultaOpcion2.ExecuteReader();
                if (leerOpcion2.Read())
                {
                    buscadorIdOpcion2 = leerOpcion2[0].ToString();
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion3 = new MySqlCommand("select o.id from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and o.id != " + Convert.ToInt16(buscadorIdOpcion1) + " and o.id != " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                MySqlDataReader leerOpcion3 = consultaOpcion3.ExecuteReader();
                if (leerOpcion3.Read())
                {
                    buscadorIdOpcion3 = leerOpcion3[0].ToString();
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion4 = new MySqlCommand("select o.id from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and o.id != " + Convert.ToInt16(buscadorIdOpcion1) + " and o.id != " + Convert.ToInt16(buscadorIdOpcion2) + " and o.id != " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                MySqlDataReader leerOpcion4 = consultaOpcion4.ExecuteReader();
                if (leerOpcion4.Read())
                {
                    buscadorIdOpcion4 = leerOpcion4[0].ToString();
                }
                conexion.offConnection();

                MySqlCommand eliminarOpcionCorrecta1 = new MySqlCommand("DELETE FROM `preguntaopciones` WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                retornoRespuestaCorrecta1 = eliminarOpcionCorrecta1.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand eliminarOpcionCorrecta2 = new MySqlCommand("DELETE FROM `preguntaopciones` WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                retornoRespuestaCorrecta2 = eliminarOpcionCorrecta2.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand eliminarOpcionCorrecta3 = new MySqlCommand("DELETE FROM `preguntaopciones` WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                retornoRespuestaCorrecta3 = eliminarOpcionCorrecta3.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand eliminarOpcionCorrecta4 = new MySqlCommand("DELETE FROM `preguntaopciones` WHERE Id_Pregunta = " + Convert.ToInt16(buscadorIdPregunta) + " and Id_Opciones = " + Convert.ToInt16(buscadorIdOpcion4) + ";", conexion.getConnection());
                retornoRespuestaCorrecta4 = eliminarOpcionCorrecta4.ExecuteNonQuery();
                conexion.offConnection();

                MySqlCommand eliminarOpcion1 = new MySqlCommand("DELETE FROM `opciones` WHERE Id = " + Convert.ToInt16(buscadorIdOpcion1) + ";", conexion.getConnection());
                retornoRespuesta1 = eliminarOpcion1.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand eliminarOpcion2 = new MySqlCommand("DELETE FROM `opciones` WHERE Id = " + Convert.ToInt16(buscadorIdOpcion2) + ";", conexion.getConnection());
                retornoRespuesta2 = eliminarOpcion2.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand eliminarOpcion3 = new MySqlCommand("DELETE FROM `opciones` WHERE Id = " + Convert.ToInt16(buscadorIdOpcion3) + ";", conexion.getConnection());
                retornoRespuesta3 = eliminarOpcion3.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand eliminarOpcion4 = new MySqlCommand("DELETE FROM `opciones` WHERE Id = " + Convert.ToInt16(buscadorIdOpcion4) + ";", conexion.getConnection());
                retornoRespuesta4 = eliminarOpcion4.ExecuteNonQuery();
                conexion.offConnection();

                MySqlCommand eliminarPregunta = new MySqlCommand("DELETE FROM `pregunta` WHERE Id = " + Convert.ToInt32(buscadorIdPregunta) + ";", conexion.getConnection());
                retornoPregunta = eliminarPregunta.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand eliminarEnunciado = new MySqlCommand("DELETE FROM `enunciado` WHERE Id = " + Convert.ToInt32(buscadorIdEnunciado) + ";", conexion.getConnection());
                retornoEnunciado = eliminarEnunciado.ExecuteNonQuery();
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
