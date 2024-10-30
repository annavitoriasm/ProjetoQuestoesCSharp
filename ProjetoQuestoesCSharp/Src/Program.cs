using ProjetoQuestoesCSharp;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

static void menu()
{
    int option = 1;
    while (option != 0)
    {
        Console.Clear();
        Console.WriteLine("\n\t\t\t -- MENU -- \n");
        Console.WriteLine("Para executar uma questão, insira a numeração correspondente...\n");
        Console.WriteLine("(Exemplo: ao digitar '5', irá rodar a 5ª questão)\n");
        Console.WriteLine("\n[0] Sair;\n");
        try
        {
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: 
                    Console.Clear(); 
                    Q1Q2(); 
                    Console.ReadKey(); 
                    break;
                case 2: 
                    Console.Clear(); 
                    Q1Q2(); 
                    Console.ReadKey(); 
                    break;
                case 3: Console.Clear(); 
                    Q3(5, 6);
                    Console.ReadKey(); 
                    break;
                case 4: 
                    Console.Clear(); 
                    Q4(5); 
                    Console.ReadKey(); 
                    break;
                case 5: 
                    Console.Clear(); 
                    Q5(9); 
                    Console.ReadKey(); 
                    break;
                case 6: 
                    Console.Clear(); 
                    Q6(22); 
                    Console.ReadKey(); 
                    break;
                case 7: 
                    Console.Clear(); 
                    Q7(6); Console.ReadKey(); 
                    break;
                case 8: 
                    Console.Clear(); 
                    Q8(6); 
                    Console.ReadKey(); 
                    break;
                case 9: 
                    Console.Clear(); 
                    Q9(10); 
                    Console.ReadKey(); 
                    break;
                case 10: 
                    Console.Clear(); 
                    Q10((float)7.8); 
                    Console.ReadKey(); 
                    break;
                case 11: 
                    Console.Clear(); 
                    Q11(" "); 
                    Console.ReadKey(); 
                    break;
                case 12: 
                    Console.Clear(); 
                    Q12(); 
                    Console.ReadKey(); 
                    break;
                case 13: 
                    Console.Clear(); 
                    Q13(4, 6, 20); 
                    Console.ReadKey(); 
                    break;
                case 14: 
                    Console.Clear(); 
                    Q14("lila"); 
                    Console.ReadKey(); 
                    break;
                case 15: 
                    Console.Clear(); 
                    Q15(16, 03, 2006); 
                    Console.ReadKey();
                    break;
                case 16: 
                    Console.Clear(); 
                    Q16(-88); 
                    Console.ReadKey(); 
                    break;
                case 17: 
                    Console.Clear(); 
                    Q17(4, 9, 5); 
                    Console.ReadKey(); 
                    break;
                case 18: 
                    Console.Clear(); 
                    Q18("aalilaaa"); 
                    Console.ReadKey(); 
                    break;
                case 19: 
                    Console.Clear(); 
                    Q19(); 
                    Console.ReadKey(); 
                    break;
                case 20: 
                    Console.Clear(); 
                    Q20(5); 
                    Console.ReadKey(); 
                    break;
                case 21: 
                    Console.Clear(); 
                    Q21("lilinha", 32); 
                    Console.ReadKey(); 
                    break;
                case 22: 
                    Console.Clear(); 
                    Q22(32); 
                    Console.ReadKey(); 
                    break;
                case 23: 
                    Console.Clear(); 
                    Q23("gab"); 
                    Console.ReadKey(); 
                    break;
                case 24: 
                    Console.Clear(); 
                    Q24(5); 
                    Console.ReadKey(); 
                    break;
                case 25: 
                    Console.Clear(); 
                    Q25(15); 
                    Console.ReadKey(); 
                    break;
                case 26: 
                    Console.Clear(); 
                    Q26(3, 9, 1); 
                    Console.ReadKey(); 
                    break;
                case 27: 
                    Console.Clear(); 
                    Q27(4); 
                    Console.ReadKey(); 
                    break;
                case 28: 
                    Console.Clear(); 
                    Q28(); 
                    Console.ReadKey(); 
                    break;
                case 29: 
                    Console.Clear(); 
                    Q29(new List<double> { 9, 8, 9 }); 
                    Console.ReadKey(); 
                    break;
                case 30: 
                    Console.Clear(); 
                    Q30("anna"); 
                    Console.ReadKey(); 
                    break;
                case 31:
                    int[] ar = { 3, 9, 4, 99, 77 };
                    Console.Clear(); Q31(ar);
                    Console.ReadKey(); break;
                case 32:
                    int[] ar32 = { 3, 9, 4, 99, 77 };
                    Console.Clear(); Q32(ar32, 5);
                    Console.ReadKey(); break;
                case 33:
                    int[] ar33 = { 3, 9, 4, 99, 77 };
                    Console.Clear(); 
                    Q33(ar33);
                    Console.ReadKey(); break;
                case 34: 
                    Console.Clear(); 
                    Q34(); 
                    Console.ReadKey(); 
                    break;
                case 35: 
                    Console.Clear(); 
                    Q35(2006); 
                    Console.ReadKey(); 
                    break;
                case 36:
                    int q = 9;
                    Console.Clear(); Q36(q);
                    Console.ReadKey(); break;
                case 37:
                    string f = "Anna Vitoria da Silva Martins";
                    Console.Clear(); Q37(f);
                    Console.ReadKey(); break;
                case 38:
                    int[] ar38 = { 5, 3, 8, 4, 2 };
                    Console.Clear(); Q38(ar38); Console.ReadKey(); break;
                case 39:
                    int numb1 = 9;
                    int numb2 = 5;
                    Console.Clear(); Q39(numb1, numb2);
                    Console.ReadKey(); break;
                case 40:
                    string xab = "xablau";
                    Console.Clear(); Q40(xab);
                    Console.ReadKey(); break;
                case 41:
                    int dec = 50;
                    Console.Clear(); Q41(dec);
                    Console.ReadKey(); break;
                case 42: 
                    Console.Clear(); 
                    Q42(10); 
                    Console.ReadKey(); 
                    break;
                case 43: 
                    Console.Clear(); 
                    Q43(3); 
                    Console.ReadKey(); 
                    break;
                case 44: 
                    Console.Clear(); 
                    Q44(67, 1.70); 
                    Console.ReadKey(); 
                    break;
                case 45:
                    Console.Clear(); 
                    Q45(new int[] { 3, 7, 8, 10, 22 });
                    Console.ReadKey(); 
                    break;
                case 46:
                    Console.Clear(); Q46(new int[] { 3, 7, 8, 10, 22 });
                    Console.ReadKey(); 
                    break;
                case 47:
                    Console.Clear();
                    int[,] m1 = { { 7, 3 }, { 3, 8 } };
                    int[,] m2 = { { 1, 0 }, { 2, 5 } };
                    Q47(m1, m2);
                    Console.ReadKey(); 
                    break;
                case 48: 
                    Console.Clear(); 
                    Q48(); 
                    Console.ReadKey(); 
                    break;
                case 49: 
                    Console.Clear(); 
                    Q49("Lila"); 
                    Console.ReadKey(); 
                    break;
                case 50: 
                    Console.Clear(); 
                    Q50(3, 2); 
                    Console.ReadKey(); 
                    break;
                case 51:
                    Console.Clear();
                    int[,] symmMatrix = { { 7, -3, 4 }, { -3, 8, 2 }, { 4, 2, 5 } };
                    int[,] nonsymmMatrix = { { 1, 0, 3 }, { 2, 5, 6 }, { 7, 8, 4 } };
                    Q51(symmMatrix);
                    Q51(nonsymmMatrix);
                    Console.ReadKey(); break;
                case 52:
                    Console.Clear();
                    List<string> l = new List<string> { "Victor", "Lila", "Gab", "Icaro", "Witallo", "Anna" };
                    Q52(l);
                    Console.ReadKey(); 
                    break;
                case 53:
                    Console.Clear();
                    int[] arrayF = { 6, 9, 2, 3, 6, 3, 6, 6, 1 };
                    Q53(arrayF);
                    Console.ReadKey(); 
                    break;
                case 54:
                    Console.Clear(); 
                    Q54(-10);
                    Console.ReadKey(); 
                    break;
                case 55:
                    Console.Clear();
                    int[] arrayL = { 6, 9, 8, 4, 3, 1 };
                    Q55(arrayL, 1);
                    Console.ReadKey(); 
                    break;
                case 56:
                    Console.Clear(); 
                    Q56();
                    Console.ReadKey(); 
                    break;
                case 57:
                    Console.Clear(); 
                    Q57("Hello World");
                    Console.ReadKey(); 
                    break;
                case 58:
                    Console.Clear(); 
                    Q58();
                    Console.ReadKey(); 
                    break;
                case 59:
                    Console.Clear();
                    int[] array1 = { 1, 2, 3, 4, 5 };
                    int[] array2 = { 4, 5, 6, 7, 8 };
                    Q59(array1, array2);
                    Console.ReadKey(); 
                    break;
                case 60:
                    Console.Clear(); 
                    Q60("LilaBacana");
                    Console.ReadKey(); 
                    break;
                case 61:
                    Console.Clear();
                    Q61("Hello Word");
                    Console.ReadKey();
                    break;
                case 62:
                    Console.Clear();
                    Q62(8);
                    Console.ReadKey();
                    break;
                case 63:
                    Console.Clear();
                    Q63(9);
                    Console.ReadKey();
                    break;
                case 64:
                    Console.Clear();
                    Q64(9);
                    Console.ReadKey();
                    break;
                case 65:
                    Console.Clear();
                    Q65();
                    Console.ReadKey();
                    break;
                case 66:
                    Console.Clear();
                    Q66();
                    Console.ReadKey();
                    break;
                case 67:
                    Console.Clear();
                    Q67();
                    Console.ReadKey();
                    break;
                case 68:
                    Console.Clear();
                    Q68(33);
                    Console.ReadKey();
                    break;
                case 69:
                    Console.Clear();
                    Q69(50);
                    Console.ReadKey();
                    break;
                case 70:
                    Console.Clear();
                    Caixa();
                    Console.ReadKey();
                    break;
                case 71:
                    Console.Clear();
                    Q71(4);
                    Console.ReadKey();
                    break;
                case 72:
                    Console.Clear();
                    Q72(10);
                    Console.ReadKey();
                    break;
                case 73:
                    Console.Clear();
                    Q73();
                    Console.ReadKey();
                    break;
                case 74:
                    Console.Clear();
                    Q74(10,12,8);
                    Console.ReadKey();
                    break;
                case 75:
                    Console.Clear();
                    Q75(5);
                    Console.ReadKey();
                    break;
                case 76:
                    Console.Clear();
                    Q76();
                    Console.ReadKey();
                    break;
                case 77:
                    Console.Clear();
                    Q77(new[] { 999, 99, 7, 28, 10, 4 }, new[] { 10, 7, 999, 4, 99, 28 });
                    Console.ReadKey();
                    break;
                case 78:
                    Console.Clear();
                    Q78.QueueService();

                    for (int i = 0; i < 3; i++)
                    {
                        string attendedPerson = Q78.Dequeue();
                        if (attendedPerson != null)
                        {
                            Console.WriteLine($"Atendendo: {attendedPerson}");
                            Console.WriteLine("Pessoas restantes na fila:");
                            foreach (var person in Q78.queue)
                            {
                                Console.WriteLine(person);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    Console.Write("Todas as pessoas foram atendidas.");
                    Console.ReadKey();
                    break;
                case 79:
                    Console.Clear();
                    Q79.RockPaperScissors();
                    Console.ReadKey();
                    break;
                case 80:
                    Console.Clear();
                    Q80.GetInput();
                    Console.ReadKey();
                    break;
                case 81:
                    Console.Clear();
                    Q81.AddNums();
                    Q81.PrintEvenNums();
                    Console.ReadKey();
                    break;
                case 82:
                    Console.Clear();
                    Q82.ShowResults();
                    Console.ReadKey();
                    break;
                case 83:
                    Console.Clear();
                    Q83.ShowNames();
                    Console.ReadKey();
                    break;
                case 84:
                    Console.Clear();
                    Q84.Palindrome();
                    Console.ReadKey();
                    break;
                case 85:
                    Console.Clear();
                    Q85.ShowResults();
                    Console.ReadKey();
                    break;
                case 86:
                    Console.Clear();
                    ContaBancaria conta1 = new("56789-1", "Lila", 1000);
                    conta1.ExibirMenu();
                    break;
                case 87:
                    Console.Clear();
                    Funcionario Lila = new("Lila", 1000);
                    Lila.ExibirSalarioLiquido();
                    Console.ReadKey();
                    break;
                case 88:
                    Console.Clear();
                    Q88.DecimalToBinary();
                    Console.ReadKey();
                    break;
                case 89:
                    Console.Clear();
                    Q89.AverageGrades();
                    Console.ReadKey();
                    break;
                case 90:
                    Console.Clear();
                    Q90.SumElementsMatrix();
                    Console.ReadKey();
                    break;
                case 91:
                    Console.Clear();
                    Q91.Election("Lila", "Icaro", "Witallo");
                    Console.ReadKey();
                    break;
                case 92:
                    Console.Clear();
                    Q92.GetInput();
                    Console.ReadKey();
                    break;
                case 93:
                    Console.Clear();
                    Q93.GetInput();
                    Console.ReadKey();
                    break;
                case 94:
                    Console.Clear();
                    Q94.GenerateNums(5);
                    Console.ReadKey();
                    break;
                case 95:
                    Console.Clear();
                    AgendaContatos.Menu();
                    break;
                case 96:
                    Console.Clear();
                    Q96.GetPrimes();
                    Console.ReadKey();
                    break;
                case 97:
                    Console.Clear();
                    Q97.MultiTable();
                    Console.ReadKey();
                    break;
                case 98:
                    Console.Clear();
                    int[,] matrix = {
                { 3, 8, 2 },
                { 55, 1, 7 },
                { 4, 6, 9 }
                };
                    Q98.FindBiggest(matrix);
                    Console.ReadKey();
                    break;
                case 99:
                    Console.Clear();
                    Q99.PrintSquares1toN(Q99.GetInput());
                    Console.ReadKey();
                    break;
                case 100:
                    Console.Clear();
                    Q100.Menu();
                    Console.ReadKey();
                    break;
                case 0:
                    break;
                default: Console.WriteLine("Opção Inválida."); Console.ReadKey(); break;
            }
        }
        catch (Exception erro)
        {
            Console.Clear();
            Console.WriteLine("\nOpção inválida! Tente novamente... " + erro.Message + "\n-- Press enter.");
            Console.ReadKey();
        }
    }
}
menu();

static void Q1Q2()
{
    product prod = new product("Biscoito", 5.99f);
    Console.WriteLine($"Produto: {prod.Name} - R${prod.Price}.\n");
}

static void Q3(int a, int b)
{
    int sum = a + b;
    Console.WriteLine($"A soma é: {sum}\n");
}

static void Q4(int n)
{
    if (n % 2 == 0)
    {
        Console.WriteLine($"O número {n} é par\n");
    }
    else
    {
        Console.WriteLine($"O número {n} é ímpar\n");
    }
}

static void Q5(int m)
{
    int cm = m * 100;
    Console.WriteLine($"{m}M são {cm}cm\n");
}

static void Q6(int age)
{
    if (age >= 18)
    {
        Console.WriteLine($"A idade {age} é maioridade\n");
    }
    else
    {
        Console.WriteLine($"A idade {age} é menoridade\n");
    }
}

static void Q7(int r)
{
    float pi = 3.14f;
    var area = pi * (r * r);
    Console.WriteLine($"Tendo em vista o raio {r}, a area do circulo é {area}\n");
}

static void Q8(int n)
{
    Console.WriteLine($"[TABELA MULTIP.]\n");
    for (global::System.Int32 i = 0; i < 11; i++)
    {
        int multip = n * i;
        Console.WriteLine($"{n} X {i} = {multip}\n");
    }
}

static void Q9(int N)
{
    Console.WriteLine($"[TABELA SOMA.]\n");
    for (global::System.Int32 i = 1; i < N + 1; i++)
    {
        int sumN = i + N;
        Console.WriteLine($"{i} + {N} = {sumN}\n");
    }
}
 
static void Q10(float C)
{
    float F = C * 1.8f + 32f;
    Console.WriteLine($"{C} celsius são {F} fahrenheit.\n");
}

static void Q11(string s)
{
    if (string.IsNullOrEmpty(s.Trim()))
    {
        Console.WriteLine($"a string é vazia.\n");
    }
    else
    {
        Console.WriteLine($"a string não é vazia.\n");
    }
}
 
static void Q12()
{
    for (global::System.Int32 i = 1; i < 51; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i}");
        }
    }
} 
static void Q13(int a, int b, int c)
{
    var bigger = Math.Max(a, Math.Max(b, c));
    Console.WriteLine($"\nO maior número é: {bigger}\n");
} 
static void Q14(string s)
{
    char[] cArray = s.ToCharArray();
    Array.Reverse(cArray);
    string invertedString = new string(cArray);
    Console.WriteLine($"String invertida: {invertedString}\n");
}

static void Q15(int day, int month, int year)
{
    if (year < 2007 && month < 11)
    {
        Console.WriteLine($"Nacido em: {year} - Apto para votar\n");
    }
    else
    {
        Console.WriteLine($"Nacido em: {month} - Inapto para votar\n");
    }
}
 
static void Q16(double numb)
{
    if (numb < 0)
    {
        Console.WriteLine($"[{numb}] -> negativo\n");
    }
    else
    {
        Console.WriteLine($"[{numb}] -> positivo\n");
    }
}

static void Q17(int sco1, int sco2, int sco3)
{
    int media = (sco1 + sco2 + sco3) / 3;
    if (media < 7)
    {
        Console.WriteLine($"média final: {media} -> reprovado\n");
    }
    else
    {
        Console.WriteLine($"média final: {media} -> aprovado\n");
    }
}
  
static void Q18(string s)
{
    int count = 0;

    foreach (char c in s.ToLower())
    {
        if (c == 'a')
        {
            count++;
        }
    }
    Console.WriteLine($"a palavra {s} possui {count} de 'a'\n");
}
  
static void Q19()
{
    for (int i = 10; i >= 1; i--)
    {
        Console.Clear();
        Console.Write(i);
        Thread.Sleep(900);
    }

    Console.Clear();
    Console.Write("Contagem finalizada!");
}
 
static void Q20(int N)
{
    int sum = 0;
    for (int i = 1; i <= N; i++)
    {
        sum += i * i;
    }
    Console.WriteLine($"\nsoma dos quadrados de 1 até {N} = {sum}\n");
}
 
static void Q21(string name, int age)
{
    Console.WriteLine($"Seja bem-vindo(a), {name} de {age} anos!\n");
}
 
static void Q22(int numb)
{
    double doub = numb * 2;
    double triple = numb * 3;
    Console.WriteLine($"{numb} -> dobro: {doub} // triplo: {triple}\n");
}
  
static void Q23(string s)
{
    var last = s[s.Length - 1];
    Console.WriteLine($"ultimo caractere de {s} é {last}\n");
}

static void Q24(int hours)
{
    int converter = hours * 3600;
    Console.WriteLine($"{hours} horas são {converter} segundos\n");
}
 
static void Q25(int numb)
{
    if (numb % 3 == 0 && numb % 5 == 0)
    {
        Console.WriteLine($"{numb} é divisivel por 3 e 5!\n");
    }
    else
    {
        Console.WriteLine($"{numb} NÃO é divisivel por 3 e 5!\n");
    }

}
 
static void Q26(int n1, int n2, int n3)
{
    int menor, medio, maior;

    if (n1 <= n2 && n1 <= n3)
    {
        menor = n1;
        if (n2 <= n3)
        {
            medio = n2;
            maior = n3;
        }
        else
        {
            medio = n3;
            maior = n2;
        }
    }
    else if (n2 <= n1 && n2 <= n3)
    {
        menor = n2;
        if (n1 <= n3)
        {
            medio = n1;
            maior = n3;
        }
        else
        {
            medio = n3;
            maior = n1;
        }
    }
    else
    {
        menor = n3;
        if (n1 <= n2)
        {
            medio = n1;
            maior = n2;
        }
        else
        {
            medio = n2;
            maior = n1;
        }
    }
    Console.WriteLine($"Números em ordem crescente: {menor}, {medio}, {maior}\n");
}
  
static void Q27(int numb)
{
    int fatorial = 1;
    for (global::System.Int32 i = numb; i > 0; i--)
    {
        fatorial *= i;
    }
    Console.WriteLine($"fatorial de {numb} = {fatorial}\n");
}

static void Q28()
{
    Aluno aluno = new Aluno("Lila", 8.6f);
    Console.WriteLine($"Nome aluno: {aluno.Name} - Nota: {aluno.Grade}.\n");
}

static void Q29(List<double> numb)
{
    List<double> list = new List<double> { 9, 8, 9 };
    double sum = numb.Sum();
    double avarage = sum / numb.Count;
    Console.WriteLine($"a média da lista é: {avarage:F2}\n");

}

static void Q30(string s)
{
    s = s.ToLower();

    int start = 0;
    int end = s.Length - 1;
    bool isPalindromo = true;

    while (start < end)
    {
        if (s[start] != s[end])
        {
            isPalindromo = false;
            break;
        }
        start++;
        end--;
    }
    if (isPalindromo)
    {
        Console.WriteLine($"{s} é palíndromo\n");
    }
    else
    {
        Console.WriteLine($"{s} não é palíndromo\n");
    }
}

static void Q31(int[] array)
{
    int smallest = array[0];

    foreach (int number in array)
    {
        if (number < smallest)
        {
            smallest = number;
        }
    }
    Console.WriteLine($"O menor número de [{string.Join(", ", array)}] é {smallest}\n");
}

static void Q32(int[] array, int numb)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * numb;
    }

    Console.WriteLine($"Array: [{string.Join(", ", array)}] // Array após multiplicar por {numb}: [{string.Join(", ", newArray)}]\n");
}

static void Q33(int[] array)
{
    int sum = 0;

    foreach (int number in array)
    {
        if (number % 2 != 0)
        {
            sum += number;
        }
    }
    Console.WriteLine($"Soma dos números ímpares: {sum}\n");
}

static void Q34()
{
    Carro carro = new Carro("Celtinha", "Chevrolet", 2003);
    Console.WriteLine($"Carro: {carro.Name} - marca: {carro.Label} - ano: {carro.Year}\n");
}

static void Q35(int year)
{

    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"{year} é bissexto\n");
    }
    else
    {
        Console.WriteLine($"{year} não é bissexto\n");
    }

}

static void Q36(int qtd)
{
    int aux = 1, aux2 = 1, next;

    if (qtd == 0)
    {
        Console.WriteLine("A quantidade de termos deve ser maior que 0.\n");
        Console.ReadKey();
        Console.Clear();
        return;
    }
    Console.Clear();

    Console.Write($"A sequência de Fibonacci equivalente ao termo {qtd} é: {aux}\n");

    for (int i = 2; i < qtd + 1; i++)
    {
        next = aux + aux2;
        aux = aux2;
        aux2 = next;
        Console.Write($", {aux}\n");
    }
}

static void Q37(string s)
{
    s = s.Replace(" ", "_");
    Console.Clear();
    Console.WriteLine($"{s}\n");
}

static void Q38(int[] nums)
{
    int biggest = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > nums[biggest])
        {
            biggest = i;
        }
    }

    Console.WriteLine($"{biggest}\n");
}

static void Q39(int num1, int num2)
{
    while (num1 != num2)
    {
        if (num1 > num2)
        {
            num1 -= num2;
        }
        else
        {
            num2 -= num1;
        }
    }

    Console.Write($"MDC: {num1}\n");
}

static void Q40(string toshow)
{
    string tocheck = toshow.ToLower();

    int count = 0;
    foreach (char c in tocheck)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            count++;
        }
    }
    Console.Clear();
    Console.Write($"A string '{toshow}' contém {count} vogais\n");
}

static void Q41(int num)
{
    Console.Write($"O número {num} em binário é: {Convert.ToString(num, 2)}\n");
}

static void Q42(int num)
{
    char letra = (char)('A' + num - 1);
    Console.Write($"O número {num} em caractere é: {letra}\n");
}

static void Q43(int qty)
{
    Random random = new();
    int num = random.Next(1, 7);

    int[] frequency = new int[6];

    for (int i = 0; i < 1000; i++)
    {
        num = random.Next(1, 7);
        frequency[num - 1]++;
    }

    Console.Clear();
    Console.WriteLine($"Resultados após {qty} lançamentos:");
    for (int i = 0; i < frequency.Length; i++)
    {
        Console.WriteLine($"Lado {i + 1}: {frequency[i]} vezes\n");
    }
}

static void Q44(double Weight, double Height)
{
    double imc = Weight / Math.Pow(Height, 2);

    var classifyIMC = new Dictionary<string, (double Min, double Max)>
        {
            { "Abaixo do peso", (0.0, 18.5) },
            { "Peso normal", (18.51, 24.9) },
            { "Sobrepeso", (25.0, 29.9) },
            { "Obesidade Grau I", (30.0, 34.9) },
            { "Obesidade Grau II", (35.0, 39.9) },
            { "Obesidade Grau III", (40.0, double.MaxValue) }
        };

    string classification = "";
    foreach (var item in classifyIMC)
    {
        if (imc >= item.Value.Min && imc <= item.Value.Max)
        {
            classification = item.Key;
            break;
        }
    }

    Console.WriteLine($"\nIMC: {imc:F2}\n");
    Console.WriteLine($"Classificação: {classification}\n");
}

static void Q45(int[] nums)
{
    int biggest = int.MinValue;
    int second = int.MinValue;

    foreach (int num in nums)
    {
        if (num > biggest)
        {
            second = biggest;
            biggest = num;
        }
        else if (num > second && num != biggest)
        {
            second = num;
        }
    }

    Console.WriteLine($"O segundo maior número é: {second}\n");
}

static void Q46(int[] nums)
{
    int[] Before = (int[])nums.Clone();
    Array.Reverse(nums);

    Console.WriteLine($"Array antes da inversão: {string.Join(", ", Before)}");
    Console.WriteLine($"Array depois da inversão: {string.Join(", ", nums)}");
}

static void Q47(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(0) != 2 || matrixA.GetLength(1) != 2 || matrixB.GetLength(0) != 2 || matrixB.GetLength(1) != 2)
    {
        Console.WriteLine("Ambas as matrizes devem ser 2x2!\n");
        return;
    }

    int[,] result = new int[2, 2];

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            result[i, j] = matrixA[i, j] + matrixB[i, j];
        }
    }

    Console.WriteLine("\nMatriz resultante:");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($"{result[i, j],4} ");
        }
        Console.WriteLine();
    }
}

static void Q48()
{
    Console.Write("Digite uma data (formato: dd/MM/yyyy): \n");
    string input = Console.ReadLine();
    Console.Clear();

    if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime data))
    {
        var daysOfWeek = new Dictionary<DayOfWeek, string>
            {
                { DayOfWeek.Sunday, "Domingo" },
                { DayOfWeek.Monday, "Segunda-feira" },
                { DayOfWeek.Tuesday, "Terça-feira" },
                { DayOfWeek.Wednesday, "Quarta-feira" },
                { DayOfWeek.Thursday, "Quinta-feira" },
                { DayOfWeek.Friday, "Sexta-feira" },
                { DayOfWeek.Saturday, "Sábado" }
            };

        string dayInPTBR = daysOfWeek[data.DayOfWeek];
        Console.WriteLine($"Dia da semana: {dayInPTBR}\n");
    }
    else
    {
        Console.WriteLine("Data inválida. Por favor, utilize o formato dd/MM/yyyy.\n");
    }
}

static void Q49(string input)
{
    bool OnlyLettersOrNums(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetterOrDigit(c) && c != ' ')
            {
                return false;
            }
        }
        return true;
    }

    var message = OnlyLettersOrNums(input) ? "\nA string contém apenas letras ou números\n" : "\nA string contém outros tipos de caracteres\n";

    Console.WriteLine(message);
}

static void Q50(double numb, int exponent)
{
    double result = 1;

    for (int i = 0; i < exponent; i++)
    {
        result *= numb;
    }
    Console.WriteLine($"Potência de {numb} elevado a {exponent} é {result}\n");
}

static void Q51(int[,] m)
{
    int rows = m.GetLength(0);
    int cols = m.GetLength(1);

    if (rows != cols)
    {
        Console.WriteLine("A matriz não é simétrica\n");
        return;
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = i + 1; j < cols; j++)
        {
            if (m[i, j] != m[j, i])
            {
                Console.WriteLine("A matriz não é simétrica\n");
                return;
            }
        }
    }

    Console.WriteLine("A matriz é simétrica\n");
}

static void Q52(List<string> list)
{
    list.Sort();
    Console.WriteLine("[Lista em ordem alfabetica:]");
    foreach (var name in list)
    {
        Console.WriteLine(name);
    }
}

static void Q53(int[] array)
{
    Dictionary<int, int> frequency = new Dictionary<int, int>();
    int count = 0;
    int e = array[0];

    foreach (var num in array)
    {
        if (frequency.ContainsKey(num))
        {
            frequency[num]++;
        }
        else
        {
            frequency[num] = 1;
        }

        if (frequency[num] > count)
        {
            count = frequency[num];
            e = num;
        }
    }

    Console.WriteLine($"\nO elemento mais frequente é: {e}.\n");
}

static void Q54(double numb)
{
    double value = (numb < 0) ? -numb : numb;
    Console.WriteLine($"O valor absoluto de {numb} é: {value}\n");
}

static void Q55(int[] array, int e)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == e)
        {
            Console.WriteLine($"Elemento {e} encontrado no índice {i}.\n");
            return;
        }
    }
    Console.WriteLine($"Elemento {e} não encontrado no array.\n");
}

static void Q56()
{
    Console.WriteLine("[Cronômetro iniciado. Aperte qualquer tecla para parar!]");

    int seconds = 0;
    while (!Console.KeyAvailable)
    {
        Console.Clear();
        Console.WriteLine($"Cronômetro: {seconds}s");
        Thread.Sleep(800);
        seconds++;
    }

    Console.ReadKey(true);
    Console.WriteLine($"Cronômetro marcou {seconds}s.");
}

static void Q57(string s)
{
    string[] words = s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    int wordCount = words.Length;

    Console.WriteLine($"Numero de palavras na frase {s}: {wordCount}\n");
}

static void Q58()
{
    Console.WriteLine($"Escreva uma mensagem:\n");
    string m = Console.ReadLine();
    Pessoa pessoa = new Pessoa(m);
    Console.WriteLine($"Mensagem: {pessoa.Talk}\n");
}

static void Q59(int[] array1, int[] array2)
{
    HashSet<int> set = new HashSet<int>(array1);
    List<int> intersection = new List<int>();

    foreach (int num in array2)
    {
        if (set.Contains(num))
        {
            intersection.Add(num);
        }
    }

    Console.WriteLine("Interseção entre os arrays: " + string.Join(", ", intersection));
}

static void Q60(string input)
{
    char[] cArr = input.ToCharArray();

    for (int i = 0; i < cArr.Length; i++)
    {
        if (i % 2 == 0)
        {
            cArr[i] = char.ToUpper(cArr[i]);
        }
        else
        {
            cArr[i] = char.ToLower(cArr[i]);
        }
    }

    string result = new string(cArr);
    Console.WriteLine($"\n{result}\n");
}

static void Q61(string palavra61)
{
    HashSet<char> caracteresUnicos = new HashSet<char>();

    foreach (char charUni in palavra61)
    {
        caracteresUnicos.Add(charUni);
    }

    Console.WriteLine($"Número de caracteres únicos: {caracteresUnicos.Count}");
}

static void Q62(int limite)
{
    for (int num = 2; num <= limite; num++)
    {
        bool Primo = true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                Primo = false;
                break;
            }
        }
        if (Primo)
        {
            Console.WriteLine(num);
        }
    }
}

static void Q63(int num63)
{
    int soma = 0;

    for (int i = 1; i < num63; i++)
    {
        if (num63 % i == 0)
        {
            soma += i;
        }
    }

    if (soma == num63)
    {
        Console.WriteLine($"{num63} é um número perfeito!");
    }
    else
    {
        Console.WriteLine($"{num63} não é um número perfeito!");
    }
}
static void Q64(int num64)
{
    Console.WriteLine($"Divisores de {num64}:\n");

    for (int i = 1; i <= num64; i++)
    {
        if (num64 % i == 0)
        {
            Console.WriteLine(i);
        }
    }
}
static void Q65()
{
    int[,] matriz = {
        {11, 12, 13},
        {14, 15, 16},
        {17, 18, 19}
    };

    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);
    int[,] transposta = new int[colunas, linhas];

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            transposta[j, i] = matriz[i, j];
        }
    }

    Console.WriteLine("Matriz transposta:");
    for (int i = 0; i < colunas; i++)
    {
        for (int j = 0; j < linhas; j++)
        {
            Console.Write($"{transposta[i, j]} ");
        }
        Console.WriteLine();
    }
}

static void Q66()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Horário atual: \n");
        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        Console.WriteLine("\n{0} - Sair");

        if (Console.KeyAvailable)
        {
            if (int.TryParse(Console.ReadLine(), out int numero) && numero == 0)
            {
                break;
            }
        }
        Thread.Sleep(1000);
    }
}
static void Q67()
{
    int num67;
    int nume67;
    int op = -1;

    while (op != 0)
    {
        Console.Clear();
        Console.WriteLine("Calculadora\n");
        Console.WriteLine("{1} - Soma");
        Console.WriteLine("{2} - Subtração");
        Console.WriteLine("{3} - Multiplicação");
        Console.WriteLine("{4} - Divisão");
        Console.WriteLine("{0} - Sair");
        op = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (op)
        {
            case 1:
                Console.WriteLine("Digite o primeiro número para somar: ");
                num67 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite o segundo número para somar: ");
                nume67 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"O resultado da soma é: {num67 + nume67}");
                Console.ReadKey();
                break;

            case 2:
                Console.WriteLine("Digite o primeiro número para subtrair: ");
                num67 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite o segundo número para subtrair: ");
                nume67 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"O resultado da subtração é: {num67 - nume67}");
                Console.ReadKey();
                break;

            case 3:
                Console.WriteLine("Digite o primeiro número para multiplicar: ");
                num67 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite o segundo número para multiplicar: ");
                nume67 = int.Parse(Console.ReadLine());
                Console.Clear();

                if (nume67 == 0)
                {
                    Console.WriteLine("O resultado da multiplicação é: 0");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"O resultado da multiplicação é: {num67 * nume67}");
                    Console.ReadKey();
                }
                break;

            case 4:
                Console.WriteLine("Digite o primeiro número para dividir: ");
                num67 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite o segundo número para dividir: ");
                nume67 = int.Parse(Console.ReadLine());
                Console.Clear();

                if (nume67 == 0)
                {
                    Console.WriteLine("Não é possível dividir por 0!");
                    Console.ReadKey();
                }
                else
                {
                    double divisao1 = (double)num67;
                    double divisao2 = (double)nume67;
                    double resultado = divisao1 / divisao2;
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                    Console.ReadKey();
                }
                break;

            case 0:
                break;
        }
    }
}
static void Q68(double valor)
{
    int num68 = (int)valor;

    string[] unid = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
    string[] deze = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
    string[] espec = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
    string extenso = "";

    if (num68 < 10)
    {
        extenso = unid[num68];
    }
    else if (num68 < 20)
    {
        extenso = espec[num68 - 10];
    }
    else if (num68 < 100)
    {
        extenso = deze[num68 / 10];
        if (num68 % 10 > 0)
        {
            extenso += " e " + unid[num68 % 10];
        }
    }
    else if (num68 < 1000)
    {
        extenso = unid[num68 / 100] + " centena";
        int resto = num68 % 100;
        if (resto > 0)
        {
            extenso += " e " + resto;
        }
    }
    else if (num68 == 1000)
    {
        extenso = "mil";
    }

    Console.WriteLine($"Valor por extenso: {extenso}");
}

static void Q69(double dinheiro)
{
    int valorInteiro = (int)dinheiro;
    int centavos = (int)Math.Round((dinheiro - valorInteiro) * 100);

    string extenso = valorInteiro + " reais";
    if (centavos > 0)
    {
        extenso += " e " + centavos + " centavos";
    }

    Console.WriteLine(extenso);
}
static void Caixa()
{
    Console.WriteLine("Bem-vindo ao Caixa");
    Console.Write("Digite o valor do depósito: ");
    int depositado = int.Parse(Console.ReadLine());
    Console.Clear();

    Console.Write("Digite o valor do saque: ");
    int saque = int.Parse(Console.ReadLine());
    Console.Clear();

    if (saque > depositado)
    {
        Console.WriteLine("Não é possível sacar o valor solicitado, o valor depositado é inferior ao saque.");
        Console.ReadKey();
    }
    else
    {
        int[] notas = { 100, 50, 20, 10, 5, 2 };
        int[] quantNotas = new int[notas.Length];

        for (int i = 0; i < notas.Length; i++)
        {
            if (saque >= notas[i])
            {
                quantNotas[i] = saque / notas[i];
                saque %= notas[i];
            }
        }

        Console.WriteLine("Distribuição de notas:");
        for (int i = 0; i < notas.Length; i++)
        {
            if (quantNotas[i] > 0)
            {
                Console.WriteLine($"{quantNotas[i]} nota(s) de R$ {notas[i]}");
            }
        }
        Console.ReadKey();
    }
}

static void Q71(int n)
{
    Console.WriteLine("Quantos itens terá no primeiro array?");
    int tam1 = n;
    int[] array1 = new int[tam1];
    Console.Clear();

    for (int i = 0; i < tam1; i++)
    {
        Console.Write($"Digite o elemento {i + 1} do primeiro array: ");
        array1[i] = int.Parse(Console.ReadLine());
    }
    Console.Clear();

    Console.WriteLine("Quantos itens terá no segundo array?");
    int tam2 = int.Parse(Console.ReadLine());
    int[] array2 = new int[tam2];
    Console.Clear();

    for (int i = 0; i < tam2; i++)
    {
        Console.Write($"Digite o elemento {i + 1} do segundo array: ");
        array2[i] = int.Parse(Console.ReadLine());
    }
    Console.Clear();

    bool comparar = Comparar_Arrays(array1, array2);
    Console.WriteLine($"Os arrays são iguais? {comparar}");
}

static bool Comparar_Arrays(int[] array1, int[] array2)
{
    if (array1.Length != array2.Length)
    {
        return false;
    }

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            return false;
        }
    }

    return true;
}

static void Q72(int tam)
{
    const string charac = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    StringBuilder senha = new StringBuilder();
    Random aleatoria = new Random();

    for (int i = 0; i < tam; i++)
    {
        int index = aleatoria.Next(charac.Length);
        senha.Append(charac[index]);
    }

    Console.Clear();
    Console.WriteLine($"Senha aleatória: {senha.ToString()}");
    Console.ReadKey();
}

static void Q73()
{
    Console.WriteLine("Digite o número de tabelas de multiplicação:");
    int tam = int.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Digite o número de multiplicações por tabela:");
    int tam2 = int.Parse(Console.ReadLine());
    Console.Clear();

    for (int i = 1; i <= tam; i += 1)
    {
        Console.WriteLine($"Tabela de multiplicação de {i}:");

        for (int index = 1; index <= tam2; index += 1)
        {
            Console.Write($"{i * index}\n");
        }
        Console.ReadKey();
        Console.Clear();
    }
}
static double Q74(double lado1, double lado2, double lado3)
{
    double perimetro = (lado1 + lado2 + lado3) / 2;
    double area = Math.Sqrt(perimetro * (perimetro - lado3) * (perimetro - lado3) * (perimetro - lado3));
    return area;
}

static List<int> Q75(int num)
{
    List<int> numeros = new List<int>();
    Random aleatorio = new Random();

    while (numeros.Count < num)
    {
        int numero = aleatorio.Next(1, num + 1);
        if (!numeros.Contains(numero))
        {
            numeros.Add(numero);
        }
    }

    return numeros;
}

static void Q76()
{
    Console.Write("Advinhe o número (entre 1 e 100): ");
    int guess = 0;
    Random random = new();
    int number = random.Next(1, 101);

    while (guess != number)
    {
        guess = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (guess > number)
        {
            if (guess - 30 > number)
            {
                Console.Clear();
                Console.Write("O palpite é muito alto. Tente novamente: ");
            }
            else
            {
                Console.Clear();
                Console.Write("O palpite é alto. Tente novamente: ");
            }
        }

        if (guess < number)
        {
            if (guess + 30 < number)
            {
                Console.Clear();
                Console.Write("O palpite é muito baixo. Tente novamente: ");
            }
            else
            {
                Console.Clear();
                Console.Write("O palpite é baixo. Tente novamente: ");
            }
        }
    }

    Console.WriteLine($"Parabéns! O número era {number}!");
}
static void Q77(int[] nums1, int[] nums2)
{
    if (nums1.Length != nums2.Length)
    {
        Console.WriteLine("Os arrays possuem tamanhos diferentes!");
        return;
    }

    Array.Sort(nums1);
    Array.Sort(nums2);

    for (int i = 0; i < nums1.Length; i++)
    {
        if (nums1[i] != nums2[i])
        {
            Console.WriteLine("Os arrays possuem valores diferentes!");
            return;
        }
    }

    Console.WriteLine("Os arrays possuem valores iguais!");
}

public class Q78()
{
    public static List<string> queue = new();

    public static void QueueService()
    {
        queue.Add("Joãozinho");
        queue.Add("Maria");
        queue.Add("Lila");
    }

    public static string Dequeue()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("A fila está vazia.");
            return null;
        }

        string firstInLine = queue[0];
        queue.RemoveAt(0);
        return firstInLine;
    }
}
public class Q79
{
    public static void RockPaperScissors()
    {
        Random random = new();
        int computerChoice = random.Next(1, 4);
        Console.WriteLine("Pedra, Papel ou Tesoura?");
        Console.WriteLine("(1) Pedra | (2) Papel | (3) Tesoura");
        Console.Write("Escolha: ");
        int playerChoice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        int result = (playerChoice - computerChoice + 3) % 3;

        if (result == 0)
        {
            Console.Write("Empate.");
            return;
        }
        if (result == 1)
        {
            Console.Write("Jogador ganhou.");
            return;
        }

        Console.Write("Computador ganhou.");
    }
}

public class Q80
{
    public static void GetInput()
    {
        Console.Write("Digite o número: ");
        string input = Console.ReadLine();

        SumOfDigits(input);
    }

    public static void SumOfDigits(string input)
    {
        int sum = 0;

        foreach (char digit in input)
        {
            if (char.IsDigit(digit))
            {
                sum += (digit - '0');
            }
        }

        Console.Clear();
        Console.Write($"A soma dos digitos de {input}: {sum}");
    }
}

public class Q81
{
    public static List<int> nums = new();

    public static void AddNums()
    {
        for (int i = 0; i < 21; i++)
        {
            nums.Add(i);
        }
    }

    public static void PrintEvenNums()
    {
        List<string> evenNums = new();

        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                evenNums.Add(num.ToString());
            }
        }

        Console.WriteLine($"Os números pares de 0 a 20 são: {string.Join(", ", evenNums)}");
    }
}


public class Q82
{
    List<int> Nums = new();
    public void GetInput()
    {
        bool Continue = true;

        while (Continue)
        {
            Console.Clear();
            Console.Write("Digite um número inteiro:");
            Console.Write("\n[0] Sair.");

            if (int.TryParse(Console.ReadLine(), out int num) && num != 0)
            {
                Nums.Add(num);
            }
            else
            {
                Continue = false;
                Console.Clear();
            }
        }
    }

    public double CalcAverage()
    {
        double sum = Nums.Sum();
        double average = sum / Nums.Count;
        return average;
    }

    public int GetBiggest()
    {
        int biggest = Nums.Max();
        return biggest;
    }

    public static void ShowResults()
    {
        Q82 obj = new();
        obj.GetInput();

        double average = obj.CalcAverage();
        int biggest = obj.GetBiggest();

        Console.WriteLine($"A média dos números digitados é: {average}");
        Console.Write($"O maior número digitado foi: {biggest}");
    }
}

public class Q83
{
    List<string> Names = new();
    public void GetNames()
    {
        Names.Add("Joaquim");
        Names.Add("Icaro");
        Names.Add("Lara");
        Names.Add("Witallo");
        Names.Add("Carlos");
        Names.Add("Larissa");
        Names.Add("Gabriel");
        Names.Add("Cristiane");
        Names.Add("Leticia");
        Names.Add("Lila");
    }

    public void OrderNames()
    {
        Names.Sort();
    }

    public static void ShowNames()
    {
        Q83 obj = new();
        obj.GetNames();
        obj.OrderNames();

        Console.WriteLine($"Nomes em ordem alfabética: {string.Join(", ", obj.Names)}");
    }
}

public class Q84
{
    public static void Palindrome()
    {
        Console.Write("Digite uma frase: ");
        string toprint = Console.ReadLine();
        string tocheck = toprint.ToLower();
        tocheck = tocheck.Replace(" ", "");
        string reverse = new string(tocheck.Reverse().ToArray());
        Console.Clear();

        string print = (tocheck == reverse) ? "é um palíndromo." : "não é um palíndromo.";
        Console.Write($"'{toprint}' {print}");
    }
}

public class Q85
{
    List<int> Nums = new();

    public void GenerateNums()
    {
        Random random = new();
        for (int i = 0; i < 10; i++)
        {
            Nums.Add(random.Next(2, 50));
        }
    }

    public static void ShowResults()
    {
        Q85 obj = new();
        obj.GenerateNums();

        Console.Write($"Maior número: {obj.Nums.Max()}\nMenor número: {obj.Nums.Min()}");
    }
}

public class ContaBancaria // Q86
{
    public string NumConta { get; private set; }
    public string NomeTitular { get; private set; }
    private decimal saldo;

    public ContaBancaria(string numConta, string nomeTitular, decimal saldoInicial)
    {
        NumConta = numConta;
        NomeTitular = nomeTitular;
        saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso.");
            ExibirSaldo();
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser positivo.");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso.");
            ExibirSaldo();
        }
        else
        {
            Console.WriteLine("Saque não efetuado. Saldo insuficiente ou valor inválido.");
        }
    }

    public void ExibirSaldo()
    {
        Console.Write($"Saldo atual: R$ {saldo:F2}");
    }

    public void ExibirMenu()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("-- [Menu] --");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Exibir Saldo");
            Console.WriteLine("0. Sair");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o valor para depósito: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito))
                        {
                            Depositar(valorDeposito);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Valor inválido!");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o valor para saque: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))
                        {
                            Sacar(valorSaque);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Valor inválido!");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        ExibirSaldo();
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Opção inválida.");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }

        } while (opcao != 0);
    }
}

public class Funcionario // Q87
{
    public string Nome { get; private set; }
    public decimal SalarioBruto { get; private set; }

    public Funcionario(string nome, decimal salarioBruto)
    {
        Nome = nome;
        SalarioBruto = salarioBruto;
    }

    public decimal CalcularSalarioLiquido()
    {
        decimal desconto = SalarioBruto * 0.10m;
        return SalarioBruto - desconto;
    }

    public void ExibirSalarioLiquido()
    {
        Console.Write($"Salário Líquido de {Nome}: R$ {CalcularSalarioLiquido():F2}");
    }
}

public class Q88
{
    public static void DecimalToBinary()
    {
        Console.Write("Digite um número em decimal: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.Write($"O número {num} em binário é: {Convert.ToString(num, 2)}");
    }
}

public class Q89
{
    public static void AverageGrades()
    {
        int[] Grade = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Clear();
            Console.Write($"Digite a {i + 1}º nota: ");
            Grade[i] = Convert.ToInt32(Console.ReadLine());
        }

        var average = Grade.Average();
        Console.Clear();
        Console.Write($"A média do aluno é: {average:F2}");
    }
}

public class Q90
{
    public static void SumElementsMatrix()
    {
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        int sum = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.Write($"A soma dos elementos da matriz é: {sum}");
    }
}

public class Q91
{
    public static void Election(string CandidatoA, string CandidatoB, string CandidatoC)
    {
        Random random = new();

        int votosCandidatoA = random.Next(100, 2001);
        int votosCandidatoB = random.Next(100, 2001);
        int votosCandidatoC = random.Next(100, 2001);

        if (votosCandidatoA > votosCandidatoB && votosCandidatoA > votosCandidatoC)
        {
            Console.Write($"{CandidatoA} venceu com {votosCandidatoA} votos");
        }
        else if (votosCandidatoB > votosCandidatoA && votosCandidatoB > votosCandidatoC)
        {
            Console.Write($"{CandidatoB} venceu com {votosCandidatoB} votos");
        }
        else if (votosCandidatoC > votosCandidatoA && votosCandidatoC > votosCandidatoB)
        {
            Console.Write($"{CandidatoC} venceu com {votosCandidatoC} votos");
        }
        else
        {
            Console.Write("Deu empate!");
        }
    }
}

public class Q92
{
    public static void GetInput()
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Q92 q92 = new Q92();
        q92.MultiplesOf3And7(num);
    }
    public void MultiplesOf3And7(int num)
    {
        if (num % 21 == 0)
        {
            Console.Write($"{num} é múltiplo de 3 e 7");
        }
        else
        {
            Console.Write($"{num} não é múltiplo de 3 e 7");
        }
    }
}

public class Q93
{
    public static void GetInput()
    {
        Console.Write($"Digite as coordenadas do primeiro ponto: ");
        string[] input = Console.ReadLine().Split(' ');
        double x1 = double.Parse(input[0]);
        double y1 = double.Parse(input[1]);

        Console.Clear();

        Console.Write($"Digite as coordenadas do segundo ponto: ");
        input = Console.ReadLine().Split(' ');
        double x2 = double.Parse(input[0]);
        double y2 = double.Parse(input[1]);

        Console.Clear();

        Console.Write($"A distância entre os pontos ({x1}, {y1}) e ({x2}, {y2}) é: {CalcularDistancia(x1, y1, x2, y2):F2}");
    }

    private static double CalcularDistancia(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}

public class Q94
{
    public static void GenerateNums(int qty)
    {
        List<int> Nums = new();
        Random random = new();
        for (int i = 0; i < qty; i++)
        {
            Nums.Add(random.Next(1, 101));
        }
        Nums.Sort();
        Console.Write($"Números em ordem crescente: {string.Join(", ", Nums)}");
    }
}

public class AgendaContatos // Q95
{
    public string Nome { get; private set; }
    public string Telefone { get; private set; }

    public AgendaContatos(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public static void Menu()
    {
        List<AgendaContatos> agenda = new();
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("--- Agenda de Contatos ---");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Listar Contatos");
            Console.WriteLine("0. Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    AddContact(agenda);
                    break;
                case 2:
                    Console.Clear();
                    ListContacts(agenda);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadKey();
                    break;
            }

        } while (opcao != 0);
    }

    public static void AddContact(List<AgendaContatos> agenda)
    {
        Console.Write("Insira o nome do contato: ");
        string nome = Console.ReadLine();

        Console.Clear();

        Console.Write("Digite o número de telefone: ");
        string telefone = Console.ReadLine();

        Console.Clear();

        AgendaContatos contato = new AgendaContatos(nome, telefone);
        agenda.Add(contato);

        Console.Clear();
        Console.Write("Contato adicionado!");
        Console.ReadKey();
    }

    public static void ListContacts(List<AgendaContatos> agenda)
    {
        if (agenda.Count == 0)
        {
            Console.Write("Nenhum contato encontrado.");
        }
        else
        {
            Console.WriteLine("--- Contatos ---");
            foreach (var contato in agenda)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
            }
        }
        Console.ReadKey();
    }
}

public class Q96
{
    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int d = 2; d * d < num; d++)
        {
            if (num % d == 0)
                return false;
        }
        return true;
    }

    public static void GetPrimes()
    {
        List<int> PrimeNums = new();

        for (int i = 2; i < 100; i++)
        {
            if (IsPrime(i))
            {
                PrimeNums.Add(i);
            }
        }

        Console.Write($"Os números primos entre 1 e 100 são: {string.Join(", ", PrimeNums)}");
    }
}

public class Q97
{
    public static void MultiTable()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.Clear();

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}

public class Q98
{
    public static void FindBiggest(int[,] matrix)
    {
        int biggest = matrix.Cast<int>().Max();

        Console.Write($"O maior número na matriz é: {biggest}");
    }
}

public class Q99
{
    public static int GetInput()
    {

        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.Clear();

        return num;
    }

    public static void PrintSquares1toN(int num)
    {
        var sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i * i;
        }

        Console.Write($"A soma dos quadrados de 1 a {num} é: {sum}");
    }
}

public class Q100
{
    public static void Menu()
    {
        var word = "cadeira";
        int tries = 5;
        List<char> FoundChars = new List<char>();
        List<char> TriedChars = new List<char>();

        Console.WriteLine("Jogo da Forca\n");
        Console.Write("Você tem 5 tentativas para adivinhar as letras da palavra..");
        Console.ReadKey();

        do
        {
            Console.Clear();
            ShowWord(word, FoundChars);
            Console.WriteLine($"Tentativas restantes: {tries}");
            Console.Write("Digite uma letra: ");

            string input = Console.ReadLine();
            char guess;

            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Digite uma letra válida.");
                Console.ReadKey();
                continue;
            }

            guess = input[0];

            if (TriedChars.Contains(guess))
            {
                Console.Clear();
                Console.Write("Essa letra já foi testada. Tente outra.");
                Console.ReadKey();
                continue;
            }

            TriedChars.Add(guess);

            if (word.Contains(guess))
            {
                FoundChars.Add(guess);
                Console.Clear();
                Console.Write("Você acertou uma letra!");
                Console.ReadKey();
            }
            else
            {
                tries--;
                Console.Clear();
                Console.WriteLine($"Letra incorreta! Você perdeu uma tentativa.");
                Console.ReadKey();
            }

            if (IsWordComplete(word, FoundChars))
            {
                Console.Clear();
                ShowWord(word, FoundChars);
                Console.WriteLine($"-- Você adivinhou a palavra com {tries} tentativas!!! --");
                return;
            }

        } while (tries > 0);

        Console.Clear();
        Console.WriteLine($"Você perdeu. A palavra era {word}");
    }

    static void ShowWord(string word, List<char> FoundChars)
    {
        foreach (char letter in word)
        {
            if (FoundChars.Contains(letter))
                Console.Write(letter + " ");
            else
                Console.Write("_ ");
        }
        Console.WriteLine();
    }

    static bool IsWordComplete(string word, List<char> FoundChars)
    {
        foreach (char letter in word)
        {
            if (!FoundChars.Contains(letter))
                return false;
        }
        return true;
    }
}