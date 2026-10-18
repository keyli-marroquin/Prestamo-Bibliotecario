namespace PrestamosBiblioteca.Dominio;

public class Libro
{
    public int Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public int Ejemplares { get; set; }
}