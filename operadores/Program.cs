// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Operadores Aritmeticos
double resultado1= 10 + 8 + 12 / 3;
Console.WriteLine(resultado1);

double resultado2= (10 + 8 + 12) / 3;
Console.WriteLine(resultado2);

double resultado3= (2 + 8) * 2 / 4;
Console.WriteLine(resultado3);

bool a = true;
bool b = false;
Console.WriteLine(a && b);

//or logico || (ou)

bool a1 = true;
bool b1 = false;
Console.WriteLine(a || b);

// Not logico ! (nao)

bool a3 = true;
Console.WriteLine( !a );

// XOR logico ^ (OU Exclusivo)

bool a4 = true;
bool b4 = false;
Console.WriteLine(a ^ b);

// Precedencia de operadores logicos

bool a5 = true;
bool b5 = false;
bool c = false;
bool resultado = !a || (b && c);
Console.WriteLine(resultado);

bool a6 = false;
bool b6 = false;
bool c6 = false;
bool resultado4 = !a || b && c;
Console.WriteLine(resultado4);



