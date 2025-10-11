using ComunidadApp.Modelos;

var maestro = new Maestro
{
    Nombre = "Elías",
    Cedula = "001-1234567-8",
    Departamento = "Educación",
    AreaAcademica = "Matemáticas",
    Materia = "Álgebra"
};

maestro.MostrarInfo();
Console.WriteLine($"Materia: {maestro.Materia}");