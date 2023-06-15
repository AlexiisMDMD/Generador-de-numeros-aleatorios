/*Vamos hacer un programa en c# que genere 40 aleatorio comprendidos 1 al 1000

Pago 2. Generan una clave de accesos , donde van combinar  la primera letra de su nombre, 
la primera letra de sus  apellidos más el número aleatorio generado
*/

Random random = new Random();
int[] numeroAleatorio = new int[40];

for (int contador = 0;  contador < numeroAleatorio.Length ; contador++ ) {

    numeroAleatorio[contador] = random.Next(1, 1001);

}

Console.WriteLine("Tus 40 numeros aleatoriuos son: ");

foreach (var num in numeroAleatorio) { 
    Console.WriteLine(num);

}
// Generar las claves de acceso
string[] clavesAcceso = new string[40];
string nombre = "Alexis"; // Cambia esto por tu nombre
string apellidos = "Mendez Del Leon"; // Cambia esto por tus apellidos

for (int contador = 0; contador < clavesAcceso.Length; contador++)
{
    char primeraLetraNombre = nombre[0];
    char primeraLetraApellido = apellidos.Split(' ')[0][0];
    string claveAcceso = $"{primeraLetraNombre}{primeraLetraApellido}{numeroAleatorio[contador]}";
    clavesAcceso[contador] = claveAcceso;
}

// Imprimir las claves de acceso
Console.WriteLine("Claves de acceso generadas: ");
for (int contador = 0; contador < clavesAcceso.Length; contador++)
{
    Console.WriteLine(clavesAcceso[contador]);
}





