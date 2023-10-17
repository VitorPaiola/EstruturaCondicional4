string[] vet = Console.ReadLine().Split(' ');
int horaInicial = int.Parse(vet[0]);
int horaFinal = int.Parse(vet[1]);

int duracao;
if (horaInicial < horaFinal) {
    duracao = horaFinal - horaInicial;
} else {
    duracao = 24 - horaInicial + horaFinal;
}

Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");