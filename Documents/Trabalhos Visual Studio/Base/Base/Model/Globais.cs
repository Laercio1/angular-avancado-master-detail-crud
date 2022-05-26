using System;

namespace Model
{
    public class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "loja";
        public static string caminhoBanco = @"\banco\";
        public static string caminhoFotos = caminho + @"\Fotos\";
    }
}
