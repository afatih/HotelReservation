using OtelRezervasyon_DadasTurizm.DadasDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon_DadasTurizm.DadasDB.EntityMappings
{
    public class BookDetailMapping:EntityTypeConfiguration<BookDetail>
    {
        public BookDetailMapping()
        {

        }
    }
}
