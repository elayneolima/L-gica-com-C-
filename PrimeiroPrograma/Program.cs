// See https://aka.ms/new-console-template for more information

#region escrevendo dados no console com e sem quebre de linha
using System.Globalization;

Console.WriteLine("Isso é ua string");
Console.Write("Isso é uma string sem quebra de linha");
Console.Write("Isso é uma demo de do texto anterior");
Console.WriteLine();

#endregion

#region escrevendo valor de variaveis no console

double numeroDecimal = 10.9013;
int numeroInteiro = 10;
string nomePessoa = "Lana";
char caractereUnico = 'F';

// ToString converte o valor da variável em sting, quando o metodo WriteLine precisa lidar com formatação

// O metodo cultureInfo é passado no ToString justamente por se tratar de formatação
Console.WriteLine(numeroDecimal);
Console.WriteLine(numeroDecimal.ToString("F2"));
Console.WriteLine(numeroDecimal.ToString("F2", CultureInfo.InvariantCulture));

#endregion

#region concatenando elementos

Console.WriteLine("O peso do bebê é: " + numeroDecimal.ToString(CultureInfo.InvariantCulture) + " ou " + numeroDecimal.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Julia tem " + numeroInteiro + " Anos");
Console.WriteLine(nomePessoa + " é do sexo" + caractereUnico + " (Feminino)");


#endregion

#region casting
double a;
int b;

a = 5.0;
b = (int) a; 
Console.WriteLine(b);
#endregion