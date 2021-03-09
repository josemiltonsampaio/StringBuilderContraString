using System;

namespace StringBuilderContraString
{
    class Program
    {
        static void Main(string[] args)
        {
            const int loops = 100_000;
            DateTime inicio, fim;
            int i;

            string stringFinal = "";
            inicio = DateTime.Now;
            for (i = 0; i < loops; i++)
            {
                stringFinal += i.ToString() + " ";
            }

            fim = DateTime.Now;
            //Console.WriteLine(stringFinal);
            Console.WriteLine("Concatenação de string levou:" + (fim - inicio).TotalSeconds + " segundos.");


            //inicio = DateTime.Now;
            //System.Text.StringBuilder sb = new System.Text.StringBuilder("");
            //for (i = 0; i < loops; i++)
            //{
            //    sb.Append(i.ToString() + " ");
            //}
            //fim = DateTime.Now;

            //Console.WriteLine(sb.ToString());
            //Console.WriteLine("Concatenação com o StringBuilder levou: " + (fim - inicio).TotalSeconds + " segundos.");

        }
    }
}
