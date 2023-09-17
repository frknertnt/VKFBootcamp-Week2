using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    /*DTO Özellikleri
     *readonly (değeri değişmemelidir)
     *immutable
     *LINQ (üzerinde sorgular yazılabilir
     *Ref type (classla aynı özellikleri taşır)
     *Ctor gibi DTO tanımlama fırsatı verir
     */


    //public record BookDtoForUpdate
    //{
    //    public int Id { get; init; }//init ile immutable,readonly özelliği kazandırdık
    //    public String Title { get; init; }//tanımlandığı yerde initialize edildiğinde değeri de verilir (set edilir)
    //    public decimal Price { get; init; }
    //}

    public record BookDtoForUpdate(int Id, String Title, decimal Price);// yukarıdaki yazım tarzına alternatif bir yazım
}
