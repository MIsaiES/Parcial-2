//Encapsulacion 
//ocultar informacion, acceso limtidado a la informacion, ejemplo cierra de mesa, pistola cargada

using Parcial_2.Clases;
using Parcial_2.Clases.Combustibles;

static void menu()
{
    Console.WriteLine("1.Encapsulacion y Polimosfismo");
    Console.WriteLine("2.Interfaces");
    Console.WriteLine("3.Indexadores");
    Console.WriteLine("4.Cerrar el Programa");
}
static void EncapYPolim()
{

    Carro carro1 = new Disel
    {
        marca = "Patito",
        placa = "p123 456",
        propietario = "Mario Isai"
    };
    carro1.Mostrar();
}

static void Interfaz()
{
    IngenieriaSistemas estudiante1 = new();
    Console.WriteLine($"Carnet: {estudiante1.Carnet()} 22 123\nCarrera: {estudiante1.Carrera()}");

    Psicologia estudiante2 = new();
    Console.WriteLine($"Carnet: {estudiante2.Carnet()} 22 456\nCarrera: {estudiante2.Carrera()}");

    AdministracionDeEmpresas estudiante3 = new();
    Console.WriteLine($"Carnet: {estudiante3.Carnet()} 22 789\nCarrera: {estudiante3.Carrera()}");
}

static void Indexadores()
{
    var productos = new Productos();
    productos[0] = "Monitor";
    productos[1] = "Baterias";
    productos[2] = "Teclado";

    for (int i = 0; i<3; i++)
    {
        Console.WriteLine($"Producto {i+1}: {productos[i]}");
    }
}

//////////////////////////////////////////////
int op = 0;

do
{
    Console.WriteLine("¿Que desea hacer?");
    menu();
    int.TryParse(Console.ReadLine(), out op);

    switch (op)
    {
        case 0:
            Console.WriteLine("Opcion Invalida");
            break;
        case 1:
            EncapYPolim();
            break;
        case 2:
            Interfaz();
            break;
        case 3:
            Indexadores();
            break;
        case 4:
            Console.WriteLine("Cerrando el Programa");
            break;
        default:
            Console.WriteLine("Opcion Invalida");
            break;
    }
    Console.ReadLine();
    Console.Clear();
} while (op != 4);
