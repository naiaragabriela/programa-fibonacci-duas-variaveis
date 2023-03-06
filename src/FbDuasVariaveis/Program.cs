int anterior, proximo, posicao;

int NumeroDigitado()
{
    Console.Write("Informe até qual posição da sequência deseja ver: ");
    return int.Parse(Console.ReadLine());
}
posicao = NumeroDigitado();
anterior = 1;
proximo = 0;

void ResultadoFb()
{
    for (int i = 1; i<= posicao; i++)
    {
        Console.Write(proximo + anterior + ",");
        proximo += anterior;
        anterior = (proximo - anterior);
    }
}
ResultadoFb();