using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("imagens_galeria")]
public class ImagemGaleria
{
    [Key]
    public int Id { get; set; }

    public string Titulo { get; set; }

    public string Url { get; set; }

    public DateTime DataUpload { get; set; }
}