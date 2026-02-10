using System;

// ================= CLASE BASE =================
public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public string Correo { get; set; }

    public MiembroDeLaComunidad(string nombre, string cedula, string correo)
    {
        Nombre = nombre;
        Cedula = cedula;
        Correo = correo;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Cédula: {Cedula}");
        Console.WriteLine($"Correo: {Correo}");
    }
}

// ================= ESTUDIANTE =================
public class Estudiante : MiembroDeLaComunidad
{
    public string Matricula { get; set; }
    public string Carrera { get; set; }

    public Estudiante(string nombre, string cedula, string correo, string matricula, string carrera)
        : base(nombre, cedula, correo)
    {
        Matricula = matricula;
        Carrera = carrera;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Carrera: {Carrera}");
    }
}

// ================= EX ALUMNO =================
public class ExAlumno : MiembroDeLaComunidad
{
    public int AñoGraduacion { get; set; }

    public ExAlumno(string nombre, string cedula, string correo, int añoGraduacion)
        : base(nombre, cedula, correo)
    {
        AñoGraduacion = añoGraduacion;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
    }
}

// ================= EMPLEADO =================
public class Empleado : MiembroDeLaComunidad
{
    public string CodigoEmpleado { get; set; }
    public string Departamento { get; set; }

    public Empleado(string nombre, string cedula, string correo, string codigoEmpleado, string departamento)
        : base(nombre, cedula, correo)
    {
        CodigoEmpleado = codigoEmpleado;
        Departamento = departamento;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Código Empleado: {CodigoEmpleado}");
        Console.WriteLine($"Departamento: {Departamento}");
    }
}

// ================= DOCENTE =================
public class Docente : Empleado
{
    public string Asignatura { get; set; }

    public Docente(string nombre, string cedula, string correo, string codigoEmpleado, string departamento, string asignatura)
        : base(nombre, cedula, correo, codigoEmpleado, departamento)
    {
        Asignatura = asignatura;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Asignatura: {Asignatura}");
    }
}

// ================= ADMINISTRATIVO =================
public class Administrativo : Empleado
{
    public string Cargo { get; set; }

    public Administrativo(string nombre, string cedula, string correo, string codigoEmpleado, string departamento, string cargo)
        : base(nombre, cedula, correo, codigoEmpleado, departamento)
    {
        Cargo = cargo;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Cargo: {Cargo}");
    }
}

// ================= ADMINISTRADOR =================
public class Administrador : Docente
{
    public string AreaGestion { get; set; }

    public Administrador(string nombre, string cedula, string correo, string codigoEmpleado, string departamento, string asignatura, string areaGestion)
        : base(nombre, cedula, correo, codigoEmpleado, departamento, asignatura)
    {
        AreaGestion = areaGestion;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Área de Gestión: {AreaGestion}");
    }
}

// ================= MAESTRO =================
public class Maestro : Docente
{
    public string NivelEducativo { get; set; }

    public Maestro(string nombre, string cedula, string correo, string codigoEmpleado, string departamento, string asignatura, string nivelEducativo)
        : base(nombre, cedula, correo, codigoEmpleado, departamento, asignatura)
    {
        NivelEducativo = nivelEducativo;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Nivel Educativo: {NivelEducativo}");
    }
}

// ================= PROGRAMA PRINCIPAL =================
class Program
{
    static void Main(string[] args)
    {
        Administrador admin = new Administrador("Carlos Pérez", "001-0000000-1", "carlos@uni.edu", "EMP001", "Dirección", "Gestión Educativa", "Académica");
        Maestro maestro = new Maestro("Ana López", "002-0000000-2", "ana@uni.edu", "EMP002", "Docencia", "Matemáticas", "Secundario");
        Estudiante estudiante = new Estudiante("Luis Gómez", "003-0000000-3", "luis@uni.edu", "2025-001", "Software");
        ExAlumno exAlumno = new ExAlumno("María Torres", "004-0000000-4", "maria@gmail.com", 2022);
        Administrativo administrativo = new Administrativo("Pedro Ruiz", "005-0000000-5", "pedro@uni.edu", "EMP003", "Finanzas", "Contador");

        Console.WriteLine("=== ADMINISTRADOR ===");
        admin.MostrarInfo();

        Console.WriteLine("\n=== MAESTRO ===");
        maestro.MostrarInfo();

        Console.WriteLine("\n=== ESTUDIANTE ===");
        estudiante.MostrarInfo();

        Console.WriteLine("\n=== EX ALUMNO ===");
        exAlumno.MostrarInfo();

        Console.WriteLine("\n=== ADMINISTRATIVO ===");
        administrativo.MostrarInfo();
    }
}
