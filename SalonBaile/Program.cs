// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Clientes cliente = new Clientes();
cliente.Cedula = 1;
cliente.Nombre = "Pepito";
cliente.Apellido = "Perez";
cliente.Telefono = "555-1234";
cliente.Correo = "PePe@gmail.com";
Profesores profesor = new Profesores();
profesor.Cedula = 2;
profesor.Nombre = "Juan";
profesor.Apellido = "Lopez";
profesor.Telefono = "555-5678";
profesor.Correo = "JUanL@outlook.com"
;profesor.Salario = 1500.00m;
profesor.Especialidad = "Salsa";
profesor.Cursos = new List<Cursos>();
profesor.Locales = new List<Locales>();
Cursos curso = new Cursos();
curso.Id = 1;
curso.Nombre = "Salsa para principiantes";
curso.Descripcion = "Aprende los pasos basicos de la salsa";
curso.Precio = 200.00m;
curso.FechaInicio = new DateTime(2024, 5, 1);
curso.Profesor = profesor;
curso.Clientes = new List<Clientes>();
curso.Profesores = new List<Profesores>();
Locales local = new Locales();
local.Id = 1;
local.Nombre = "Salon Central";
local.Direccion = "Calle 123";
local.Telefono = "555-7890";
local.Correo = "SalonCentral@gmail.com";



public class Clientes
{
    public int Cedula;
    public string? Nombre;
    public string? Apellido;
    public string? Telefono;
    public string? Correo;
}

public class Profesores
{
    public int Cedula;
    public string? Nombre;
    public string? Apellido;
    public string? Telefono;
    public string? Correo;
    public decimal Salario;
    public string? Especialidad;
    public List<Cursos>? Cursos;
    public List<Locales>? Locales;
}

public class Cursos
{
    public int Id;
    public string? Nombre;
    public string? Descripcion;
    public decimal Precio;
    public DateTime FechaInicio;
    public Profesores? Profesor;
    public List<Clientes>? Clientes;
    public List<Profesores>? Profesores;
}

public class Locales
{
    public int Id;
    public string? Nombre;
    public string? Direccion;
    public string? Telefono;
    public string? Correo;
}

