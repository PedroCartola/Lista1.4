string? jocen;
int n;
do
{
    Console.WriteLine("Quantidade de alunos: ");
    jocen = Console.ReadLine();
    Int32.TryParse(jocen, out n);
} while (n <= 0);
double[] media = new double[n];
double[] g1 = new double[n];
double[] g2 = new double[n];

for (int i = 0; i<n; i++)
{
    do
    {
        Console.WriteLine("Nota G1 do " + (i + 1) + "º aluno");
        jocen = Console.ReadLine();
        Double.TryParse(jocen, out g1[i]);
    } while (g1[i] < 0);
    do
    {
        Console.WriteLine("Nota G2 do " + (i + 1) + "º aluno");
        jocen = Console.ReadLine();
        Double.TryParse(jocen, out g2[i]);
    } while (g2[i] < 0);
    media[i] = (g1[i] + g2[i]) / 2;
}
for(int j=0; j<n; j++)
{
    Console.WriteLine("Nota G1 do " + (j + 1) + "º aluno: " + g1[j]);
    Console.WriteLine("Nota G2 do " + (j + 1) + "º aluno: " + g2[j]);
    Console.WriteLine("Nota média do " + (j + 1) + "º aluno: " + media[j]);
}

// Não sou um rei, não sou deus, eu sou algo muito... Pior - aatrox