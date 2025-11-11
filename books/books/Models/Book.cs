namespace books.Models
{
    public class Book
    {
        public string titulo;
        public string autor;
        public int anio;

        public Book(string p_titulo, string p_autor, int p_anio)
        {
            this.anio = p_anio;
            this.autor = p_autor;
            this.titulo = p_autor;
        
        }

    }
}
