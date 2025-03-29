internal class Program
{
    private static void Main(string[] args)
    {
        int meta = 1000, diasDaSemana = 5;
        Console.Write("Digite o numero de horas que voce ira treinar: ");
         double horasPorDia = double.Parse(Console.ReadLine());
         double horasPorSemana = horasPorDia*diasDaSemana;
         if(horasPorDia > 0){
          int dias = (int)(meta / horasPorDia);
          int semanas = (int) (meta / horasPorSemana);
          double meses = (int) (semanas / 4.5);
          Console.WriteLine("faltam "+meses+" meses, "+semanas+" semanas, "+dias+" dias para completar seu treinamento");
        }
        else
        {Console.WriteLine("voce precisa treinar mais");}
    }
}
